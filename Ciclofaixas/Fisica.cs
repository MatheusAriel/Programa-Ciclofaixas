using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    sealed class Fisica : Pessoa
    {
        private string cpf;
        private string rg;
        private string data_nasc;

        public Fisica()
        {

        }

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }

        public string Rg
        {
            get
            {
                return rg;
            }

            set
            {
                rg = value;
            }
        }

        public string Data_nasc
        {
            get
            {
                return data_nasc;
            }

            set
            {
                data_nasc = value;
            }
        }
       

        public Fisica(int id_pessoa, string nome, string rua, string bairro, string numero, string cep, string cidade, string estado, string email, string telefone, string cpf, string rg, string data_nasc)
            :base(id_pessoa, nome, rua, bairro, numero, cep, cidade, estado, email, telefone)
        {
            this.cpf = cpf;
            this.rg = rg;
            this.data_nasc = data_nasc;
        }

        public Fisica(int id_pessoa, string nome, string rua, string bairro, string numero, string cep, string cidade, string estado, string email, string telefone)
            :base (id_pessoa, nome, rua, bairro, numero, cep, cidade, estado, email, telefone)
        {
         
        }







    }
}
