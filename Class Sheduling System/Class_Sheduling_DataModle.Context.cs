﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Class_Sheduling_System
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClassShedulerEntities : DbContext
    {
        public ClassShedulerEntities()
            : base("name=ClassShedulerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicYear> AcademicYears { get; set; }
        public virtual DbSet<CouresAssingment> CouresAssingments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<DateOfSub> DateOfSubs { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Lecturer> Lecturers { get; set; }
        public virtual DbSet<LevelOfStudy> LevelOfStudies { get; set; }
        public virtual DbSet<ModeOfStudy> ModeOfStudies { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Time> Times { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
