namespace M01_S10_Exercicios.DTO
{
    public class StudentDTO
    {
        public class CreateStudentDTO
        {
            public int UserId { get; set; }
            public int Period { get; set; }
            public int RA { get; set; }
        }


        public class AlteracaoStudentDTO
        {
            public int UserId { get; set; }
            public int Period { get; set; }
            public int RA { get; set; }
        }
    }
}
