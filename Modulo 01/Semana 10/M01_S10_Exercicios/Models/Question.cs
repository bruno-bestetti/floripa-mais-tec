namespace M01_S10_Exercicios.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Enunciation { get; set; }
        public float Weight { get; set; }


        public virtual Quiz Quiz { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
