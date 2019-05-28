//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoursesDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cours
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cours()
        {
            this.Lectures = new HashSet<Lecture>();
        }
    
        public int CO_ID { get; set; }
        public int CategoryID { get; set; }
        public int UniversityID { get; set; }
        public int AuthorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
        public virtual University University { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lecture> Lectures { get; set; }
    }
}
