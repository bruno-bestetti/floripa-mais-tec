using M01_S10_Exercicios.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M01_S10_Exercicios.Configurations
{
    public class Student_DisciplineConfig : IEntityTypeConfiguration<Student_Discipline>
    {
        public void Configure(EntityTypeBuilder<Student_Discipline> builder)
        {

            builder.ToTable("Student_Discipline");

            builder.HasKey(e => e.Id).HasName("PK__Student_Discipline");

            builder.Property(p => p.StudentId)
                .HasColumnName("Student_Id");

            builder.Property(p => p.DisciplineId)
                .HasColumnName("Discipline_Id");

            builder.HasOne(x => x.Students)
                    .WithMany(p => p.Student_Disciplines)
                    .HasForeignKey(x => x.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Student_Student_Discipline");

            builder.HasOne(x => x.Disciplines)
                    .WithMany(p => p.Students_Disciplines)
                    .HasForeignKey(x => x.StudentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Discipline_Student_Discipline");

        }
    }
}
