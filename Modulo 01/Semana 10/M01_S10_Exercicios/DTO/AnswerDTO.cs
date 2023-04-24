using M01_S10_Exercicios.Models;
using M01_S10_Exercicios.Controllers;

namespace M01_S10_Exercicios.DTO
{
    public class AnswerDTO
    {
        public class CreateAnswerDTO
        {
            public string? Answers { get; set; }
            public float Score { get; set; }
            public string? Observation { get; set; }
        }

        public class AlteracaoAnswerDTO
        {
            public string? Answers { get; set; }
            public float Score { get; set; }
            public string? Observation { get; set; }
        }
    }
}
