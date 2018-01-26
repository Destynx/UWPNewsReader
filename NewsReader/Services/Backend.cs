using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NewsReader.Model;
using Newtonsoft.Json;

namespace NewsReader.Services
{
    static class Backend
    {
        public static async Task<RootObject> GetDataFromBackendAsync()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("http://inhollandbackend.azurewebsites.net/api/Articles");
                return JsonConvert.DeserializeObject<RootObject>(json);
            }
        }
    }
}
