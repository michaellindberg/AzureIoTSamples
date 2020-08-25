using System;
using Microsoft.Azure.Devices;
using Newtonsoft.Json;

namespace DeviceTwins
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryManager registryManager = RegistryManager.CreateFromConnectionString("HostName=ambiantgroup-iothub-dev.azure-devices.net;SharedAccessKeyName=iothubowner;SharedAccessKey=s+ShoUvRo+GYGFKqEwI4KG8+TNQ+T2VHnXYkWqfF8Xw=");

            var query = registryManager.CreateQuery("SELECT * FROM devices");
            var result = query.GetNextAsTwinAsync().Result;

            Console.WriteLine(JsonConvert.SerializeObject(result));
        }
    }
}
