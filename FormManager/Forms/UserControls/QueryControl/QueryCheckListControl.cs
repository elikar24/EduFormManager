using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Native;
using EduFormManager.Models;
using ItemCheckEventArgs = DevExpress.XtraEditors.Controls.ItemCheckEventArgs;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public partial class QueryCheckListControl : XtraBaseControl
    {
        private List<query> _queryList;
        private List<query> _queryListOthers;
        private List<query> _queryListPassport;
        private List<query> _queryListSplitted;
        private List<query> _selectedQueryList;

        private CheckedListBoxControl _listBoxQueries;
        private CheckedListBoxControl _listBoxOtherQueries;
        private CheckedListBoxControl _listBoxPassportQueries;
        
        private bool _isManualChecking = true;

        public delegate void SelectionChangedHandler(object sender, SelectionChangedEventArgs e);
        public event SelectionChangedHandler SelectionChanged;

        public QueryCheckListControl()
        {
            InitializeComponent();

            _queryListOthers = new List<query>();

            _queryListPassport = new List<query>(typeof(edu).GetProperties()
                .Where(prop => prop.GetCustomAttribute<DescriptionAttribute>() != null)
                .Select(prop => new query
                {
                    title = prop.GetCustomAttribute<DescriptionAttribute>().Description, 
                    content = "@" + prop.Name
                }));
            _queryListSplitted = new List<query>();
            _selectedQueryList = new List<query>();

            QueryPartHeadDataSource = new List<query_head_part>();
        }

        public IList<query> QueryDataSource
        {
            set
            {
                _queryList = new List<query>(value);
                _queryList.AddRange(_queryListPassport);
                Initialize();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IList<query_head_part> QueryPartHeadDataSource { set; get; }

        public IList<query> SelectedQueries { get { return _selectedQueryList; } }
        public IList<query> Queries { get { return _queryList; } } 

        private void Initialize()
        {
            _queryListOthers.Clear();
            _queryListSplitted.Clear();
            var queryListToWorkWith = _queryList.Where(t => !t.content.StartsWith("@")).ToList();
            IList<QueryGroupItem> groupItemList = new List<QueryGroupItem>();
            foreach (var head in QueryPartHeadDataSource)
            {
                string headTitle = head.title;
                IList<query> possibleSplittedQueries = queryListToWorkWith.Where(t => t.title.StartsWith(headTitle)).ToList();
                if (possibleSplittedQueries.Count == 0) continue;

                var groupItem = new QueryGroupItem
                {
                    Head = headTitle,
                    QueryDictionary = new Dictionary<string, query>()
                };

                foreach (var query in possibleSplittedQueries)
                {
                    string[] parts = query.title.Split(new[] { headTitle }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 0)
                    {
                        _queryListOthers.Add(query);
                        continue;
                    }
                    groupItem.QueryDictionary.Add(parts[0].Trim(), query);
                    _queryListSplitted.Add(query);
                }

                if (groupItem.QueryDictionary.Count > 0)
                    groupItemList.Add(groupItem);
            }

            var passportGroupItem = new QueryGroupItem()
            {
                Head = "Паспорт",
                QueryDictionary = new Dictionary<string, query>()
            };
            foreach (var query in _queryListPassport)
            {
                passportGroupItem.QueryDictionary.Add(query.title, query);   
            }
            groupItemList.Add(passportGroupItem);
            _queryListOthers.AddRange(queryListToWorkWith.Where(t => !_queryListSplitted.Contains(t)));
            CreateControls(groupItemList);
        }

        private void CreateControls(IList<QueryGroupItem> groupItems)
        {
            this.layoutControlContainer.BeginUpdate();
            try
            {
                this.layoutControlGroupMain.Clear();
                foreach (var groupItem in groupItems)
                {
                    var combo = new CheckedComboBoxEdit {Name = "checkedCombo" + groupItems.IndexOf(groupItem)};

                    EventHandler popupHandler = null;
                    popupHandler = (sender, args) =>
                    {
                        var popupContainer = (PopupContainerForm) ((IPopupControl) sender).PopupWindow;
                        _listBoxQueries = popupContainer.Controls[3].Controls[0] as CheckedListBoxControl;
                        if (_listBoxQueries == null) return;
                        if (_listBoxQueries.DataSource == null)
                        {
                            _listBoxQueries.DisplayMember = "Key";
                            _listBoxQueries.ValueMember = "Value";
                            _listBoxQueries.DataSource = groupItem.QueryDictionary.ToList();
                        }
                        popupContainer.Height = 200;
                        _listBoxQueries.ItemCheck += (o, eventArgs) =>
                        {
                            combo.Text = string.Join("; ",
                                _listBoxQueries.CheckedIndices.OfType<int>().Select(t => _listBoxQueries.GetItemText(t)));
                            ListBoxQueriesOnItemCheck(o, eventArgs);
                        };

                        combo.Popup -= popupHandler;
                    };
                    combo.Popup += popupHandler;

                    combo.Closed += (sender, args) =>
                    {
                        combo.Text = string.Join("; ",
                            _listBoxQueries.CheckedIndices.OfType<int>().Select(t => _listBoxQueries.GetItemText(t)));
                    };
                    var layoutItem = new LayoutControlItem()
                    {
                        Text = groupItem.Head,
                        TextLocation = Locations.Top,
                        Control = combo
                    };
                    layoutItem.AppearanceItemCaption.Font = new Font("Segoe UI", 9);
                    this.layoutControlGroupMain.Add(layoutItem);
                }
                if (_queryListOthers.Any())
                {
                    _listBoxOtherQueries = new CheckedListBoxControl
                    {
                        DisplayMember = "title",
                        ValueMember = null,
                        DataSource = _queryListOthers,
                        Name = "listBoxOtherQueries"
                    };
                    _listBoxOtherQueries.ItemCheck += ListBoxQueriesOnItemCheck;

                    var layoutItem = new LayoutControlItem()
                    {
                        Text = "Остальные запросы",
                        TextLocation = Locations.Top,
                        SizeConstraintsType = SizeConstraintsType.Custom,
                        ControlMaxSize = new Size(0, 120),
                        Control = _listBoxOtherQueries
                    };
                    layoutItem.AppearanceItemCaption.Font = new Font("Segoe UI", 9);
                    this.layoutControlGroupMain.Add(layoutItem);
                }
            }
            finally
            {
                this.layoutControlContainer.EndUpdate();
            }
        }

        private void ListBoxQueriesOnItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!_isManualChecking) return;
            var listBoxControl = (CheckedListBoxControl) sender;
            if (listBoxControl != null)
            {
                var query = (query) listBoxControl.GetItemValue(e.Index);
                if (query == null)
                {
                    if (listBoxControl.Items.Count > 0) 
                        query = (query) listBoxControl.Items[e.Index].Value;
                    else 
                        return;
                }
                if (query == null) return;
                if (e.State == CheckState.Checked)
                    _selectedQueryList.Add(query);
                else
                    _selectedQueryList.Remove(query);

                var eventArgs = new SelectionChangedEventArgs(
                    e.State == CheckState.Checked 
                        ? CollectionChangeAction.Add 
                        : CollectionChangeAction.Remove, _queryList.IndexOf(query));
                OnSelectionChanged(eventArgs);
            }
        }

        protected virtual void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, e);
        }

        public void SetItemCheckState(query queryObject, CheckState state)
        {
            _isManualChecking = false;
            if (_listBoxQueries != null)
            {
                int itemIdx = _listBoxQueries.FindItem(0, true, e => e.IsFound = e.ItemValue == queryObject);
                if (itemIdx >= 0)
                {
                    _listBoxQueries.SetItemChecked(itemIdx, state == CheckState.Checked);
                    _isManualChecking = true;
                    return;
                }
            }
            if (_listBoxOtherQueries != null)
            {
                int itemIdx = _listBoxOtherQueries.FindItem(queryObject);
                if (itemIdx >= 0)
                    _listBoxOtherQueries.SetItemChecked(itemIdx, state == CheckState.Checked);
            }

            _isManualChecking = true;
        }

        public void SelectItem(query queryObject)
        {
            SetItemCheckState(queryObject, CheckState.Checked);
        }

        public void SelectRange(IEnumerable<query> queryObjectList, bool clearSelection = true)
        {
            if (clearSelection)
                UnselectAll();
            queryObjectList.ForEach(SelectItem);
        }

        public void UnselectItem(query queryObject)
        {
            SetItemCheckState(queryObject, CheckState.Unchecked);
        }

        public void UnselectAll()
        {
            _isManualChecking = false;

            if (_listBoxQueries != null) _listBoxQueries.UnCheckAll();
            if (_listBoxOtherQueries != null) _listBoxOtherQueries.UnCheckAll();

            _isManualChecking = true;
        }
    }
}
