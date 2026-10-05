## Estructura de Proyectos (.NET 8)

> **Regla de nomenclatura:** Cada proyecto y espacio de nombres debe respetar el formato `[Apellido].[NombreProyecto]` (ejemplo: `Herrera.Dominio`, `Herrera.Data`, etc.).
> 
> *Nota: La capa de presentación se puede implementar en **Windows Forms** o **Blazor WebAssembly** según la elección solicitada.*

| Proyecto | Tipo / SDK | Paquetes NuGet | Referencias a Proyectos | Responsabilidad |
| :--- | :--- | :--- | :--- | :--- |
| **`[Apellido].Dominio`** | Biblioteca de clases (`net8.0`) | *Ninguno* | *Ninguna* | Entidades de negocio (`Alquiler`, `Promocion`) y enumeradores de estado (`EstadoAlquiler`, `EstadoProm`). |
| **`[Apellido].DTO`** | Biblioteca de clases (`net8.0`) | *Ninguno* | `[Apellido].Dominio` | Clases DTO para transferencia desacoplada de datos entre capas y clientes. |
| **`[Apellido].Data`** | Biblioteca de clases (`net8.0`) | `Microsoft.EntityFrameworkCore.SqlServer` | `[Apellido].Dominio` | `DbContext` (EF Core con `Database.EnsureCreated()`) y patrón repositorio (`AlquilerRepository`, `PromocionRepository`). |
| **`[Apellido].Services`** | Biblioteca de clases (`net8.0`) | *Ninguno* | `[Apellido].Data`<br>`[Apellido].Dominio`<br>`[Apellido].DTO` | Lógica de negocio, validaciones requeridas por consigna y mapeo entidad-DTO. |
| **`[Apellido].WebApi`** | ASP.NET Core Web API (`net8.0`) | `Microsoft.AspNetCore.OpenApi`<br>`Swashbuckle.AspNetCore` | `[Apellido].Dominio`<br>`[Apellido].DTO`<br>`[Apellido].Services`<br>`[Apellido].Data` | Minimal APIs / Controladores, endpoints asíncronos y Swagger. |
| **`[Apellido].APIClients`** | Biblioteca de clases (`net8.0`) | *Ninguno* *(usa APIs nativas)* | `[Apellido].Dominio`<br>`[Apellido].DTO` | Cliente HTTP (`HttpClient`) y métodos asíncronos para consumir la Web API desde la presentación. |
| **`[Apellido].Presentacion`** *(WinForms)* | Windows Forms App (`net8.0-windows`) | *Ninguno* | `[Apellido].APIClients`<br>`[Apellido].DTO`<br>`[Apellido].Dominio` | Interfaz de escritorio: formularios de listado, filtro por estado y alta de la entidad. |
| **`[Apellido].Presentacion`** *(Blazor)* | Blazor WebAssembly (`net8.0`) | `Microsoft.AspNetCore.Components.WebAssembly`<br>`Microsoft.AspNetCore.Components.WebAssembly.DevServer` | `[Apellido].APIClients`<br>`[Apellido].DTO`<br>`[Apellido].Dominio` | Interfaz web: componentes Razor para listado con filtros y modal/formulario de alta. |
