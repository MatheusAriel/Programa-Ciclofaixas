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
    public partial class PrincipalAtracoesFORM : Form
    {

        List<Parques> lista;
        List<Restaurantes> listaR;
        List<Museus> listaM;
        public PrincipalAtracoesFORM()
        {
            InitializeComponent();
        }

        
        

        private void btnInserirAtracoes_Click(object sender, EventArgs e)
        {
            CadastrarAtracoesFORM atra = new CadastrarAtracoesFORM();
            atra.ShowDialog();
        }

        private void PrincipalAtracoesFORM_Load(object sender, EventArgs e)
        {
            
            ParquesDAO pd = new ParquesDAO();
            RestaurantesDAO rd = new RestaurantesDAO();
            MuseusDAO md = new MuseusDAO();

            List<Parques> lp = new List<Parques>();
            List<Restaurantes> rp = new List<Restaurantes>();
            List<Museus> mp = new List<Museus>();

            lp = pd.ListaTodos();
                dtgParques.DataSource = lp;

            rp = rd.ListaTodos();
                dtgRestaurantes.DataSource = rp;

            mp = md.ListaTodos();
                dtgMuseus.DataSource = mp;
        }

        private void btnEditarParques_Click(object sender, EventArgs e)
        {
            if (dtgParques.SelectedRows.Count > 0)
            {
                ParquesDAO p = new ParquesDAO();
                using (CadastrarAtracoesFORM finc = new CadastrarAtracoesFORM())
                {
                    finc.id = dtgParques.CurrentRow.Cells[1].Value.ToString();
                    finc.modo = "EditaParque";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        lista = p.ListaTodos();
                        dtgParques.DataSource = lista;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnRemoverParques_Click(object sender, EventArgs e)
        {
            if (dtgParques.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse parque?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    ParquesDAO p = new ParquesDAO();
                    string id = dtgParques.CurrentRow.Cells[1].Value.ToString();
                    p.Remover(id);
                    lista = p.ListaTodos();
                    dtgParques.DataSource = lista;
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnPesquisarParques_Click(object sender, EventArgs e)
        {
            ParquesDAO p = new ParquesDAO();
            List<Parques> lista;
            string where = "";            
            if (txtbPesquisaParques.Text != "")
            {
                 where = "and a.nome like " + "'%" + txtbPesquisaParques.Text + "%'";
            }


            lista = p.selecionaParqueNome(where);
            dtgParques.DataSource = lista;
        }

        private void btnEditarRestaurantes_Click(object sender, EventArgs e)
        {

            if (dtgRestaurantes.SelectedRows.Count > 0)
            {
                RestaurantesDAO r = new RestaurantesDAO();
                using (CadastrarAtracoesFORM finc = new CadastrarAtracoesFORM())
                {
                    finc.id = dtgRestaurantes.CurrentRow.Cells[1].Value.ToString();
                    finc.modo = "EditaRestaurante";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        listaR = r.ListaTodos();
                        dtgRestaurantes.DataSource = listaR;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnRemoverRestaurantes_Click(object sender, EventArgs e)
        {

            if (dtgRestaurantes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse restaurante?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    RestaurantesDAO r = new RestaurantesDAO();
                    string id = dtgRestaurantes.CurrentRow.Cells[1].Value.ToString();
                    r.Remover(id);
                    listaR = r.ListaTodos();
                    dtgParques.DataSource = listaR;
                }
            }
            else
            {
                MessageBox.Show("Nenhum Restaurante Selecionado!");
            }
        }

        private void btnPesquisaRestaurantes_Click(object sender, EventArgs e)
        {
            RestaurantesDAO r = new RestaurantesDAO();
            List<Restaurantes> listaR;
            string where = "";
            if (txtbPesquisaRestaurantes.Text != "")
            {
                where = "and a.nome like " + "'%" + txtbPesquisaRestaurantes.Text + "%'";
            }


            listaR = r.SelecionaRestauranteNome(where);
            dtgRestaurantes.DataSource = listaR;
        }

        private void btnEditarMuseus_Click(object sender, EventArgs e)
        {
            if (dtgMuseus.SelectedRows.Count > 0)
            {
                MuseusDAO m = new MuseusDAO();
                using (CadastrarAtracoesFORM finc = new CadastrarAtracoesFORM())
                {
                    finc.id = dtgMuseus.CurrentRow.Cells[2].Value.ToString();
                    finc.modo = "EditaMuseu";
                    if (finc.ShowDialog() == DialogResult.OK)
                    {
                        listaM = m.ListaTodos();
                        dtgMuseus.DataSource = listaM;
                        finc.Dispose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Museu Selecionado!");
            }
        }

        private void btnRemoverMuseus_Click(object sender, EventArgs e)
        {
            if (dtgMuseus.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esse museu?", "?", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MuseusDAO m = new MuseusDAO();
                    string id = dtgMuseus.CurrentRow.Cells[2].Value.ToString();
                    m.Remover(id);
                    listaM = m.ListaTodos();
                    dtgMuseus.DataSource = listaM;
                }
            }
            else
            {
                MessageBox.Show("Nenhum parque selecionado!");
            }
        }

        private void btnPesquisaMuseus_Click(object sender, EventArgs e)
        {
            MuseusDAO m = new MuseusDAO();
            List<Museus> listaM;
            string where = "";
            if (txtbPesquisaMuseus.Text != "")
            {
                where = "and a.nome like " + "'%" + txtbPesquisaMuseus.Text + "%'";
            }


            listaM = m.selecionaMuseuNome(where);
            dtgMuseus.DataSource = listaM;
        }

        private void btnInserirAtracoes_Click_1(object sender, EventArgs e)
        {
            CadastrarAtracoesFORM atra = new CadastrarAtracoesFORM();
            atra.ShowDialog();
        }
    }
}
