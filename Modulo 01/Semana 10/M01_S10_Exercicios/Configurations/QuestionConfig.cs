using M01_S10_Exercicios.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace M01_S10_Exercicios.Configurations
{
    public class QuestionConfig : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {

            builder.ToTable("Question");

            builder.HasKey(e => e.Id)
                .HasName("PK_Question");


            builder.Property(p => p.QuizId)
                .HasColumnName("Quiz_Id");


            builder.HasOne(x => x.Quiz)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(x => x.QuizId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Quiz_Questions");

        }
    }
}
