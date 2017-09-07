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
    class CiclofaixasDAO : IDAO<Ciclofaixas>
    {

        public void Inserir(Ciclofaixas c)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO ciclofaixas(id_ciclofaixas, nome, cep_inicial, cep_final, tamanho) VALUES(?id_ciclofaixas, ?nome, ?cep_inicial, ?cep_final, ?tamanho);";
            Com.Parameters.AddWithValue("?nome", c.Nome);
            Com.Parameters.AddWithValue("?cep_inicial", c.Cep_inicial);
            Com.Parameters.AddWithValue("?cep_final", c.Cep_final);
            Com.Parameters.AddWithValue("?tamanho", c.Tamanho);
            Com.Parameters.AddWithValue("?id_ciclofaixas", BD.CriaId("ciclofaixas", "id_ciclofaixas"));



            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Ciclofaixa Inserida com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no cadastro @ciclofaixas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

        }

        public void Editar(Ciclofaixas c, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {
                Com.CommandText = "UPDATE ciclofaixas SET nome = ?nome, cep_inicial = ?cep_inicial, cep_final = ?cep_final, tamanho = ?tamanho WHERE id_ciclofaixas = ?id";
                Com.Parameters.AddWithValue("?cep_inicial", c.Cep_inicial);
                Com.Parameters.AddWithValue("?cep_final", c.Cep_final);
                Com.Parameters.AddWithValue("?tamanho", c.Tamanho);
                Com.Parameters.AddWithValue("?id_ciclofaixas", c.CodigoCiclofaixa);
                Com.Parameters.AddWithValue("?nome", c.Nome);
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

                Com.CommandText = "DELETE FROM ciclofaixas WHERE id_ciclofaixas = ?id";
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





        public Ciclofaixas SelecionaCiclofaixaNome(string nome)
        {
            Ciclofaixas novo = new Ciclofaixas();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM ciclofaixas WHERE nome = \"" + nome + "\";";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    novo = new Ciclofaixas(Convert.ToInt16(dr["id_ciclofaixas"]), (String)dr["nome"], (String)dr["cep_inicial"], (String)dr["cep_final"], Convert.ToDouble(dr["tamanho"]));

                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @ciclofaixas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
            return novo;
        }





        public List<Ciclofaixas> SelecionaCiclofaixaNomeWhere(string where)
        {
            Ciclofaixas ciclofaixa = new Ciclofaixas();
            List<Ciclofaixas> listaC = new List<Ciclofaixas>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM ciclofaixas " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {                    
                    Ciclofaixas c = new Ciclofaixas(Convert.ToInt16(dr["id_ciclofaixas"]), (String)dr["nome"], (String)dr["cep_inicial"], (String)dr["cep_final"], Convert.ToDouble(dr["tamanho"]));
                    listaC.Add(c);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @ciclofaixas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return listaC;
        }







        public List<Ciclofaixas> ListaId(string id)
        {
            List<Ciclofaixas> ListCiclofaixas = new List<Ciclofaixas>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ciclofaixas WHERE id_ciclofaixas = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    Ciclofaixas c = new Ciclofaixas(Convert.ToInt16(dr["id_ciclofaixas"]), (String)dr["nome"], (String)dr["cep_inicial"], (String)dr["cep_final"], Convert.ToDouble(dr["tamanho"]));
                    ListCiclofaixas.Add(c);


                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @ciclofaixas!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListCiclofaixas;
        }






        public List<Ciclofaixas> ListaTodos()
        {

            List<Ciclofaixas> LISTABIKE = new List<Ciclofaixas>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ciclofaixas;";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                   
                    Ciclofaixas c = new Ciclofaixas(Convert.ToInt16(dr["id_ciclofaixas"]), (String)dr["nome"], (String)dr["cep_inicial"], (String)dr["cep_final"], Convert.ToDouble(dr["tamanho"]));
                    LISTABIKE.Add(c);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Errp no select @Ciclofaixa!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return LISTABIKE;
        }






      





    }
}
