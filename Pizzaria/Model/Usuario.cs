using EasyEncryption;
using MySqlConnector;
using System;
using System.Data;

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
            string comando = "SELECT * FROM usuarios WHERE cpf = @cpf AND senha = @senha";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@cpf", cpf);
            string senhasha = SHA.ComputeSHA256Hash(Senha);
            cmd.Parameters.AddWithValue("@senha", senhasha);

            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO usuarios (nome_usuario, cpf, cargo, senha) " +
                             "VALUES (@nome_usuario, @cpf, @cargo, @senha)";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome_usuario", Nome_usuario);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@cargo", Cargo);
            cmd.Parameters.AddWithValue("@senha", SHA.ComputeSHA256Hash(Senha));

            cmd.Prepare();
            try
            {
                bool ok = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return ok;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public DataTable Listar()
        {
            string comando = "SELECT id_usuario, nome_usuario, senha, cpf, cargo FROM usuarios;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }

        public bool Modificar()
        {
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();

            string comando;
            MySqlCommand cmd;

            if (string.IsNullOrEmpty(Senha))
            {
                // Não altera a senha
                comando = "UPDATE usuarios SET nome_usuario = @nome_usuario, cpf = @cpf, cargo = @cargo " +
                          "WHERE id_usuario = @id_usuario";
                cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@nome_usuario", Nome_usuario);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cargo", Cargo);
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            }
            else
            {
                // Altera a senha também
                comando = "UPDATE usuarios SET nome_usuario = @nome_usuario, cpf = @cpf, cargo = @cargo, senha = @senha " +
                          "WHERE id_usuario = @id_usuario";
                cmd = new MySqlCommand(comando, con);
                cmd.Parameters.AddWithValue("@nome_usuario", Nome_usuario);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@cargo", Cargo);
                cmd.Parameters.AddWithValue("@senha", SHA.ComputeSHA256Hash(Senha));
                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
            }

            cmd.Prepare();
            try
            {
                bool ok = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return ok;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }

        public bool Excluir()
        {
            string comando = "DELETE FROM usuarios WHERE id_usuario = @id_usuario";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

            cmd.Prepare();
            try
            {
                bool ok = cmd.ExecuteNonQuery() > 0;
                conexaoBD.Desconectar(con);
                return ok;
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}