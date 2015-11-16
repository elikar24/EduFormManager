using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using EduFormManager.Properties;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryMunitControl : XtraBaseControl, ISupportDocumentActions
    {
        public XtraDictionaryMunitControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();

            this.labelSavedStatus.Visible = false;
            this.munitEditControl.Repo = repo;
        }

        private void listBoxMunicipality_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = (ListBoxControl)sender;
            municipalityBindingSource.Position = listBox.SelectedIndex;

            var munit = (municipality)municipalityBindingSource.Current;

            this.eduBindingSource.DataSource = munit.edus.ToList();

            this.munitEditControl.Municipality = munit;

            this.labelSavedStatus.Visible = false;
        }

        public void New()
        {
            New(null);
        }

        protected override void New(Document doc)
        {
            var munit = this.Repo.Create<municipality>();
            this.municipalityBindingSource.Add(munit);
            var editForm = new XtraDictionaryEditMunitForm(this, munit);
            editForm.Show(this.ParentForm);
            this.labelSavedStatus.Text = "В справочнике Образовательных Организаций муниципалитет появится после добавления к нему организации";
            this.labelSavedStatus.Visible = true;
        }

        public bool CanNew()
        {
            return CanNew(null);
        }

        public void CancelNew()
        {
            var current = municipalityBindingSource.Current as municipality;
            if (current != null && current.municipality_id == 0)
                municipalityBindingSource.Remove(current);
        }

        protected override bool CanNew(Document doc)
        {
            return true;
        }

        public void Save()
        {
            Save(null);
        }

        protected override void Save(Document doc)
        {
            if (this.CanSave(doc))
            {
                this.munitEditControl.Save();
            }
        }
        public bool CanSave()
        {
            return CanSave(null);
        }

        protected override bool CanSave(Document doc)
        {
            return this.munitEditControl.CanSave();
        }

        public void Remove()
        {
            Remove(null);
        }

        protected override async void Remove(Document doc)
        {
            var munit = municipalityBindingSource.Current as municipality;
            if (munit == null)
            {
                ShowFlyoutMessageBox("Информация", "Не выбрана запись");
                return;
            }
            if (munit.edus.Count > 0)
            {
                this.ShowFlyoutMessageBox("Уведомление",
                    String.Format("нельзя удалить муниципалитет \"{0}\", пока ему принадлежат следующие организации: {1}.", 
                    munit, munit.edus.Select(t => t.name))
                    );
                return;
            }
            var dialogResult = this.ShowFlyoutMessageBox("Подтвердите", string.Format("Удалить муниципалитет \"{0}\"", munit.name), 
                FlyoutCommand.OK, FlyoutCommand.Cancel);
            if (dialogResult == DialogResult.OK)
            {
                municipalityBindingSource.RemoveCurrent();
                municipalityBindingSource.EndEdit();
                if (munit.municipality_id > 0)
                {
                    Repo.Remove(munit);
                    await Repo.SaveChangesAsync();
                }
            } 
        }

        public bool CanRemove()
        {
            return CanRemove(null);
        }

        protected override bool CanRemove(Document doc)
        {
            return municipalityBindingSource.Current != null;
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(New) { Caption = "Новый", Image = Resources.glyphicons_432_plus });
            args.DocumentActions.Add(new DocumentAction(Save) { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
            args.DocumentActions.Add(new DocumentAction(CanRemove, Remove) { Caption = "Удалить", Image = Resources.glyphicons_207_remove_2 });
        }
    }
}
