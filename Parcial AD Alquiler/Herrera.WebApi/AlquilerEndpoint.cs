using Herrera.DTO;
using Herrera.Services;
using Herrera.Dominio;

namespace Herrera.WebApi
{
    public static class AlquilerEndpoint
    {
        public static void MapAlquileresEndpoint(this WebApplication app)
        {
            app.MapGet("/alquileres", async (AlquilerService serv) =>
            {
                var dtos = await serv.GetAllAsync();
                return Results.Ok(dtos);
            })
            .WithName("GetAllAlquileres")
            .Produces<List<AlquilerDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/alquileres/{estado}", async (EstadoAlquiler estado, AlquilerService serv) =>
            {
                var dtos = await serv.GetByEstadoAsync(estado);
                return Results.Ok(dtos);
            })
            .WithName("GetAlquileresByEstado")
            .Produces<List<AlquilerDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/alquileres", async (AlquilerService serv, AlquilerDTO dto) =>
            {
                try
                {
                    AlquilerDTO alq = await serv.AddAsync(dto);
                    return Results.Created($"/alquileres/{alq.Id}", alq);
                }
                catch (ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddAlquiler")
            .Produces<AlquilerDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/alquileres/{id}", async (AlquilerService serv, int id) =>
            {
                var deleted = await serv.DeleteAsync(id);
                if (!deleted)
                {
                    return Results.NotFound();
                }
                return Results.NoContent();
            })
            .WithName("DeleteAlquiler");
        }


    }


}
