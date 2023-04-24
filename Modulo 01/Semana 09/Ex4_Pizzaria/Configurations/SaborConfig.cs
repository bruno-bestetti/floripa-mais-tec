using Ex4_Pizzaria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria.Configurations
{
    public class SaborConfig : IEntityTypeConfiguration<Sabor>
    {
        public void Configure(EntityTypeBuilder<Sabor> builder)
        {
            builder.ToTable("Sabores");

            builder.HasKey(e => e.Id)
                    .HasName("PK_Sabores");

        }
    }
}
