namespace M01_S10_Exercicios.DTO
{
    public class DisciplineDTO
    {

        public class CreateDisciplineDTO
        {
            public int TeacherId { get; set; }
            public string NameDiscipline { get; set; }
        }


        public class AlteracaoDisciplineDTO
        {
            public int TeacherId { get; set; }
            public string NameDiscipline { get; set; }
        }
    }
}
