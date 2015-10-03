using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EduFormManager.Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public partial class XtraDictionaryEditQueryControl : XtraBaseControl
    {
        public class QueriesCreatedEventArgs : EventArgs
        {
            public List<query> QueryList { get; set; }
            public bool Canceled { get; set; }
        }

        public class CellAddressClickedEventArgs : EventArgs
        {
            public string Value { get; set; }
        }

        private query _selectedQuery;
        private form _selectedForm;
        private AutoCompleteStringCollection _queryPartAutocompleteSource;
        private AutoCompleteStringCollection _queryHeadAutocompleteSource;
        private int _currentRowIndex = 0;

        public delegate void QueriesChangedHandler(object sender, QueriesCreatedEventArgs e);
        public event QueriesChangedHandler QueriesCreated;

        public delegate void CellAddressClickedHandler(object sender, CellAddressClickedEventArgs e);
        public event CellAddressClickedHandler CellAddressClicked;

        public XtraDictionaryEditQueryControl()
        {
            InitializeComponent();
            this.dataGridViewQueryParts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Light", 12);

            this.textBoxQueryTitle.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.textBoxQueryTitle.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public query SelectedQuery
        {
            set
            {
                if (value != null)
                {
                    _selectedQuery = value;                    
                }
            }
            get { return _selectedQuery; }
        }

        public form SelectedForm
        {
            set
            {
                if (value != null)
                {
                    _selectedForm = value;
                }
            }
            get { return _selectedForm; }
        }

        public void Clear()
        {
            this.textBoxQueryTitle.Text = string.Empty;
            this.dataGridViewQueryParts.Rows.Clear();
        }

        public List<query_autocomplete_part> QueryAutocompletePartSource
        {
            set
            {
                if (_queryPartAutocompleteSource == null)
                    _queryPartAutocompleteSource = new AutoCompleteStringCollection();
                _queryPartAutocompleteSource.Clear();
                _queryPartAutocompleteSource.AddRange(value.Select(v => v.title).ToArray());
            }
        }
        public List<query_head_part> QueryHeadPartSource
        {
            set
            {
                if (_queryHeadAutocompleteSource == null)
                    _queryHeadAutocompleteSource = new AutoCompleteStringCollection();
                _queryHeadAutocompleteSource.Clear();
                _queryHeadAutocompleteSource.AddRange(value.Select(v => v.title).ToArray());
                this.textBoxQueryTitle.AutoCompleteCustomSource = _queryHeadAutocompleteSource;
            }
        } 
        public void SetCellAddressToCurrentQuery(string addr)
        {
            if (_currentRowIndex < this.dataGridViewQueryParts.Rows.Count)
            {
                this.dataGridViewQueryParts.Rows[_currentRowIndex].Cells[1].Value = addr;
                this.dataGridViewQueryParts.Rows[_currentRowIndex].Cells[1].ValueType = addr.GetType();
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                string valueStr = this.textBoxQueryTitle.Text.Trim();
                if (!_queryHeadAutocompleteSource.Contains(valueStr))
                {
                    var headPart = new query_head_part
                    {
                        title = valueStr
                    };
                    try
                    {
                        Repo.Db.query_head_part.Add(headPart);
                        Repo.Db.SaveChangesAsync()
                            .ContinueWith((t) => _queryHeadAutocompleteSource.Add(headPart.title),
                                TaskScheduler.FromCurrentSynchronizationContext());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                List<query> queries = this.GetQueryList();
                OnQueriesCreated(new QueriesCreatedEventArgs() { Canceled = false, QueryList = queries });
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            OnQueriesCreated(new QueriesCreatedEventArgs() { Canceled = true });
        }

        public List<query> GetQueryList()
        {
            var queryList = new List<query>();
            foreach(var row in this.dataGridViewQueryParts.Rows.Cast<DataGridViewRow>())
            {
                if (row.Index == dataGridViewQueryParts.Rows.Count - 1) break;
                object titleValue = row.Cells[0].FormattedValue;
                object cellAddressValue = row.Cells[1].FormattedValue;
                if (titleValue != null && cellAddressValue != null)
                {
                    var queryTtitle = string.Format("{0} {1}", this.textBoxQueryTitle.Text.Trim(), titleValue.ToString().Trim());
                    var queryCellAddress = cellAddressValue.ToString().Trim();
                    var query = new query()
                    {
                        form = _selectedForm,
                        content = queryCellAddress,
                        title = queryTtitle
                    };
                    if (!queryList.Contains(query))
                        queryList.Add(query);
                }
            }
            return queryList;
        } 

        private void OnQueriesCreated(QueriesCreatedEventArgs e)
        {
            var handler = QueriesCreated;
            if (handler != null) handler(this, e);
        } 

        private bool CheckFields()
        {
            return !string.IsNullOrEmpty(this.textBoxQueryTitle.Text.Trim()) && 
                this.dataGridViewQueryParts.Rows.Cast<DataGridViewRow>().All(
                    row =>
                    {
                        if (row.Index == dataGridViewQueryParts.Rows.Count - 1) return true;
                        var titleValue = row.Cells[0].FormattedValue;
                        var cellAddressValue = row.Cells[1].FormattedValue;
                        return cellAddressValue != null && titleValue != null &&
                               !string.IsNullOrEmpty(titleValue.ToString().Trim()) &&
                               !string.IsNullOrEmpty(cellAddressValue.ToString().Trim());
                    });
        }
        private void dataGridViewQueryParts_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (string.IsNullOrEmpty(e.FormattedValue.ToString().Trim()))
            //{
            //    this.dataGridViewQueryParts.Rows[e.RowIndex].ErrorText = "Значение не может быть пустым";
            //    e.Cancel = true;
            //}
        }

        private void dataGridViewQueryParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _currentRowIndex = e.RowIndex;
            if (e.ColumnIndex != 1) return;
            var args = new CellAddressClickedEventArgs();
            var value = this.dataGridViewQueryParts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            args.Value = value != null 
                ? value.ToString().Trim() 
                : string.Empty;
            OnCellAddressClicked(args);
        }

        private void dataGridViewQueryParts_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewQueryParts_CellClick(sender, e);
        }

        protected virtual void OnCellAddressClicked(CellAddressClickedEventArgs e)
        {
            var handler = CellAddressClicked;
            if (handler != null) handler(this, e);
        }

        private void dataGridViewQueryParts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var textBox = e.Control as TextBox;
            if (textBox == null) return;
            if (this.dataGridViewQueryParts.CurrentCell.ColumnIndex == 0)
            {
                textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox.AutoCompleteCustomSource = _queryPartAutocompleteSource;
            }
            else
            {
                textBox.AutoCompleteCustomSource = null;
            }
        }

        private void dataGridViewQueryParts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            var value = this.dataGridViewQueryParts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (value == null) return;
            var valueStr = value.ToString().Trim();
            if (_queryPartAutocompleteSource.Contains(valueStr)) return;

            var autocompletePart = new query_autocomplete_part
            {
                title = valueStr
            };
            try
            {
                Repo.Db.query_autocomplete_part.Add(autocompletePart);
                Repo.Db.SaveChangesAsync()
                    .ContinueWith((t) => _queryPartAutocompleteSource.Add(autocompletePart.title), 
                    TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
