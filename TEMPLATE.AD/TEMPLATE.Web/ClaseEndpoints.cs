// Esto es una clase

using TEMPLATE.Domain;

namespace TEMPLATE.Web
{
    public static class ClaseEndpoints
    {
        public static void MapClaseEndpoints(this WebApplication app)
        {
            app.MapGet("/clases/{id}", async (int id) =>
            {
                ClaseService ClaseService = new ClaseService();

                Clase Clase = await ClaseService.GetAsync(id);

                return Clase is null ? Results.NotFound() : Results.Ok(Clase);
            })
            .WithName("GetClase");

            app.MapGet("/Clases", async () =>
            {
                ClaseService ClaseService = new ClaseService();

                return await ClaseService.GetAllAsync();
            })
            .WithName("GetAllClases");

            // 2.a: recuperar registros según el estado ("Activo" / "Finalizado")
            app.MapGet("/Clases/estado/{estado}", async (string estado) =>
            {
                ClaseService ClaseService = new ClaseService();

                try
                {
                    return Results.Ok(await ClaseService.GetByEstadoAsync(estado));
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("GetClasesPorEstado");

            // 2.b: agregar nuevo registro (el servicio lo crea siempre como "Activo")
            app.MapPost("/Clases", async (Clase Clase) =>
            {
                ClaseService ClaseService = new ClaseService();

                try
                {
                    Clase creado = await ClaseService.AddAsync(Clase);

                    return Results.Created($"/Clases/{creado.Id}", creado);
                }
                catch (Exception ex)
                {
                    // Falló alguna validación del punto 3: se informa el mensaje al cliente
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("AddClase");

            // 2.c: finalizar un Clase
            app.MapPut("/Clases/{id}/finalizar", async (int id) =>
            {
                ClaseService ClaseService = new ClaseService();

                try
                {
                    bool encontrado = await ClaseService.FinalizarAsync(id);

                    return encontrado ? Results.NoContent() : Results.NotFound();
                }
                catch (Exception ex)
                {
                    return Results.BadRequest(ex.Message);
                }
            })
            .WithName("FinalizarClase");
        }

    }
}
