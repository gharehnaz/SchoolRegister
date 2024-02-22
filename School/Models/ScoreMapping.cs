using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Models
{
    public class ScoreMapping : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.ToTable("Score");
            builder.HasKey(x => new { x.Id });


            builder.HasOne(x => x.Student)
                            .WithMany(x => x.Scores)
                            .HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Course)
                            .WithMany(x => x.Scores)
                            .HasForeignKey(x => x.CourseId);
            builder.HasOne(x => x.Teacher)
                            .WithMany(x => x.Scores)
                            .HasForeignKey(x => x.TeacherId);
        }
    }
}
