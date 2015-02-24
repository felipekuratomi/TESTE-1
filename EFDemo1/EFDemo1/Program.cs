using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Model1Container();
            var clientes = from c in context.Clientes
                        select c;




            foreach (var cliente in clientes)
            {
                Console.WriteLine("Nome:{0} , Sobrenome: {1}, Idade: {2}, Nome Completo: {3}", 
                        cliente.Nome,
                        cliente.Sobrenome,
                        cliente.Idade,
                        cliente.NomeCompleto);           
             
            }

        }
    }
}
