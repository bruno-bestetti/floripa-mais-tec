namespace M01_S10_Exercicios.DTO
{
    public class Student_DisciplineDTO
    {
        public class CreateStudent_DisciplineDTO
        {
            public int StudentId { get; set; }
            public int DisciplineId { get; set; }
        }

        public class AlteracaoStudent_DisciplineDTO
        {
            public int StudentId { get; set; }
            public int DisciplineId { get; set; }
        }
    }
}
