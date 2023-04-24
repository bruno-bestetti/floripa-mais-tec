using M01_S10_Exercicios.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M01_S10_Exercicios.Configurations
{
    public class QuizConfig : IEntityTypeConfiguration<Quiz>
    {
        public void Configure(EntityTypeBuilder<Quiz> builder)
        {
            builder.ToTable("Quiz");

            builder.HasKey(e => e.Id).HasName("PK__Quiz");


            builder.Property(p => p.DisciplineId)
                .HasColumnName("Discipline_Id");


            builder.HasOne(x => x.Discipline)
                    .WithMany(p => p.Quizzes)
                    .HasForeignKey(x => x.DisciplineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Discipline_Quizzes");

        }
    }
}
