using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using EduFormManager.Properties;
using Models;
using Models.Repo;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;

namespace EduFormManager.Forms.UserControls
{
    public partial class XtraDictionaryFormsControl : XtraBaseControl, ISupportDocumentActions
    {
        private bool _isManualChecking;
        private form _selectedForm;
        private new List<form> _editedList; 

        public XtraDictionaryFormsControl(WindowsUIView view, Repository repo)
            : base(view, repo)
        {
            InitializeComponent();
            InitializeProps();

            _isManualChecking = true;
            _editedList = new List<form>();
        }

        private void InitializeProps()
        {
            this.formBindingSource.DataSourceChanged += (s, e) => 
            {
                var formList = (List<form>) this.formBindingSource.List;
                RebuildAllformTree(formList);
            };

            this.formBindingSource.ListChanged += (s, e) => 
            {
                if (e.ListChangedType == ListChangedType.ItemAdded ||
                    e.ListChangedType == ListChangedType.ItemChanged)
                {
                    var form = (form) this.formBindingSource.List[e.NewIndex];
                    if (!_editedList.Contains(form))
                        _editedList.Add(form);
                }

                var formList = (List<form>) this.formBindingSource.List;
                RebuildAllformTree(formList);
            };

            this.comboBoxAllformType.SelectedIndexChanged += (s, e) =>
            {
                var type = (form_type) this.comboBoxAllformType.SelectedItem;
                if (type == null) return;
                if (type.form_type_id == (int)FormType.Municipality)
                {
                    this.checkedListBoxEduKinds.Enabled = false;
                    UncheckAllEdukindList();
                }
                else
                {
                    this.checkedListBoxEduKinds.Enabled = true;
                }
            };
            var isBlockedDictionarySource = new Dictionary<bool, string>() { { true, "Заблокирована" }, { false, "Разблокирована" } };
            this.comboBoxIsBlocked.DataSource = new BindingSource(isBlockedDictionarySource, null);
            this.comboBoxIsBlocked.DisplayMember = "Value";
            this.comboBoxIsBlocked.ValueMember = "Key";
        }

        private void RebuildAllformTree(List<form> formList)
        {
            this.treeViewForms.Nodes.Clear();
            var nodeList = GetFormNodelist(formList);
            this.treeViewForms.Nodes.AddRange(nodeList);
            this.treeViewForms.ExpandAll();
            this.SelectFormNode(_selectedForm);
        }

        private void SelectFormNode(form form)
        {
            if (form != null)
            {
                var foundNodes = this.treeViewForms.Nodes.Find(form.name, true);
                if (foundNodes.Length > 0)
                {
                    this.treeViewForms.SelectedNode = foundNodes[0];
                }
            }
        }

        private TreeNode[] GetFormNodelist(List<form> formList)
        {
            var nodeList = new List<TreeNode>();
            var groupList = formList.GroupBy(t => t.form_type);
            foreach (var groupItem in groupList)
            {
                var type = groupItem.Key;
                if (type == null) continue;
                var typeNode = new TreeNode() 
                { 
                    Text = type.name, 
                    Name =  type.name,
                    Tag = type
                };
                foreach (var item in groupItem)
                {
                    var formNode = new TreeNode() 
                    {
                        Text = _editedList.Contains(item) ? item.name + "*" : item.name,
                        Name = item.name,
                        Tag = item
                    };
                    typeNode.Nodes.Add(formNode);
                }
                nodeList.Add(typeNode);
            }
            return nodeList.ToArray();
        }

        private void UncheckAllEdukindList()
        {
            _isManualChecking = false;
            this.checkedListBoxEduKinds.UnCheckAll();
            _isManualChecking = true;
        }

        private void CheckEdukindList(ICollection<edu_kind> list)
        {
            _isManualChecking = false;
            if (list != null)
            {
                foreach (var kind in list)
                {
                    int idx = this.checkedListBoxEduKinds.FindItem(kind);
                    if (idx >= 0 && idx < this.checkedListBoxEduKinds.ItemCount)
                        this.checkedListBoxEduKinds.SetItemChecked(idx, true);
                }
            }
            _isManualChecking = true;
        }

        private void SelectFormType(form_type type)
        {
            _isManualChecking = false;
            this.comboBoxAllformType.SelectedItem = type;
            _isManualChecking = true;
        }

        private void treeViewForms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UncheckAllEdukindList();
            layoutControlGroup2.Enabled = true;
            if (e.Node.Tag is form)
            {
                var form = (form) e.Node.Tag;
                _selectedForm = form;
                int idxForm = this.formBindingSource.List.IndexOf(form);
                this.formBindingSource.Position = idxForm;
                CheckEdukindList(form.edu_kind);
                SelectFormType(form.form_type);
                this.comboBoxIsBlocked.SelectedValue = form.is_blocked;
            }
            else
            {
                layoutControlGroup2.Enabled = false;
            }
        }

