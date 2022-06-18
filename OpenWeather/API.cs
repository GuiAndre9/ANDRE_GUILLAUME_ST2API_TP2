using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
        
        public class Api
        {
            public async Task<Root> Request(City city)
            {
                var client = new HttpClient();

                var request = new System.Net.Http.HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri =
                        new Uri("https://api.openweathermap.org/data/2.5/weather?q={city.name}&appid=5369a438fbd27caaeee463405bea57bb")
                };
                using var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                Root data = JsonConvert.DeserializeObject<Root>(json);
                return data;
            }
        }
    }
