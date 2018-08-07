using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    static class ApiComm
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<PirSensor> GetProductAsync(string path)
        {
            var sensor = new PirSensor();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                sensor = JsonConvert.DeserializeObject<PirSensor>(data);
            }
            return sensor;
        }

    }
}
