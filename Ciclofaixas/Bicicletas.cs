using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
    class Bicicletas
    {
        private int codigo_bicicleta;
        private string cor;
        private string modelo;
        private Estacoes estacoes;

        public Bicicletas()
        {

        }

        public Bicicletas(int codigo_bicicleta, string cor, string modelo, Estacoes estacoes)
        {
            this.codigo_bicicleta = codigo_bicicleta;
            this.cor = cor;
            this.modelo = modelo;
            this.estacoes = estacoes;
        }

        public int Codigo_bicicleta
        {
            get
            {
                return codigo_bicicleta;
            }

            set
            {
                codigo_bicicleta = value;
            }
        }

        public string Cor
        {
            get
            {
                return cor;
            }

            set
            {
                cor = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        internal Estacoes Estacoes
        {
            get
            {
                return estacoes;
            }

            set
            {
                estacoes = value;
            }
        }
    }
}
