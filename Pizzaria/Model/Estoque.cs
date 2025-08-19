using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    internal class Estoque
    {
        public int id_estoque { get; set; }
        public string nome_item {  get; set; }
        public decimal quantidade {  get; set; }
        public string unidade { get; set; }
        public int Id_Categoria { get; set;}
        public DateTime atualizado_em { get; set; }
        

        public DataTable Listar()
        {
            string comando = "SELECT * FROM estoque;";

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
        public bool Modificar()
        {
            string comando = "UPDATE estoque SET nome_item = @nome_item, quantidade = @quantidade, unidade = @unidade, Id_Categoria = @Id_Categoria WHERE id_estoque = @id_estoque";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_produto", nome_item);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@Id_Categoria", Id_Categoria);
            cmd.Parameters.AddWithValue("@id_estoque", id_estoque);



            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            // se der erro, ele ira desconectar do bd
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
