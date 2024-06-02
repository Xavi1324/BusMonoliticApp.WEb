namespace XavierCasilla_2023_0995.Data.Models
{
    public class DetallePedidoModel
    {
        public int IdDetallePedido { get; set; }
        public int? IdPedido { get; set; }
        public int? IdPlato { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Subtotal { get; set; }

    }
}
