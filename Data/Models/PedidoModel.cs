namespace XavierCasilla_2023_0995.Data.Models
{
    public class PedidoModel
    {
        public int IdPedido { get; set; }
        public int? IdCliente { get; set; }
        public int? IdMesa { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Total { get; set; }
    }
}
