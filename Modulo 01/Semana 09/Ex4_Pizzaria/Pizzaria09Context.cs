using Ex4_Pizzaria.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Ex4_Pizzaria
{
    public partial class Pizzaria09Context : DbContext
    {
        public Pizzaria09Context()
        {

        }
        public Pizzaria09Context(DbContextOptions<Pizzaria09Context> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=LAPTOP-I2B2MOGA; Database=brunobestetti.labschoolbd;Trusted_Connection=True;TrustServerCertificate=True;User Id=sa;Password=1234;");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BordaConfig());
            modelBuilder.ApplyConfiguration(new MassaConfig());
            modelBuilder.ApplyConfiguration(new PedidoConfig());
            modelBuilder.ApplyConfiguration(new Pizza_SaboresConfig());
            modelBuilder.ApplyConfiguration(new PizzaConfig());
            modelBuilder.ApplyConfiguration(new SaborConfig());
            modelBuilder.ApplyConfiguration(new StatusConfig());
        }
    }
}


//("Data Source=LAPTOP-I2B2MOGA\\SQLEXPRESS\\SQLEXPRESS;Database=PIZZARIA09;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");