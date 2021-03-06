namespace InternshipWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attendance")]
    public partial class Attendance
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AttendanceId { get; set; }

        [Column(TypeName = "date")]
        public DateTime AttendanceDate { get; set; }

        public TimeSpan TimeIn { get; set; }

        public TimeSpan TimeOut { get; set; }

        [Required]
        [StringLength(900)]
        public string Description { get; set; }

        public int? StudentId { get; set; }

        public int? FirmId { get; set; }

        public virtual Firm Firm { get; set; }

        public virtual Student Student { get; set; }
    }
}
