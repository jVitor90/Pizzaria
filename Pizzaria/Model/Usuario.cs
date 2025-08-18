using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string Nome_usuario { get; set; }
        public string Senha { get; set; }
        public string cpf { get; set; }
        public string Cargo { get; set; }
        public DateTime criado_em { get; set; }


        public DataTable Logar()
        {
            string comando = "SELECT * FROM  usuarios WHERE" +
                " cpf = @cpf AND senha = @senha";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);


            // Trocar os cacacteres coringa pelos valores reais 
            cmd. Parameters.AddWithValue("@cpf", cpf);
            // Criar hash da senha
            string senhasha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", senhasha);

            cmd.Prepare();
            // Declarar a tabela que vai receber o resultado
            DataTable tabela = new DataTable();
            // Colocar o resultado da consulta na tabela
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Cadastrar()
        {
            string comando = "INSERT INTO usuarios ( nome_usuario, cpf, cargo, senha) " +
                "VALUES (@nome_usuario, @cpf, @cargo, @senha)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_usuario", Nome_usuario);
            cmd.Parameters.AddWithvalue("@cpf", cpf);
            cmd.Parameters.AddWithvalue("@cargo", Cargo);
            cmd.Parameters.AddWithvalue("@senha", Senha);
            // Obter o hash
            string hashsenha = EasyEncryption.SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", hashsenha);
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
        public DataTable Listar()
        {
            Banco conexaoBD = new Banco();
            MysqlConnection con = conexaoBD.ObterConexao();
            Mysqlcommand cmd = new Mysqlcommand(comando, con );

            cmd.Prepare();
            //Declarar tablela que ira receber o resultado

        }
        }

    }
}
