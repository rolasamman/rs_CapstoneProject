namespace InternshipWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Announcement")]
    public partial class Announcement
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AnnouncementId { get; set; }

        [Required]
        [StringLength(100)]
        public string Subject { get; set; }

        public DateTime AnnouncementDate { get; set; }

        [Required]
        [StringLength(900)]
        public string Description { get; set; }

        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
