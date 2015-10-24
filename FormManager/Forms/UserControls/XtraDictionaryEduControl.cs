using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EduFormManager.Properties;
using Models;
using Models.Repo;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryEduControl : XtraBaseControl, ISupportDocumentActions
    {
        private edu _selectedEdu;
        private List<edu> _eduList; 
        public XtraDictionaryEduControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();
            InitializeProps();

            _eduList = new List<edu>();

            this.editEduControl.Repo = repo;
        }

        private void InitializeProps()
        {
            this.municipalityBindingSource.DataSourceChanged += (s, e) =>
            {
                this.editEduControl.MunicipalityDataSource = 
                    (List<municipality>) this.municipalityBindingSource.DataSource;
            };
            this.eduKindBindingSource.DataSourceChanged += (s, e) =>
            {
                this.editEduControl.EduKindDataSource = 
                    (List<edu_kind>) this.eduKindBindingSource.DataSource;
            };

            this.eduBindingSource.DataSourceChanged += (s, e) =>
            {
                RebuildEduTree();
            };
            this.eduBindingSource.PositionChanged += (sender, args) =>
            {
                this.editEduControl.Enabled = this.eduBindingSource.Position >= 0;
            };
            this.treeViewEdu.AfterSelect += (s, e) =>
            {
                var edu = e.Node.Tag as edu;
                if (edu != null)
                {
                    _selectedEdu = edu;
                    int idx = this.eduBindingSource.CurrencyManager.List.IndexOf(_selectedEdu);
                    this.eduBindingSource.CurrencyManager.Position = idx;
                    this.editEduControl.Edu = _selectedEdu;
                    this.editEduControl.Enabled = true;
                }
                else
                {
                    this.eduBindingSource.CurrencyManager.Position = -1;

                    this.editEduControl.Enabled = false;
                }
            };
            var timer = new Timer { Interval = 1200 };
            timer.Tick += (sender, args) =>
            {
                timer.Stop();
                var queryText = this.textBoxSearch.Text.ToLower();
                this.eduBindingSource.DataSource = _eduList
                    .Where(t => t.name.ToLower().Contains(queryText) || t.fullname.ToLower().Contains(queryText)).ToList();
            };
            this.textBoxSearch.TextChanged += (sender, args) =>
            {
                timer.Stop();
                timer.Start();
            };

            this.checkBoxShowToolTips.CheckedChanged += (sender, args) =>
            {
                this.treeViewEdu.ShowNodeToolTips = this.checkBoxShowToolTips.Checked;
            };
        }

        public override List<edu> EduDataSource
        {
            set
            {
                _eduList = value;
                eduBindingSource.DataSource = value;
            }
        }

        public edu SelectedEdu
        {
            get { return eduBindingSource.Current as edu; }
        }

        public void RebuildEduTree()
        {
            this.treeViewEdu.Nodes.Clear();
            var nodeCollection = GetEduNodelist();
            this.treeViewEdu.Nodes.AddRange(nodeCollection);
            if (string.IsNullOrEmpty(this.textBoxSearch.Text))
                this.treeViewEdu.CollapseAll();
            else
                this.treeViewEdu.ExpandAll();
        }

        private TreeNode[] GetEduNodelist()
        {
            var nodeCollection = new List<TreeNode>();
            var bindList = (List<edu>) this.eduBindingSource.List;
            var grp = bindList.GroupBy(x => x.municipality).OrderBy(t => t.Key.name);
            foreach (var grpItem in grp)
            {
                var munitNode = new TreeNode() {Text = grpItem.Key.name, Tag = grpItem.Key};
                foreach (var subItem in grpItem.OrderBy(t => t.name))
                {
                    var eduNode = new TreeNode
                    {
                        Text = subItem.name,
                        Tag = subItem,
                        Name = subItem.name,
                        ToolTipText = subItem.ToStringFull()
                    };
                    munitNode.Nodes.Add(eduNode);
                }
                nodeCollection.Add(munitNode);
            }
            return nodeCollection.ToArray();
        }

        public void SelectEdu(edu edu)
        {
            var nodes = this.treeViewEdu.Nodes.Find(edu.name, true);
            if (nodes.Length > 0)
            {
                this.treeViewEdu.SelectedNode = nodes[0];
            }
        }

        public void New()
        {
            New(null);
        }
        protected override void New(Document doc)
        {
            eduBindingSource.AddNew();
            XtraDictionaryEditEduForm editForm = new XtraDictionaryEditEduForm(this, 
                                                     (List<municipality>) this.municipalityBindingSource.List, 
                                                     (List<edu_kind>) this.eduKindBindingSource.List,
                                                     (edu) eduBindingSource.Current);
            editForm.Show(this.ParentForm);
        }

        public void CancelNew()
        {
            var current = (edu) eduBindingSource.Current;
            if (current.edu_id == 0)
                eduBindingSource.Remove(current);
        }

        public void Save()
        {
            Save(null);
        }
        protected override void Save(Document doc)
        {
            try
            {
                if (this.editEduControl.CanSave())
                {
                    var edu = this.editEduControl.Save();
                    RebuildEduTree();
                    this.SelectEdu(edu);
                }
            }
            catch
            {
                this.ShowFlyoutMessageBox("Ошибка", "Не удалось сохранить");
            }

            //base.UpdateData();
        }

        public bool CanSave()
        {
            return this.editEduControl.CanSave();
        }

        public void Remove()
        {
            Remove(null);
        }
        protected override void Remove(Document doc)
        {
            var edu = (edu) eduBindingSource.Current;
            var dialogResult = this.ShowFlyoutMessageBox("", string.Format("Удалить ОУ '{0}'?", edu.name), FlyoutCommand.Yes, FlyoutCommand.No);
            if (dialogResult == DialogResult.No) return;
            var eduSelected = (edu) this.treeViewEdu.SelectedNode.Tag;
            if (edu.Equals(eduSelected))
            {
                Repo.Remove(edu);
                eduBindingSource.Remove(edu);
                eduBindingSource.EndEdit();
                Repo.SaveChanges();
                RebuildEduTree();
            }
            else
            {
                this.ShowFlyoutMessageBox("Ошибка", "Для удаления не выбран элемент", FlyoutCommand.OK);
            }
        }
        public bool CanRemove()
        {
            return CanRemove(null);
        }
        protected override bool CanRemove(Document doc)
        {
            return eduBindingSource.Current != null;
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(New) { Caption = "Новый", Image = Resources.glyphicons_432_plus });
            args.DocumentActions.Add(new DocumentAction(Save) { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
            args.DocumentActions.Add(new DocumentAction(CanRemove, Remove) { Caption = "Удалить", Image = Resources.glyphicons_207_remove_2 });
        }
    }
}
