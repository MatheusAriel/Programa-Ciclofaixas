using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    sealed class Museus : Atracoes
    {
        private string tipo;
        private double preco_entrada;

        public Museus()
        {

        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public double Preco_entrada
        {
            get
            {
                return preco_entrada;
            }

            set
            {
                preco_entrada = value;
            }
        }

        public Museus(int codigo_atracoes, string hora_abertura, string hora_fechamento, string nome, string rua, string bairro, string numero, string cep, string telefone, Ciclofaixas ciclofaixa, string tipo, double preco_entrada)
            : base(codigo_atracoes, hora_abertura, hora_fechamento, nome, rua, bairro, numero, cep, telefone, ciclofaixa)
        {
            this.tipo = tipo;
            this.preco_entrada = preco_entrada;
        }
    }
}
