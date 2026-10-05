using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Herrera.Dominio;
using Herrera.DTO;

namespace Herrera.APIClients
{
    public class AlquilerApiClient
    {
        public static async Task<List<AlquilerDTO>> GetAllAsync()
        {
            var response = await ApiClient.Http.GetAsync("alquileres");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<AlquilerDTO>>() ?? new List<AlquilerDTO>();
        }
        public static async Task<List<AlquilerDTO>> GetByEstadoAsync(EstadoAlquiler estado)
        {
            var response = await ApiClient.Http.GetAsync($"alquileres/{estado}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<AlquilerDTO>>() ?? new List<AlquilerDTO>();
        }

        public static async Task<HttpResponseMessage> AddAsync(AlquilerDTO dto)
        {
            return await ApiClient.Http.PostAsJsonAsync("alquileres", dto);
        }

        public static async Task<bool> DeleteAsync(int id)
        {
            var response = await ApiClient.Http.DeleteAsync($"alquileres/{id}");
            return response.IsSuccessStatusCode;
        }

    }
}
