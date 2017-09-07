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
    public partial class CadastrarBicicletasFORM : Form
    {
        public string id, modo;
        public CadastrarBicicletasFORM()
        {
            InitializeComponent();
        }

        private void btnCadastraEstacoes_Click(object sender, EventArgs e)
        {
            CadastrarEstacoesFORM estacao = new CadastrarEstacoesFORM();
            estacao.Show();
        }

        public void atualizaDataGridComboBox()
        {
            EstacoesDAO eDAO = new EstacoesDAO();
            cmbSelecionaEstacao.DataSource = eDAO.ListaTodos();
            cmbSelecionaEstacao.DisplayMember = "nome";

            dtgEstacoes.DataSource = eDAO.ListaTodos();
        }

        private void btnAtualizaEstacoes_Click(object sender, EventArgs e)
        {
            atualizaDataGridComboBox();
        }

        private void CadastrarBicicletasFORM_Load(object sender, EventArgs e)
        {

            int CODIGO_BICICLETA = 0;
            string MODELO = txtbModelo.Text;
            string COR = txtbCor.Text;
            if (modo == "EditaBicicleta")
            {

               
                Estacoes es = new Estacoes();
                EstacoesDAO eDAO = new EstacoesDAO();
                es = eDAO.SelecionaEstacaoNome(cmbSelecionaEstacao.Text);
                BicicletasDAO bDAO = new BicicletasDAO();
                bDAO.Editar(new Bicicletas(CODIGO_BICICLETA, COR, MODELO,es), id);
                this.Close();

            }
        }

        private void txtbCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbCor.Focus();
                e.Handled = true;

            }
        }

        private void btnCadastrarBicicletas_Click(object sender, EventArgs e)
        {
            int CODIGO_BICICLETA = 0;
            string MODELO = txtbModelo.Text;
            string COR = txtbCor.Text;

            if (modo == "EditaBicicleta")
            {
                
                Estacoes et= new Estacoes();
                EstacoesDAO eDAO = new EstacoesDAO();
                et = eDAO.SelecionaEstacaoNome(cmbSelecionaEstacao.Text);
                BicicletasDAO bDAO = new BicicletasDAO();
                bDAO.Editar(new Bicicletas(CODIGO_BICICLETA, COR, MODELO, et), id);
                this.Close();

            }


            else if (txtbCor.Text == "" || txtbModelo.Text == "")
            {
                MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {

                Estacoes er = new Estacoes();
                EstacoesDAO eDAO = new EstacoesDAO();
                er = eDAO.SelecionaEstacaoNome(cmbSelecionaEstacao.Text);
                BicicletasDAO bDAO = new BicicletasDAO();
                bDAO.Inserir(new Bicicletas(CODIGO_BICICLETA, COR, MODELO, er));
                this.Close();
            }
            

        }
    }
}
