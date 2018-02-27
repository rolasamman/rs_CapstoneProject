namespace InternshipWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Section")]
    public partial class Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Section()
        {
            InternshipEvaluations = new HashSet<InternshipEvaluation>();
            Students = new HashSet<Student>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SectionId { get; set; }

        public int Semester { get; set; }

        public int Year { get; set; }

        public int Capacity { get; set; }

        public int IntrenshipId { get; set; }

        public int InstructorId { get; set; }

        public virtual Instructor Instructor { get; set; }

        public virtual Internship Internship { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InternshipEvaluation> InternshipEvaluations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
