//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace School_Management_System.Areas.AdminArea.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Broker_SubjectTeacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Broker_SubjectTeacher()
        {
            this.Routines = new HashSet<Routine>();
        }
    
        public int ID { get; set; }
        public string SubjectName { get; set; }
        public int ClassID { get; set; }
        public int TeacherID { get; set; }
    
        public virtual Class Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Routine> Routines { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
