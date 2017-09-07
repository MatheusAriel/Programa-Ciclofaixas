using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ciclofaixas
{
    class MuseusDAO : IDAO<Museus>
    {

        public void Inserir(Museus m)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO atracoes(codigo_atracoes, hora_de_abertura, hora_de_fechamento, nome, rua, bairro, numero, cep, telefone, id_ciclofaixas) VALUES(?codigo, ?hora_de_abertura, ?hora_de_fechamento, ?nome, ?rua, ?bairro, ?numero, ?cep, ?telefone, ?ciclofaixa);";
            Com.CommandText += " INSERT INTO museus(cod_atra, tipo, preco_entrada) VALUES(?codigo, ?tipo, ?preco_entrada);";
            Com.Parameters.AddWithValue("?hora_de_abertura", m.Hora_abertura);
            Com.Parameters.AddWithValue("?hora_de_fechamento", m.Hora_fechamento);
            Com.Parameters.AddWithValue("?nome", m.Nome);
            Com.Parameters.AddWithValue("?rua", m.Rua);
            Com.Parameters.AddWithValue("?bairro", m.Bairro);
            Com.Parameters.AddWithValue("?numero", m.Numero);
            Com.Parameters.AddWithValue("?cep", m.Cep);
            Com.Parameters.AddWithValue("?telefone", m.Telefone);
            Com.Parameters.AddWithValue("?codigo", BD.CriaId("atracoes", "codigo_atracoes"));
            Com.Parameters.AddWithValue("?ciclofaixa", m.Ciclofaixa.CodigoCiclofaixa);
            Com.Parameters.AddWithValue("?tipo", m.Tipo);
            Com.Parameters.AddWithValue("?preco_entrada", m.Preco_entrada);




            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Museu Inserido com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        public void Editar(Museus m, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {

                Com.CommandText = "UPDATE atracoes a JOIN museus m ON a.codigo_atracoes = m.cod_atra SET a.hora_de_abertura = ?hora_de_abertura, a.hora_de_fechamento = ?hora_de_fechamento, a.nome = ?nome, a.rua = ?rua, a.bairro = ?bairro, a.cep = ?cep, a.telefone = ?telefone, m.tipo = ?tipo , m.preco_entrada = ?preco_entrada WHERE a.codigo_atracoes = ?id";
                Com.Parameters.AddWithValue("?hora_de_abertura", m.Hora_abertura);
                Com.Parameters.AddWithValue("?hora_de_fechamento", m.Hora_fechamento);
                Com.Parameters.AddWithValue("?nome", m.Nome);
                Com.Parameters.AddWithValue("?rua", m.Rua);
                Com.Parameters.AddWithValue("?bairro", m.Bairro);
                Com.Parameters.AddWithValue("?numero", m.Numero);
                Com.Parameters.AddWithValue("?cep", m.Cep);
                Com.Parameters.AddWithValue("?telefone", m.Telefone);
                Com.Parameters.AddWithValue("?id", id);
                Com.Parameters.AddWithValue("?preco_entrada", m.Preco_entrada);
                Com.Parameters.AddWithValue("?tipo", m.Tipo);
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
        public MySqlDataReader SelecionaMuseuTipo(Atracoes a, Museus m)
        {
            MySqlDataReader dr = null;
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * From atracoes a, museus m WHERE a.codigo_atracoes = m.cod_atra and m.tipo = \"" + m.Tipo + "\"";
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);
                dr = cmd.ExecuteReader();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @atracoes!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return dr;

        }
        */


        public List<Museus> selecionaMuseuNome(string where)
        {
            Museus museus = new Museus();
            List<Museus> listam = new List<Museus>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM atracoes a, museus m WHERE a.codigo_atracoes = m.cod_atra " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);

                    Museus m = new Museus((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)dr["tipo"] ,(Convert.ToDouble(dr["preco_entrada"])));

                    listam.Add(m);
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

            return listam;
        }





        public List<Museus> ListaId(string id)
        {
            List<Museus> ListMuseus = new List<Museus>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM atracoes a, museus m WHERE a.codigo_atracoes = " + id;
                Console.WriteLine("SELECT * FROM atracoes a, museus m WHERE a.codigo_atracoes = " + id);
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    Museus m = new Museus((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)dr["tipo"], (Convert.ToDouble(dr["preco_entrada"])));

                    ListMuseus.Add(m);
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

            return ListMuseus;
        }






        public List<Museus> ListaTodos()
        {
            List<Museus> ListMuseus = new List<Museus>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "select a.codigo_atracoes, a.hora_de_abertura, a.hora_de_fechamento, a.nome,a.rua, a.bairro, a.numero, a.cep, a.telefone, m.tipo, m.preco_entrada FROM atracoes a, museus m WHERE a.codigo_atracoes = m.cod_atra;";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    Museus m = new Museus((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (String)dr["tipo"] , (Convert.ToDouble(dr["preco_entrada"])));

                    ListMuseus.Add(m);
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

            return ListMuseus;
        }



    }
}
