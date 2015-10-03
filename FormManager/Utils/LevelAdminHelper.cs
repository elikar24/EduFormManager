using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EduFormManager.Models;
using EduFormManager.Models.Repo;
using EduFormManager.Utilities;

namespace EduFormManager.Utils
{
    public class LevelAdminHelper
    {
        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext> 
            LoadMunicipalityLayerAction = 
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType, 
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var containers = new List<TileContainer>();
                    TileContainerHelper.SetStatusLoading(container);
                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        using (var db = new Entities())
                        {
                            db.Configuration.LazyLoadingEnabled = false;
                            var municipalities = db.municipalities.Include("edus").ToList();
                            foreach (var m in municipalities)
                            {
                                var mTile = TileHelper.CreateMunitTile(m, isArchive);
                                var typeCaption = "Типы образовательных учреждений";
                                var typeSubCaption = m.name;
                                var typeContainer = TileContainerHelper.CreateTileContainer(view, mTile,
                                    typeCaption, typeSubCaption, container);
                                var statusDict = Repository.GetStatusForMunicipalities(db, isArchive);
                                if (statusDict.ContainsKey(m.municipality_id))
                                {
                                    mTile.Appearances.Normal.BackColor =
                                        ColorUtility.FormDataColors[statusDict[m.municipality_id]];
                                    mTile.Group = ColorUtility.FormDataGroupText[statusDict[m.municipality_id]];
                                }
                                else
                                {
                                    mTile.Appearances.Normal.BackColor = ColorUtility.FormDataColors[Status.Default];
                                    mTile.Group = ColorUtility.FormDataGroupText[Status.Default];
                                }
                                mTile.Click +=
                                    (sender, args) => 
                                        LoadEduKindLayerAction.Invoke(sender, args, view, isArchive, formType, guiCtx);

                                tiles.Add(mTile);
                                containers.Add(typeContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Municipality entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);
                            db.Configuration.LazyLoadingEnabled = true;
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext> 
            LoadEduKindLayerAction =
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType, 
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var tag = tile.Tag.ToString();
                    var id = TagHelper.GetId(tag);
                    if (id == null) return;
                    var mId = id.Value;
                
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var containers = new List<TileContainer>();
                    TileContainerHelper.SetStatusLoading(container);

                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        using (var db = new Entities())
                        {
                            db.Configuration.LazyLoadingEnabled = false;

                            var m = db.municipalities.Include("edus.edu_kind").Single(t => t.municipality_id == mId);
                            var eduKinds = m.edus.Select(t => t.edu_kind).Distinct().ToList();
                            foreach (var eok in eduKinds)
                            {
                                var eotTile = TileHelper.CreateEduTypeTile(eok, tile, isArchive);
                                var eduCaption = "Образовательные учреждения";
                                var subEduCaption = eok.name;
                                var eduContainer = TileContainerHelper.CreateTileContainer(view, eotTile, eduCaption, subEduCaption, container);

                                var statusDict = Repository.GetStatusForEduKinds(db, mId, isArchive);
                                if (statusDict.ContainsKey(eok.edu_kind_id))
                                {
                                    eotTile.Appearances.Normal.BackColor =
                                        ColorUtility.FormDataColors[statusDict[eok.edu_kind_id]];
                                    eotTile.Group = ColorUtility.FormDataGroupText[statusDict[eok.edu_kind_id]];
                                }
                                else
                                {
                                    eotTile.Appearances.Normal.BackColor = ColorUtility.FormDataColors[Status.Default];
                                    eotTile.Group = ColorUtility.FormDataGroupText[Status.Default];
                                }
                                eotTile.Click +=
                                    (sender, args) =>
                                        LoadEduLayerAction.Invoke(sender, args, view, isArchive, formType, guiCtx);
                                tiles.Add(eotTile);
                                containers.Add(eduContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Edu kind entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);

                            db.Configuration.LazyLoadingEnabled = true;
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext> 
            LoadEduLayerAction = 
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType, 
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var tag = tile.Tag.ToString();
                    var id = TagHelper.GetId(tag);
                    if (id == null) return;
                    var eokId = id.Value;
                    var municipalityId = TagHelper.GetMunicipalityId(tag);
                    if (municipalityId == null) return;
                    var mId = municipalityId.Value;
                
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var containers = new List<TileContainer>();
                    TileContainerHelper.SetStatusLoading(container);
                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        using (var db = new Entities())
                        {
                            db.Configuration.LazyLoadingEnabled = false;

                            var edus = db.edus.Where(t => t.municipality_id == mId && t.edu_kind_id == eokId).ToList();
                            //var c = edus.Count();
                            //var i = 0;
                            foreach (var eo in edus)
                            {
                                //var progress =(int) (((float)++i/(float)c)*100f);
                                //guiCtx.Send(t => TileContainerHelper.SetLoadingProgress(container, progress), null);
                                var statusCountArray = Repository.GetStatusCountForEdu(db, eo.edu_id, formType, isArchive);

                                //var eoTile = TileHelper.CreateAnimatedEduTile(eo, isArchive);
                                var eoTile = TileHelper.CreateEduTile(eo, isArchive);
                                eoTile.Group = eo.name.Substring(0, 1);
                                //var statusText = string.Format("Загруженных форм {0}" +
                                //                                  "\nС ошибками {1}" +
                                //                                  "\nС опозданием {2}" +
                                //                                  "\nС ошибками и опозданием {3}" +
                                //                                  "\nБез ошибок и опозданий {4}",
                                //                                  statusCountArray[0],
                                //                                  statusCountArray[1],
                                //                                  statusCountArray[2],
                                //                                  statusCountArray[3],
                                //                                  statusCountArray[4]);
                                //eoTile.Frames[1].Elements[0].Text = statusText;

                                var status = Status.Default;
                                if (statusCountArray[4] > 0 && statusCountArray[1] == 0 && statusCountArray[2] == 0 && statusCountArray[3] == 0)
                                    status = Status.OK;
                                else if (statusCountArray[1] > statusCountArray[2] && statusCountArray[1] > statusCountArray[3])
                                    status = Status.WithErrors;
                                else if (statusCountArray[2] > statusCountArray[1] && statusCountArray[2] > statusCountArray[3])
                                    status = Status.Expired;
                                else if (statusCountArray[3] > statusCountArray[1] && statusCountArray[3] > statusCountArray[2])
                                    status = Status.WithErrors | Status.Expired;
                                else if (statusCountArray.All(t => t == 0))
                                    status = Status.Default;
                                else if (statusCountArray[1] != 0 || statusCountArray[2] != 0 || statusCountArray[3] != 0)
                                    status = Status.Unknown;
                                eoTile.Appearances.Normal.BackColor = ColorUtility.FormDataColors[status];
                                eoTile.Group = ColorUtility.FormDataGroupText[status];

                                eoTile.Click +=
                                    (sender, args) =>
                                        LoadEduFormsLayerAction.Invoke(sender, args, view, isArchive, formType, guiCtx);
                                var formCaption = eo.name;
                                var formSubCaption = isArchive ? "Архивные " : "";
                                formSubCaption += (formType == FormType.Federal) ? "Формы федерального статистического наблюдения" : "Доп. формы";
                                var formContainer = TileContainerHelper.CreateTileContainer(view, eoTile, formCaption, formSubCaption, container);
                                
                                tiles.Add(eoTile);
                                containers.Add(formContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Edu entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);

                            db.Configuration.LazyLoadingEnabled = true;
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext>
            LoadEduFormsLayerAction =
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType,
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var tag = tile.Tag.ToString();
                    var id = TagHelper.GetId(tag);
                    if (id == null) return;
                    var eoId = id.Value;
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var pages = new List<Page>();
                    var docs = new List<Document>();
                    TileContainerHelper.SetStatusLoading(container);
                    TileContainerHelper.InitFormContainerActions(container);
                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        var statusCount = new GuiHelper.FormStatusCount();
                        using (var db = new Entities())
                        {
                            db.Configuration.LazyLoadingEnabled = false;

                            var currYear = DateTime.Now.Year;
                            var formTypeId = (int) formType;
                            var forms = db.edu_form_data.Include("form").Where(t => t.edu_id == eoId && t.form.form_type_id == formTypeId);
                            forms = isArchive 
                                ? forms.Where(t => t.send_date.Year < currYear) 
                                : forms.Where(t => t.send_date.Year == currYear);
                            foreach (var fd in forms)
                            {
                                dynamic dTileObj = TileHelper.CreateFormTile(fd, container, isArchive);
                                TileHelper.SetFormTileStatus(dTileObj.Tile, null, null, null, fd, ref statusCount);
                                tiles.Add(dTileObj.Tile);
                                pages.Add(dTileObj.Page);
                                docs.Add(dTileObj.Document);
                            }
                            sw.Stop();
                            Debug.WriteLine("Edu forms entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.Documents.AddRange(docs), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(pages), null);

                            db.Configuration.LazyLoadingEnabled = true;
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext>
            LoadMunicipalityMunicipalityLayerAction =
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType,
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var containers = new List<TileContainer>();
                    TileContainerHelper.SetStatusLoading(container);
                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        using (var db = new Entities())
                        {
                            db.Configuration.LazyLoadingEnabled = false;

                            var municipalities = db.municipalities.ToList();
                            foreach (var m in municipalities)
                            {
                                var statusCountArray = Repository.GetStatusCountForMunicipality(db, m.municipality_id, isArchive);

                                var mTile = TileHelper.CreateMunitTileForMunicipality(m, isArchive);
                                var formsCaption = isArchive ? "Архивные формы муниципалитетов" : "Формы муниципалитетов"; ;
                                var formsSubCaption = m.name;
                                var formsContainer = TileContainerHelper.CreateTileContainer(view, mTile,
                                    formsCaption, formsSubCaption, container);
                                mTile.Click +=
                                    (sender, args) =>
                                        LoadMunicipalityFormsLayerAction.Invoke(sender, args, view, isArchive, formType, guiCtx);

                                var statusText = string.Format("Загруженных форм {0}" +
                                                               "\nС ошибками {1}" +
                                                               "\nС опозданием {2}" +
                                                               "\nС ошибками и опозданием {3}" +
                                                               "\nБез ошибок и опозданий {4}",
                                                               statusCountArray[0],
                                                               statusCountArray[1],
                                                               statusCountArray[2],
                                                               statusCountArray[3],
                                                               statusCountArray[4]);
                                mTile.Elements[1].Text = statusText;

                                var status = Status.Default;
                                if (statusCountArray[4] > 0 && statusCountArray[1] == 0 && statusCountArray[2] == 0 && statusCountArray[3] == 0)
                                    status = Status.OK;
                                else if (statusCountArray[1] > statusCountArray[2] && statusCountArray[1] > statusCountArray[3])
                                    status = Status.WithErrors;
                                else if (statusCountArray[2] > statusCountArray[1] && statusCountArray[2] > statusCountArray[3])
                                    status = Status.Expired;
                                else if (statusCountArray[3] > statusCountArray[1] && statusCountArray[3] > statusCountArray[2])
                                    status = Status.WithErrors | Status.Expired;
                                else if (statusCountArray.All(t => t == 0))
                                    status = Status.Default;
                                else if (statusCountArray[1] != 0 || statusCountArray[2] != 0 || statusCountArray[3] != 0)
                                    status = Status.Unknown;

                                mTile.Appearances.Normal.BackColor = ColorUtility.FormDataColors[status];
                                mTile.Group = ColorUtility.FormDataGroupText[status];

                                tiles.Add(mTile);
                                containers.Add(formsContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Municipality form entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);

                            db.Configuration.LazyLoadingEnabled = false;
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext>
            LoadMunicipalityFormsLayerAction =
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType,
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var tag = tile.Tag.ToString();
                    var id = TagHelper.GetId(tag);
                    if (id == null) return;
                    var mId = id.Value;
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var pages = new List<Page>();
                    var docs = new List<Document>();
                    TileContainerHelper.SetStatusLoading(container);
                    TileContainerHelper.InitFormContainerActions(container);
                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        var statusCount = new GuiHelper.FormStatusCount();
                        using (var db = new Entities())
                        {
                            var currYear = DateTime.Now.Year;
                            var forms = db.municipality_form_data.Include("form").Where(t => t.municipality_id == mId && t.form.form_type_id == (int) formType);
                            forms = isArchive
                                ? forms.Where(t => t.send_date.Year < currYear)
                                : forms.Where(t => t.send_date.Year == currYear);
                            foreach (var fd in forms)
                            {
                                dynamic dTileObj = TileHelper.CreateFormTile(fd, container, isArchive);
                                TileHelper.SetFormTileStatus(dTileObj.Tile, tile, null, null, fd, ref statusCount);
                                tiles.Add(dTileObj.Tile);
                                pages.Add(dTileObj.Page);
                                docs.Add(dTileObj.Document);
                            }
                            sw.Stop();
                            Debug.WriteLine("Municipality entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.Documents.AddRange(docs), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(pages), null);
                        }
                    });
                };

        public static TileContainer CreateQuestionaryTileContainer(WindowsUIView view)
        {
            const string caption = "Анкеты";
            TileContainer questionaryContainer = TileContainerHelper.CreateTileContainer(view, null, caption);

            //IList<Questionary> questionaryList = RepoHelper.Repo.GetAll<Questionary>().OrderBy((t) => t.Title).ToList();
            //foreach (Questionary questionary in questionaryList)
            //{
            //    Tile qTile = TileHelper.CreateQuestionaryTile(questionary, view, questionaryContainer);
            //    questionaryContainer.Items.Add(qTile);
            //}
            view.ContentContainers.Add(questionaryContainer);
            GuiHelper.GuiThreadContext.Post(x => TileContainerHelper.InitQuestionaryContainerActions(questionaryContainer), null);
            return questionaryContainer;
        }
    }
}
