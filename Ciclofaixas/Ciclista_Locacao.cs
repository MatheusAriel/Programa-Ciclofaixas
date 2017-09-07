using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    class Ciclista_Locacao
    {
        private string data;
        private string hora_locacao;
        private Pessoa pessoa;
        private Bicicletas bicicleta;

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Hora_locacao
        {
            get
            {
                return hora_locacao;
            }

            set
            {
                hora_locacao = value;
            }
        }

        internal Pessoa Pessoa
        {
            get
            {
                return pessoa;
            }

            set
            {
                pessoa = value;
            }
        }

        internal Bicicletas Bicicleta
        {
            get
            {
                return bicicleta;
            }

            set
            {
                bicicleta = value;
            }
        }

        public Ciclista_Locacao()
        {

        }

        public Ciclista_Locacao(string data, string hora_locacao, Pessoa pessoa, Bicicletas bicicleta)
        {
            this.data = data;
            this.hora_locacao = hora_locacao;
            this.pessoa = pessoa;
            this.bicicleta = bicicleta;
        }
    }
}
