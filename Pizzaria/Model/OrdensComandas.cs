using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class OrdensComandas
    {


        public int id_comanda { get; set; }
        public int num_mesa { get; set; }
        public int id_resp { get; set; }
        public DateTime data_adic { get; set; }
        public int situacao { get; set; }
        public string metodo_pagamento { get; set; }

        public DataTable BuscarMesa()
        {
            string comando = "SELECT * FROM ordens_comandas WHERE num_mesa = @num_mesa;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO ordens_comandas " +
                "( id_comanda, num_mesa, id_resp, situacao) " +
                "VALUES (@id_comanda, @num_mesa, @id_resp, @situacao)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_comanda", id_comanda);
            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);
            cmd.Parameters.AddWithValue("@id_resp", id_resp);
            cmd.Parameters.AddWithValue("@situacao", situacao);
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
            // se der erro, ele ira desconectar do bd
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
