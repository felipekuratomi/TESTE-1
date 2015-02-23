using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2Demo
{
    //public delegate bool Predicado(string text);

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "banana","abacate","maça","laranja","pera"
            };

           // var predicado = new Predicado(TextoComMaisDoQue5Caracteres);

            var listaFiltrada = Filtrar(list, t=>t.Length >5);

        }

        //public static bool TextoComMaisDoQue5Caracteres(string texto)
        //{
        //    if (texto.Length > 5)
        //    {
        //        return true;
        //    }
        //    return false;
        
        //}




        public static List<string> Filtrar(List<string> textos, Predicate<string> predicado)
        {
            List<string> retorno = new List<string>();
            foreach (var texto in textos)
            {
                if (predicado(texto))
                {
                    retorno.Add(texto);
                }

            }

            return retorno;


        }

    }
}
