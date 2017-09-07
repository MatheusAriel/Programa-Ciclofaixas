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
    public partial class CadastrarCiclista_LocacaoFORM : Form
    {
        public CadastrarCiclista_LocacaoFORM()
        {
            InitializeComponent();
        }

        private void CadastrarCiclista_LocacaoFORM_Load(object sender, EventArgs e)
        {
            cmbPessoa.DataSource = (new FisicaDAO()).ListaTodos();
            cmbPessoa.DisplayMember = "nome";
            cmbPessoa.SelectedIndex = -1;

            cmbBicicleta.DataSource = (new BicicletasDAO()).ListaTodos();
            cmbBicicleta.DisplayMember = "modelo";
            cmbBicicleta.SelectedIndex = -1;

        }

        private void btnLocao_Click(object sender, EventArgs e)
        {
            if(txtbDataLocacao.Text == ""|| txtbHoraLocacao.Text==""|| cmbBicicleta.Text==""|| cmbPessoa.Text=="")
            {
                MessageBox.Show("Preencha Todos os Campos !", "Atenção !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                BicicletasDAO bDAO = new BicicletasDAO();
                FisicaDAO fDAO = new FisicaDAO();
                string where;
                string where2;
                string DATALOCACAO = txtbDataLocacao.Text;
                string HORALOCACAO = txtbHoraLocacao.Text;

                where = " and modelo like " + "'%" + cmbBicicleta.Text + "%'";
                where2 = " and nome like " + "'%" + cmbPessoa.Text + "%'";

                Bicicletas BIKE = bDAO.SelecionaBicicletaModelo(where)[0];
                Console.WriteLine(BIKE.Modelo);
                Fisica PESSOA = fDAO.SelecionaFisicaNome(where2)[0];
                Console.WriteLine(PESSOA.Nome);


                Ciclista_Locacao cl = new Ciclista_Locacao(DATALOCACAO, HORALOCACAO, PESSOA, BIKE);
                Ciclista_locacaoDAO clDAO = new Ciclista_locacaoDAO();
                clDAO.Inserir(cl);
               
            }
        }
    }
}
