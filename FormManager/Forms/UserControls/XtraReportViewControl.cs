﻿using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraReports.UI;
using Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraReportViewControl : XtraBaseControl
    {
        private XtraReport _report;
        public XtraReportViewControl(WindowsUIView view) 
            : base(view)
        {
            InitializeComponent();
            this.barButtonItemExport.ItemClick += (sender, args) => Export();
        }

        public XtraReportViewControl(WindowsUIView view, Repository repo) 
            : base(view, repo)
        {
            InitializeComponent();
            this.barButtonItemExport.ItemClick += (sender, args) => Export();
        }

        private void Export()
        {
            var exportAction = new FlyoutAction()
            {
                Caption = "Экспорт"
            };
            var exportFlyout = this.View.ContentContainers.FindFirst(t =>
            {
                var flyout = t as Flyout;
                if (flyout != null && flyout.Document != null)
                    return "ExportReport".Equals(flyout.Document.ControlName);
                return false;
            }) as Flyout;
            if (exportFlyout != null)
            {
                exportFlyout.Action = exportAction;
                View.ActivateContainer(exportFlyout);
            }
        }

        public XtraReport Report
        {
            set
            {
                _report = value;
                this.documentViewerReport.DocumentSource = value;
            }
            get { return _report; }
        }

        public void ExportToXlsx(string filename)
        {
            _report.ExportToXlsx(filename);
        }

        public void ExportToPdf(string filename)
        {
            _report.ExportToPdf(filename);
        }
    }
}
                                                                           