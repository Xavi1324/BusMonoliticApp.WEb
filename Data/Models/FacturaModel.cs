namespace XavierCasilla_2023_0995.Data.Models
{
    public class FacturaModel
    {
        public int IdFactura { get; set; }
        public int? IdPedido { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
