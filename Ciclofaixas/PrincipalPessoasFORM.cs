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
    public partial class PrincipalPessoasFORM : Form
    {
        List<Fisica> listaF;
        List<Juridica> listaJ;
        public PrincipalPessoasFORM()
        {
            InitializeComponent();
        }



        private void btncadastrarPessoa_Click(object sender, EventArgs e)
        {
            CadastrarPessoaFORM pessoa = new CadastrarPessoaFORM();
            pessoa.ShowDialog();
        }

        private void PrincipalPessoasFORM_Load(object sender, EventArgs e)
        {
            FisicaDAO pf = new FisicaDAO();
            JuridicaDAO pj = new JuridicaDAO();

            List<Fisica> lf = new List<Fisica>();
            List<Juridica> lj = new List<Juridica>();

            lf = pf.ListaTodos();
            dtgFisica.DataSource = lf;

            lj = pj.ListaTodos();
            dtgJuridica.DataSource = lj;
        }


        private void btnEditarPessoasFisica_Click(object sender, EventArgs e)
        {
            if (dtgFisica.SelectedRows.Count > 0)
            {
                FisicaDAO f = new FisicaDAO();
                using (CadastrarPessoaFORM finc = new CadastrarPessoaFORM())
                {
                    finc.id = dtgFisica.CurrentRow.Cells[3].Value.ToString();
                    finc.modo = "EditaFisica";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        listaF = f.ListaTodos();
                        dtgFisica.DataSource = listaF;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionado!");
            }
        }

        private void btnRemoverPessoaFisica_Click(object sender, EventArgs e)
        {
            if (dtgFisica.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir essa pessoa?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    FisicaDAO f = new FisicaDAO();
                    string id = dtgFisica.CurrentRow.Cells[3].Value.ToString();
                    f.Remover(id);
                    listaF = f.ListaTodos();
                    dtgFisica.DataSource = listaF;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionada!");
            }
        }

        private void btnPesquisarPessoaFisica_Click(object sender, EventArgs e)
        {
            FisicaDAO f = new FisicaDAO();
            List<Fisica> listaF;
            string where = "";
            if (txtbPesquisaPessoaFisica.Text != "")
            {
                where = "and p.nome like " + "'%" + txtbPesquisaPessoaFisica.Text + "%'";
            }


            listaF = f.SelecionaFisicaNome(where);
            dtgFisica.DataSource = listaF;
        }

        private void btnEditarPessoJuridica_Click(object sender, EventArgs e)
        {
            if (dtgJuridica.SelectedRows.Count > 0)
            {
                JuridicaDAO f = new JuridicaDAO();
                using (CadastrarPessoaFORM finc = new CadastrarPessoaFORM())
                {
                    finc.id = dtgJuridica.CurrentRow.Cells[1].Value.ToString();
                    finc.modo = "EditaJuridica";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        listaJ = f.ListaTodos();
                        dtgJuridica.DataSource = listaJ;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionado!");
            }
        }

        private void btnRemoverPessoaJuridica_Click(object sender, EventArgs e)
        {
            if (dtgJuridica.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir essa pessoa?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    JuridicaDAO j = new JuridicaDAO();
                    string id = dtgJuridica.CurrentRow.Cells[1].Value.ToString();
                    j.Remover(id);
                    listaJ = j.ListaTodos();
                    dtgJuridica.DataSource = listaJ;
                }
            }
            else
            {
                MessageBox.Show("Nenhuma pessoa selecionada!");
            }
        }

        private void btnPesquisarPessoaJuridica_Click(object sender, EventArgs e)
        {
            JuridicaDAO j = new JuridicaDAO();
            List<Juridica> listaJ;
            string where = "";
            if (txtbPesquisaPessoaJuridica.Text != "")
            {
                where = "and p.nome like " + "'%" + txtbPesquisaPessoaJuridica.Text + "%'";
            }


            listaJ = j.SelecionaJuridicaNome(where);
            dtgJuridica.DataSource = listaJ;
        }
    }
}
