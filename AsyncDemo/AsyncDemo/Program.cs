using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static async void Main(string[] args)
        {
            var client = new HttpClient();
            string result = await client.GetStringAsync("http://www.uol.com.br");
            
            Console.WriteLine(result);
        }
    }
}
