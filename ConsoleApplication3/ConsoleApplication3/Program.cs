using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    enum Dia
    { 
        Domingo,
        Segunda,
        Terca
    }



    class Program
    {
        static void Main(string[] args)
        {
            Processar(Dia.Segunda);
        }
        static void Processar(Dia dia)
        {
            switch (dia)
            {
                case Dia.Domingo:
                    break;
                case Dia.Segunda:
                    break;
                case Dia.Terca:
                    break;
                default:
                    break;
            }

        }
    }
}
