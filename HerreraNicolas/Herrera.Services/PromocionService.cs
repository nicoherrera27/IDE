using Herrera.Data;
using Herrera.Domain;
using Herrera.DTO;
namespace Herrera.Services
{
    public class PromocionService
    {
        public async Task<IEnumerable<PromocionDTO>> GetAllAsync()
        {
            var promoRepo = new PromocionRepository();
            var promos = await promoRepo.GetAllAsync();

            return promos.Select(promo => new PromocionDTO
            {
                Id = promo.Id,
                Nombre = promo.Nombre,
                FechaInicio = promo.FechaInicio,
                FechaFin = promo.FechaFin,
                Descuento = promo.Descuento,
                Estado = promo.Estado
            }).ToList();

        }

        public async Task<IEnumerable<PromocionDTO>> GetByEstadoAsync(EstadoProm estado)
        {
            var promoRepo = new PromocionRepository();
            var promos = await promoRepo.GetByEstadoAsync(estado);

            return promos.Select(promo => new PromocionDTO
            {
                Id = promo.Id,
                Nombre = promo.Nombre,
                FechaInicio = promo.FechaInicio,
                FechaFin = promo.FechaFin,
                Descuento = promo.Descuento,
                Estado = promo.Estado
            }).ToList();

        }

        public async Task<PromocionDTO> AddAsync(PromocionDTO promoDTO)
        {
            var promoRepo = new PromocionRepository();

            Promocion promo = new Promocion(
                0,
                promoDTO.Nombre,
                promoDTO.FechaInicio,
                promoDTO.FechaFin,
                promoDTO.Descuento,
                EstadoProm.Activa
            );

            await promoRepo.AddAsync(promo);

            promoDTO.Id = promo.Id;
            promoDTO.Estado = promo.Estado;

            return promoDTO;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var promoRepo = new PromocionRepository();

            return await promoRepo.DeleteAsync(id);
        }
    }
}
