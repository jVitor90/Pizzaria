using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Banco
    {
        private const string SERVER = "localhost",
                             PORT = "3306",
                             DATABASE = "pizzaria",
                             UID = "root",
                             PWD = "";

        public MySqlConnection ObterConexao()
        {
            MySqlConnection con = new MySqlConnection(
                "SERVER=" + SERVER + ";PORT=" + PORT +
                ";DATABASE=" + DATABASE + ";UID=" + UID + ";PWD=" + PWD + ";");
            try
            {
                con.Open();
            }
            catch (MySqlException e)
            {
                System.Windows.Forms.MessageBox.Show(
                    "Erro ao conectar ao banco de dados:\n\n" + e.Message,
                    "Erro de Conexão",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                throw;
            }
            return con;
        }

        public bool ConexaoAberta(MySqlConnection con)
        {
            return (con.State == ConnectionState.Open);
        }

        public void Desconectar(MySqlConnection con)
        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}