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
    class BD
    {
        private static MySqlConnection mConn;
        private static MySqlDataAdapter mAdapter;

        private static string pathServer = "localhost";
        private static string dataBase = "ciclofaixas";
        private static string user = "matheus";
        private static string password = "root";

        public static MySqlConnection MConn
        {
            get
            {
                return mConn;
            }

            set
            {
                mConn = value;
            }
        }

        public static string GetURL()
        {
            return "SERVER=" + pathServer + "; DATABASE=" +
                dataBase + "; UID=" + user + "; PASSWORD=" + password + ";";
        }

        public static void conectar()
        {
            Console.Write(GetURL());
            mConn = new MySqlConnection(GetURL());
            mConn.Open();

        }

        public static void desconectar()
        {
            try
            {
                mConn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na conexão com o Banco de Dados", e);
            }
        }

        public DataSet GetDataSet(string command)
        {
            DataSet mDataSet = new DataSet();
            conectar();

            mAdapter = new MySqlDataAdapter(command, mConn);

            mAdapter.Fill(mDataSet);

            desconectar();
            return mDataSet;
        }

        public bool SetDados(string comando)
        {
            conectar();

            try
            {
                MySqlCommand command = new MySqlCommand(comando, mConn);
                command.ExecuteNonQuery();
            }

            catch (Exception e)
            {
                Console.WriteLine("Erro ao executar o comando " + comando + "\n ERRO: " + e);
            }
            desconectar();

            return true;
        }

        public static int ValorMaximoID(string tabela, string nomeID)
        {
            int aux = 1;

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT max(" + nomeID + ") as UltimoID FROM " + tabela + ";";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    try
                    {
                        aux = Convert.ToInt16(dr["UltimoID"]);
                    }

                    catch
                    {
                        aux = 1;
                    }
                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return aux;
        }




        public static int CriaId(string tabela, string nomeID)
        {
            int aux = 0;

            try
            {
                BD.conectar();
                MySqlCommand cmd = BD.MConn.CreateCommand();
                cmd.CommandText = "SELECT max(" + nomeID + ") as UltimoID FROM " + tabela + ";";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, BD.MConn);

                while (dr.Read())
                {
                    try
                    {
                        //Console.WriteLine(Convert.ToInt32(dr["UltimoID"]));
                        // String a = (String) (dr["UltimoID"]);
                        //Console.WriteLine("aqui" + dr["UltimoID"]);
                        //aux = Convert.ToInt32(a);
                        Console.WriteLine(Convert.ToInt16(dr["UltimoID"]));
                        aux = Convert.ToInt16(dr["UltimoID"]);
                    }

                    catch
                    {
                        aux = 0;
                    }

                }

            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro\n" + ex);
            }

            finally
            {
                BD.desconectar();
            }

            return aux + 1;
        }

        public static void TestaBancoDados()
        {
            try
            {
                conectar();
            }
            catch
            {
                MessageBox.Show("Erro na conexxão do Banco de Dados, o programa será fechado");
                return;
            }
            finally
            {
                desconectar();
            }
        }





    }


}
