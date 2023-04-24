using Ex4_Pizzaria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria.Configurations
{
    public class PizzaConfig : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.ToTable("Pizza");

            builder.HasKey(e => e.Id)
                    .HasName("PK_Pizza");

            builder.Property(p => p.IdMassa)
                    .HasColumnName("Pizza_Id");

            builder.Property(p => p.IdBordas)
                    .HasColumnName("Sabores_Id");
        }
    }
}
