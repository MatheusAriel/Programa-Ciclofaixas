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
    public partial class CadastrarEstacoesFORM : Form
    {
        public string modo, id;
        public CadastrarEstacoesFORM()
        {
            InitializeComponent();
        }

        private void CadastrarEstacoesFORM_Load(object sender, EventArgs e)
        {
            if (modo == "EditaEstacao")
            {
                EstacoesDAO er = new EstacoesDAO();
                List<Estacoes> lista;
                lista = er.ListaId(id);
                foreach (Estacoes ec in lista)
                {
                    txtbNome.Text = ec.Nome;
                    txtbBairro.Text = ec.Bairro;
                    txtbCEP.Text = ec.Cep;
                    txtbNumero.Text = ec.Numero;
                    txtbRua.Text = ec.Rua;
                    txtbTelefone.Text = ec.Telefone;

                    btnCadastrarEstacoes.Text = "Salvar";
                    lblEstacao.Text = "Edição de Estações";
                }
            }
        }

        private void txtbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                MessageBox.Show("Preencha Somente com Números !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbNumero.Focus();
                e.Handled = true;
            }
        }

        private void txtbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbNome.Focus();
                e.Handled = true;

            }
        }

        private void txtbBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbBairro.Focus();
                e.Handled = true;

            }
        }

        private void btnCadastrarEstacoes_Click(object sender, EventArgs e)
        {
            int CODIGO_ESTACAO = 0;
            string NOME = txtbNome.Text;
            string RUA = txtbRua.Text;
            string BAIRRO = txtbBairro.Text;
            string NUMERO = txtbNumero.Text;
            string TELEFONE = txtbTelefone.Text;
            string CEP = txtbCEP.Text;

            
            if (modo == "EditaEstacao")
            {
                EstacoesDAO eDAO = new EstacoesDAO();
                eDAO.Editar(new Estacoes(CODIGO_ESTACAO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE), id);
                this.Close();

            }
            

            else if (txtbNome.Text == "" || txtbRua.Text == "" || txtbBairro.Text == "" || txtbNumero.Text == "" || txtbTelefone.Text=="")
            {

                MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                Estacoes et = new Estacoes(CODIGO_ESTACAO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE);
                EstacoesDAO ed = new EstacoesDAO();
                ed.Inserir(et);
                Close();
            }
        }
    }
}
