using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo_2
{
    public delegate void MyEventHandler(string text);
    class Program
    {
        public static event MyEventHandler DigaOla;

        static void Main(string[] args)
        {
            DigaOla += ExibirMensagem; // Me inscrevendo
            DigaOla +=Program_DigaOla;

            
            OnDigaOla("Fulano");
        }

        public static void OnDigaOla(string nome)
        {
            var handler = DigaOla;
            if (handler != null)
            {
                handler.Invoke(nome);
            }
        }




        static void Program_DigaOla(string text)
        {
            throw new NotImplementedException();
        }


        public static void ExibirMensagem(string nome)
        {
            Console.WriteLine("Olá" + nome);
        
        }

    }
}
