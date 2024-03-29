﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using EduFormManager.Utils;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls.MunicipalityFormulaPeek
{
    public partial class MunicipalityFormulaPeekControl : XtraUserControl
    {
        private municipality _municipality;
        private form _summaryForm;
        private form _regularForm;
        private int _year;
        private mm_regular__summary_form _formula;

        public event EventHandler<MunicipalityFormulaPeekArgs> Completed;

        public MunicipalityFormulaPeekControl(Repository repo, form summaryForm, int year)
        {
            InitializeComponent();
            IsAvailable = false;

            if (Authentication.Credentials.IsMunicipality)
            {
                InitializeMunicipality(repo, summaryForm, year);
            }
            else if (Authentication.Credentials.IsAdmin)
            {
                InitializeAdmin(repo, summaryForm, year);
            }

            this.buttonCancel.Click += CompleteHandler;
            this.buttonOk.Click += CompleteHandler;
        }

        async private Task InitializeMunicipality(Repository repo, form summaryForm, int year)
        {
            var munit = repo.GetMunicipality(Authentication.Credentials.MunitId).Result;
            _formula = await repo.GetMunicipalityFormulaByMunicipalityForm(summaryForm.form_id);
            this.IsAvailable = (_formula != null);
            if (this.IsAvailable)
            {
                _municipality = munit;
                _summaryForm = summaryForm;
                _regularForm = _formula.regular_form;
                _year = year;

                var eduList = await repo.GetEdus(munit.municipality_id);
                var eduHasFormIdList = (await repo.GetEdusHaveFormData(_regularForm.form_id, _year))
                    .Select(t => t.edu_id);
                foreach (var edu in eduList)
                {
                    var hasForm = eduHasFormIdList.Contains(edu.edu_id);
                    edu.SetAttachedProperty("bHasForm", hasForm);
                }
                this.eduBindingSource.DataSource = eduList;
            }
        }

        async private Task InitializeAdmin(Repository repo, form summaryForm, int year)
        {
            _formula = await repo.GetMunicipalityFormulaByMunicipalityForm(summaryForm.form_id);
            this.IsAvailable = (_formula != null);
            if (this.IsAvailable)
            {
                _summaryForm = summaryForm;
                _regularForm = _formula.regular_form;
                _year = year;
                var eduList = await repo.GetEdusHaveFormData(_regularForm.form_id, _year);

                this.eduBindingSource.DataSource = eduList;
            }
        }

        public bool IsAvailable { get; private set; }

        private void CompleteHandler(object sender, EventArgs e)
        {
            var btn = (SimpleButton) sender;
            if (btn.Name == "buttonCancel")
            {
                OnCompleted(new MunicipalityFormulaPeekArgs() { Write = false });
                return;
            }
            var args = new MunicipalityFormulaPeekArgs
            {
                Write = this.IsAvailable
            };

            if (IsAvailable)
            {
                foreach (int index in this.gridViewEdu.GetSelectedRows())
                {
                    var edu = (edu) this.gridViewEdu.GetRow(index);
                    var data = edu.edu_form_data.FirstOrDefault(t => t.form.form_id == _regularForm.form_id 
                        && t.send_date.Year == _year);
                    if (data == null) continue;
                    args.FormDataList.Add(data);
                }
                args.FormulaBytes = _formula.file_data;
            }
            OnCompleted(args);
        }

        protected virtual void OnCompleted(MunicipalityFormulaPeekArgs e)
        {
            var handler = Completed;
            if (handler != null) handler(this, e);
        }

        private void gridViewEdu_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var grid = (GridView) sender;
            if (e.Action == CollectionChangeAction.Add)
            {
                var edu = grid.GetRow(e.ControllerRow);
                var hasForm = edu.GetAttachedProperty("bHasForm");
                if (hasForm == null) return;
                if ((bool) hasForm) return;
                grid.UnselectRow(e.ControllerRow);
            }
        }

        private void gridViewEdu_RowStyle(object sender, RowStyleEventArgs e)
        {
            var grid = (GridView) sender;
            if (e.RowHandle > 0)
            {
                var edu = grid.GetRow(e.RowHandle);
                var hasForm = edu.GetAttachedProperty("bHasForm");
                if (hasForm == null) return;
                if ((bool)hasForm) return;
                e.Appearance.BackColor = Color.FromArgb(76, 211, 211, 211);
            }
        }
    }
}
