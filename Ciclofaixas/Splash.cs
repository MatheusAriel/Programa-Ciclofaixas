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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }


        public void executar()
        {
            timer1.Enabled = false;           
            Hide();
            PrincipalFORM FORM = new PrincipalFORM();
            FORM.ShowDialog();
            Close();
        }

        private void AtualizaProgresso(string text, int valor)
        {
            label1.Text = text;
            progressBar1.Value += valor;
            Console.WriteLine(valor);

        }

        private void Splash_Activated(object sender, EventArgs e)
        {
            AtualizaProgresso("Verificando conexão com o banco de dados", 20);
            BD.TestaBancoDados();
            AtualizaProgresso("Carregando componentes", 20);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<=100)
            {
                executar();
                return;
            }
            AtualizaProgresso("Carregando componentes", 20);
        }
    }
}
