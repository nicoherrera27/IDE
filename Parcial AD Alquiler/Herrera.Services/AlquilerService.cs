using Herrera.Data;
using Herrera.Dominio;
using Herrera.DTO;

namespace Herrera.Services
{
    public class AlquilerService
    {
        public async Task<IEnumerable<AlquilerDTO>> GetAllAsync()
        {
            var repo = new AlquilerRepository();
            var alquileres = await repo.GetAllAsync();
            return alquileres.Select(alq => new AlquilerDTO
            {
                Id = alq.Id,
                Inquilino = alq.Inquilino,
                MontoAlquiler = alq.MontoAlquiler,
                FechaInicio = alq.FechaInicio,
                FechaFin = alq.FechaFin,
                Estado = alq.Estado
            }).ToList();
        }

        public async Task<IEnumerable<AlquilerDTO>> GetByEstadoAsync(EstadoAlquiler estado)
        {
            var repo = new AlquilerRepository();
            var alquileresByEstado = await repo.GetByEstadoAsync(estado);
            return alquileresByEstado.Select(alq => new AlquilerDTO
            {
                Id = alq.Id,
                Inquilino = alq.Inquilino,
                MontoAlquiler = alq.MontoAlquiler,
                FechaInicio = alq.FechaInicio,
                FechaFin = alq.FechaFin,
                Estado = alq.Estado
            }).ToList();
        }

        public async Task<AlquilerDTO> AddAsync(AlquilerDTO dto)
        {
            var repo = new AlquilerRepository();

            Alquiler alq = new Alquiler(
                0,
                dto.Inquilino,
                dto.MontoAlquiler,
                dto.FechaInicio,
                dto.FechaFin,
                EstadoAlquiler.Activo
            );

            await repo.AddAsync(alq);
            dto.Id = alq.Id;
            dto.Estado = alq.Estado;

            return dto;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var repo = new AlquilerRepository();

            return await repo.DeleteAsync(id);
        }
    }
}

