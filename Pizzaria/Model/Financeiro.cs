using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class Financeiro
    {
        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }

        public DataTable ObterFaturamentoPeriodo()
        {
            string comando = @"
            SELECT 
                SUM(p.preco * ml.quantidade) AS faturamento_total 
            FROM 
                mesas_lancamentos ml 
            JOIN 
                produtos p ON ml.id_Produto = p.id_produto 
            JOIN 
                mesas m ON ml.num_mesa = m.num_mesa 
            WHERE 
                ml.pagamento = 0  
                AND m.ativa = 0    
                AND m.data_adic BETWEEN @data_inicio AND @data_fim;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@data_inicio", data_inicio);
            cmd.Parameters.AddWithValue("@data_fim", data_fim);

            DataTable tabela = new DataTable();
            try
            {
                tabela.Load(cmd.ExecuteReader());
                conexaoBD.Desconectar(con);
                return tabela;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return null;
            }
        }
        public DataTable ObterFaturamentoMensal()
        {
            string comando = @"
            SELECT 
            SUM(p.preco * ml.quantidade) AS faturamento_total_geral 
            FROM 
            mesas_lancamentos ml 
            JOIN 
            produtos p ON ml.id_Produto = p.id_produto 
            JOIN 
            mesas m ON ml.num_mesa = m.num_mesa 
            WHERE 
            ml.pagamento = 0 
            AND m.ativa = 0;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            DataTable tabela = new DataTable();
            try
            {
                tabela.Load(cmd.ExecuteReader());
                conexaoBD.Desconectar(con);
                return tabela;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return null;
            }
        }
        public DataTable ObterFaturamentoMensalAtual()
        {
            string comando = @"
             SELECT 
              YEAR(m.data_adic) AS ano, 
              MONTH(m.data_adic) AS mes, 
              SUM(p.preco * ml.quantidade) AS faturamento_mensal 
              FROM 
              mesas_lancamentos ml 
              JOIN 
              produtos p ON ml.id_Produto = p.id_produto 
              JOIN 
              mesas m ON ml.num_mesa = m.num_mesa 
              WHERE 
              ml.pagamento = 0 
              AND m.ativa = 0 
              AND m.data_adic BETWEEN @data_inicio AND @data_fim  -- Adicionado filtro de datas
              GROUP BY 
              ano, mes 
              ORDER BY 
              ano DESC, mes DESC;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@data_inicio", data_inicio);  
            cmd.Parameters.AddWithValue("@data_fim", data_fim);        

            DataTable tabela = new DataTable();
            try
            {
                tabela.Load(cmd.ExecuteReader());
                conexaoBD.Desconectar(con);
                return tabela;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return null;
            }
        }
    }
}
