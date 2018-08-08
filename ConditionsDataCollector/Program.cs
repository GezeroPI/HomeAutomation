using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ConditionsDataCollector.Models;
using Newtonsoft.Json;

namespace ConditionsDataCollector
{
    public class Program
    {
        static HttpClient client = new HttpClient();

        static async void GetData()
        {
            string _url = "https://localhost:44355";
            
            var client = new RestClient(_url);
            client.AddDefaultHeader("Authorization", string.Format("Bearer {0}", _token));
            var request = new RestRequest(string.Format("delete/{0}", id), Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = client.Execute(request);
            JToken data = JToken.Parse(response.Content);
        }
        static void Main(string[] args)
        {
            DateTime localDate = DateTime.Now;
            Console.WriteLine($"Migration starting... {localDate}");
            try
            {
                var alarm = new Alarm();
                var condition = new Condition();
                GetData();
                //Inserting and saves data in DB
                using (var context = new ApplicationDBContext())
                {
                    context.Add(alarm);
                    context.Add(condition);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Migration failed... {e}");
            }
            DateTime localDate2 = DateTime.Now;
            Console.WriteLine($"Migration finished... {localDate2}");
        }
    }
}
