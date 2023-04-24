namespace M01_S10_Exercicios.DTO
{
    public class QuizDTO
    {
        public class CreateQuizDTO
        {
            public int DisciplineId { get; set; }
            public string Title { get; set; }
            public string Observation { get; set; }
        }


        public class AlteracaoQuizDTO
        {
            public int DisciplineId { get; set; }
            public string Title { get; set; }
            public string Observation { get; set; }
        }
    }
}
