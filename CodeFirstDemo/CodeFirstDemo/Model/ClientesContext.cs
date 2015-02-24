using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    public class ClientesContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } //DbSet é uma Collection

        public DbSet<Pedido> Pedidos { get; set; }

    }
}
