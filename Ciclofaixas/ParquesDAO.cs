using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ciclofaixas
{
    class ParquesDAO:IDAO<Parques>
    {

        public void Inserir(Parques p)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO atracoes(codigo_atracoes, hora_de_abertura, hora_de_fechamento, nome, rua, bairro, numero, cep, telefone, id_ciclofaixas) VALUES(?codigo, ?hora_de_abertura, ?hora_de_fechamento, ?nome, ?rua, ?bairro, ?numero, ?cep, ?telefone, ?ciclofaixa);";
            Com.CommandText += " INSERT INTO parques(cod_atra, preco_entrada) VALUES(?codigo, ?preco_entrada);";
            Com.Parameters.AddWithValue("?hora_de_abertura", p.Hora_abertura);
            Com.Parameters.AddWithValue("?hora_de_fechamento", p.Hora_fechamento);
            Com.Parameters.AddWithValue("?nome", p.Nome);
            Com.Parameters.AddWithValue("?rua", p.Rua);
            Com.Parameters.AddWithValue("?bairro", p.Bairro);
            Com.Parameters.AddWithValue("?numero", p.Numero);
            Com.Parameters.AddWithValue("?cep", p.Cep);
            Com.Parameters.AddWithValue("?telefone", p.Telefone);
            Com.Parameters.AddWithValue("?codigo", BD.CriaId("atracoes", "codigo_atracoes"));
            Com.Parameters.AddWithValue("?preco_entrada", p.Preco_entrada);
            Com.Parameters.AddWithValue("?ciclofaixa", p.Ciclofaixa.CodigoCiclofaixa);




            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Parque Inserido com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
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




        public void Editar(Parques p, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {

                Com.CommandText = "UPDATE atracoes a JOIN parques p ON a.codigo_atracoes = p.cod_atra SET a.hora_de_abertura = ?hora_de_abertura, a.hora_de_fechamento = ?hora_de_fechamento, a.nome = ?nome, a.rua = ?rua, a.bairro = ?bairro, a.cep = ?cep, a.telefone = ?telefone, p.preco_entrada = ?preco_entrada WHERE a.codigo_atracoes = ?id";
                Com.Parameters.AddWithValue("?hora_de_abertura", p.Hora_abertura);
                Com.Parameters.AddWithValue("?hora_de_fechamento", p.Hora_fechamento);
                Com.Parameters.AddWithValue("?nome", p.Nome);
                Com.Parameters.AddWithValue("?rua", p.Rua);
                Com.Parameters.AddWithValue("?bairro", p.Bairro);
                Com.Parameters.AddWithValue("?numero", p.Numero);
                Com.Parameters.AddWithValue("?cep", p.Cep);
                Com.Parameters.AddWithValue("?telefone", p.Telefone);
                Com.Parameters.AddWithValue("?id", id);
                Com.Parameters.AddWithValue("?preco_entrada", p.Preco_entrada);
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




        public List<Parques> ListaTodos()
        {
            List<Parques> ListParques = new List<Parques>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "select a.codigo_atracoes, a.hora_de_abertura, a.hora_de_fechamento, a.nome,a.rua, a.bairro, a.numero, a.cep, a.telefone, p.preco_entrada, c.nome FROM atracoes a, parques p , ciclofaixas c WHERE a.codigo_atracoes=p.cod_atra AND c.id_ciclofaixas = a.id_ciclofaixas;";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    Parques p = new Parques((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (Convert.ToDouble(dr["preco_entrada"])));

                    ListParques.Add(p);
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

            return ListParques;
        }



        public List<Parques> ListaId(string id)
        {
            List<Parques> ListParques = new List<Parques>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM atracoes a, parques p WHERE a.codigo_atracoes = "+id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    Parques p = new Parques((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (Convert.ToDouble(dr["preco_entrada"])));

                    ListParques.Add(p);
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

            return ListParques;
        }








        public List<Parques> selecionaParqueNome(string where)
        {
            Parques parque = new Parques();
            List<Parques> listap = new List<Parques>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM atracoes a, parques p WHERE a.codigo_atracoes = p.cod_atra "  + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    
                    CiclofaixasDAO cDAO = new CiclofaixasDAO();
                    Ciclofaixas c = cDAO.SelecionaCiclofaixaNome((String)dr["nome"]);
                    
                    Parques p = new Parques((Convert.ToInt16(dr["codigo_atracoes"])),
                        (String)dr["hora_de_abertura"], (String)dr["hora_de_fechamento"], (String)dr["nome"],
                        (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"], c, (Convert.ToDouble(dr["preco_entrada"])));

                    listap.Add(p);
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

            return listap;
        }




    }

}
