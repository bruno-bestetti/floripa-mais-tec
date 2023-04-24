using Ex4_Pizzaria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria.Configurations
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(e => e.Id)
                    .HasName("PK_Pedido");

            builder.Property(p => p.IdPizza)
                    .HasColumnName("Pizza_Id");

            builder.Property(p => p.IdStatus)
                    .HasColumnName("Status_Id");
        }
    }
}
