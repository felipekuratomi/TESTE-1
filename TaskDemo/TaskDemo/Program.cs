using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var task1 = new Task(() => Console.WriteLine("Hefalsndfm"));
            //var task2 = new Task(() => Console.WriteLine("World"));
            //var task3 = Task.Factory.StartNew(() => Console.WriteLine("Bla"));
            //var task4 = Task.Run(() => Console.WriteLine("asdfasdfasd"));
            
            //task1.Start();
            //task2.Start();

            //task1.ContinueWith (antecedent => Console.WriteLine("Acabou!"));

            var task1 = Task.Run<string>(() => DateTime.Now.DayOfWeek.ToString());

            var resultado = task1.Result;

            Console.WriteLine(resultado);

            Console.Read();
        }
    }
}
