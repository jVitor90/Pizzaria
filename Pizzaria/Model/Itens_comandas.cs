 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Itens_comandas
    {
        public int id_item {  get; set; }
        public int id_Comanda { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public string situacao_pedido { get; set; }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO itens_comandas " +
                "( id_item, id_comanda, id_produto, quantidade, situacao_pedido) " +
                "VALUES (@id_item, @id_comanda, @id_produto, @quantidade, @situacao_pedido)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_item", id_item);
            cmd.Parameters.AddWithValue("@id_comanda", id_Comanda);
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@situacao_pedido", situacao_pedido);
            cmd.Prepare();

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
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Encerrar()
        {
            string comando = "UPDATE itens_comandas SET situacao_pedido = @situacao_pedido WHERE id_item = @id_item";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_item", id_item);
            cmd.Prepare();

            // para impedir que o programa quebre 
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
