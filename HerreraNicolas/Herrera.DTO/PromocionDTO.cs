using Herrera.Domain;

namespace Herrera.DTO
{
    public class PromocionDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public int Descuento { get; set; }
        public EstadoProm Estado { get; set; }
    }
}
