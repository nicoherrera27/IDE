namespace Herrera.Domain
{
    public class Promocion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaInicio {  get; set; }
        public DateOnly FechaFin {  get; set; }
        public int Descuento { get; set; }
        public EstadoProm Estado { get; set; } 

        public Promocion (int id, string nombre, DateOnly fechaInicio, DateOnly fechaFin, int descuento, EstadoProm estado)
        {
            SetId(id);
            SetNombre(nombre);
            SetFechas(fechaInicio, fechaFin);
            SetDescuento(descuento);
            SetEstado(estado);
        }

        private Promocion() { }
        public void SetId(int id)
        {
            if (id<0)
                throw new ArgumentException("El id debe ser mayor o igual a 0.", nameof(id));
            Id = id;
        }
        public void SetNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre es obligatorio", nameof(nombre));
            Nombre = nombre;
        }
        public void SetFechas(DateOnly fechaInicio, DateOnly fechaFin)
        {
            if (fechaInicio >= fechaFin)
            {
                throw new ArgumentException("La fecha de inicio tiene que ser anterior (o inferior) a la fecha de fin");
 
            }
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }
        public void SetDescuento(int descuento)
        {
            if (descuento < 1 || descuento > 100 )
                throw new ArgumentException("El descuento debe estar entre 1% y 100%.", nameof(descuento));
            Descuento = descuento;
        }
        public void SetEstado(EstadoProm estado)
        {
            if (!Enum.IsDefined(typeof(EstadoProm), estado))
                throw new ArgumentException("El estado no es válido.", nameof(estado));
            Estado = estado;
        }
    }
}
