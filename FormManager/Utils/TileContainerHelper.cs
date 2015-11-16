using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using Models;
using Models.Repo;

namespace EduFormManager.Utils
{
    public static class TileContainerHelper
    {
        public static TileContainer CreateTileContainer(WindowsUIView view, Tile activationTile, string caption = "", String subCaption = "", IContentContainer parent = null)
        {
            TileContainer container = new TileContainer() { Caption = caption, Subtitle = subCaption, Parent = parent };
            if (activationTile != null)
            {
                (container as IContentContainer).Name = activationTile.Tag.ToString();
                activationTile.ActivationTarget = container;
            }
            container.Properties.IndentBetweenItems = 1;
            container.Properties.IndentBetweenGroups = 16;
            container.Properties.ItemSize = 128;
            container.Properties.ShowGroupText = DefaultBoolean.True;
            container.AppearanceGroupText.Font = new Font("Segoe UI Light", 18);
            container.Properties.AllowItemHover = DefaultBoolean.True;
            return container;
        }

        public static void SetStatusLoading(TileContainer container)
        {
            container.Items.Clear();
            var loadingTile = TileHelper.CreateLoadingTile();
            container.Items.Add(loadingTile);
        }

        public static void RemoveStatusLoading(TileContainer container)
        {
            container.Items.Clear();
        }

        public static void SetLoadingProgress(TileContainer container, int value)
        {
            var tile = container.Items.FirstOrDefault();
            if (tile == null) return;
            if (tile.Elements.Count < 2) return;
            tile.Elements[0].Text = value + "%";
        }

