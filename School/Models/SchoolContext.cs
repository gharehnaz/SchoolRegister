using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
      
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<TeacherStudent> TeacherStudents { get; set; }
        public DbSet<TeacherCourse> TeacherCourses { get; set; }


        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration(new StudentCourseMapping());
            modelBuilder.ApplyConfiguration(new TeacherStudentMapping());
            modelBuilder.ApplyConfiguration(new TeacherCourseMapping());



            base.OnModelCreating(modelBuilder);
        }
        public DbSet<School.Models.Teacher> Teacher { get; set; } = default!;
    }

}
