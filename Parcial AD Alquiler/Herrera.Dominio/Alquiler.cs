namespace Herrera.Dominio
{
    public class Alquiler
    {
        public int Id { get; private set; }
        public string Inquilino { get; private set; }
        public float MontoAlquiler { get; private set; }
        public DateTime FechaInicio { get; private set; }
        public DateTime FechaFin { get; private set; }
        public EstadoAlquiler Estado { get; private set; }
        public Alquiler(int id, string inquilino, float montoAlq, DateTime fechaInicio, DateTime fechaFin, EstadoAlquiler estado)
        {
            SetId(id);
            SetInquilino(inquilino);
            SetMontoAlquiler(montoAlq);
            SetFechas(fechaInicio, fechaFin);
            SetEstado(estado);
        }
        private Alquiler() { }
        public void SetId(int id) {
            if (id < 0)
            {
                throw new ArgumentException("El campo 'Id' debe ser mayor o igual a 0");
            }
            Id = id;
        }
        public void SetInquilino(string inquilino)
        {
            if (string.IsNullOrWhiteSpace(inquilino))
            {
                throw new ArgumentException("El campo 'Inquilino' es obligatorio", nameof(inquilino));
            }
            Inquilino = inquilino;
        }

        public void SetMontoAlquiler(float montoAlquiler)
        {
            if(montoAlquiler <0 || montoAlquiler > 1000000)
            {
                throw new ArgumentException("El campo 'MontoAlquiler' tiene que ser un valor comprendido entre 0 y 1.000.000.", nameof(montoAlquiler));
            }
            MontoAlquiler = montoAlquiler;
        }

        public void SetFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio >= fechaFin)
            {
                throw new ArgumentException("El campo 'FechaInicio' debe ser inferior a la 'FechaFin'.");
            }
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
        }

        public void SetEstado(EstadoAlquiler estado)
        {
            if(!Enum.IsDefined(typeof(EstadoAlquiler), estado))
            {
                throw new ArgumentException("El estado no es valido", nameof(estado));
            }
            Estado = estado;
        }
    }

  
}