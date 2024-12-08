using Microsoft.EntityFrameworkCore;

namespace SmartCourseSelectorWeb.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<StudentCourseSelection> StudentCourseSelection { get; set; }
        public DbSet<Transcript> Transcript { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourseSelection>(entity =>
            {
                entity.HasKey(e => e.SelectionID); // Primary Key tanımlaması
                entity.HasOne(e => e.Student)
                      .WithMany(s => s.StudentCourseSelections)
                      .HasForeignKey(e => e.StudentID);

                entity.HasOne(e => e.Course)
                      .WithMany(c => c.StudentCourseSelections)
                      .HasForeignKey(e => e.CourseID);
            });
        }
    }
}
