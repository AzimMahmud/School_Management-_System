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
    
    public partial class Mark
    {
        public int MarksID { get; set; }
        public string StudentRegID { get; set; }
        public int ExamID { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string SubjectName { get; set; }
        public decimal SubjectMark { get; set; }
        public string EntryBy { get; set; }
        public string EntryDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }
        public string Comment { get; set; }
    
        public virtual Exam Exam { get; set; }
    }
}
