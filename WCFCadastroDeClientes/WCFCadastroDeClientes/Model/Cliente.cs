using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFCadastroDeClientes.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
    }
}