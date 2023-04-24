using Ex_1ao3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex_1ao3.Configuration
{
    public class MaeConfig : IEntityTypeConfiguration<Mae>
    {
        public void Configure(EntityTypeBuilder<Mae> builder)
        {
            builder.ToTable("Mae");

            builder.HasKey(e => e.Id).HasName("PK_Mae");

            builder.Property(e => e.Nome)
                    .HasMaxLength(150);

            builder.Property(e => e.Endereco)
                    .HasMaxLength(150);
        }
    }
}