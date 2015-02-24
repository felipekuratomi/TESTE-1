using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CadastroDeClientes.Model
{
    public class ClientesContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }


    }
}
