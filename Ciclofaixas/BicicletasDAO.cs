using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Ciclofaixas
{
    class BicicletasDAO : IDAO<Bicicletas>
    {
        public void Inserir(Bicicletas b)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO bicicletas(codigo_bicicleta, cod_esta, cor, modelo) VALUES(?codigo_bicicleta, ?cod_esta, ?cor, ?modelo);";
            Com.Parameters.AddWithValue("?codigo_bicicleta", BD.CriaId("bicicletas", "codigo_bicicleta"));
            Com.Parameters.AddWithValue("?cod_esta", b.Estacoes.Codigo_estacao);
            Com.Parameters.AddWithValue("?cor", b.Cor);
            Com.Parameters.AddWithValue("?modelo", b.Modelo);

            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Bicicleta Inserida com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no cadastro @bicicletas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
        }




        public void Editar(Bicicletas b, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {
                Com.CommandText = "UPDATE bicicletas SET cor = ?cor, modelo = ?modelo WHERE codigo_bicicleta = ?id";
                Com.Parameters.AddWithValue("?cor", b.Cor);
                Com.Parameters.AddWithValue("?modelo", b.Modelo);
                Com.Parameters.AddWithValue("?id", id);
                Com.ExecuteNonQuery();

            }

            catch (Exception e)
            {
                throw e;
            }

            finally
            {
                BD.desconectar();
            }
        }




        public void Remover(string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();

            try
            {
                Com.CommandText = "DELETE FROM bicicletas WHERE codigo_bicicleta = ?id";
                Com.Parameters.AddWithValue("?id", id);
                Com.ExecuteNonQuery();
            }

            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                BD.desconectar();
            }
        }



        public List<Bicicletas> SelecionaBicicletaModelo(string where)
        {
            Bicicletas bike = new Bicicletas();
            List<Bicicletas> listaB = new List<Bicicletas>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM bicicletas, estacoes WHERE bicicletas.cod_esta = estacoes.codigo_estacao  " + where;//mudar nome where e o que ele faz
                Console.WriteLine(cmd.CommandText);
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    Estacoes es = new Estacoes((Convert.ToInt16(dr["codigo_estacao"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);


                    Bicicletas b = new Bicicletas((Convert.ToInt16(dr["codigo_bicicleta"])), (String)dr["cor"], (String)dr["modelo"], es);

                    listaB.Add(b);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @bicicletas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return listaB;
        }




        public List<Bicicletas> ListaTodos()
        {
            List<Bicicletas> ListBikes = new List<Bicicletas>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM bicicletas, estacoes WHERE bicicletas.cod_esta = estacoes.codigo_estacao ";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    Estacoes es = new Estacoes((Convert.ToInt16(dr["codigo_estacao"])),(String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);
                    Bicicletas b = new Bicicletas((Convert.ToInt16(dr["codigo_bicicleta"])), (String)dr["cor"], (String)dr["modelo"], es);

                    ListBikes.Add(b);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @bicicletas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListBikes;
        }





        public List<Bicicletas> ListaId(string id)
        {
            List<Bicicletas> ListBikes = new List<Bicicletas>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM bicicletas  WHERE codigo_bicicleta = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    EstacoesDAO eDAO = new EstacoesDAO();
                    Estacoes e = eDAO.SelecionaEstacaoNome((String)dr["nome"]);

                    Bicicletas b = new Bicicletas((Convert.ToInt16(dr["codigo_bicicleta"])), (String)dr["cor"], (String)dr["modelo"], e);

                    ListBikes.Add(b);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Errp no select @atracoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListBikes;
        }





    }
}
