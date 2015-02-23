using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(); //Não é fortemente dipada, não é mais utilizada
            list.Add(120);
            list.Add("banana");
            list.Add(DateTime.Now);

            var item = list[0];
            int a = (int)list[0];

            Hashtable list2 = new Hashtable(); //Não é fortemente dipada, não é mais utilizada
            list2.Add("Nome", "Fulano");
            list2.Add("Nome", 32);
            list2.Add(20, 100);

            Queue fila = new Queue(); // Fila, não recomendada
            fila.Enqueue("banana");
            fila.Enqueue(120);

            var coisa = (string)fila.Dequeue(); //Tem que realizar um cast

            //Stack pilha = new Stack();
            //pilha.Push("Banana");

            //string outraCoisa = (string)pilha... 

        }
    }
}
