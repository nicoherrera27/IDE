
namespace TEMPLATE.Domain
{
    public class ClaseValidation
    {
        public static bool isValid(Clase clase)
        {
            if (clase == null)
            {
                throw new Exception("Los datos del clase son requeridos");
            }
            if (string.IsNullOrWhiteSpace(clase.Nombre))
            {
                throw new Exception("El nombre es requerido");
            }
            if (clase.Monto < 0 || clase.Monto > 1000000)
            {
                throw new Exception("El monto del clase debe ser mayor a cero y menor a 1000000");
            }
            if (clase.FechaInicio >= clase.FechaFin)
            {
                throw new Exception("La fecha de inicio debe ser anterior a la fecha de fin");
            }

            // Si llega aca es que es valido
            return true;
        }
    }
}