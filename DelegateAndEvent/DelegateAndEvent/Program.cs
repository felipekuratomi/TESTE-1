using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    public delegate int Calcular(int x, int y); // ponteiro de função, muito utilizado

    class Program
    {
        
        static void Main(string[] args)
        {
            //Calcular add =new Calcular(Adicionar);
            //var resultado = add(2, 2);

            //Calcular mult = new Calcular(Multiplicar);
            //var resultado2 = mult(2, 2);

            Calcular add = new Calcular(Adicionar);
            Calcular mult = new Calcular(Multiplicar);
            var resultado1 = Processar(add);
            var resultado2 = Processar(mult);


        }

        public static int Adicionar(int x, int y)
        {
            return x + y;
        }

        public static int Multiplicar(int a, int b)
        {

            return a * b;
        }

        public static int Processar(Calcular calc)
        {
            return calc(3, 3);
        }




    }
}
