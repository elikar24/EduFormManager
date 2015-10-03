using System.Collections.Generic;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EduFormManager.Models;

namespace EduFormManager.Utils
{
    public static class LevelEduHelper
    {
        public static TileContainer CreateEduFormsTileContainer(edu eo, WindowsUIView view, FormType formType, bool isArchive = false)
        {
            string subCaption = isArchive ? "Архивные " : "";
            subCaption += (formType == FormType.Federal) ? "Формы федерального статистического наблюдения" : "Доп. формы";
            string caption = eo.name;
            TileContainer formContainer = TileContainerHelper.CreateTileContainer(view, null, caption, subCaption);
            formContainer.Tag = TagHelper.GetFormContainerTag(eo, formType, isArchive);
            TileContainerHelper.InitFormContainerActions(formContainer);
            var dataList = eo.edu_form_data;
            if (dataList.Count > 0)
            {
                GuiHelper.FormStatusCount statusCount = new GuiHelper.FormStatusCount() { FormsOkCount = 0, FormsWithErrorsCount = 0, FormsWithExpiredDateCount = 0, FormsWithBothCount = 0 };
                foreach (var fd in dataList)
                {
                    Tile dTile = TileHelper.CreateFormTile(fd, view, formContainer, isArchive);
                    TileHelper.SetFormTileStatus(dTile, null, null, null, fd, ref statusCount);
                    formContainer.Items.Add(dTile);
                }
            }
            view.ContentContainers.Add(formContainer);
            return formContainer;
        }

        
    }
}
