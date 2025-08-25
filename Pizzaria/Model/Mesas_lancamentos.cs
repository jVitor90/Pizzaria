 using System;
using System.Collections.Generic;
using System.Linq;
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
                             "SET pagamento = @pagamento " +
                             "WHERE id_lancamento = @id_lancamento";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            // supondo que você tenha uma propriedade id_lancamento
            cmd.Parameters.AddWithValue("@id_lancamento", id_lancamento);
            cmd.Parameters.AddWithValue("@pagamento", 1); // 0 = encerrado/pago, 1 = em aberto

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
    }
}