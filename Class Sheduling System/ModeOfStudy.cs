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
    
    public partial class ModeOfStudy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModeOfStudy()
        {
            this.CouresAssingments = new HashSet<CouresAssingment>();
        }
    
        public int ModeOfStudy_Id { get; set; }
        public string ModeOfStudy1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CouresAssingment> CouresAssingments { get; set; }
    }
}
