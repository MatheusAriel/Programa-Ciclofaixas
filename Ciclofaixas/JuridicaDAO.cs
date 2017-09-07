using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ciclofaixas
{
    class JuridicaDAO
    {

        public void Inserir(Juridica j)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();

            Com.CommandText = "INSERT INTO pessoa(id_pessoa, nome, rua, bairro, numero, cep, cidade, estado, email, telefone) VALUES(?codigo, ?nome, ?rua, ?bairro, ?numero, ?cep, ?cidade, ?estado, ?email, ?telefone);";
            Com.CommandText += " INSERT INTO juridica(id_pessoa, cnpj) VALUES(?codigo, ?cnpj);";
            Com.Parameters.AddWithValue("?nome", j.Nome);
            Com.Parameters.AddWithValue("?rua", j.Rua);
            Com.Parameters.AddWithValue("?bairro", j.Bairro);
            Com.Parameters.AddWithValue("?numero", j.Numero);
            Com.Parameters.AddWithValue("?cep", j.Cep);
            Com.Parameters.AddWithValue("?cidade", j.Cidade);
            Com.Parameters.AddWithValue("?estado", j.Estado);
            Com.Parameters.AddWithValue("?email", j.Email);
            Com.Parameters.AddWithValue("?telefone", j.Telefone);
            Com.Parameters.AddWithValue("?codigo",BD.CriaId("pessoa", "id_pessoa")); 
            Com.Parameters.AddWithValue("?cnpj", j.Cnpj);




            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Pessoa Inserida com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no cadastro @pessoa!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
        }




        public void Editar(Juridica j, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {
                Com.CommandText = "UPDATE pessoa p JOIN juridica j ON p.id_pessoa = j.id_pessoa SET p.nome = ?nome, p.rua = ?rua, p.bairro = ?bairro, p.numero = ?numero, p.cep = ?cep, p.cidade = ?cidade, p.estado = ?estado, p.email = ?email, p.telefone = ?telefone, j.cnpj = ?cnpj WHERE p.id_pessoa = ?id";
                Com.Parameters.AddWithValue("?nome", j.Nome);
                Com.Parameters.AddWithValue("?rua", j.Rua);
                Com.Parameters.AddWithValue("?bairro", j.Bairro);
                Com.Parameters.AddWithValue("?numero", j.Numero);
                Com.Parameters.AddWithValue("?cep", j.Cep);
                Com.Parameters.AddWithValue("?cidade", j.Cidade);
                Com.Parameters.AddWithValue("?estado", j.Estado);
                Com.Parameters.AddWithValue("?email", j.Email);
                Com.Parameters.AddWithValue("?telefone", j.Telefone);
                Com.Parameters.AddWithValue("?id_pessoa", j.Id_pessoa);
                Com.Parameters.AddWithValue("?cnpj", j.Cnpj);
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

                Com.CommandText = "DELETE FROM pessoa WHERE id_pessoa = ?id";
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




        public List<Juridica> SelecionaJuridicaNome(string where)
        {
            Juridica juridica = new Juridica();
            List<Juridica> listapj = new List<Juridica>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM pessoa p, juridica j  WHERE p.id_pessoa = j.id_pessoa " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {



                    Juridica j = new Juridica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"],
                        (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"], (String)dr["email"], (String)dr["telefone"], (String)dr["cnpj"]);

                    listapj.Add(j);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @pessoa!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return listapj;
        }



        public List<Juridica> ListaId(string id)
        {
            List<Juridica> ListJuridica = new List<Juridica>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM pessoa p, juridica f WHERE p.id_pessoa = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    Juridica j = new Juridica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"],
                        (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"],
                        (String)dr["email"], (String)dr["telefone"], (String)dr["cnpj"]);

                    ListJuridica.Add(j);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @pessoa!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListJuridica;
        }







        public List<Juridica> ListaTodos()
        {
            List<Juridica> ListJuridica = new List<Juridica>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM pessoa p, juridica j WHERE p.id_pessoa = j.id_pessoa;";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    Juridica j = new Juridica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"],
                        (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"],
                        (String)dr["email"], (String)dr["telefone"], (String)dr["cnpj"]);

                    ListJuridica.Add(j);

                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @pessoa!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListJuridica;
        }


    }
}
