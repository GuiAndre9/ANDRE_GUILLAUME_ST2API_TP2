using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class Api
    {
        private async Task<string> Request(City city)
        {
            var client = new HttpClient();

            var request = new System.Net.Http.HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri =
                    new Uri("https://api.openweathermap.org/data/2.5/weather?q={city.name}&appid=dc30fe9f8626b0e1dcdb24030931d64c")
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();
                Root data = JsonConvert.DeserializeObject<Root>(json);
                return data;
            }
        }
    }
}
