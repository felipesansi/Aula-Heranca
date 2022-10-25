using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    internal class Fisica: Pessoa
    {
        public string Cpf { get; set; }
        public string Data_nascimento { get; set; }

        public Fisica(string nome, string endereco, string telefone, string email, string cpf, string data_ns ): base(nome,endereco, telefone, email)
        {
            this.Cpf = cpf;
            this.Data_nascimento = data_ns;
        }
    }
}
