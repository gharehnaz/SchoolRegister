using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace School.Models
{
    public class BookMapping : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Scores)
               .WithOne(x => x.Student)
               .HasForeignKey(x => x.StudentId);
        }
    }
}
