using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraExportReportControl : XtraUserControl
    {
        [Flags]
        public enum ExportFormat
        {
            [Display(Name = "Microsoft Excel (.xslx)")]
            Xslx = 0,
            [Display(Name = "PDF (.pdf)")]
            Pdf = 1
        };

        private ExportFormat _format = ExportFormat.Xslx;

        public string FileName { get; private set; }
        public ExportFormat Format { get { return _format; } }

        public XtraExportReportControl()
        {
            InitializeComponent();
            this.comboBoxExportFormat.DataSource = Enum.GetNames(typeof (ExportFormat));

            this.comboBoxExportFormat.SelectedIndexChanged += (sender, args) =>
            {
                Enum.TryParse(this.comboBoxExportFormat.SelectedValue.ToString(), out _format);
            };

            this.buttonFile.Click += (sender, args) =>
            {
                SaveFileDialog sfd = new SaveFileDialog();
                switch (_format)
                {
                    case ExportFormat.Xslx:
                        sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                        break;
                    case ExportFormat.Pdf:
                        sfd.Filter = "PDF (*.pdf)|*.pdf";
                        break;
                }
                
                DialogResult result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.textBox1.Text = sfd.FileName;
                    FileName = sfd.FileName;
                }
            };
        }
    }
}
