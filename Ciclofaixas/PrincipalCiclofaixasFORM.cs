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
    public partial class PrincipalCiclofaixasFORM : Form
    {
        List<Ciclofaixas> listaC;
        public PrincipalCiclofaixasFORM()
        {
            InitializeComponent();
        }

        private void btnCadastrarCiclofaixas_Click(object sender, EventArgs e)
        {
            CadastrarCiclofaixasFORM cilofaixa = new CadastrarCiclofaixasFORM();
            cilofaixa.ShowDialog();
        }

        private void PrincipalCiclofaixasFORM_Load(object sender, EventArgs e)
        {
            CiclofaixasDAO cd = new CiclofaixasDAO();
            List<Ciclofaixas> lc = new List<Ciclofaixas>();

            lc = cd.ListaTodos();
            dtgCiclofaixas.DataSource = lc;

        }

        private void btnEditarCiclofaixas_Click(object sender, EventArgs e)
        {
            if (dtgCiclofaixas.SelectedRows.Count > 0)
            {
                CiclofaixasDAO c = new CiclofaixasDAO();
                using (CadastrarCiclofaixasFORM finc = new CadastrarCiclofaixasFORM())
                {
                    finc.id = dtgCiclofaixas.CurrentRow.Cells[0].Value.ToString();
                    finc.modo = "EditaCiclofaixa";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        listaC = c.ListaTodos();
                        dtgCiclofaixas.DataSource = listaC;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionado!");
            }
        }

        private void btnRemoverCiclofaixas_Click(object sender, EventArgs e)
        {

            if (dtgCiclofaixas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir essa Ciclofaixa?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CiclofaixasDAO c = new CiclofaixasDAO();
                    string id = dtgCiclofaixas.CurrentRow.Cells[0].Value.ToString();
                    c.Remover(id);
                    listaC = c.ListaTodos();
                    dtgCiclofaixas.DataSource = listaC;
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnPesquisaCiclofaixas_Click(object sender, EventArgs e)
        {
            CiclofaixasDAO c = new CiclofaixasDAO();
            List<Ciclofaixas> listaC;
            string where = "";
            if (txtbPesquisaCiclofaixas.Text != "")
            {
                where = " WHERE nome like " + "'%" + txtbPesquisaCiclofaixas.Text + "%'";
            }


            listaC = c.SelecionaCiclofaixaNomeWhere(where);
            dtgCiclofaixas.DataSource = listaC;
        }
    }
}
