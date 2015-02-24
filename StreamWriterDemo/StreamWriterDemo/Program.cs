using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "blablabla";

            texto=texto.Capitalizar();

            Console.WriteLine(texto);
            Console.Read();
        }
    }
}
