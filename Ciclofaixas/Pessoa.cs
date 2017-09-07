using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    abstract class Pessoa
    {
        private int id_pessoa;
        private string nome;
        private string rua;
        private string bairro;
        private string numero;
        private string cep;
        private string cidade;
        private string estado;
        private string email;
        private string telefone;




        public Pessoa()
        {

        }

        public int Id_pessoa
        {
            get
            {
                return id_pessoa;
            }

            set
            {
                id_pessoa = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }

            set
            {
                cidade = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public Pessoa(int id_pessoa, string nome, string rua, string bairro, string numero, string cep, string cidade, string estado, string email, string telefone)
        {
            this.id_pessoa = id_pessoa;
            this.nome = nome;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.email = email;
            this.telefone = telefone;
        }



    }
}
