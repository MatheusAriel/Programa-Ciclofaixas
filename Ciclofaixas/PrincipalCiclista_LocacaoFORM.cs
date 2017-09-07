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
    public partial class PrincipalCiclista_LocacaoFORM : Form
    {
        List<Ciclista_Locacao> listaCL;

        public PrincipalCiclista_LocacaoFORM()
        {
            InitializeComponent();
        }

        private void btnRealizaLocacao_Click(object sender, EventArgs e)
        {
            CadastrarCiclista_LocacaoFORM cl = new CadastrarCiclista_LocacaoFORM();
            cl.ShowDialog();
        }

        private void PrincipalCiclista_LocacaoFORM_Load(object sender, EventArgs e)
        {
            List<Ciclista_Locacao> Listcl = new List<Ciclista_Locacao>();
            Ciclista_locacaoDAO clDao = new Ciclista_locacaoDAO();
            Listcl = clDao.ListaTodos();
            dtgLocacoes.DataSource = listaCL;
            




        }

        private void btnPesquisarPessoa_Click(object sender, EventArgs e)
        {
            FisicaDAO f = new FisicaDAO();
            List<Fisica> ListaCL;
            string where = "";
            if (txtbPesquisaPessoa.Text != "")
            {
                where = "and p.nome like " + "'%" + txtbPesquisaPessoa.Text + "%'";
            }

            ListaCL = f.SelecionaFisicaNome(where);
            dtgLocacoes.DataSource = ListaCL;
        }
    
    }
}
