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
    public partial class CadastrarAtracoesFORM : Form
    {
        public string id, modo;
        enum FormStatus
        {
            neutro,
            parque,
            restaurante,
            museu,
        }

        private FormStatus formstatus;


        private void ControlaComponentes(FormStatus status)
        {
            lblPrecoEntradaParque.Visible = status == FormStatus.parque ? true : false;
            txtbPrecoEntradaParque.Visible = status == FormStatus.parque ? true : false;
            lblRS.Visible = status == FormStatus.parque ? true : false;

            lblTiporestaurante.Visible = status == FormStatus.restaurante ? true : false;
            txtbTipoRestaurante.Visible = status == FormStatus.restaurante ? true : false;

            lblPrecoEntradaMuseu.Visible = status == FormStatus.museu ? true : false;
            lblRSMuseu.Visible = status == FormStatus.museu ? true : false;
            txtbPrecoEntradaMuseu.Visible = status == FormStatus.museu ? true : false;
            lblTipoMuseu.Visible = status == FormStatus.museu ? true : false;
            txtbTipoMuseu.Visible = status == FormStatus.museu ? true : false;


        }


        public CadastrarAtracoesFORM()
        {
            InitializeComponent();
            lblPrecoEntradaParque.Visible = false;
            txtbPrecoEntradaParque.Visible = false;
            lblRS.Visible = false;

            lblTiporestaurante.Visible = false;
            txtbTipoRestaurante.Visible = false;

            lblPrecoEntradaMuseu.Visible = false;
            txtbPrecoEntradaMuseu.Visible = false;
            lblRSMuseu.Visible = false;
            lblTipoMuseu.Visible = false;
            txtbTipoMuseu.Visible = false;

            atualizaDataGridComboBox();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int CODIGOATRACAO = 0;
            string NOME = txtbNome.Text;
            string HORA_ABERTURA = txtbHoraAbertura.Text;
            string HORA_FECHAMENTO = txtbHoraFechamento.Text;
            string RUA = txtbRua.Text;
            string BAIRRO = txtbBairro.Text;
            string NUMERO = TxtbNumero.Text;
            string CEP = txtbCEP.Text;
            string TELEFONE = txtbTelefone.Text;

            if (modo == "EditaParque")
            {
                double PRECO_ENTRADA_PARQUE = Convert.ToDouble(txtbPrecoEntradaParque.Text);
                Ciclofaixas c = new Ciclofaixas();
                CiclofaixasDAO cDAO = new CiclofaixasDAO();
                c = cDAO.SelecionaCiclofaixaNome(cmbNomeCiclofaixas.Text);
                ParquesDAO pDAO = new ParquesDAO();
                pDAO.Editar(new Parques(CODIGOATRACAO, HORA_ABERTURA, HORA_FECHAMENTO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE, c, PRECO_ENTRADA_PARQUE), id);
                this.Close();

            }

            else if (modo == "EditaMuseu")
            {
                double PRECO_ENTRADA_MUSEU = Convert.ToDouble(txtbPrecoEntradaMuseu.Text);
                string TIPO_MUSEU = txtbTipoMuseu.Text;
                Ciclofaixas c = new Ciclofaixas();
                CiclofaixasDAO cDAO = new CiclofaixasDAO();
                c = cDAO.SelecionaCiclofaixaNome(cmbNomeCiclofaixas.Text);
                MuseusDAO mDAO = new MuseusDAO();
                mDAO.Editar(new Museus(CODIGOATRACAO, HORA_ABERTURA, HORA_FECHAMENTO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE, c, TIPO_MUSEU, PRECO_ENTRADA_MUSEU), id);
                this.Close();
            }


            else if(modo == "EditaRestaurante")
            {
                string tipoRestaurante = txtbTipoRestaurante.Text;
                Ciclofaixas c = new Ciclofaixas();
                CiclofaixasDAO cDAO = new CiclofaixasDAO();
                c = cDAO.SelecionaCiclofaixaNome(cmbNomeCiclofaixas.Text);
                RestaurantesDAO rDAO = new RestaurantesDAO();
                rDAO.Editar(new Restaurantes(CODIGOATRACAO, HORA_ABERTURA, HORA_FECHAMENTO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE, c, tipoRestaurante), id);
                this.Close();

            }

            

            else
            {

                if (txtbNome.Text == "" || txtbHoraAbertura.Text == "" || txtbHoraFechamento.Text == "" || txtbRua.Text == "" || txtbBairro.Text == "" || TxtbNumero.Text == "" || txtbCEP.Text == "" || txtbTelefone.Text == "")
                {
                    MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                else if (rbtnParque.Checked == true)
                {
                    if (txtbPrecoEntradaParque.Text == "")
                    {
                        MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        double PRECO_ENTRADA_PARQUE = Convert.ToDouble(txtbPrecoEntradaParque.Text);
                        Ciclofaixas c = new Ciclofaixas();
                        CiclofaixasDAO cDAO = new CiclofaixasDAO();
                        c = cDAO.SelecionaCiclofaixaNome(cmbNomeCiclofaixas.Text);
                        ParquesDAO pDAO = new ParquesDAO();
                        pDAO.Inserir(new Parques(CODIGOATRACAO, HORA_ABERTURA, HORA_FECHAMENTO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE, c, PRECO_ENTRADA_PARQUE));
                        this.Close();
                    }
                }


                else if (rbtnRestaurante.Checked == true)
                {
                    if (txtbTipoRestaurante.Text == "")
                    {
                        MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        string TIPO_RESTAURANTE = txtbTipoRestaurante.Text;
                        Ciclofaixas c = new Ciclofaixas();
                        CiclofaixasDAO cDAO = new CiclofaixasDAO();
                        c = cDAO.SelecionaCiclofaixaNome(cmbNomeCiclofaixas.Text);
                        RestaurantesDAO rDAO = new RestaurantesDAO();
                        rDAO.Inserir(new Restaurantes(CODIGOATRACAO, HORA_ABERTURA, HORA_FECHAMENTO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE, c, TIPO_RESTAURANTE));
                        this.Close();
                    }
                }


                else if (rbtnMuseu.Checked == true)
                {
                    if (txtbPrecoEntradaMuseu.Text == "" || txtbTipoMuseu.Text == "")
                    {
                        MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        double PRECO_ENTRADA_MUSEU = Convert.ToDouble(txtbPrecoEntradaMuseu.Text);
                        string TIPO_MUSEU = txtbTipoMuseu.Text;
                        Ciclofaixas c = new Ciclofaixas();
                        CiclofaixasDAO cDAO = new CiclofaixasDAO();
                        c = cDAO.SelecionaCiclofaixaNome(cmbNomeCiclofaixas.Text);
                        MuseusDAO mDAO = new MuseusDAO();
                        mDAO.Inserir(new Museus(CODIGOATRACAO, HORA_ABERTURA, HORA_FECHAMENTO, NOME, RUA, BAIRRO, NUMERO, CEP, TELEFONE, c, TIPO_MUSEU, PRECO_ENTRADA_MUSEU));
                        this.Close();
                    }
                }

                else
                {
                    MessageBox.Show("Escolha um Tipo de Atração !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void btnCadastrarCiclofaixa_Click(object sender, EventArgs e)
        {
            CadastrarCiclofaixasFORM cCadastra = new CadastrarCiclofaixasFORM();
            cCadastra.Show();
        }

        public void atualizaDataGridComboBox()
        {
            CiclofaixasDAO cDAO = new CiclofaixasDAO();
            cmbNomeCiclofaixas.DataSource = cDAO.ListaTodos();
            cmbNomeCiclofaixas.DisplayMember = "nome";

            dtgCiclofaixas.DataSource = cDAO.ListaTodos();
        }


        private void btnAtualizarListaCiclofaixas_Click(object sender, EventArgs e)
        {
            atualizaDataGridComboBox();
        }

        private void rbtnParque_CheckedChanged(object sender, EventArgs e)
        {
            ControlaComponentes(FormStatus.parque);
        }

        private void rbtnRestaurante_CheckedChanged(object sender, EventArgs e)
        {
            ControlaComponentes(FormStatus.restaurante);
        }

        private void rbtnMuseu_CheckedChanged(object sender, EventArgs e)
        {
            ControlaComponentes(FormStatus.museu);
        }

        private void TxtbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                MessageBox.Show("Preencha Somente com Números !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtbNumero.Focus();
                e.Handled = true;
            }
        }

        private void txtbTipoMuseu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbTipoMuseu.Focus();
                e.Handled = true;

            }
        }

        private void txtbTipoRestaurante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {

                MessageBox.Show("Preencha Somente com Letras !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbTipoRestaurante.Focus();
                e.Handled = true;

            }
        }

        private void CadastrarAtracoesFORM_Load(object sender, EventArgs e)
        {
            if (modo == "EditaParque")
            {
                ParquesDAO p = new ParquesDAO();
                List<Parques> lista;
                lista = p.ListaId(id);
                foreach (Parques pq in lista)
                {
                    txtbNome.Text = pq.Nome;
                    txtbHoraAbertura.Text = pq.Hora_abertura;
                    txtbHoraFechamento.Text = pq.Hora_fechamento;
                    txtbTelefone.Text = pq.Telefone;
                    txtbPrecoEntradaParque.Text = Convert.ToString(pq.Preco_entrada);
                    txtbRua.Text = pq.Rua;
                    txtbBairro.Text = pq.Bairro;
                    TxtbNumero.Text = pq.Numero;
                    txtbCEP.Text = pq.Cep;
                    cmbNomeCiclofaixas.Text = pq.Ciclofaixa.Nome;


                    rbtnMuseu.Visible = false;
                    rbtnRestaurante.Visible = false;
                    rbtnParque.Checked = true;
                    lblPrecoEntradaParque.Visible = true;
                    lblRS.Visible = true;
                    txtbPrecoEntradaParque.Visible = true;
                    cmbNomeCiclofaixas.Visible = false;
                    lblAtracoes.Text = "Edição de Atrações";


                    btnCadastrar.Text = "Salvar";
                }
            }
            else if(modo == "EditaRestaurante")
            {
                RestaurantesDAO r = new RestaurantesDAO();
                List<Restaurantes> lista;
                lista = r.ListaId(id);
                foreach(Restaurantes rt in lista)
                {
                    txtbNome.Text = rt.Nome;
                    txtbHoraAbertura.Text = rt.Hora_abertura;
                    txtbHoraFechamento.Text = rt.Hora_fechamento;
                    txtbTelefone.Text = rt.Telefone;
                    txtbTipoRestaurante.Text = rt.Tipo;
                    txtbRua.Text = rt.Rua;
                    txtbBairro.Text = rt.Bairro;
                    TxtbNumero.Text = rt.Numero;
                    txtbCEP.Text = rt.Cep;
                    cmbNomeCiclofaixas.Text = rt.Ciclofaixa.Nome;

                    rbtnMuseu.Visible = false;
                    rbtnParque.Visible = false;
                    rbtnRestaurante.Checked = true;
                    lblTiporestaurante.Visible = true;
                    txtbTipoRestaurante.Visible = true;
                    cmbNomeCiclofaixas.Visible = false;
                    lblAtracoes.Text = "Edição de Atrações";


                    btnCadastrar.Text = "Salvar";

                }
            }
            else if (modo == "EditaMuseu")
            {
                MuseusDAO m = new MuseusDAO();
                List<Museus> lista;
                lista = m.ListaId(id);
                foreach (Museus ms in lista)
                {
                    txtbNome.Text = ms.Nome;
                    txtbHoraAbertura.Text = ms.Hora_abertura;
                    txtbHoraFechamento.Text = ms.Hora_fechamento;
                    txtbTelefone.Text = ms.Telefone;
                    txtbPrecoEntradaMuseu.Text = Convert.ToString(ms.Preco_entrada);
                    txtbTipoMuseu.Text = ms.Tipo;
                    txtbRua.Text = ms.Rua;
                    txtbBairro.Text = ms.Bairro;
                    TxtbNumero.Text = ms.Numero;
                    txtbCEP.Text = ms.Cep;
                    cmbNomeCiclofaixas.Text = ms.Ciclofaixa.Nome;

                    rbtnParque.Visible = false;
                    rbtnRestaurante.Visible = false;
                    rbtnMuseu.Checked = true;
                    lblRSMuseu.Visible = true;
                    lblPrecoEntradaMuseu.Visible = true;
                    txtbPrecoEntradaMuseu.Visible = true;

                    lblTipoMuseu.Visible = true;
                    txtbTipoMuseu.Visible = true;
                    cmbNomeCiclofaixas.Visible = false;
                    lblAtracoes.Text = "Edição de Atrações";


                    btnCadastrar.Text = "Salvar";

                }
            }
        }
    }
}
