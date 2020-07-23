using System;
using System.Net.Http;

namespace DemoClientRestModel
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoClientRestModel demoClientRestModel = new DemoClientRestModel();
            HttpResponseMessage httpResponseMessage = demoClientRestModel.Demo1().Result;

            Console.WriteLine("status code: " + httpResponseMessage.StatusCode);

            Console.WriteLine("IsSucessStatusCode : " + httpResponseMessage.IsSuccessStatusCode);
            var result = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Console.WriteLine("Result : " + result);
            Console.ReadLine();

        }
    }
}
