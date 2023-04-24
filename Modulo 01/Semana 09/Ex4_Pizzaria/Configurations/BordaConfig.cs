using Ex4_Pizzaria.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria.Configurations
{
    public class BordaConfig : IEntityTypeConfiguration<Borda>
    {
        public void Configure(EntityTypeBuilder<Borda> builder)
        {
        builder.ToTable("Borda");

        builder.HasKey(e => e.Id)
               .HasName("PK_Borda");
        }
    }

}
