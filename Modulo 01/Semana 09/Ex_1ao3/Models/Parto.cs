namespace Ex_1ao3.Models
{
    public class Parto
    {
        public int Id { get; set; }
        public DateTime Data_Parto { get; set; }
        public DateTime Horario_Parto { get; set; }
        public int MedicoId { get; set; }

        public virtual ICollection<Bebe> Bebes { get; set; }
        public virtual Medico Medico { get; set; }
    }
}
