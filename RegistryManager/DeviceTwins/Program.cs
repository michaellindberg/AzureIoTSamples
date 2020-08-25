using System;
using Microsoft.Azure.Devices;
using Newtonsoft.Json;

namespace DeviceTwins
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryManager registryManager = RegistryManager.CreateFromConnectionString("<connection string>");

            var query = registryManager.CreateQuery("SELECT * FROM devices");
            var result = query.GetNextAsTwinAsync().Result;

            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
