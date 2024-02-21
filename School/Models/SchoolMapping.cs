using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Models
{
    public class StudentCourseMapping : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.ToTable("StudentCourse");
            builder.HasKey(x => new { x.StudentId, x.CourseId });

            builder.HasOne(x => x.Student).WithMany(x => x.StudentCourses).HasForeignKey(z => z.StudentId);

            builder.HasOne(z => z.Course).WithMany(z => z.StudentCourses).HasForeignKey(z => z.CourseId);
        }
    }
    public class TeacherStudentMapping : IEntityTypeConfiguration<TeacherStudent>
    {
        public void Configure(EntityTypeBuilder<TeacherStudent> builder)
        {
            builder.ToTable("TeacherStudent");
            builder.HasKey(x => new { x.StudentId, x.TeacherId });

            builder.HasOne(x => x.Student).WithMany(x => x.TeacherStudents).HasForeignKey(z => z.StudentId);

            builder.HasOne(z => z.Teacher).WithMany(z => z.TeacherStudents).HasForeignKey(z => z.TeacherId);
        }
    }
    public class TeacherCourseMapping : IEntityTypeConfiguration<TeacherCourse>
    {
        public void Configure(EntityTypeBuilder<TeacherCourse> builder)
        {
            builder.ToTable("TeacherCourse");
            builder.HasKey(x => new { x.CourseId, x.TeacherId });

            builder.HasOne(x => x.Course).WithMany(x => x.TeacherCourses).HasForeignKey(z => z.CourseId);

            builder.HasOne(z => z.Teacher).WithMany(z => z.TeacherCourses).HasForeignKey(z => z.TeacherId);
        }
    }
}