        private void comboBoxAllformType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isManualChecking)
            {
                var type = (form_type) this.comboBoxAllformType.SelectedItem;
                var form = (form) this.formBindingSource.Current;
                if (form == null) return;
                if (type == form.form_type) return;
                form.form_type = type;
                if (!_editedList.Contains(form))
                    _editedList.Add(form);
                var formList = (List<form>) this.formBindingSource.List;
                RebuildAllformTree(formList);
            }
        }

        private void comboBoxIsBlocked_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isblocked = (KeyValuePair<bool, string>) this.comboBoxIsBlocked.SelectedItem;
            var form = (form)this.formBindingSource.Current;
            if (form == null) return;
            if (form.is_blocked == isblocked.Key) return;
            form.is_blocked = isblocked.Key;
            if (!_editedList.Contains(form))
                _editedList.Add(form);
            var formList = (List<form>)this.formBindingSource.List;
            RebuildAllformTree(formList);
        }

        private void checkedListBoxEduKinds_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (_isManualChecking)
            {
                var kind = (edu_kind) this.checkedListBoxEduKinds.GetItem(e.Index);
                var form = (form) this.formBindingSource.Current;
                if (e.State == CheckState.Checked)
                {
                    form.edu_kind.Add(kind);
                }
                else
                {
                    form.edu_kind.Remove(kind);
                }
                if (!_editedList.Contains(form))
                    _editedList.Add(form);
            }
        }

        async protected override void Remove(Document doc)
        {
            if (!CanRemove(doc))
            {
                this.ShowFlyoutMessageBox("Информация", "Не выбран элемент для удаления", FlyoutCommand.OK);
                return;
            }
            
            var form = (form) this.formBindingSource.Current;
            var messageBuilder = new StringBuilder(string.Format("Удалить Форму {0}?", form.name));
            
                var eduFormDataList = form.edu_form_data.Cast<IForm>().ToList();
                var munitFormDataList = form.municipality_form_data.Cast<IForm>().ToList();
                var formDataList = new List<IForm>();
                formDataList.AddRange(eduFormDataList);
                formDataList.AddRange(munitFormDataList);
                if (formDataList.Count > 0)
                {
                    messageBuilder.AppendLine(string.Format("\nВместе с формой будут удалены {0} загруженных форм", formDataList.Count));
                }
                if (form.queries.Count > 0)
                {
                    messageBuilder.AppendLine(string.Format("\nВместе с формой будут удалены {0} запросов", form.queries.Count));
                }
            
            var dialogResult = this.ShowFlyoutMessageBox("Подтверждение", messageBuilder.ToString(), FlyoutCommand.Yes, FlyoutCommand.No);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (new MarqueeProgressDialog(this.ParentForm, description: "Обработка"))
                    {
                        await Task.Run(() =>
                        {
                            Repo.Remove(form.templated_form_data);
                            Repo.RemoveRange(form.queries);
                            Repo.RemoveRange(form.edu_form_data);
                            Repo.RemoveRange(form.municipality_form_data);
                            Repo.Remove(form);
                        });

                        await Repo.SaveChangesAsync();
                        this.formBindingSource.Remove(form);
                        this.formBindingSource.EndEdit();
                    }
                }
                catch (Exception ex)
                {
                    this.ShowFlyoutMessageBox("Ошибка", ex.Message, FlyoutCommand.OK);
                }
                
            }
        }

        protected override bool CanRemove(Document doc)
        {
            return (this.formBindingSource.Current as form) != null;
        }

        protected override bool CanSave(Document doc)
        {
            return true;
        }

        async protected override void Save(Document doc)
        {
            if (!CanSave(doc))
            {
                this.ShowFlyoutMessageBox("Ошибка", "Проверьте заполнены ли все поля.", FlyoutCommand.OK);
            }
            ProgressDialog.ShowTop(this.ParentForm, description: "Сохраняю");
            await Task.Run(() => 
            {
                //this.formBindingSource.EndEdit();
                var allformLeftList = new List<form>();
                foreach (var form in _editedList)
                {
                    if (!string.IsNullOrEmpty(form.name) && form.submission_date != null && form.form_type != null)
                    {
                        if (form.form_id == 0)
                            Repo.Add(form);
                    }
                    else
                    {
                        allformLeftList.Add(form);
                    }
                }
                Repo.SaveChanges();

                _editedList.Clear();
                _editedList.AddRange(allformLeftList);
            });
            var formList = (List<form>)this.formBindingSource.List;
            this.RebuildAllformTree(formList);

            ProgressDialog.HideTop();
            if (_editedList.Count != 0)
            {
                this.ShowFlyoutMessageBox("Информация", "Несохраненные объекты помечены символом '*'", FlyoutCommand.OK);
            }
        }

        protected override bool CanNew(Document doc)
        {
            return true;
        }

        protected override void New(Document doc)
        {
            UncheckAllEdukindList();
            
            this.textBoxName.Text = "Новая форма";
            this.dateEditExpire.Value = DateTime.Now;
            var form = new form
            {
                form_type = (form_type) this.comboBoxAllformType.SelectedItem,
                name = this.textBoxName.Text,
                submission_date = this.dateEditExpire.Value,
                check_file_data = new byte[0],
                check_file_md5 = "0"
            };

            this.formBindingSource.Add(form);
            _selectedForm = form;
            this.formBindingSource.Position = this.formBindingSource.List.IndexOf(form);
            var formList = (List<form>) this.formBindingSource.List;
            RebuildAllformTree(formList);
        }

        public void OnQueryDocumentActions(IDocumentActionsArgs args)
        {
            args.DocumentActions.Add(new DocumentAction(New) { Caption = "Новая форма", Image = Resources.glyphicons_432_plus });
            args.DocumentActions.Add(new DocumentAction(Save) { Caption = "Сохранить", Image = Resources.glyphicons_206_ok_2 });
            args.DocumentActions.Add(new DocumentAction(Remove) { Caption = "Удалить", Image = Resources.glyphicons_207_remove_2 });
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            foreach (form form in this.formBindingSource.List)
            {
                if (form != _selectedForm && form.name == this.textBoxName.Text)
                {
                    this.ShowFlyoutMessageBox("Информация", 
                        string.Format("Форма с таким именем уже существует:\n{0}, {1}", form.form_type.name, form.name), 
                        FlyoutCommand.OK);
                    e.Cancel = true;
                    return;
                }
            }
            e.Cancel = false;
        }
    }
}
