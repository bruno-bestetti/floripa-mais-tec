namespace M01_S10_Exercicios.DTO
{
    public class TeacherDTO
    {
        public class CreateTeacherDTO
        {
            public int UserId { get; set; }
            public string Department { get; set; }
        }


        public class AlteracaoTeacherDTO
        {
            public int UserId { get; set; }
            public string Department { get; set; }
        }
    }
}
