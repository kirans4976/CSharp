using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoClientRestModel
{
    internal class DemoClientRestModel
    {
        private readonly string baseUrl = "https://localhost:44331/api/demo/";

        public Task<HttpResponseMessage> Demo1()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                return client.GetAsync("demo1");

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
