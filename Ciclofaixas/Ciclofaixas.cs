using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclofaixas
{
     sealed class Ciclofaixas
    {
        private int codigoCiclofaixa;
        private string nome;
        private string cep_inicial;
        private string cep_final;
        private double tamanho;
       

        public int CodigoCiclofaixa
        {
            get
            {
                return codigoCiclofaixa;
            }

            set
            {
                codigoCiclofaixa = value;
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

        public string Cep_inicial
        {
            get
            {
                return cep_inicial;
            }

            set
            {
                cep_inicial = value;
            }
        }

        public string Cep_final
        {
            get
            {
                return cep_final;
            }

            set
            {
                cep_final = value;
            }
        }

        public double Tamanho
        {
            get
            {
                return tamanho;
            }

            set
            {
                tamanho = value;
            }
        }

        

        public Ciclofaixas(int codigoCiclofaixa, string nome, string cep_inicial, string cep_final, double tamanho)
        {
            this.codigoCiclofaixa = codigoCiclofaixa;
            this.nome = nome;
            this.cep_inicial = cep_inicial;
            this.cep_final = cep_final;
            this.tamanho = tamanho;
            
        }

        public Ciclofaixas()
        {

        }
    }
}
