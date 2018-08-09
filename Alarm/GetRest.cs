using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Alarm
{
    public static class GetRest
    {
        public static async Task<bool> GetResponseAsync(string uri)
        {
            using (var client = new HttpClient())
            {
                bool status;
                var result = await client.GetAsync(uri);
                var response = await result.Content.ReadAsStringAsync();
                if (response.Contains("200"))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                return status;
            }
        }
    }
}
