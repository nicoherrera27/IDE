using Herrera.Domain;
using Herrera.DTO;
using System.Net.Http.Json;
namespace Herrera.API.Clients

{
    public static class PromocionApiClient
    {
        public static async Task<HttpResponseMessage> AddAsync(PromocionDTO promo)
        {
            return await ApiClient.Http.PostAsJsonAsync("promociones", promo);
        }
        public static async Task<bool> DeleteAsync(int id)
        {
            var response = await ApiClient.Http.DeleteAsync($"promociones/{id}");

            return response.IsSuccessStatusCode;
        }
        public static async Task<List<PromocionDTO>> GetAllAsync()
        {
            var response = await ApiClient.Http.GetAsync("promociones");

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PromocionDTO>>() ?? new List<PromocionDTO>();
        }
        public static async Task<List<PromocionDTO>> GetByEstadoAsync(EstadoProm estado)
        {
            var response = await ApiClient.Http.GetAsync($"promociones/{estado}");

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<PromocionDTO>>() ?? new List<PromocionDTO>();
        }

    }
}
