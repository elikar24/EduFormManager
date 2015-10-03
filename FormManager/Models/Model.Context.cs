﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Common;
using System.Data.Entity.Core.EntityClient;

namespace EduFormManager.Models
{
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
            var originalConnectionString = ConfigurationManager.ConnectionStrings["Entities"].ConnectionString;
            var entityBuilder = new EntityConnectionStringBuilder(originalConnectionString);
            var factory = DbProviderFactories.GetFactory(entityBuilder.Provider);
            var providerBuilder = factory.CreateConnectionStringBuilder();

            providerBuilder.ConnectionString = entityBuilder.ProviderConnectionString;

            providerBuilder.Add("Password", "qwer1234");

            this.Database.Connection.ConnectionString = providerBuilder.ToString();
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<action> actions { get; set; }
        public virtual DbSet<edu_log> edu_log { get; set; }
        public virtual DbSet<activity_ype> activity_ype { get; set; }
        public virtual DbSet<credential> credentials { get; set; }
        public virtual DbSet<document_format> document_format { get; set; }
        public virtual DbSet<edu> edus { get; set; }
        public virtual DbSet<edu_form_data> edu_form_data { get; set; }
        public virtual DbSet<edu_kind> edu_kind { get; set; }
        public virtual DbSet<edu_status> edu_status { get; set; }
        public virtual DbSet<edu_type> edu_type { get; set; }
        public virtual DbSet<file> files { get; set; }
        public virtual DbSet<form> forms { get; set; }
        public virtual DbSet<form_type> form_type { get; set; }
        public virtual DbSet<management_agency> management_agency { get; set; }
        public virtual DbSet<management_agency_activity> management_agency_activity { get; set; }
        public virtual DbSet<message> messages { get; set; }
        public virtual DbSet<mm_regular__summary_form> mm_regular__summary_form { get; set; }
        public virtual DbSet<municipality> municipalities { get; set; }
        public virtual DbSet<municipality_form_data> municipality_form_data { get; set; }
        public virtual DbSet<ownership_type> ownership_type { get; set; }
        public virtual DbSet<query> queries { get; set; }
        public virtual DbSet<query_autocomplete_part> query_autocomplete_part { get; set; }
        public virtual DbSet<query_head_part> query_head_part { get; set; }
        public virtual DbSet<t_detailed_form_statistics> t_detailed_form_statistics { get; set; }
        public virtual DbSet<t_form_statistics> t_form_statistics { get; set; }
        public virtual DbSet<t_summary_form_statistics> t_summary_form_statistics { get; set; }
        public virtual DbSet<templated_form_data> templated_form_data { get; set; }
        public virtual DbSet<answer> answers { get; set; }
        public virtual DbSet<question> questions { get; set; }
        public virtual DbSet<questionary> questionaries { get; set; }
    }
}