using System.IO;

namespace Ex_1ao3.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Celular { get; set; }
        public string Especialidade { get; set; }

        public virtual ICollection<Parto> Partos { get; set; }
    }
}
