using Microsoft.EntityFrameworkCore;
using Ex_1ao3.Configuration;
using Ex_1ao3.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.IdentityModel.Tokens;

// Ex1 - Crie modelos e contexto
//Crie um novo projeto de API Web APS.NET core.
//Instale as bibliotecas do Entity Framework Core
//Injete a dependência do Entity Framework no arquivo program.cs
//Crie os modelos respectivos de acordo com o modelo lógico abaixo de um berçário, contendo as classes e propriedades.
//Crie o contexto e configure os respectivos DbSets.

// Ex2 - Configurar mapeamentos dos modelos
// Utilize os mapeamentos de API fluente e Anotações para fazer os mapeamentos necessários entre os modelos.

// Ex 3 - Criar tabelas através do Code First
//Utilize os mapeamentos de API fluente e Anotações para fazer os mapeamentos necessários entre os modelos.

namespace Ex_1ao3
{
    public class BercarioContext : DbContext
    {
        public DbSet<Bebe> Bebes { get; set; }
        public DbSet<Mae> Maes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Parto> Partos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-I2B2MOGA\\SQLEXPRESS;Database=BERCARIOS09;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BebeConfig());
            modelBuilder.ApplyConfiguration(new MaeConfig());
            modelBuilder.ApplyConfiguration(new MedicoConfig());
            modelBuilder.ApplyConfiguration(new PartoConfig());
        }
    }
}