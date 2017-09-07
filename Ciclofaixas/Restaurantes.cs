using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    sealed class Restaurantes : Atracoes
    {
        private string tipo;

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

        public Restaurantes(int codigo_atracoes, string hora_abertura, string hora_fechamento, string nome, string rua, string bairro, string numero, string cep, string telefone, Ciclofaixas ciclofaixa, string tipo)
            :base(codigo_atracoes, hora_abertura, hora_fechamento, nome, rua, bairro, numero, cep, telefone, ciclofaixa)
        {
            this.tipo = tipo;
        }

        public Restaurantes()
        {

        }

        
    }
}
