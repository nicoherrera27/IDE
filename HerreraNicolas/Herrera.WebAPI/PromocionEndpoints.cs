using Herrera.Services;
using Herrera.DTO;
using Herrera.Domain;


namespace Herrera.WebAPI
{
    public static class PromocionEndpoints
    {
        public static void MapPromocionEndpoints(this WebApplication app)
        {
            app.MapGet("/promociones", async (PromocionService promoServ) =>
            {
                var dtos = await promoServ.GetAllAsync();

                return Results.Ok(dtos);

            })
            .WithName("GetAllPromociones")
            .Produces<List<PromocionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapGet("/promociones/{estado}",async (EstadoProm estado, PromocionService promoServ) =>
            {
                var dtos = await promoServ.GetByEstadoAsync(estado);

                return Results.Ok(dtos);

            })
            .WithName("GetAllPromocionesByEstado")
            .Produces<List<PromocionDTO>>(StatusCodes.Status200OK)
            .WithOpenApi();

            app.MapPost("/promociones", async (PromocionDTO dto, PromocionService promoServ) =>
            {
                try
                {
                    PromocionDTO promoDTO = await promoServ.AddAsync(dto);

                    return Results.Created($"/promociones/{promoDTO.Id}", promoDTO);
                }
                catch(ArgumentException ex)
                {
                    return Results.BadRequest(new { error = ex.Message });
                }
            })
            .WithName("AddPromocion")
            .Produces<PromocionDTO>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .WithOpenApi();

            app.MapDelete("/promociones/{id}",async (int id, PromocionService promoServ) =>
            {
                var deleted = await promoServ.DeleteAsync(id);
                if (!deleted)
                {
                    return Results.NotFound();
                }
                return Results.NoContent();
 
            })
            .WithName("DeletePromocion")
            .Produces(StatusCodes.Status204NoContent)
            .Produces(StatusCodes.Status404NotFound)
            .WithOpenApi();
        }


    }
}
