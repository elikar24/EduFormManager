using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using EduFormManager.Models;
using EduFormManager.Models.Repo;

namespace EduFormManager.Utils
{
    public static class LevelMunitHelper
    {
        private static readonly Action<object, TileEventArgs, WindowsUIView, bool, FormType, SynchronizationContext>
            LoadMunicipalityFormsLayerAction =
                async delegate(object o, TileEventArgs e, WindowsUIView view, bool isArchive, FormType formType,
                    SynchronizationContext guiCtx)
                {
                    var tile = (Tile)e.Tile;
                    var tag = tile.Tag.ToString();
                    var mId = TagHelper.GetId(tag).Value;
                    var container = (TileContainer)tile.ActivationTarget;
                    var tiles = new List<Tile>();
                    var pages = new List<Page>();
                    var docs = new List<Document>();
                    container.Items.Clear();
                    await Task.Run(() =>
                    {
                        var statusCount = new GuiHelper.FormStatusCount();
                        using (var db = new Entities())
                        {
                            var currYear = DateTime.Now.Year;
                            var formTypeId = (int)formType;
                            var forms = db.municipality_form_data.Where(t => t.municipality_id == mId);
                            forms = isArchive
                                ? forms.Where(t => t.send_date.Value.Year < currYear)
                                : forms.Where(t => t.send_date.Value.Year == currYear);
                            foreach (var fd in forms)
                            {
                                dynamic dTileObj = TileHelper.CreateFormTile(fd, container, isArchive);
                                TileHelper.SetFormTileStatus(dTileObj.Tile, tile, null, null, fd, ref statusCount);
                                tiles.Add(dTileObj.Tile);
                                pages.Add(dTileObj.Page);
                                docs.Add(dTileObj.Document);
                            }
                            guiCtx.Post(t => container.Items.AddRange(tiles), null);
                            guiCtx.Post(t => view.Documents.AddRange(docs), null);
                            guiCtx.Post(t => view.ContentContainers.AddRange(pages), null);
                        }
                    });
                };

        public static TileContainer CreateEduFormsTileContainer(municipality m, WindowsUIView view, FormType formType, bool isArchive = false)
        {
            string eduCaption = "Образовательные учреждения";
            string subEduCaption = "";
            TileContainer eduContainer = TileContainerHelper.CreateTileContainer(view, null, eduCaption, subEduCaption);
            //IList<EduFormData> dataList = RepoHelper.Repo.GetEduFormDataByMunit(m, formType, isArchive);
            foreach (var eo in m.edus.OrderBy(e => e.name))
            {
                var data = isArchive
                    ? eo.edu_form_data
                    .Where(e => e.send_date.Value.Year < DateTime.Now.Year && e.form.form_type_id == (int) formType)
                    .ToList()
                    : eo.edu_form_data
                    .Where(e => e.send_date.Value.Year == DateTime.Now.Year && e.form.form_type_id == (int) formType)
                    .ToList();
                Tile eoTile = data.Count > 0 ? TileHelper.CreateAnimatedEduTile(eo, isArchive) : TileHelper.CreateEduTile(eo, isArchive);

                eoTile.Group = eo.name.Substring(0, 1);
                eduContainer.Items.Add(eoTile);

                string formCaption = "Формы федерального статистического наблюдения";
                string subFormCaption = eo.name;
                TileContainer formContainer = TileContainerHelper.CreateTileContainer(view, eoTile, formCaption, subFormCaption, eduContainer);
                formContainer.Tag = TagHelper.GetFormContainerTag(eo, formType, isArchive);

                GuiHelper.FormStatusCount statusCount = new GuiHelper.FormStatusCount() { FormsOkCount = 0, FormsWithErrorsCount = 0, FormsWithExpiredDateCount = 0, FormsWithBothCount = 0 };

                if (data.Count > 0)
                {
                    foreach (var fd in data)
                    {
                        Tile dTile = TileHelper.CreateFormTile(fd, view, formContainer, isArchive);
                        TileHelper.SetFormTileStatus(dTile, eoTile, null, null, fd, ref statusCount);
                        formContainer.Items.Add(dTile);
                    }
                    eoTile.Frames[1].Elements[0].Text = String.Format(
                              "Загруженных форм {0}\nС ошибками {1}\nС опозданием {2}\nС ошибками и опозданием {3}\nБез ошибок и опозданий {4}",
                              data.Count, statusCount.FormsWithErrorsCount, statusCount.FormsWithExpiredDateCount, statusCount.FormsWithBothCount, statusCount.FormsOkCount);
                }
                view.ContentContainers.Add(formContainer);
            }
            view.ContentContainers.Add(eduContainer);
            return eduContainer;
        }

        public static TileContainer CreateMunicipalityFormsTileContainer(municipality m, WindowsUIView view, bool isArchive = false)
        {
            string formCaption = m.name;
            string formSubCaption = isArchive ? "Архивные формы" : "Формы";

            TileContainer formContainer = TileContainerHelper.CreateTileContainer(view, null, formCaption, formSubCaption);
            formContainer.Tag = TagHelper.GetFormContainerTag(m, FormType.Municipality, isArchive); //Для добавления плитки с загруженной формой
            TileContainerHelper.InitFormContainerActions(formContainer);
            GuiHelper.FormStatusCount statusCount = new GuiHelper.FormStatusCount() { FormsOkCount = 0, FormsWithErrorsCount = 0, FormsWithExpiredDateCount = 0, FormsWithBothCount = 0 };

            //var dataList = RepoHelper.Repo.GetMunitFormData(m, isArchive);
            var dataList = isArchive
                ? m.municipality_form_data.Where(e => e.send_date.Value.Year < DateTime.Now.Year).ToList()
                : m.municipality_form_data.Where(e => e.send_date.Value.Year == DateTime.Now.Year).ToList();
            if (dataList.Count > 0)
            {
                foreach (var fd in dataList)
                {Tile dTile = TileHelper.CreateFormTile(fd, view, formContainer, isArchive);
                    dTile.ActivationTarget.Parent = formContainer;
                    TileHelper.SetFormTileStatus(dTile, null, null, null, fd, ref statusCount);
                    formContainer.Items.Add(dTile);
                }
            }
            view.ContentContainers.Add(formContainer);
            return formContainer;
        }
    }
}
