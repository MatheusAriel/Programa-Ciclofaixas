using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
     sealed class Juridica:Pessoa
    {
        private string cnpj;

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public Juridica(int id_pessoa, string nome, string rua, string bairro, string numero, string cep, string cidade, string estado, string email, string telefone, string cnpj)
            :base(id_pessoa, nome, rua, bairro, numero, cep, cidade, estado, email, telefone)
        {
            this.cnpj = cnpj;
        }

        public Juridica()
        {

        }

        
    }
}
