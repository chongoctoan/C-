using ConsoleApp1.btvn5;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.btvn4
{
    public class CallApiWeather
    {
        public async Task<ApiWeather> WetherData()
        {

            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                ApiWeather a = JsonConvert.DeserializeObject<ApiWeather>(responseText);
                return a;

            }

            return null;
        }
    }
}
