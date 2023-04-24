namespace M01_S10_Exercicios.DTO
{
    public class QuestionDTO
    {
        public class CreateQuestionDto
        {
            public int QuizId { get; set; }
            public string Enunciation { get; set; }
            public float Weight { get; set; }
        }


        public class AlteracaoQuestionDTO
        {
            public int QuizId { get; set; }
            public string Enunciation { get; set; }
            public float Weight { get; set; }
        }
    }
}
