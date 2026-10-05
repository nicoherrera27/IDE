/*   
    <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.31" />
    </ItemGroup>

Dentro del TEMPLATE.domain
 */

// Proyecto Console App
// Esto es una clase
// No hay referencias en este proyecto

namespace TEMPLATE.Domain
{
    public class Clase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Monto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Estado { get; set; } = "Activo";
    }
}
