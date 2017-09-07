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
    public partial class PrincipalBicicletasFORM : Form
    {
        List<Bicicletas> listaB;
        public PrincipalBicicletasFORM()
        {
            InitializeComponent();
        }

        private void btnCadastrarBicicletas_Click(object sender, EventArgs e)
        {
            CadastrarBicicletasFORM bike = new CadastrarBicicletasFORM();
            bike.ShowDialog();
        }

        private void btnEditarBicicletas_Click(object sender, EventArgs e)
        {
            if (dtgBicicletas.SelectedRows.Count > 0)
            {
                BicicletasDAO b = new BicicletasDAO();
                using (CadastrarBicicletasFORM finc = new CadastrarBicicletasFORM())
                {
                    finc.id = dtgBicicletas.CurrentRow.Cells[0].Value.ToString();
                    finc.modo = "EditaBicicleta";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        listaB = b.ListaTodos();
                        dtgBicicletas.DataSource = listaB;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma bicicleta selecionado!");
            }
        }

        private void PrincipalBicicletasFORM_Load(object sender, EventArgs e)
        {
            BicicletasDAO bDAO = new BicicletasDAO();
            List<Bicicletas> lb = new List<Bicicletas>();

            lb = bDAO.ListaTodos();
            dtgBicicletas.DataSource = lb;

            
        }

        private void btnRemoverBicicletas_Click(object sender, EventArgs e)
        {
            if (dtgBicicletas.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir essa bicicleta?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BicicletasDAO b = new BicicletasDAO();
                    string id = dtgBicicletas.CurrentRow.Cells[0].Value.ToString();
                    b.Remover(id);
                    listaB = b.ListaTodos();
                    dtgBicicletas.DataSource = listaB;
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnPesquisarBicicletas_Click(object sender, EventArgs e)
        {
            BicicletasDAO b = new BicicletasDAO();
            List<Bicicletas> ListB;
            string where = "";
            if (txtbPesquisaBicicletas.Text != "")
            {
                where = " and modelo like " + "'%" + txtbPesquisaBicicletas.Text + "%'";
            }


            ListB = b.SelecionaBicicletaModelo(where);
            dtgBicicletas.DataSource = ListB;
        }
    }
}
