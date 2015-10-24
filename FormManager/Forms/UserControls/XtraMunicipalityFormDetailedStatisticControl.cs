using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraMunicipalityFormDetailedStatisticControl : XtraBaseControl
    {
        private int _selectedYear;

        public XtraMunicipalityFormDetailedStatisticControl(WindowsUIView view, Repository repo)
            : base (view, repo)
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            this.formStatisticBindingSource.ListChanged += (sender, args) =>
            {
                var doc = (Document)this.View.Documents.SingleOrDefault(t => t.ControlName == "MunicipalityFormDetailedStatisticsReport");
                if (doc != null)
                    doc.Tag = this.formStatisticBindingSource.List.Cast<t_detailed_municipality_form_statistics>().ToList();
            };

            this.repositoryItemComboBoxYear.EditValueChanged += async (sender, args) =>
            {
                var s = (ComboBoxEdit)sender;
                _selectedYear = (int)s.EditValue;
                this.barEditItemYear.Enabled = false;
                this.formStatisticBindingSource.DataSource = Authentication.Credentials.IsMunicipality
                    ? await Repo.GetDetailedMunicipalityFormStatistics(Authentication.Credentials.MunitId, _selectedYear)
                    : await Repo.GetDetailedMunicipalityFormStatistics(_selectedYear);
                this.barEditItemYear.Enabled = true;
            };

            this.barButtonItemReport.ItemClick += (sender, args) =>
            {
                var doc = (Document)this.View.Documents.SingleOrDefault(t => t.ControlName == "MunicipalityFormDetailedStatisticsReport");
                var container = this.View.ContentContainers.FindFirst(t => t.Parent == this.View.ActiveContentContainer && t.Contains(doc));
                if (container != null)
                    this.View.ActivateContainer(container);
            };
        }

        public int SelectedYear { get { return _selectedYear; } }

        public IList<int> YearsDataSource
        {
            set
            {
                var years = value.OrderByDescending(t => t).ToArray();
                this.repositoryItemComboBoxYear.Items.Clear();
                this.repositoryItemComboBoxYear.Items.AddRange(years);
                this.barEditItemYear.EditValue = years[0];
            }
        } 

        public IList<t_detailed_municipality_form_statistics> FormStatisticDataSource
        {
            get
            {
                return this.formStatisticBindingSource.List.Cast<t_detailed_municipality_form_statistics>().ToList();
            }
            set
            {
                this.formStatisticBindingSource.DataSource = value;
                this.gridView1.CollapseAllGroups();
            }
        }

        private void gridView1_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "is_uploaded")
            {
                e.DisplayText = (int) e.Value == 1 ? "Загрузили" : "Не загрузили";
            }
        }
    }
}
