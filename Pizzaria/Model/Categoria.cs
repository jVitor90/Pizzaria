using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Categoria
    {
        public int id_categoria {  get; set; } 
        public string nome_categoria { get; set; }
        public int id_Usuario { get; set; }
        public DateTime criado_em { get; set; }

        public int Cadastrar()
        {
            // Modificar depois
            return 0;
        }
        public DataTable Listar()
        {
            string comando = "SELECT * FROM categoria;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar a t6abela que irá receber o rtesultado
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;



        }
        public DataTable Listar2()
        {
            string comando = "SELECT nome_categoria, id_categoria FROM categoria WHERE id_categoria IN (5, 6);";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar a t6abela que irá receber o rtesultado
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;

        }
        public int Exluir()
        {
            return 0; // Modificar depois
        }
        public int Modificar()
        {
            return 0; // Modificar depois
        }
    }
}
