using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclofaixas
{
    public partial class PrincipalFORM : Form
    {
        public PrincipalFORM()
        {
            InitializeComponent();
        }

        private void btnCadastrarAtracoes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPessoas_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCiclofaixas_Click(object sender, EventArgs e)
        {
            PrincipalCiclofaixasFORM ciclofaixa = new PrincipalCiclofaixasFORM();
            ciclofaixa.ShowDialog();
        }

        private void btnEstacoes_Click(object sender, EventArgs e)
        {
            PrincipalEstacoesFORM estacao = new PrincipalEstacoesFORM();
            estacao.ShowDialog();
        }

        private void btnBicicletas_Click(object sender, EventArgs e)
        {
            PrincipalBicicletasFORM bike = new PrincipalBicicletasFORM();
            bike.ShowDialog();
        }

        private void btnLocacoes_Click(object sender, EventArgs e)
        {
            PrincipalCiclista_LocacaoFORM cl = new PrincipalCiclista_LocacaoFORM();
            cl.ShowDialog();
        }

        private void btnAtracoes_Click(object sender, EventArgs e)
        {
            PrincipalAtracoesFORM formatra = new PrincipalAtracoesFORM();
            formatra.ShowDialog();
        }

        private void btnPessoas_Click_1(object sender, EventArgs e)
        {
            PrincipalPessoasFORM pessoa = new PrincipalPessoasFORM();
            pessoa.ShowDialog();
        }
    }
}
