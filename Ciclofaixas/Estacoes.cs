using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    class Estacoes
    {
        private int codigo_estacao;
        private string nome;
        private string rua;
        private string bairro;
        private string numero;
        private string cep;        
        private string telefone;

        public int Codigo_estacao
        {
            get
            {
                return codigo_estacao;
            }

            set
            {
                codigo_estacao = value;
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

        public Estacoes(int codigo_estacao, string nome, string rua, string bairro, string numero, string cep, string telefone)
        {
            this.codigo_estacao = codigo_estacao;
            this.nome = nome;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.cep = cep;
            this.telefone = telefone;
        }

        public Estacoes()
        {

        }
    }
}
