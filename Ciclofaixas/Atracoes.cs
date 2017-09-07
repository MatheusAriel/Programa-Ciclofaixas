using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ciclofaixas
{
    abstract class Atracoes
    {
        private int codigo_atracoes;
        private string hora_abertura;
        private string hora_fechamento;
        private string nome;
        private string rua;
        private string bairro;
        private string numero;
        private string cep;
        private string telefone;
        private Ciclofaixas ciclofaixa;

       

        public int Codigo_atracoes
        {
            get
            {
                return codigo_atracoes;
            }

            set
            {
                codigo_atracoes = value;
            }
        }

        public string Hora_abertura
        {
            get
            {
                return hora_abertura;
            }

            set
            {
                hora_abertura = value;
            }
        }

        public string Hora_fechamento
        {
            get
            {
                return hora_fechamento;
            }

            set
            {
                hora_fechamento = value;
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

        internal Ciclofaixas Ciclofaixa
        {
            get
            {
                return ciclofaixa;
            }

            set
            {
                ciclofaixa = value;
            }
        }

        public Atracoes()
        { }

        public Atracoes(int codigo_atracoes, string hora_abertura, string hora_fechamento, string nome, string rua, string bairro, string numero, string cep, string telefone, Ciclofaixas ciclofaixa)
        {
            this.codigo_atracoes = codigo_atracoes;
            this.hora_abertura = hora_abertura;
            this.hora_fechamento = hora_fechamento;
            this.nome = nome;
            this.rua = rua;
            this.bairro = bairro;
            this.numero = numero;
            this.cep = cep;
            this.telefone = telefone;
            this.ciclofaixa = ciclofaixa;
        }










    }
}
