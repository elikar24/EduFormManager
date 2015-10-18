CREATE OR REPLACE VIEW detailed_municipality_form_statistics AS 
SELECT COALESCE(row_number() OVER (), (-1)::bigint) AS row_id,
    sub_main.form_type_id,
    sub_main.form_type,	
    sub_main.form,
    sub_main.form_id,
    sub_main.municipality_id,
    sub_main.municipality,
        CASE
            WHEN sub_fd.id IS NULL THEN 0
            ELSE 1
        END AS is_uploaded,
        CASE
            WHEN sub_fd.year IS NULL THEN 0
            ELSE sub_fd.year
        END AS year
   FROM ( SELECT DISTINCT
            m.municipality_id,
            m.name AS municipality,
            f.form_id,
            f.name AS form,
            ft.name AS form_type,
            ft.form_type_id
           FROM municipality m
           JOIN form f ON 1 = 1
           JOIN form_type ft ON f.form_type_id = ft.form_type_id and (f.form_type_id = 3 or f.form_type_id = 4)
           order by m.municipality_id, m.name, f.form_id, f.name
         ) sub_main
   LEFT JOIN ( SELECT 	sum(fd.id) AS id, 
			fd.form_id,
			fd.municipality_id,
			date_part('year'::text, fd.send_date)::integer AS year
		FROM municipality_form_data fd
		where date_part('year'::text, fd.send_date) = date_part('year', now())
		GROUP BY fd.form_id, fd.municipality_id, date_part('year'::text, fd.send_date)
		) sub_fd ON sub_main.form_id = sub_fd.form_id AND sub_main.municipality_id = sub_fd.municipality_id;

ALTER TABLE detailed_municipality_form_statistics
  OWNER TO postgres;
GRANT ALL ON TABLE detailed_municipality_form_statistics TO postgres;
GRANT SELECT, UPDATE, INSERT, DELETE ON TABLE detailed_municipality_form_statistics TO "user";

create table t_detailed_municipality_form_statistics as 
(select * from detailed_municipality_form_statistics limit 0);

ALTER TABLE t_detailed_municipality_form_statistics
  OWNER TO postgres;
GRANT ALL ON TABLE t_detailed_municipality_form_statistics TO postgres;
GRANT SELECT, UPDATE, INSERT, TRUNCATE, DELETE ON TABLE t_detailed_municipality_form_statistics TO "user";

CREATE OR REPLACE FUNCTION update_detailed_municipality_stats_view(integer)
  RETURNS void AS
$BODY$ 
	truncate t_detailed_municipality_form_statistics;
	insert into t_detailed_municipality_form_statistics 
	(
			SELECT COALESCE(row_number() OVER (), (-1)::bigint) AS row_id,
		    sub_main.form_type_id,
		    sub_main.form_type,	
		    sub_main.form,
		    sub_main.form_id,
		    sub_main.municipality_id,
		    sub_main.municipality,
			CASE
			    WHEN sub_fd.id IS NULL THEN 0
			    ELSE 1
			END AS is_uploaded,
			CASE
			    WHEN sub_fd.year IS NULL THEN 0
			    ELSE sub_fd.year
			END AS year
		   FROM ( SELECT DISTINCT
			    m.municipality_id,
			    m.name AS municipality,
			    f.form_id,
			    f.name AS form,
			    ft.name AS form_type,
			    ft.form_type_id
			   FROM municipality m
			   JOIN form f ON 1 = 1
			   JOIN form_type ft ON f.form_type_id = ft.form_type_id and (f.form_type_id = 3 or f.form_type_id = 4)
			   order by m.municipality_id, m.name, f.form_id, f.name
			 ) sub_main
		   LEFT JOIN ( SELECT 	sum(fd.id) AS id, 
					fd.form_id,
					fd.municipality_id,
					date_part('year'::text, fd.send_date)::integer AS year
				FROM municipality_form_data fd
				where date_part('year'::text, fd.send_date)::integer = $1
				GROUP BY fd.form_id, fd.municipality_id, date_part('year'::text, fd.send_date)
				) sub_fd ON sub_main.form_id = sub_fd.form_id AND sub_main.municipality_id = sub_fd.municipality_id
	);
$BODY$
  LANGUAGE sql VOLATILE
  COST 100;
ALTER FUNCTION update_detailed_municipality_stats_view(integer)
  OWNER TO postgres;
GRANT EXECUTE ON FUNCTION update_detailed_municipality_stats_view(integer) TO postgres;
GRANT EXECUTE ON FUNCTION update_detailed_municipality_stats_view(integer) TO public;
GRANT EXECUTE ON FUNCTION update_detailed_municipality_stats_view(integer) TO "user";

GRANT EXECUTE ON FUNCTION update_detailed_stats_view(integer) TO postgres;
GRANT EXECUTE ON FUNCTION update_detailed_stats_view(integer) TO public;
GRANT EXECUTE ON FUNCTION update_detailed_stats_view(integer) TO "user";