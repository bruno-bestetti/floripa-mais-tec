using M01_S10_Exercicios.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M01_S10_Exercicios.Configurations
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");

            builder.HasKey(e => e.Id).HasName("PK__Teacher");


            builder.Property(p => p.UserId)
                .HasColumnName("User_Id");


            builder.HasOne(x => x.User)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(x => x.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Teachers");

        }
    }
}
