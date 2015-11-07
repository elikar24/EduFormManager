using System.Collections.Generic;
using System.Linq;
using Models;

namespace EduFormManager.Forms.UserControls.QueryControl
{
    public class QuerySummaryModelCollection<TModel> : List<TModel> 
        where TModel : QuerySummaryModel
    {
        private TModel _current;
        public TModel this[form form, int year]
        {
            get
            {
                if (_current == null
                    || _current.Form.form_id != form.form_id
                    || _current.Year != year)
                {
                    _current = this.FirstOrDefault(t => t.Form.form_id == form.form_id && t.Year == year);
                }
                return _current;
            }
        }

        public bool Contains(form form, int year)
        {
            return this.Any(t => t.Form.form_id == form.form_id && t.Year == year);
        }

        public TModel Current
        {
            get
            {
                if (this.Count == 0 && _current != null) this.Add(_current);
                return this.Contains(_current) ? _current : this.FirstOrDefault();
            }
            set
            {
                if (!this.Contains(value))
                    this.Add(value);
                _current = value;
            }
        }
    }
}
