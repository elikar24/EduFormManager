using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using EduFormManager.Models;
using EduFormManager.Models.Repo;
using EduFormManager.Utilities;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraBaseControl : XtraUserControl
    {
        public enum Type
        {
            Form,
            Component
        }

        protected static MarqueeProgressDialog ProgressDialog = new MarqueeProgressDialog();
        protected Type _controlType;

        public XtraBaseControl()
        {
            InitializeComponent();
        }

        public XtraBaseControl(WindowsUIView view)
        {
            InitializeComponent();
            this.View = view;
            _controlType = Type.Component;
        }

        public XtraBaseControl(WindowsUIView view, Repository repo)
        {
            InitializeComponent();
            this.View = view;
            Repo = repo;_controlType = Type.Component;
        }
        
        public virtual Type ControlType
        {
            get
            {
                return _controlType;
            }
            set 
            {
                _controlType = value;
            }
        }

        public DialogResult WarnAboutSavingChanges()
        {
            return this.ShowFlyoutMessageBox("Подтверждение", "Сохранить изменения?", FlyoutCommand.Yes, FlyoutCommand.No, FlyoutCommand.Cancel);
        }

        public DialogResult ShowFlyoutMessageBox(string caption, string msg, params FlyoutCommand[] commands)
        {
            Flyout fly = View.ContentContainers.FindFirst(x => x is Flyout && x.Caption == "Сообщение") as Flyout;
            if (View != null && fly != null)
            {
                return GuiUtility.ShowFlyoutMessage(View, fly, caption, msg, commands);
            }
            else
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK);
            }
        }
        public Repository Repo { get; set; }

        public WindowsUIView View { get; set; }

        public virtual List<form> FormDataSource
        {
            set
            {
                formBindingSource.DataSource = value;
            }
            get
            {
                return formBindingSource.DataSource as List<form>;
            }
        }

        public virtual List<form_type> FormTypeDataSource
        {
            set
            {
                formTypeBindingSource.DataSource = value;
            }
            get
            {
                return formTypeBindingSource.DataSource as List<form_type>;
            }
        }

        public virtual List<templated_form_data> TemplatedFormDataDataSource
        {
            set
            {
                templatedFormDataBindingSource.DataSource = value;
            }
        }

        public virtual  List<query> DataSourceQuery
        {
            set
            {
                queryBindingSource.DataSource = value;
            }
        }

        public virtual List<edu> EduDataSource
        {
            set
            {
                eduBindingSource.DataSource = new BindingList<edu>(value);
            }
        }
        public virtual List<municipality> MunicipalityDataSource
        {
            set
            {
                municipalityBindingSource.DataSource = value;
            }
        }
        public virtual List<edu_type> EduTypeDataSource
        {
            set
            {
                eduTypeBindingSource.DataSource = value;
            }
        }
        public virtual List<edu_kind> DataSourceEduKind
        {
            set
            {
                eduKindBindingSource.DataSource = value;
            }
        }
        public virtual List<message> DataSourceMessage
        {
            set
            {
                messageBindingSource.DataSource = value;
            }
        }
        protected virtual void New(Document doc) { }
        protected virtual bool CanNew(Document doc) { return true; }
        protected virtual void Save(Document doc) { }
        protected virtual bool CanSave(Document doc) { return true; }
        protected virtual void Remove(Document doc) { }
        protected virtual bool CanRemove(Document doc) { return true; }
    }
}
