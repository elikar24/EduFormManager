CREATE OR REPLACE VIEW municipality_form_statistics AS
SELECT COALESCE(row_number() OVER (), (-1)::bigint) AS row_id,
    m.municipality_id AS munit_id,
    m.name AS munit_name,
    sub_count.overall_count AS overall_count,
    sub_ok.ok_count,
    sub_expired.expired_count,
    sub_error.error_count,
    sub_bad.bad_count,
    sub_loaded.loaded_count
   FROM municipality m
   
   JOIN ( SELECT m_1.municipality_id, count(f.form_id) AS overall_count
		FROM municipality m_1
		LEFT JOIN form f 
		ON f.form_type_id = 3 or f.form_type_id = 4
		GROUP BY m_1.municipality_id
	) sub_count ON sub_count.municipality_id = m.municipality_id
   
   JOIN ( SELECT m_1.municipality_id, count(fd.id) AS ok_count
		FROM municipality m_1
		LEFT JOIN municipality_form_data fd 
		ON fd.municipality_id = m_1.municipality_id AND fd.status = 0 AND date_part('year'::text, fd.send_date) = date_part('year'::text, now())
		GROUP BY m_1.municipality_id
	) sub_ok ON sub_ok.municipality_id = m.municipality_id
	
   JOIN ( SELECT m_1.municipality_id, count(fd.id) AS expired_count
		FROM municipality m_1
		LEFT JOIN municipality_form_data fd 
		ON fd.municipality_id = m_1.municipality_id AND fd.status = 1 AND date_part('year'::text, fd.send_date) = date_part('year'::text, now())
		GROUP BY m_1.municipality_id
	) sub_expired ON sub_expired.municipality_id = m.municipality_id

   JOIN ( SELECT m_1.municipality_id, count(fd.id) AS error_count
		FROM municipality m_1
		LEFT JOIN municipality_form_data fd 
		ON fd.municipality_id = m_1.municipality_id AND fd.status = 2 AND date_part('year'::text, fd.send_date) = date_part('year'::text, now())
		GROUP BY m_1.municipality_id
	) sub_error ON sub_error.municipality_id = m.municipality_id
  
   JOIN ( SELECT m_1.municipality_id, count(fd.id) AS bad_count
		FROM municipality m_1
		LEFT JOIN municipality_form_data fd 
		ON fd.municipality_id = m_1.municipality_id AND fd.status = 3 AND date_part('year'::text, fd.send_date) = date_part('year'::text, now())
		GROUP BY m_1.municipality_id
	) sub_bad ON sub_bad.municipality_id = m.municipality_id
	
   JOIN ( SELECT m_1.municipality_id, count(fd.id) AS loaded_count
		FROM municipality m_1
		LEFT JOIN municipality_form_data fd 
		ON fd.municipality_id = m_1.municipality_id AND date_part('year'::text, fd.send_date) = date_part('year'::text, now())
		GROUP BY m_1.municipality_id
	) sub_loaded ON sub_loaded.municipality_id = m.municipality_id
  
  GROUP BY m.municipality_id, m.name, sub_ok.ok_count, sub_count.overall_count, sub_expired.expired_count, sub_error.error_count, sub_bad.bad_count, sub_loaded.loaded_count
  ORDER BY m.municipality_id, m.name;

  ALTER TABLE municipality_form_statistics
  OWNER TO postgres;
GRANT ALL ON TABLE municipality_form_statistics TO postgres;
GRANT SELECT, UPDATE, INSERT, DELETE ON TABLE municipality_form_statistics TO "user";

CREATE TABLE t_municipality_form_statistics
(
  row_id bigint NOT NULL,
  munit_id integer,
  munit_name character varying(200),
  overall_count bigint,
  ok_count bigint,
  expired_count bigint,
  error_count bigint,
  bad_count bigint,
  loaded_count bigint,
  CONSTRAINT t_municipality_form_statistics_pkey PRIMARY KEY (row_id)
)
WITH (
  OIDS=FALSE
);
ALTER TABLE t_municipality_form_statistics
  OWNER TO postgres;
GRANT ALL ON TABLE t_municipality_form_statistics TO postgres;
GRANT SELECT, UPDATE, INSERT, TRUNCATE, DELETE ON TABLE t_municipality_form_statistics TO "user";

CREATE OR REPLACE FUNCTION update_municipality_stats_view()
  RETURNS void AS
$BODY$ 
	truncate t_municipality_form_statistics;
	insert into t_municipality_form_statistics select * from municipality_form_statistics;
$BODY$
  LANGUAGE sql VOLATILE
  COST 100;
ALTER FUNCTION update_municipality_stats_view()
  OWNER TO postgres;
GRANT EXECUTE ON FUNCTION update_municipality_stats_view() TO postgres;
GRANT EXECUTE ON FUNCTION update_municipality_stats_view() TO public;
GRANT EXECUTE ON FUNCTION update_municipality_stats_view() TO "user";