## Estructura de Proyectos (.NET 8)

> **Formato:** `HerreraNicolas.[NombreProyecto]`  
> *Presentación: se implementa en **WinForms** o **Blazor WASM** según la consigna.*

| Proyecto | Tipo | Referencias | NuGet | Responsabilidad |
| :--- | :--- | :--- | :--- | :--- |
| `HerreraNicolas.Dominio` | ClassLib (`net8.0`) | *Ninguna* | *Ninguno* | Entidad del negocio y enums de estado |
| `HerreraNicolas.DTO` | ClassLib (`net8.0`) | `.Dominio` | *Ninguno* | DTOs para transporte de datos |
| `HerreraNicolas.Data` | ClassLib (`net8.0`) | `.Dominio` | `EFCore.SqlServer` | DbContext (`EnsureCreated`) y Repositorios |
| `HerreraNicolas.Services` | ClassLib (`net8.0`) | `.Dominio`<br>`.DTO`<br>`.Data` | *Ninguno* | Lógica de negocio y validaciones |
| `HerreraNicolas.WebApi` | Web API (`net8.0`) | `.Dominio`<br>`.DTO`<br>`.Services`<br>`.Data` | `OpenApi`<br>`Swashbuckle` | Endpoints REST asíncronos y Swagger |
| `HerreraNicolas.APIClients` | ClassLib (`net8.0`) | `.Dominio`<br>`.DTO` | *Ninguno* | `HttpClient` y consumo de la Web API |
| `HerreraNicolas.Presentacion` *(WinForms)* | WinForms (`net8.0-windows`) | `.APIClients`<br>`.DTO`<br>`.Dominio` | *Ninguno* | Vistas de escritorio (listado, filtro y alta) |
| `HerreraNicolas.Presentacion` *(Blazor)* | Blazor WASM (`net8.0`) | `.APIClients`<br>`.DTO`<br>`.Dominio` | `WebAssembly` | Vistas web Razor (listado, filtro y alta) |

---

### Paquetes NuGet detallados

* **Data**: `Microsoft.EntityFrameworkCore.SqlServer`
* **WebApi**: `Microsoft.AspNetCore.OpenApi` y `Swashbuckle.AspNetCore`
* **Blazor** *(si se usa)*: `Microsoft.AspNetCore.Components.WebAssembly`
