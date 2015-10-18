--alter table activity_ype rename to activity_type;
alter table activity_type alter column "name" set not null;

alter table credentials alter column ref_id set not null;
alter table credentials alter column login_type set not null;

ALTER TABLE edu_form_data
   ALTER COLUMN send_date SET NOT NULL;
ALTER TABLE edu_form_data
   ALTER COLUMN status SET NOT NULL;
ALTER TABLE edu_form_data
   ALTER COLUMN file_id SET NOT NULL;

ALTER TABLE edu_status
   ALTER COLUMN name SET NOT NULL;

ALTER TABLE edu_type
   ALTER COLUMN name SET NOT NULL;   

ALTER TABLE file
   ALTER COLUMN contents SET NOT NULL;
ALTER TABLE file
   ALTER COLUMN code_page SET NOT NULL;

ALTER TABLE form
   ALTER COLUMN submission_date SET NOT NULL;
ALTER TABLE form
   ALTER COLUMN check_file_data SET NOT NULL;

ALTER TABLE form_type
   ALTER COLUMN name SET NOT NULL;

ALTER TABLE message
   ALTER COLUMN from_edu_id SET NOT NULL;
ALTER TABLE message
   ALTER COLUMN is_viewed SET NOT NULL;

ALTER TABLE municipality_form_data
   ALTER COLUMN send_date SET NOT NULL;
ALTER TABLE municipality_form_data
   ALTER COLUMN status SET NOT NULL;
ALTER TABLE municipality_form_data
   ALTER COLUMN file_id SET NOT NULL;

ALTER TABLE query
   ALTER COLUMN credentials_id SET NOT NULL;

ALTER TABLE t_form_statistics
   ALTER COLUMN munit_id SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN edu_id SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN overall_count SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN ok_count SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN expired_count SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN error_count SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN bad_count SET NOT NULL;
ALTER TABLE t_form_statistics
   ALTER COLUMN loaded_count SET NOT NULL;

ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN munit_id SET NOT NULL;
ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN overall_count SET NOT NULL;
ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN ok_count SET NOT NULL;
ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN expired_count SET NOT NULL;
ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN error_count SET NOT NULL;
ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN bad_count SET NOT NULL;
ALTER TABLE t_municipality_form_statistics
   ALTER COLUMN loaded_count SET NOT NULL;

ALTER TABLE t_summary_form_statistics
   ALTER COLUMN municipality_id SET NOT NULL;
ALTER TABLE t_summary_form_statistics
   ALTER COLUMN overall_count SET NOT NULL;
ALTER TABLE t_summary_form_statistics
   ALTER COLUMN loaded_count SET NOT NULL;
ALTER TABLE t_summary_form_statistics
   ALTER COLUMN ok_count SET NOT NULL;
ALTER TABLE t_summary_form_statistics
   ALTER COLUMN expired_count SET NOT NULL;
ALTER TABLE t_summary_form_statistics
   ALTER COLUMN error_count SET NOT NULL;
ALTER TABLE t_summary_form_statistics
   ALTER COLUMN bad_count SET NOT NULL;  


ALTER TABLE t_detailed_municipality_form_statistics
   ALTER COLUMN row_id SET NOT NULL;
ALTER TABLE t_detailed_municipality_form_statistics
   ALTER COLUMN form_type_id SET NOT NULL;
ALTER TABLE t_detailed_municipality_form_statistics
   ALTER COLUMN form_id SET NOT NULL;
ALTER TABLE t_detailed_municipality_form_statistics
   ALTER COLUMN municipality_id SET NOT NULL;
ALTER TABLE t_detailed_municipality_form_statistics
   ALTER COLUMN is_uploaded SET NOT NULL;
ALTER TABLE t_detailed_municipality_form_statistics
   ALTER COLUMN year SET NOT NULL;
