using Ex_1ao3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex_1ao3.Configuration
{
    public class MedicoConfig : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(e => e.Id).HasName("PK_Medico");

            builder.Property(e => e.Nome)
                    .HasMaxLength(150);
        }
    }
}
