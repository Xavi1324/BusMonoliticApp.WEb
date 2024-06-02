namespace XavierCasilla_2023_0995.Data.Models
{
    public class BusModel
    {
        public int IdBus { get; set; }
        public string? NumeroPlaca { get; set; }
        public string? Nombre { get; set; }
        public int? CapacidadPiso1 { get; set; }
        public int? CapacidadPiso2 { get; set; }
        public int? CapacidadTotal => (CapacidadPiso1 ?? 0) + (CapacidadPiso2 ?? 0);
        public bool? Disponible { get; set; }
    }
}
