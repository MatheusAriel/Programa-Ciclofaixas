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
    class Ciclista_locacaoDAO
    {
        public void Inserir(Ciclista_Locacao cl)
        {
            BD.conectar();
            MySqlCommand Com = BD.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO ciclista_locacao(data, hora_locacao, cod_bic, id_pes) VALUES(?data, ?hora_locacao, ?cod_bic, ?id_pes);";
            Com.Parameters.AddWithValue("?data", cl.Data);
            Com.Parameters.AddWithValue("?hora_locacao", cl.Hora_locacao);
            Com.Parameters.AddWithValue("?cod_bic", cl.Bicicleta.Codigo_bicicleta);
            Com.Parameters.AddWithValue("?id_pes", cl.Pessoa.Id_pessoa);





            try
            {
                int registrosInseridos = Com.ExecuteNonQuery();
                MessageBox.Show("Ciclista - Locação Inserida com Sucesso !", "OK !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no cadastro @Ciclista - Locação!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }
        }







        public List<Ciclista_Locacao> ListaTodos()
        {
            List<Ciclista_Locacao> ListCiclista = new List<Ciclista_Locacao>();
            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT *FROM ciclista_locacao cl, pessoa p, bicicletas b , estacoes e WHERE p.id_pessoa = cl.id_pes and cl.cod_bic = b.codigo_bicicleta and e.codigo_estacao = b.cod_esta ";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    Fisica pf = new Fisica((Convert.ToInt16(dr["id_pessoa"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["cidade"], (String)dr["estado"], (String)dr["email"], (String)dr["telefone"]);

                    Estacoes es = new Estacoes((Convert.ToInt16(dr["codigo_estacao"])), (String)dr["nome"], (String)dr["rua"], (String)dr["bairro"], (String)dr["numero"], (String)dr["cep"], (String)dr["telefone"]);


                    Bicicletas b = new Bicicletas((Convert.ToInt16(dr["codigo_bicicleta"])), (String)dr["cor"], (String)dr["modelo"], es);

                    Ciclista_Locacao cl = new Ciclista_Locacao((String)dr["data"], (String)dr["hora_locacao"], pf, b);
                    ListCiclista.Add(cl);
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select @ciclista - locação!\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return ListCiclista;
        }


    }
}
