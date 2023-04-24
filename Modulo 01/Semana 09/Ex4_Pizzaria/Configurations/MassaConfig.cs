using Ex4_Pizzaria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria.Configurations
{
    public class MassaConfig : IEntityTypeConfiguration<Massa>
    {
        public void Configure(EntityTypeBuilder<Massa> builder)
        {
            builder.ToTable("Massa");

            builder.HasKey(e => e.Id)
                    .HasName("PK_Massa");
        }
    }
}
