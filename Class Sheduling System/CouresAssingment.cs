//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CouresAssingment
    {
        public int CouresAssingment_Id { get; set; }
        public Nullable<int> Faculty_id { get; set; }
        public Nullable<int> Course_id { get; set; }
        public Nullable<int> Subject_id { get; set; }
        public Nullable<int> Lecturer_id { get; set; }
        public Nullable<int> Room_id { get; set; }
        public Nullable<int> Mode_Of_Study_id { get; set; }
        public Nullable<int> Semester_id { get; set; }
        public Nullable<int> Time_id { get; set; }
        public Nullable<int> DateOfSub_id { get; set; }
    
        public virtual Faculty Faculty { get; set; }
        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Lecturer Lecturer { get; set; }
        public virtual Room Room { get; set; }
        public virtual ModeOfStudy ModeOfStudy { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Time Time { get; set; }
        public virtual DateOfSub DateOfSub { get; set; }
    }
}
