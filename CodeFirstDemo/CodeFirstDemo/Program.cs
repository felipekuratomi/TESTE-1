using CodeFirstDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ClientesContext();

            var clientes = from c in context.Clientes
                           where c.Nome == "Fulana"
                           select c;





            foreach (var cliente in clientes) 
            {
                Console.WriteLine("Nome:{0} , Sobrenome: {1}, Idade: {2}",
                        cliente.Nome,
                        cliente.Sobrenome,
                        cliente.Idade);
            }

            var novoCliente = new Cliente
            {
                Nome = "Jose",
                Sobrenome = "Da Silva",
                Idade = 23
            };
            context.Clientes.Add(novoCliente);

            //var primeiroCliente = context.Clientes.First();
            //primeiroCliente.Nome = "José";
            //context.Entry(primeiroCliente).State = EntityState.Modified; // Falar q mudou
            
            //context.Clientes.Remove(primeiroCliente);
            
            context.SaveChanges(); // Salvar Aletrações


        }
    }
}
