using M01_S10_Exercicios.Models;
using M01_S10_Exercicios.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M01_S10_Exercicios.Context
{
    public class SchoolContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Discipline> Students_Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAPTOP-I2B2MOGA\\SQLEXPRESS;Database=School;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnswerConfig());
            modelBuilder.ApplyConfiguration(new DisciplineConfig());
            modelBuilder.ApplyConfiguration(new QuestionConfig());
            modelBuilder.ApplyConfiguration(new QuizConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new Student_DisciplineConfig());
            modelBuilder.ApplyConfiguration(new TeacherConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

    } 
}
