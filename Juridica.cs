using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Juridica:Pessoa
    {
        public Juridica(string nome, string endereco, string telefone, string email, string fantasia, string cnpj) : base(nome, endereco, telefone, email)
        {
            this.Fantasia = fantasia;
            this.Cnpj = cnpj;
        }
        public string Fantasia { get; set; }
        public string Cnpj { get; set; }

     

    }
}
