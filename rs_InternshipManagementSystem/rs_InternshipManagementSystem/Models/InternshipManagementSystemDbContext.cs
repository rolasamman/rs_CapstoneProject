namespace InternshipWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class InternshipManagementSystemDbContext : DbContext
    {
        public InternshipManagementSystemDbContext()
            : base("name=InternshipManagementSystemDbContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Firm> Firms { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Internship> Internships { get; set; }
        public virtual DbSet<InternshipCriterion> InternshipCriterions { get; set; }
        public virtual DbSet<InternshipEvaluation> InternshipEvaluations { get; set; }
        public virtual DbSet<MeetingOnCampu> MeetingOnCampus { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Supervisor> Supervisors { get; set; }
        public virtual DbSet<SupervisorCriterion> SupervisorCriterions { get; set; }
        public virtual DbSet<SupervisorEvaluation> SupervisorEvaluations { get; set; }
        public virtual DbSet<VisitOnSite> VisitOnSites { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Announcements)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Complains)
                .WithRequired(e => e.Admin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Admin)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Instructor)
                .WithRequired(e => e.Employee);

            modelBuilder.Entity<Firm>()
                .HasMany(e => e.Supervisors)
                .WithRequired(e => e.Firm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.MeetingOnCampus)
                .WithRequired(e => e.Instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Instructor>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Instructor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Internship>()
                .HasMany(e => e.Sections)
                .WithRequired(e => e.Internship)
                .HasForeignKey(e => e.IntrenshipId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InternshipEvaluation>()
                .HasMany(e => e.InternshipCriterions)
                .WithRequired(e => e.InternshipEvaluation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.InternshipEvaluations)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Section>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Section)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Complains)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.InternshipEvaluations)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.MeetingOnCampus)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supervisor>()
                .HasMany(e => e.Students)
                .WithRequired(e => e.Supervisor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SupervisorEvaluation>()
                .HasMany(e => e.SupervisorCriterions)
                .WithRequired(e => e.SupervisorEvaluation)
                .WillCascadeOnDelete(false);
        }
    }
}
