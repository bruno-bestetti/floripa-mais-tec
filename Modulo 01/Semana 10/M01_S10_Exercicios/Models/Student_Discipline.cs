namespace M01_S10_Exercicios.Models
{
    public class Student_Discipline
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public int StudentId { get; set; }


        public virtual Discipline Disciplines { get; set; }
        public virtual Student Students { get; set; }
    }
}
