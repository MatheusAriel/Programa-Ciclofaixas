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
    public partial class PrincipalEstacoesFORM : Form
    {
        List<Estacoes> ListE;
        public PrincipalEstacoesFORM()
        {
            InitializeComponent();
        }

        private void btnCadastrarEstacoes_Click(object sender, EventArgs e)
        {
            CadastrarEstacoesFORM estacao = new CadastrarEstacoesFORM();
            estacao.ShowDialog();
        }

        private void btnEditarEstacao_Click(object sender, EventArgs e)
        {
            if (dtgEstacoes.SelectedRows.Count > 0)
            {
                EstacoesDAO er = new EstacoesDAO();
                using (CadastrarEstacoesFORM finc = new CadastrarEstacoesFORM())
                {
                    finc.id = dtgEstacoes.CurrentRow.Cells[0].Value.ToString();
                    finc.modo = "EditaEstacao";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        ListE = er.ListaTodos();
                        dtgEstacoes.DataSource = ListE;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionado!");
            }
        }

        private void PrincipalEstacoesFORM_Load(object sender, EventArgs e)
        {
            EstacoesDAO ed = new EstacoesDAO();
            List<Estacoes> le = new List<Estacoes>();

            le = ed.ListaTodos();
            dtgEstacoes.DataSource = le;
        }

        private void btnRemoverEstacao_Click(object sender, EventArgs e)
        {
            if (dtgEstacoes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir essa estação?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    EstacoesDAO er = new EstacoesDAO();
                    string id = dtgEstacoes.CurrentRow.Cells[0].Value.ToString();
                    er.Remover(id);
                    ListE = er.ListaTodos();
                    dtgEstacoes.DataSource = ListE;
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnPesquisaEstacao_Click(object sender, EventArgs e)
        {
            EstacoesDAO er = new EstacoesDAO();
            List<Estacoes> ListE;
            string where = "";
            if (txtbPesquisaEstacao.Text != "")
            {
                where = "nome like " + "'%" + txtbPesquisaEstacao.Text + "%'";
            }


            ListE = er.SelecionaEstacaoNomeWhere(where);
            dtgEstacoes.DataSource = ListE;
        }
    }
}
