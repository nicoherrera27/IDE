//esto es una clase


using System.Net.Http.Headers;
using System.Net.Http.Json;
using TEMPLATE.Domain;

namespace TEMPLATE.Escritorio
{
    public class ClaseApiClient
    {
        private static HttpClient client = new HttpClient();

        static ClaseApiClient()
        {
            // Esta URL se podría pasar a un setting
            client.BaseAddress = new Uri("http://localhost:5056/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Clase> GetAsync(int id)
        {
            Clase clase = null;
            HttpResponseMessage response = await client.GetAsync("clases/" + id);
            if (response.IsSuccessStatusCode)
            {
                clase = await response.Content.ReadFromJsonAsync<Clase>();
            }
            return clase;
        }

        public static async Task PostAsync(Clase clase)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("clases", clase);
            await EnsureSuccessAsync(response);
        }

        public static async Task<IEnumerable<Clase>> GetClasesAsync()
        {
            IEnumerable<Clase> clases = null;
            HttpResponseMessage response = await client.GetAsync("clases");
            if (response.IsSuccessStatusCode)
            {
                clases = await response.Content.ReadFromJsonAsync<IEnumerable<Clase>>();
            }
            return clases;
        }

        public static async Task<IEnumerable<Clase>> GetByEstadoAsync(string estado)
        {
            IEnumerable<Clase> clases = null;
            HttpResponseMessage response = await client.GetAsync("clases/estado/" + estado);
            if (response.IsSuccessStatusCode)
            {
                clases = await response.Content.ReadFromJsonAsync<IEnumerable<Clase>>();
            }
            return clases;
        }

        public static async Task FinalizarAsync(int id) 
        { 
            HttpResponseMessage response = await client.PutAsync("clases/" + id + "/finalizar", null);
            await EnsureSuccessAsync(response);
        }

        private static async Task EnsureSuccessAsync(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(string.IsNullOrWhiteSpace(mensaje) ? response.ReasonPhrase : mensaje.Trim('"'));
            }
        }
    }
}