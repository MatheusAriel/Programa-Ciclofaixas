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
    class EstacoesDAO : IDAO<Estacoes>
    {
        public void Inserir(Estacoes e)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO estacoes(codigo_estacao, nome, rua, bairro, numero, cep, telefone) VALUES(?codigo_estacao, ?nome, ?rua, ?bairro, ?numero, ?cep, ?telefone);";
            Com.Parameters.AddWithValue("?codigo_estacao", BD.CriaId("estacoes", "codigo_estacao"));
            Com.Parameters.AddWithValue("?nome", e.Nome);
            Com.Parameters.AddWithValue("?rua", e.Rua);
            Com.Parameters.AddWithValue("?bairro", e.Bairro);
            Com.Parameters.AddWithValue("?numero", e.Numero);
            Com.Parameters.AddWithValue("?cep", e.Cep);
            Com.Parameters.AddWithValue("?telefone", e.Telefone);


            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Estação Inserida com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no cadastro @estacoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
        }



        public void Editar(Estacoes e, string id)
        {

            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {
                Com.CommandText = "UPDATE estacoes SET nome = ?nome, rua = ?rua, bairro = ?bairro, numero = ?numero, cep = ?cep, telefone = ?telefone WHERE codigo_estacao = ?id";
                Com.Parameters.AddWithValue("?nome", e.Nome);
                Com.Parameters.AddWithValue("?rua", e.Rua);
                Com.Parameters.AddWithValue("?bairro", e.Bairro);
                Com.Parameters.AddWithValue("?numero", e.Numero);
                Com.Parameters.AddWithValue("?cep", e.Cep);
                Com.Parameters.AddWithValue("?telefone", e.Telefone);
                Com.Parameters.AddWithValue("?id", id);
                Com.ExecuteNonQuery();           
            }
            catch (Exception er)
            {
                throw er;
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

                Com.CommandText = "DELETE FROM estacoes WHERE codigo_estacao = ?id";
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



        public Estacoes SelecionaEstacaoNome(string nome)
        {
            Estacoes novo = new Estacoes();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM estacoes WHERE nome = \"" + nome + "\";";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    novo = new Estacoes(Convert.ToInt16(dr["codigo_estacao"]), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);

                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @estacoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
            return novo;
        }


        public List<Estacoes> SelecionaEstacaoNomeWhere(string where)
        {
            Estacoes estacao = new Estacoes();
            List<Estacoes> listaE = new List<Estacoes>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM estacoes " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    Estacoes e = new Estacoes(Convert.ToInt16(dr["codigo_estacao"]), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);
                    listaE.Add(e);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @estacoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return listaE;
        }


        public List<Estacoes> ListaId(string id)
        {
            List<Estacoes> ListEstacoes = new List<Estacoes>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM estacoes WHERE codigo_estacao= " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    Estacoes e = new Estacoes(Convert.ToInt16(dr["codigo_estacao"]), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);
                    ListEstacoes.Add(e);


                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @estacoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListEstacoes;
        }




        public List<Estacoes> ListaTodos()
        {

            List<Estacoes> ListEstacoes = new List<Estacoes>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM estacoes;";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    Estacoes e = new Estacoes(Convert.ToInt16(dr["codigo_estacao"]), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);
                    ListEstacoes.Add(e);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @estacoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListEstacoes;
        }

       
    }
}
