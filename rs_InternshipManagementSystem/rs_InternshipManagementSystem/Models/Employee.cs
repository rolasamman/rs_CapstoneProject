namespace InternshipWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(10)]
        public string EmployeeUniversityId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(8)]
        public string Office { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(4)]
        public string Extension { get; set; }

        [Required]
        [StringLength(20)]
        public string Mobile { get; set; }

        public int EmployeeType { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}
