using Herrera.Dominio;

namespace Herrera.DTO
{
    public class AlquilerDTO
    {
        public int Id { get; set; }
        public string Inquilino { get; set; }
        public float MontoAlquiler { get;  set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public EstadoAlquiler Estado { get;  set; }
    }
}
