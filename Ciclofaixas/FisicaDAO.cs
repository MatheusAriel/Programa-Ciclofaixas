using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Ciclofaixas
{
    class FisicaDAO:IDAO<Fisica>
    {

        public void Inserir(Fisica f)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();

            Com.CommandText = "INSERT INTO pessoa(id_pessoa, nome, rua, bairro, numero, cep, cidade, estado, email, telefone) VALUES(?codigo, ?nome, ?rua, ?bairro, ?numero, ?cep, ?cidade, ?estado, ?email, ?telefone);";
            Com.CommandText += " INSERT INTO fisica(id_pessoa, cpf, rg, data_nasc) VALUES(?codigo, ?cpf, ?rg, ?data_nasc);";
            Com.Parameters.AddWithValue("?nome", f.Nome);
            Com.Parameters.AddWithValue("?rua", f.Rua);
            Com.Parameters.AddWithValue("?bairro", f.Bairro);
            Com.Parameters.AddWithValue("?numero", f.Numero);
            Com.Parameters.AddWithValue("?cep", f.Cep);
            Com.Parameters.AddWithValue("?cidade", f.Cidade);
            Com.Parameters.AddWithValue("?estado", f.Estado);
            Com.Parameters.AddWithValue("?email", f.Email);
            Com.Parameters.AddWithValue("?telefone", f.Telefone);
            Com.Parameters.AddWithValue("?codigo", BD.CriaId("pessoa", "id_pessoa"));   
            Com.Parameters.AddWithValue("?cpf", f.Cpf);
            Com.Parameters.AddWithValue("?rg", f.Rg);
            Com.Parameters.AddWithValue("?data_nasc", f.Data_nasc);

         

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




        public void Editar(Fisica f, string id)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            try
            {
                Com.CommandText = "UPDATE pessoa p JOIN fisica f ON p.id_pessoa = f.id_pessoa SET p.nome = ?nome, p.rua = ?rua, p.bairro = ?bairro, p.numero = ?numero, p.cep = ?cep, p.cidade = ?cidade, p.estado = ?estado, p.email = ?email, p.telefone = ?telefone, f.cpf = ?cpf, f.rg = ?rg, f.data_nasc = ?data_nasc WHERE p.id_pessoa = ?id";
                Com.Parameters.AddWithValue("?nome", f.Nome);
                Com.Parameters.AddWithValue("?rua", f.Rua);
                Com.Parameters.AddWithValue("?bairro", f.Bairro);
                Com.Parameters.AddWithValue("?numero", f.Numero);
                Com.Parameters.AddWithValue("?cep", f.Cep);
                Com.Parameters.AddWithValue("?cidade", f.Cidade);
                Com.Parameters.AddWithValue("?estado", f.Estado);
                Com.Parameters.AddWithValue("?email", f.Email);
                Com.Parameters.AddWithValue("?telefone", f.Telefone);
                Com.Parameters.AddWithValue("?cpf", f.Cpf);
                Com.Parameters.AddWithValue("?rg", f.Rg);
                Com.Parameters.AddWithValue("?data_nasc", f.Data_nasc);
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





        public List<Fisica> SelecionaFisicaNome(string where)
        {
            Fisica fisica = new Fisica();
            List<Fisica> Listapf = new List<Fisica>();

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();

                cmd.CommandText = "SELECT * FROM pessoa p, fisica f  WHERE p.id_pessoa = f.Id_pessoa " + where;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {



                    Fisica f = new Fisica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], 
                        (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"], (String)dr["email"], (String)dr["telefone"], (String)dr["cpf"], (String)dr["rg"], (String)dr["data_nasc"]);

                    Listapf.Add(f);
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

            return Listapf;
        }



        public List<Fisica>ListaId(string id)
        {
            List<Fisica> ListFisica = new List<Fisica>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM pessoa p, fisica f WHERE p.id_pessoa = " + id;
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {

                    Fisica f = new Fisica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"],
                        (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"],
                        (String)dr["email"], (String)dr["telefone"], (String)dr["cpf"], (String)dr["rg"], (String)dr["data_nasc"]);

                    ListFisica.Add(f);
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

            return ListFisica;
        }











        public List<Fisica> ListaTodos()
        {
            List<Fisica> Listfisica = new List<Fisica>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT * FROM pessoa p, fisica f WHERE p.id_pessoa = f.id_pessoa;";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while(dr.Read())
                {
                    Fisica f = new Fisica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], 
                        (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"], 
                        (String)dr["email"], (String)dr["telefone"], (String)dr["cpf"], (String)dr["rg"], (String)dr["data_nasc"]);

                    Listfisica.Add(f);

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

            return Listfisica;
        }





        
    }

}
