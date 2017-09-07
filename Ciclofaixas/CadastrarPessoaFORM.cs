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
    public partial class CadastrarPessoaFORM : Form
    {
        public string id, modo;
        enum FormStatus
        {
            neutro,
            fisica,
            juridica,
        }

        private FormStatus formstatus;

        private void ControlarComponentes(FormStatus status)
        {
            lblCPF.Visible = status == FormStatus.fisica ? true : false;
            txtbCPF.Visible = status == FormStatus.fisica ? true : false;

            lblRG.Visible = status == FormStatus.fisica ? true : false;
            txtbRG.Visible = status == FormStatus.fisica ? true : false;

            lblDataNasc.Visible = status == FormStatus.fisica ? true : false;
            txtbDataNasc.Visible = status == FormStatus.fisica ? true : false;

            lblCNPJ.Visible = status == FormStatus.juridica ? true : false;
            txtbCNPJ.Visible = status == FormStatus.juridica ? true : false;
        }






        public CadastrarPessoaFORM()
        {
            InitializeComponent();
            lblCPF.Visible = false;
            txtbCPF.Visible = false;

            lblRG.Visible = false;
            txtbRG.Visible = false;

            lblDataNasc.Visible = false;
            txtbDataNasc.Visible = false;

            lblCNPJ.Visible = false;
            txtbCNPJ.Visible = false;
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int IDPESSOA = 0;
            string NOME = txtbNome.Text;
            string RUA = txtbRua.Text;
            string BAIRRO = txtbBairro.Text;
            string CIDADE = txtbCidade.Text;
            string TELEFONE = txtbTelefone.Text;
            string NUMERO = txtbNumero.Text;
            string CEP = txtbCEP.Text;
            string ESTADO = txtbEstado.Text;
            string EMAIL = txtbEmail.Text;
           


            if (modo == "EditaFisica")
            {
                string CPF = txtbCPF.Text;
                string RG = txtbRG.Text;
                string DATANASC = txtbDataNasc.Text;


                FisicaDAO fDAO = new FisicaDAO();
                fDAO.Editar(new Fisica(IDPESSOA, NOME, RUA, BAIRRO, NUMERO, CEP, CIDADE, ESTADO, EMAIL, TELEFONE, CPF, RG, DATANASC),id);
                this.Close();

            }

            else if(modo=="EditaJuridica")
            {
                string CNPJ = txtbCNPJ.Text;
                JuridicaDAO jDAO = new JuridicaDAO();
                jDAO.Editar(new Juridica(IDPESSOA, NOME, RUA, BAIRRO, NUMERO, CEP, CIDADE, ESTADO, EMAIL, TELEFONE, CNPJ), id);
                this.Close();
            }

            else
            {

                if (txtbNome.Text == "" || txtbEmail.Text == "" || txtbTelefone.Text == "" || txtbRua.Text == "" || txtbNumero.Text == "" || txtbCEP.Text == "" || txtbBairro.Text == "" || txtbCidade.Text == "" || txtbEstado.Text == "")
                {
                    MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }

                else if (rbtnFisica.Checked == true)
                {
                    if (txtbCPF.Text == "" || txtbRG.Text == "" || txtbDataNasc.Text == "")
                    {
                        MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        string CPF = txtbCPF.Text;
                        string RG = txtbRG.Text;
                        string DATANASC = txtbDataNasc.Text;
                        FisicaDAO fDAO = new FisicaDAO();
                        fDAO.Inserir(new Fisica(IDPESSOA, NOME, RUA, BAIRRO, NUMERO, CEP, CIDADE, ESTADO, EMAIL, TELEFONE, CPF, RG, DATANASC));
                        Close();                       
                    }
                }

                else if (rbtnJuridica.Checked == true)
                {
                    if (txtbCNPJ.Text == "")
                    {

                        MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        string CNPJ = txtbCNPJ.Text;
                        Juridica j = new Juridica(IDPESSOA, NOME, RUA, BAIRRO, NUMERO, CEP, CIDADE, ESTADO, EMAIL, TELEFONE, CNPJ);
                        JuridicaDAO jd = new JuridicaDAO();
                        jd.Inserir(j);
                        Close();
                    }
                }


                else
                {
                    MessageBox.Show("Escolha um Tipo de Pessoa !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void rbtnFisica_CheckedChanged(object sender, EventArgs e)
        {
            ControlarComponentes(FormStatus.fisica);
        }

        private void rbtnJuridica_CheckedChanged(object sender, EventArgs e)
        {
            ControlarComponentes(FormStatus.juridica);
        }

        private void txtbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                MessageBox.Show("Preencha Somente com Números !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbNumero.Focus();
                e.Handled = true;
            }
        }

        private void txtbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar !=(char)Keys.Space) && (e.KeyChar!=(char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbNome.Focus();
                e.Handled = true;

            }
        }

        private void CadastrarPessoaFORM_Load(object sender, EventArgs e)
        {
            if (modo == "EditaFisica")
            {
                FisicaDAO f = new FisicaDAO();
                List<Fisica> lista;
                lista = f.ListaId(id);
                foreach (Fisica fs in lista)
                {
                    txtbNome.Text = fs.Nome;
                    txtbRua.Text = fs.Rua;
                    txtbBairro.Text = fs.Bairro;
                    txtbNumero.Text = fs.Numero;
                    txtbCEP.Text = fs.Cep;
                    txtbCidade.Text = fs.Cidade;
                    txtbEstado.Text = fs.Estado;
                    txtbEmail.Text = fs.Email;
                    txtbTelefone.Text = fs.Telefone;
                    txtbCPF.Text = fs.Cpf;
                    txtbDataNasc.Text = fs.Cpf;
                    txtbRG.Text = fs.Rg;


                    lblPessoa.Text = "Edição de Pessoas";
                    rbtnJuridica.Visible = false;
                    rbtnFisica.Checked = true;
                    lblCPF.Visible = true;
                    lblRG.Visible = true;
                    lblDataNasc.Visible = true;
                    txtbCPF.Visible = true;
                    txtbRG.Visible = true;
                    txtbDataNasc.Visible = true;


                    btnCadastrar.Text = "Salvar";
                }
            }

            else if (modo == "EditaJuridica")
            {
                JuridicaDAO j = new JuridicaDAO();
                List<Juridica> lista;
                lista = j.ListaId(id);
                foreach (Juridica jd in lista)
                {
                    txtbNome.Text = jd.Nome;
                    txtbRua.Text = jd.Rua;
                    txtbBairro.Text = jd.Bairro;
                    txtbNumero.Text = jd.Numero;
                    txtbCEP.Text = jd.Cep;
                    txtbCidade.Text = jd.Cidade;
                    txtbEstado.Text = jd.Estado;
                    txtbEmail.Text = jd.Email;
                    txtbTelefone.Text = jd.Telefone;
                    txtbCNPJ.Text = jd.Cnpj;

                    rbtnFisica.Visible = false;
                    rbtnJuridica.Checked = true;
                    lblCNPJ.Visible = true;
                    txtbCNPJ.Visible = true;
                    lblPessoa.Text = "Edição de Pessoas";

                    btnCadastrar.Text = "Salvar";
                }
            }
        }

        private void txtbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbEstado.Focus();
                e.Handled = true;

            }
        }

        private void txtbCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbNome.Focus();
                e.Handled = true;

            }
        }
    }
}
