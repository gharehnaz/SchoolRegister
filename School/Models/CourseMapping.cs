using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Models
{
    public class CourseMapping : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Course");
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Scores)
              .WithOne(x => x.Course)
              .HasForeignKey(x => x.CourseId);
        }
    }
}
