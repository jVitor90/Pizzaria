using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class Mesas
    {
        public int id_mesa { get; set; }
        public int num_mesa { get; set; }
        public int id_resp { get; set; }
        public DateTime data_adic { get; set; }
        public string nome_cliente { get; set; }
        public bool ativa { get; set; }

        // Buscar mesa pelo número
        public DataTable BuscarMesa()
        {
            string comando = @"
            SELECT 
                id_mesa,
                num_mesa,
                id_resp,
                data_adic,
                nome_cliente,
                ativa
            FROM mesas
            WHERE num_mesa = @num_mesa;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO mesas (num_mesa, id_resp, nome_cliente, ativa) " +
                             "VALUES (@num_mesa, @id_resp, @nome_cliente, @ativa)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);
            cmd.Parameters.AddWithValue("@id_resp", id_resp);
            cmd.Parameters.AddWithValue("@nome_cliente", nome_cliente ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@ativa", ativa);
            //try
            //{
                bool sucesso = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return sucesso;
           // }
           // catch
           // {
                conexaoBD.Desconectar(con);
                return false;
           // }
        }

        public bool Encerrar()
        {
            string comando = "UPDATE mesas SET ativa = 0 WHERE num_mesa = @num_mesa AND ativa = 1";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

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

        public DataTable ListarMesas()
        {
            string comando = "SELECT mesas.id_mesa, mesas.num_mesa, usuarios.nome_usuario AS " +
                "responsavel, mesas.data_adic, mesas.nome_cliente, mesas.ativa" +
                " FROM mesas INNER JOIN usuarios ON mesas.id_resp = usuarios.id_usuario WHERE mesas.ativa = 1;";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);



            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool ExcluirPorId()
        {
            string comando = "DELETE FROM mesas WHERE id_mesa = @id_mesa";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();

            // Garante que a conexão esteja aberta
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_mesa", id_mesa);

            try
            {
                bool sucesso = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con); // Fecha a conexão após a execução
                return sucesso;
            }
            catch
            {
                conexaoBD.Desconectar(con); // Garante que a conexão seja fechada em caso de erro
                return false;
            }

        }

        public bool ExcluirPorMesa()
        {
            string comando = "DELETE FROM mesas WHERE num_mesa = @num_mesa AND ativa = 1";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@num_mesa", num_mesa);

            //try
            //{
            bool sucesso = cmd.ExecuteNonQuery() > 0;
            conexaoBD.Desconectar(con);
            return sucesso;
            //}
            //catch
            //{
            //conexaoBD.Desconectar(con);
            //return false;
            //}
        }

    }
}
