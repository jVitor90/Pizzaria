 using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Mesas_lancamentos
    {
        public int id_lancamento { get; set; }
        public int num_mesa { get; set; }
        public int id_Produto { get; set; }
        public int quantidade { get; set; }
        public int cozinha { get; set; }
        public int pagamento { get; set; }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO mesas_lancamentos " +
             "(num_mesa, id_Produto, quantidade, cozinha, pagamento) " +
              "VALUES (@num_mesa, @id_Produto, @quantidade, @cozinha, @pagamento)";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // parâmetros que você deve passar do seu código
            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);
            cmd.Parameters.AddWithValue("@id_Produto", id_Produto);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@cozinha", cozinha);
            cmd.Parameters.AddWithValue("@pagamento", pagamento);

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
            string comando = "UPDATE mesas_lancamentos " +
                     "SET pagamento = 0 " +
                     "WHERE num_mesa = @num_mesa AND pagamento = 1";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            cmd.Prepare();

            try
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                conexaoBD.Desconectar(con);
                return rowsAffected > 0;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public DataTable Listar()
        {


            string comando = "SELECT * FROM view_mesas_abertas  WHERE num_mesa = @num_mesa";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public DataTable ListarProdutos()
        {
            string comando = @"
             SELECT 
              ml.id_lancamento,
               ml.num_mesa,
              ml.id_Produto,
              p.nome_produto,
              ml.quantidade,
              p.preco,
              (p.preco * ml.quantidade) AS total_item,
              m.nome_cliente
              FROM mesas_lancamentos ml
              INNER JOIN produtos p 
              ON ml.id_Produto = p.id_produto
              LEFT JOIN mesas m
              ON ml.num_mesa = m.num_mesa AND m.ativa = 1
              WHERE ml.pagamento = 1
              AND ml.num_mesa = @num_mesa;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool ExcluirPorId()
        {
            string comando = "DELETE FROM mesas_lancamentos WHERE id_lancamento = @id_lancamento";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_lancamento", id_lancamento);

            try
            {
                bool sucesso = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return sucesso;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool ExcluirPorMesa()
        {
            string comando = "DELETE FROM mesas_lancamentos WHERE num_mesa = @num_mesa";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            try
            {
                bool sucesso = cmd.ExecuteNonQuery() >= 0; // >= 0 porque pode não haver lançamentos
                conexaoBD.Desconectar(con);
                return sucesso;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }   


    }
}