        public static void InitFormContainerActions(TileContainer con)
        {
            con.Properties.ItemCheckMode = TileItemCheckMode.Single;
            var deleteAction = new DelegateAction(() => true, async () =>
            {
                var checkedTile = (Tile)con.Items.FirstOrDefault(x => x.Checked.HasValue && x.Checked.Value);
                if (checkedTile == null) return;
                if (checkedTile.Tag == null) return;
                int? formId = TagHelper.GetFormDataId(checkedTile.Tag.ToString());
                if (!formId.HasValue)
                    return;
                var view = (WindowsUIView)con.Manager.View;
                var fly = view.ContentContainers.FindFirst(x => x is Flyout && x.Caption == "Сообщение") as Flyout;
                var formType = ((Page)checkedTile.ActivationTarget).Document.ControlName;
                if ((new Regex(@"(Archive)?FormData[1|2]")).IsMatch(formType))
                {
                    try
                    {
                        using (var repo = new Repository())
                        {
                            var data = await repo.GetEduFormDataById(formId.Value);
                            if (data.form.DaysRemain() == -1 && data.form.is_blocked)
                            {
                                var mes = fly != null
                                    ? GuiUtility.ShowFlyoutMessage(view, fly, "Информация",
                                        "Удаление формы отключено, так как срок сдачи истек.\nЧтобы иметь возможность удалить эту форму, обратитесь к региональному оператору")
                                    : MessageBox.Show("Удалить форму?", "Информация", MessageBoxButtons.OKCancel);
                                return;
                            }
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

                var res = fly != null ?
                    GuiUtility.ShowFlyoutMessage(view, fly, "Подтверждение", "Удалить форму?", FlyoutCommand.Yes, FlyoutCommand.No) :
                    MessageBox.Show("Удалить форму?", "Подтверждение", MessageBoxButtons.OKCancel);
                if (res == DialogResult.No)
                    return;
                switch (formType)
                {
                    case "ArchiveFormData1":
                    case "ArchiveFormData2":
                    case "FormData2":
                    case "FormData1":
                        {
                            try
                            {
                                using (var repo = new Repository())
                                {
                                    var data = await repo.GetEduFormDataById(formId.Value);
                                    var file = await repo.GetFile(data.file_id);
                                    var forms = file.edu_form_data;
                                    
                                    var tag = TagHelper.GetFormDataTag(TagHelper.TagType.Tile, data);
                                    var tiles = con.Items.Find(t => t.Tag.ToString() == tag).ToArray();
                                    
                                    repo.RemoveRange(forms);
                                    repo.Remove(file);
                                    await repo.SaveChangesAsync();

                                    if (con.Items.Count == 1)
                                        con.Items.Clear();
                                    else
                                        con.Items.RemoveRange(tiles);
                                }
                            }
                            catch (Exception ex)
                            {
                                var mess = fly != null ?
                                    GuiUtility.ShowFlyoutMessage(view, fly, "Ошибка удаления", ex.Message) :
                                    MessageBox.Show(ex.Message, "Ошибка удаления", MessageBoxButtons.OK);
                            }
                            break;
                        }
                    case "ArchiveFormData4":
                    case "FormData4":
                    case "ArchiveFormData3":
                    case "FormData3":
                        {
                            try
                            {
                                using (var repo = new Repository())
                                {
                                    var data = await repo.GetMunitFormDataById(formId.Value);
                                    var file = data.file;
                                    var forms = file.municipality_form_data;

                                    var tag = TagHelper.GetFormDataTag(TagHelper.TagType.Tile, data);
                                    var tiles = con.Items.Find(t => t.Tag.ToString() == tag).ToArray();

                                    repo.RemoveRange(forms);
                                    repo.Remove(file);
                                    await repo.SaveChangesAsync();

                                    if (con.Items.Count == 1) 
                                        con.Items.Clear();
                                    else 
                                        con.Items.RemoveRange(tiles);
                                }
                            }
                            catch (Exception ex)
                            {
                                var mess = fly != null ?
                                    GuiUtility.ShowFlyoutMessage(view, fly, "Ошибка удаления", ex.Message) :
                                    MessageBox.Show(ex.Message, "Ошибка удаления", MessageBoxButtons.OK);
                            }
                            break;
                        }
                }
            })
            {
                Caption = "Удалить форму",
                Type = ActionType.Context,
                Edge = ActionEdge.Right,
                Behavior = ActionBehavior.HideBarOnClick
            };

            con.Actions.Clear();
            con.Actions.Add(deleteAction);
        }

        public static void InitQuestionaryContainerActions(TileContainer con)
        {
            con.Properties.ItemCheckMode = TileItemCheckMode.Single;
            DelegateAction deleteAction = new DelegateAction(() => true, () =>
            {
                BaseTile checkedTile = con.Items.First(x => x.Checked.HasValue && x.Checked.Value);
                if (checkedTile.Tag == null)
                    return;
                int? questionaryId = TagHelper.GetQuestionaryId(checkedTile.Tag.ToString());
                if (!questionaryId.HasValue)
                    return;
                try
                {
                    //Questionary questionary = RepoHelper.Repo.GetById<Questionary>(questionaryId.Value);
                    //RepoHelper.Repo.Delete(questionary);
                    con.Items.Remove(checkedTile);
                }
                catch (Exception)
                {
                    
                }
            })
            {
                Caption = "Удалить анкету",
                Type = ActionType.Context,
                Edge = ActionEdge.Right,
                Behavior = ActionBehavior.HideBarOnClick
            };

            con.Actions.Clear();
            con.Actions.Add(deleteAction);

            DelegateAction newAction = new DelegateAction(() => true, () =>
            {
                try
                {
                    var questionary = new questionary() { questionary_title = "Новая анкета" , questions = new HashSet<question>()};
                    //RepoHelper.Repo.Save(questionary);

                    Tile newTile = TileHelper.CreateQuestionaryTile(questionary, (WindowsUIView) con.Manager.View, con);
                    con.Items.Add(newTile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            })
            {
                Caption = "Новая анкета",
                Edge = ActionEdge.Right
            };
            con.Buttons.AddAction(newAction);
        }
    }
}
