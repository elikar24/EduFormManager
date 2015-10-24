using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using Models;
using Models.Repo;

namespace EduFormManager.Utils
{
    public class FormStatusCount
    {
        public int FormsOkCount;
        public int FormsWithErrorsCount;
        public int FormsWithExpiredDateCount;
        public int FormsWithBothCount;
    }

    public static class GuiUtility
    {
        public static SynchronizationContext GuiThreadContext
        {
            get;
            set;
        }

        public static void UpdateDataBindingSources(params object[] args)
        {
            for (int i = 0; i < args.Length; i += 2) 
            {
                BindingSource source = (BindingSource)args[i];
                object data = args[i + 1];
                source.Clear();
                source.DataSource = data;
                source.Position = 0;
            }
        }

        public static void ShowNavigationBar(WindowsUIView view)
        {
            FieldInfo field = view.GetType().GetField("navigationBarBootStrapperCore", BindingFlags.Instance | BindingFlags.NonPublic);
            object strapper = field.GetValue(view);
            MethodInfo method = strapper.GetType().GetMethod("Show");
            method.Invoke(strapper, null);
        }

        public static DialogResult ShowFlyoutMessage(WindowsUIView view, Flyout flyoutMessage, String caption, String description, params FlyoutCommand[] commands)
        {
            FlyoutAction messageAction = new FlyoutAction()
            {
                Caption = caption,
                Description = description
            };
            messageAction.Commands.Clear();
            if (commands.Length == 0)
            {
                messageAction.Commands.Add(FlyoutCommand.OK);
            }
            else
            {
                foreach (FlyoutCommand command in commands)
                {
                    messageAction.Commands.Add(command);
                }
            }

            flyoutMessage.Action = messageAction;

            return view.ShowFlyoutDialog(flyoutMessage);
        }

        public static void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox lst = sender as ListBox;
            if (lst.Items.Count > 0)
                e.ItemHeight = (int)e.Graphics.MeasureString(lst.Items[e.Index].ToString(), lst.Font, lst.Width).Height + 5;
        }

        public static void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox lst = sender as ListBox;
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (lst.Items.Count > 0)
            {
                e.Graphics.DrawString(lst.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
                e.Graphics.DrawLine(new Pen(SystemColors.ActiveBorder, 1), e.Bounds.Left, e.Bounds.Bottom - 1,
                    e.Bounds.Right, e.Bounds.Bottom - 1);
            }
            //e.Graphics.DrawRectangle(new Pen(e.ForeColor), e.Bounds);
        }

        public static async void NotifyAboutForms(Credentials user)
        {
            using (var repo = new Repository())
            {
                var formList = new List<form>();
                if (user.IsEdu)
                {
                    var kind = (await repo.GetEdu(user.EduId)).edu_kind;
                    formList = kind.forms.ToList();
                } 
                else if (user.IsMunicipality)
                {
                    formList = await repo.GetMunicipalityForms();
                }
                foreach (var form in formList)
                {
                    var daysRemain = form.DaysRemain();
                    if (daysRemain < 0 || daysRemain >= 30) continue;
                    var warn = new Notifications.ExpireWarn()
                    {
                        DaysRemain = daysRemain,
                        FormName = form.name
                    };
                    Notifications.Add(warn);
                }
            }
        }
    }
}
