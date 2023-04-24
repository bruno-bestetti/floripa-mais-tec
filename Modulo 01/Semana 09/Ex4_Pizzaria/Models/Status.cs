namespace Ex4_Pizzaria.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string? NomeStatus { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
