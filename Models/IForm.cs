using System;

namespace Models
{
    public interface IForm
    {
        int id { get; set; }
        int document_format_id { get; set; }
        int form_id { get; set; }
        DateTime send_date { get; set; }
        int status { get; set; }
        int file_id { get; set; }

        document_format document_format { get; set; }
        file file { get; set; }
        form form { get; set; }
    }
}
