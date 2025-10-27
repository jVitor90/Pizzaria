using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Banco
    {
        //Informações da conexão com o BD
        private const string SERVER = "localhost",
                              PORT = "3306",
                              DATABASE = "pizzaria",
                              UID = "root",
                              PWD = "qNJqN_j5J(LNKUR2";

        // Conecta ao BD

        public MySqlConnection ObterConexao()
        {
            MySqlConnection con = null;
            try
            {
                con = new MySqlConnection("SERVER=" + SERVER + ";PORT=" + PORT + ";DATABASE=" + DATABASE + ";UID=" + UID + ";PWD=" + PWD + ";");
                con.Open();
            }
            catch(MySqlException e) 
            {
                Console.WriteLine(e.ToString());

                Console.WriteLine("Não foi possivel realizar a conexão. ");
            }
            return con;
        }

        //Verificar se a conexão esta aberta
        public bool ConexaoAberta(MySqlConnection con)
        {
            return (con.State == ConnectionState.Open);
        }

        // Metodo para desconectar
        public void  Desconectar(MySqlConnection con)
        {
            try
            {
                con.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());

                Console.WriteLine("Não foi possivel encerrar a conexão. ");
            }
        }
    }
}
