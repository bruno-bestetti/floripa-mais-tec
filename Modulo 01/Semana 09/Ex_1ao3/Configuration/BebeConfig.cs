using Ex_1ao3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ex_1ao3.Configuration
{
    public class BebeConfig : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.ToTable("Bebe");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.PartoId)
                .HasColumnName("Parto_Id");

            builder.Property(p => p.Peso_Nascimento)
                .HasColumnName("PesoNascimento");

            builder.Property(p => p.MaeId)
                .HasColumnName("Mae_Id");

            builder.HasOne(x => x.Mae)
                    .WithMany(p => p.Bebes)
                    .HasForeignKey(x => x.MaeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mae_Bebe");

            builder.HasOne(x => x.Parto)
                    .WithMany(p => p.Bebes)
                    .HasForeignKey(x => x.PartoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Parto_Bebe");
        }
    }
}