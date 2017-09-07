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
    public partial class CadastrarCiclofaixasFORM : Form
    {

        public string id, modo;
        public CadastrarCiclofaixasFORM()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int IDCICLOFAIXA = 0;
            string NOME = txtbNomeCiclofaixa.Text;
            string CEPINICIAL = txtbCEPInicial.Text;
            string CEPFINAL = txtbCEPFinal.Text;
            double TAMANHO = Convert.ToDouble(txtbTamanho.Text);

            if (modo == "EditaCiclofaixa")
            {
               
                CiclofaixasDAO cDAO = new CiclofaixasDAO();
                cDAO.Editar(new Ciclofaixas(IDCICLOFAIXA, NOME, CEPINICIAL, CEPFINAL, TAMANHO), id);
                this.Close();

            }


            else if(txtbCEPInicial.Text=="" || txtbCEPInicial.Text==""||txtbCEPFinal.Text==""||txtbTamanho.Text=="")
            {
                MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                Ciclofaixas c = new Ciclofaixas(IDCICLOFAIXA, NOME, CEPINICIAL, CEPFINAL, TAMANHO);
                CiclofaixasDAO cd = new CiclofaixasDAO();
                cd.Inserir(c);
                Close();
            }

        }

        private void txtbNomeCiclofaixa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbNomeCiclofaixa.Focus();
                e.Handled = true;

            }
        }

        private void CadastrarCiclofaixasFORM_Load(object sender, EventArgs e)
        {
            if (modo == "EditaCiclofaixa")
            {
                CiclofaixasDAO c = new CiclofaixasDAO();
                List<Ciclofaixas> lista;
                lista = c.ListaId(id);
                foreach (Ciclofaixas cf in lista)
                {
                    txtbNomeCiclofaixa.Text = cf.Nome;
                    txtbCEPInicial.Text = cf.Cep_inicial;
                    txtbCEPFinal.Text = cf.Cep_final;
                    txtbTamanho.Text = Convert.ToString(cf.Tamanho);

                    lclCiclofaixas.Text = "Edição de Ciclofaixas";
                    btnCadastrar.Text = "Salvar";
                }
            }
        }

        private void txtbTamanho_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar!=44)
            {
                MessageBox.Show("Preencha Somente com Números !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbTamanho.Focus();
                e.Handled = true;
            }
        }
    }
}
