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
    
    public partial class Lecture
    {
        public int Lecture_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Nullable<int> Course_Id { get; set; }
        public Nullable<int> Subject_Id { get; set; }
        public string Address { get; set; }
        public Nullable<int> gender_id { get; set; }
        public Nullable<int> attendance_id { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Attendance Attendance { get; set; }
        public virtual Gender Gender { get; set; }
    }
}