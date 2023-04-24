using Ex4_Pizzaria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria.Configurations
{
    public class Pizza_SaboresConfig : IEntityTypeConfiguration<Pizza_Sabores>
    {
        public void Configure(EntityTypeBuilder<Pizza_Sabores> builder)
        {
            builder.ToTable("Pizza_Sabores");

            builder.HasKey(e => e.Id)
                    .HasName("PK_PizzaSabor");

            //builder.Property(p => p.PizzaId)
            //        .HasColumnName("Pizza_Id");

            //builder.Property(p => p.SaboresId)
            //        .HasColumnName("Sabores_Id");

        }
    }
}
