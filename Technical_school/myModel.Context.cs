﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Technical_school
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class school_Entities : DbContext
    {
        public school_Entities()
            : base("name=school_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<course_tbl> course_tbl { get; set; }
        public virtual DbSet<intern_tbl> intern_tbl { get; set; }
        public virtual DbSet<master_tbl> master_tbl { get; set; }
        public virtual DbSet<register_tbl> register_tbl { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}