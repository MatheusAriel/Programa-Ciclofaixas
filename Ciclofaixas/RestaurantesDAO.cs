using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ciclofaixas
{
    class RestaurantesDAO:IDAO<Restaurantes>
    {


        public void Inserir(Restaurantes r)
        {

            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO atracoes(codigo_atracoes,hora_de_abertura, hora_de_fechamento, nome, rua, bairro, numero, cep, telefone, id_ciclofaixas) VALUES(?codigo, ?hora_de_abertura, ?hora_de_fechamento, ?nome, ?rua, ?bairro, ?numero, ?cep, ?telefone, ?ciclofaixa);";
            Com.CommandText += " INSERT INTO restaurantes(cod_atra, tipo) VALUES(?codigo, ?tipo);";
            Com.Parameters.AddWithValue("?hora_de_abertura", r.Hora_abertura);
            Com.Parameters.AddWithValue("?hora_de_fechamento", r.Hora_fechamento);
            Com.Parameters.AddWithValue("?nome", r.Nome);
            Com.Parameters.AddWithValue("?rua", r.Rua);
            Com.Parameters.AddWithValue("?bairro", r.Bairro);
            Com.Parameters.AddWithValue("?numero", r.Numero);
            Com.Parameters.AddWithValue("?cep", r.Cep);
            Com.Parameters.AddWithValue("?telefone", r.Telefone);
            Com.Parameters.AddWithValue("?codigo", BD.CriaId("atracoes", "codigo_atracoes"));
            Com.Parameters.AddWithValue("?ciclofaixa", r.Ciclofaixa.CodigoCiclofaixa);
            Com.Parameters.AddWithValue("?tipo", r.Tipo);
 

            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Restaurante Inserido com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no cadastro @atracoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
        }




        public void Editar(Restaurantes r, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {
                Com.CommandText = "UPDATE atracoes a JOIN restaurantes r ON a.codigo_atracoes = r.cod_atra SET a.hora_de_abertura = ?hora_de_abertura, a.hora_de_fechamento = ?hora_de_fechamento, a.nome = ?nome, a.rua = ?rua, a.bairro = ?bairro, a.cep = ?cep, a.telefone = ?telefone, r.tipo= ?tipo WHERE a.codigo_atracoes = ?id";
                Com.Parameters.AddWithValue("?hora_de_abertura", r.Hora_abertura);
                Com.Parameters.AddWithValue("?hora_de_fechamento", r.Hora_fechamento);
                Com.Parameters.AddWithValue("?nome", r.Nome);
                Com.Parameters.AddWithValue("?rua", r.Rua);
                Com.Parameters.AddWithValue("?bairro", r.Bairro);
                Com.Parameters.AddWithValue("?numero", r.Numero);
                Com.Parameters.AddWithValue("?cep", r.Cep);
                Com.Parameters.AddWithValue("?telefone", r.Telefone);
                Com.Parameters.AddWithValue("?tipo", r.Tipo);
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
                Com.CommandText = "DELETE FROM atracoes WHERE codigo_atracoes = ?id";
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

        /*
        public List<Restaurantes> SelecionaRestauranteTipo(string where)
        {
            Restaurantes restaurantes = new Restaurantes();
            List<Restaurantes> tr = new List<Restaurantes>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM atracoes a, restaurantes r WHERE a.codigo_atracoes = r.cod_atra " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);

                    Restaurantes r = new Restaurantes((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)(dr["tipo"]));

                    tr.Add(r);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @atracoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return tr;
        }
        */






        public List<Restaurantes> SelecionaRestauranteNome(string where)
        {
            Restaurantes restaurantes = new Restaurantes();
            List<Restaurantes> listar = new List<Restaurantes>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM atracoes a, restaurantes r WHERE a.codigo_atracoes = r.cod_atra " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);

                    Restaurantes r = new Restaurantes((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)(dr["tipo"]));

                    listar.Add(r);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @atracoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return listar;
        }






        public List<Restaurantes> ListaTodos()
        {
            List<Restaurantes> ListRestaurantes = new List<Restaurantes>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM atracoes a, restaurantes r WHERE a.codigo_atracoes = r.cod_atra";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    Restaurantes r = new Restaurantes((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)dr["tipo"]);

                    ListRestaurantes.Add(r);
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

            return ListRestaurantes;
        }





        public List<Restaurantes> ListaId(string id)
        {
            List<Restaurantes> ListRestaurantes = new List<Restaurantes>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM atracoes a, restaurantes r WHERE a.codigo_atracoes = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    Restaurantes r = new Restaurantes((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)(dr["tipo"]));

                    ListRestaurantes.Add(r);
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

            return ListRestaurantes;
        }




    }
}
