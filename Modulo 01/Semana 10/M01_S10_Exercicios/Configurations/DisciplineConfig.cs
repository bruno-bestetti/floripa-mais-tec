using M01_S10_Exercicios.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M01_S10_Exercicios.Configurations
{
    public class DisciplineConfig : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.ToTable("Discipline");

            builder.HasKey(e => e.Id).HasName("PK__Discipline");


            builder.Property(p => p.TeacherId)
                .HasColumnName("Teacher_Id");


            builder.HasOne(x => x.Teacher)
                    .WithMany(p => p.Disciplines)
                    .HasForeignKey(x => x.TeacherId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Teacher_Disciplines");

        }
    }
}
