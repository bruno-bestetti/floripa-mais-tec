using System.IO;

namespace Ex_1ao3.Models
{
    public class Bebe
    {
        public int Id { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public float Peso_Nascimento { get; set; }
        public int Altura { get; set; }
        public int MaeId { get; set; }
        public int PartoId { get; set; }
        
        public virtual Parto Parto { get; set; }
        public virtual Mae Mae { get; set; }
    }
}
