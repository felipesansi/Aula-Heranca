using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string  Endereco { get; set; }
        public string Telefone { get; set; }
         public string Email { get; set; }

        public Pessoa (string nome, string endereco, string telefone, string email)
        {
           this. Nome = nome;
           this. Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}
