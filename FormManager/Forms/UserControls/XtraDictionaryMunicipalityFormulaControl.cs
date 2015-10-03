using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraSpreadsheet;
using DevExpress.XtraSpreadsheet.Menu;
using EduFormManager.Models;
using EduFormManager.Models.Repo;
using EduFormManager.Properties;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryMunicipalityFormulaControl : XtraBaseControl, ISupportDocumentActions
    {
        private mm_regular__summary_form _currentFormula;
        public XtraDictionaryMunicipalityFormulaControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();

            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            this.allformBindingSource1.CurrentItemChanged += (sender, args) =>
            {
                var form = this.allformBindingSource1.Current as form;
                if (form == null) return;
                LoadTemplate(form, spreadsheetControlEdu);
            };

            this.allformBindingSource2.CurrentItemChanged += async (sender, args) =>
            {
                var form = this.allformBindingSource2.Current as form;
                var eduForm = this.allformBindingSource1.Current as form;
                if (form == null || eduForm == null) return;

                this.layoutControl1.Enabled = false;

                var formula = await Repo.GetMunicipalityFormulaByMunicipalityForm(form.form_id);
                if (formula != null)
                {
                    if (formula.regular_form != eduForm)
                    {
                        eduForm = formula.regular_form;
                        this.comboBoxFormEdu.SelectedItem = formula.regular_form;
                    }
                    _currentFormula = formula;
                    this.formulaEditControl1.Text = await Task.Run(() => Encoding.UTF8.GetString(formula.file_data));
                }
                else
                {
                    _currentFormula = new mm_regular__summary_form();
                    this.formulaEditControl1.Text = string.Empty;
                }
                this.LoadTemplate(form, this.spreadsheetControlMunit);
                this.LoadTemplate(eduForm, this.spreadsheetControlEdu);

                this.layoutControl1.Enabled = true;
            };
        }

        protected override async void Save(Document doc)
        {
            var eduForm = this.allformBindingSource1.Current as form;
            var munitForm = this.allformBindingSource2.Current as form;
            if (eduForm == null || munitForm == null)
            {
                this.ShowFlyoutMessageBox("Ошибка", "Не выбрана форма", FlyoutCommand.OK);
                return;
            }
            string formulaText = this.formulaEditControl1.Text.Trim();
            if (string.IsNullOrEmpty(formulaText))
            {
                this.ShowFlyoutMessageBox("Ошибка", "Нечего сохранять", FlyoutCommand.OK);
                return;
            }
            
            try
            {
                using (new MarqueeProgressDialog(this.ParentForm, description: "Сохранение"))
                {
                    var formulaBytes = Encoding.UTF8.GetBytes(formulaText);
                    _currentFormula.regular_form = eduForm;
                    _currentFormula.summary_form = munitForm;
                    _currentFormula.file_data = formulaBytes;
                    if (_currentFormula.id == 0)
                        Repo.Db.mm_regular__summary_form.Add(_currentFormula);
                    await Repo.Db.SaveChangesAsync();
                }
                this.ShowFlyoutMessageBox("Информация", "Сохранено", FlyoutCommand.OK);
            }
            catch (Exception ex)
            {
                this.ShowFlyoutMessageBox("Ошибка", ex.Message, FlyoutCommand.OK);
            }
        }

        protected override async void Remove(Document doc)
        {
            if (_currentFormula.id == 0)
            {
                this.ShowFlyoutMessageBox("Информация",
                    "Это только что созданная и не сохраненная формула. Ее удалять не требуется.");
                return;
            }
            Repo.Db.mm_regular__summary_form.Remove(_currentFormula);
            await Repo.Db.SaveChangesAsync();
        }

        public List<form> RegularFormDataSource
        {
            set { this.allformBindingSource1.DataSource = value; }
        }
        public List<form> SummaryFormDataSource
        {
            set { this.allformBindingSource2.DataSource = value; }
        }

        private void LoadTemplate(form form, ISpreadsheetControl spreadsheetControl)
        {
            var template = form.templated_form_data;
            if (template == null)
            {
                this.ShowFlyoutMessageBox("Информация", string.Format("У формы {0} отсутствует шаблон", form), FlyoutCommand.OK);
                spreadsheetControl.CreateNewDocument();
                return;
            }
            var excelData = template.file_data;
            if (excelData == null)
            {
                this.ShowFlyoutMessageBox("Информация", "Не удалось загрузить шаблон", FlyoutCommand.OK);
                spreadsheetControl.CreateNewDocument();
                return;
            }
            using (var ms = new MemoryStream(excelData))
            {
                var format = DocumentFormat.OpenXml;
                spreadsheetControl.LoadDocument(ms, format);
                spreadsheetControl.Document.History.IsEnabled = true;
                spreadsheetControl.Document.Worksheets.ActiveWorksheet = spreadsheetControl.Document.Worksheets.FirstOrDefault();
            }
        }

        private void spreadsheetControlEdu_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                e.Menu.Items.Clear();
                var ranges = this.spreadsheetControlEdu.GetSelectedRanges();
                var itemAdd = new SpreadsheetMenuItem("Добавить", (o, args) => this.formulaEditControl1.AddToRightPart(ranges));
                var itemReplace = new SpreadsheetMenuItem("Заменить", (o, args) => this.formulaEditControl1.ReplaceRightPart(ranges));
                e.Menu.Items.Add(itemAdd);
                e.Menu.Items.Add(itemReplace);
            }
        }

        private void spreadsheetControlMunit_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == SpreadsheetMenuType.Cell)
            {
                e.Menu.Items.Clear();
                var ranges = this.spreadsheetControlMunit.GetSelectedRanges();
                var itemAdd = new SpreadsheetMenuItem("Добавить", (o, args) => this.formulaEditControl1.AddToLeftPart(ranges));
                var itemReplace = new SpreadsheetMenuItem("Заменить", (o, args) => this.formulaEditControl1.ReplaceLeftPart(ranges));
                e.Menu.Items.Add(itemAdd);
                e.Menu.Items.Add(itemReplace);
            }
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(CanSave, Save) { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
            args.DocumentActions.Add(new DocumentAction(CanRemove, Remove) { Caption = "Удалить", Image = Resources.glyphicons_207_remove_2 });
        }
    }
}
