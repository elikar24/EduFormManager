using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using Models;
using Models.Repo;

namespace EduFormManager.Utils
{
    public class Actions{
        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext> 
            LoadMunicipalityLayerAction = 
                async delegate(object o, TileEventArgs args, WindowsUIView view, bool isArchive, FormType formType, 
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)args.Tile;
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var containers = new List<TileContainer>();
                    TileContainerHelper.SetStatusLoading(container);
                    await Task.Run(() =>
                    {
                        var sw = new Stopwatch();
                        sw.Start();
                        using (var repo = new Repository())
                        {
                            var municipalities = repo.GetMunicipalitiesNotLazy("edus");
                            foreach (var m in municipalities)
                            {
                                var mTile = TileHelper.CreateMunitTile(m, isArchive);
                                var typeCaption = "Типы образовательных учреждений";
                                var typeSubCaption = m.name;
                                var typeContainer = TileContainerHelper.CreateTileContainer(view, mTile,
                                    typeCaption, typeSubCaption, container);
                                var statusDict = repo.GetStatusForMunicipalities(isArchive);
                                if (statusDict.ContainsKey(m.municipality_id))
                                {
                                    mTile.Appearances.Normal.BackColor = TileResources.FormDataColors[statusDict[m.municipality_id]];
                                    mTile.Group = TileResources.FormDataText[statusDict[m.municipality_id]];
                                }
                                else
                                {
                                    mTile.Appearances.Normal.BackColor = TileResources.FormDataColors[Status.Default];
                                    mTile.Group = TileResources.FormDataText[Status.Default];
                                }
                                mTile.Click += (s, e) => LoadEduKindLayerAction.Invoke(s, e, view, isArchive, formType, guiCtx);

                                tiles.Add(mTile);
                                containers.Add(typeContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Municipality entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext> 
            LoadEduKindLayerAction =
                async delegate(object o, TileEventArgs args, WindowsUIView view, bool isArchive, FormType formType, 
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)args.Tile;
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
                        using (var repo = new Repository())
                        {
                            var m = repo.GetMunicipalityNotLazy(mId, "edus.edu_kind");
                            var eduKinds = m.edus.Select(t => t.edu_kind).Distinct().ToList();
                            foreach (var eok in eduKinds)
                            {
                                var eotTile = TileHelper.CreateEduTypeTile(eok, tile, isArchive);
                                var eduCaption = "Образовательные учреждения";
                                var subEduCaption = eok.name;
                                var eduContainer = TileContainerHelper.CreateTileContainer(view, eotTile, eduCaption, subEduCaption, container);

                                var statusDict = repo.GetStatusForEduKinds(mId, isArchive);
                                if (statusDict.ContainsKey(eok.edu_kind_id))
                                {
                                    eotTile.Appearances.Normal.BackColor =
                                        TileResources.FormDataColors[statusDict[eok.edu_kind_id]];
                                    eotTile.Group = TileResources.FormDataText[statusDict[eok.edu_kind_id]];
                                }
                                else
                                {
                                    eotTile.Appearances.Normal.BackColor = TileResources.FormDataColors[Status.Default];
                                    eotTile.Group = TileResources.FormDataText[Status.Default];
                                }
                                eotTile.Click += (s, e) => LoadEduLayerAction.Invoke(s, e, view, isArchive, formType, guiCtx);
                                tiles.Add(eotTile);
                                containers.Add(eduContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Edu kind entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);
                        }
                    });
                };

        public static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext> 
            LoadEduLayerAction = 
                async delegate(object o, TileEventArgs args, WindowsUIView view, bool isArchive, FormType formType, 
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)args.Tile;
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
                        using (var repo = new Repository())
                        {
                            var edus = repo.GetEdusNotLazy(mId, eokId);
                            foreach (var eo in edus)
                            {
                                var statusCountArray = repo.GetStatusCountForEdu(eo.edu_id, formType, isArchive);
                                var eoTile = TileHelper.CreateEduTile(eo, isArchive);
                                eoTile.Group = eo.name.Substring(0, 1);
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
                                eoTile.Appearances.Normal.BackColor = TileResources.FormDataColors[status];
                                eoTile.Group = TileResources.FormDataText[status];

                                eoTile.Click += (s, e) => LoadEduFormsLayerAction.Invoke(s, e, view, isArchive, formType, guiCtx);
                                var formSubCaption = eo.name;
                                var formCaption = isArchive ? "Архивные " : "";
                                formCaption += (formType == FormType.Edu) ? "Формы федерального статистического наблюдения" : "Доп. формы";
                                var formContainer = TileContainerHelper.CreateTileContainer(view, eoTile, formCaption, formSubCaption, container);
                                
                                tiles.Add(eoTile);
                                containers.Add(formContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Edu entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);
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
                        
                        using (var repo = new Repository())
                        {
                            var formTypeId = (int) formType;
                            var forms = repo.GetEduFormDataNotLazy(eoId, formTypeId, isArchive, "form");
                            foreach (var fd in forms)
                            {
                                dynamic dTileObj = TileHelper.CreateFormTile(fd, container, isArchive);
                                TileHelper.SetFormTileStatus(dTileObj.Tile, null, null, null, fd);
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
                        using (var repo = new Repository())
                        {
                            var municipalities = repo.GetMunicipalitiesNotLazy(String.Empty);
                            foreach (var m in municipalities)
                            {
                                var statusCountArray = repo.GetStatusCountForMunicipality(m.municipality_id, formType, isArchive);

                                var mTile = TileHelper.CreateMunitTileForMunicipality(m, isArchive);
                                var formsCaption = isArchive ? "Архивные формы муниципалитетов" : "Формы муниципалитетов";
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

                                mTile.Appearances.Normal.BackColor = TileResources.FormDataColors[status];
                                mTile.Group = TileResources.FormDataText[status];

                                tiles.Add(mTile);
                                containers.Add(formsContainer);
                            }
                            sw.Stop();
                            Debug.WriteLine("Municipality form entities loaded in {0}", sw.ElapsedMilliseconds);
                            guiCtx.Post(t => TileContainerHelper.RemoveStatusLoading(container), null);
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(containers), null);
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
                        using (var repo = new Repository())
                        {
                            var forms = repo.GetMunicipalityFormDataNotLazy(mId, (int) formType, isArchive, "form");
                            foreach (var fd in forms)
                            {
                                dynamic dTileObj = TileHelper.CreateFormTile(fd, container, isArchive);
                                TileHelper.SetFormTileStatus(dTileObj.Tile, tile, null, null, fd);
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
    }
}
