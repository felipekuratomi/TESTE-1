using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceConfiguration config = new ServiceConfiguration()
            {
                ApplicationDataPath = @"D:\Data",
                ConfigName = "Teste",
                DatabaseHostName = "host1"

            };
            Serialize(config);
            var config2 = Deserialize();
        }
        static void Serialize(ServiceConfiguration config)
        {
            var jsonSerializer = new DataContractJsonSerializer(config.GetType());
            FileStream buffer = File.Create("E:\\config.json");
            jsonSerializer.WriteObject(buffer,config);
            buffer.Close();
        

        }

        static ServiceConfiguration Deserialize()
        {
            var jsonSerializer = new DataContractJsonSerializer(typeof(ServiceConfiguration));
            FileStream buffer = File.OpenRead("E:\\config.json");
            var config = jsonSerializer.ReadObject(buffer) as ServiceConfiguration;
            buffer.Close();
            return config;
        }
    
    
    }
}
