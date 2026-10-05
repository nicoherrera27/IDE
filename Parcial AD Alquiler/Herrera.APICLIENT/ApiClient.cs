using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herrera.APIClients
{
    public static class ApiClient
    {
        public static readonly HttpClient Http = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:5183/")
        };
    }
}
