using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<string>();
            lista.Add("banana");
            lista.Add("pera");
            lista.Add("maça");

            lista.Remove("banana");

            string item = lista[1];

            var fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(2);

            var resultado = fila.Dequeue();

            var dicionario = new Dictionary<string, int>();
            dicionario.Add("Primeiro", 1);
            dicionario.Add("Segundo", 2);

            var item1 = dicionario["Primeiro"]; //Retorna 1

            LinkedList<int> listaLigada = new LinkedList<int>();

            var col = new MyCollection<string>();
            col.Add("banana");


        }

        class MyCollection<T> 
        {
            private List<T> listaInterna;

            public MyCollection()
            { 
                listaInterna = new List<T>();
            }

            public void Add(T item)
            {
                listaInterna.Add(item);
            
            }

   

        
        }

    }
}
