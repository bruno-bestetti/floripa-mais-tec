using Ex_1ao3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex_1ao3.Configuration
{         
    public class PartoConfig : IEntityTypeConfiguration<Parto>
    {
            public void Configure(EntityTypeBuilder<Parto> builder)
            {
            builder.ToTable("Parto");

            builder.HasKey(x => x.Id);

            builder.Property(p => p.MedicoId)
                   .HasColumnName("Medico_Id");

            builder.HasOne(x => x.Medico)
                   .WithMany(p => p.Partos)
                   .HasForeignKey(x => x.MedicoId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK__Medico_Parto");
            }
    }
}