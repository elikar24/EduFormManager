using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using EduFormManager.Models;
using EduFormManager.Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraFormDetailedStatisticControl : XtraBaseControl
    {
        private int _selectedYear;

        public XtraFormDetailedStatisticControl(WindowsUIView view, Repository repo)
            : base (view, repo)
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            this.repositoryItemComboBoxYear.EditValueChanged += async (sender, args) =>
            {
                var s = (ComboBoxEdit)sender;
                _selectedYear = (int)s.EditValue;
                this.barEditItemYear.Enabled = false;
                this.formStatisticBindingSource.DataSource = Authentication.Credentials.IsMunicipality
                    ? await Repo.GetDetailedFormStatistics(Authentication.Credentials.MunitId, _selectedYear)
                    : await Repo.GetDetailedFormStatistics(_selectedYear);
                this.barEditItemYear.Enabled = true;
            };

            this.barButtonItemReport.ItemClick += (sender, args) =>
            {
                var container = this.View.ContentContainers.FindFirst(t => t.Parent == this.View.ActiveContentContainer);
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

        public IList<t_detailed_form_statistics> FormStatisticDataSource
        {
            get
            {
                return this.formStatisticBindingSource.List.Cast<t_detailed_form_statistics>().ToList();
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
