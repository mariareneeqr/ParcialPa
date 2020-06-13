using System;
using System.Collections.Generic;
using System.Text;

namespace AppPa2.Services
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Plugin.Connectivity;
    public class ApiService
    {
        public async Task<List<T>> Get<T>(
           string urlBase,
           string servicePrefix,
           string controller,
           string tokenType,
           string accessToken
           )
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    tokenType, accessToken);
                client.BaseAddress = new Uri(urlBase);
                var url = string.Format("{0}{1}", servicePrefix, controller);
                var response = await client.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }
                var result = await response.Content.ReadAsStringAsync();
                var list = JsonConvert.DeserializeObject<List<T>>(result);
                return list;
            }
            catch
            {
                return null;
            }
        }

        internal Task Get<T>(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}
