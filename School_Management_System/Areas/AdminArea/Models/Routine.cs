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
    
    public partial class Routine
    {
        public int RoutineID { get; set; }
        public int ClassSectionID { get; set; }
        public int SubjectTeacherID { get; set; }
        public string Day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Broker_ClassSection Broker_ClassSection { get; set; }
        public virtual Broker_SubjectTeacher Broker_SubjectTeacher { get; set; }
    }
}
