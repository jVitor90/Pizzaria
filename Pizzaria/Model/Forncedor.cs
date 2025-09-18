using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    internal class Forncedor
    {
        public int id_fornecedor { get; set; }
        public string pizzarias { get; set; }
        public string cnpj { get; set; }
        public string contato { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string endereco { get; set; }

        // Inserir um fornecedor
        public bool Inserir()
        {
            
            string comando = "INSERT INTO fornecedor (pizzarias, cnpj, contato, telefone, email, endereco) " +
                             "VALUES (@pizzaria @cnpj, @contato, @telefone, @email, @endereco)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("pizzarias", pizzarias);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.ExecuteNonQuery();
            // impede que o programa quebre
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
            // se deer erro vai desconectar do banco de dados
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }



        }

        // Atualizar um fornecedor
       public bool Modificar()
        {

            string comando = "UPDATE fornecedor SET id_fornecedor = @id_fornecedor, pizzarias = @pizzaria cnpj = @cnpj, contato = @contato, telefone = @telefone, email = @email, endereco = @endereco WHERE id_fornecedor = @id_fornecedor";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("pizzarias", pizzarias);
            cmd.Parameters.AddWithValue("@cnpj", cnpj);
            cmd.Parameters.AddWithValue("@contato", contato);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@endereco", endereco);

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

        // Excluir um fornecedor
        public bool Excluir()
        {
            string comando = "DELETE FROM fornecedor WHERE id_fornecedor = @id_fornecedor";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("id_fornecedor", id_fornecedor);

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
            string comando = "SELECT pizzarias, cnpj, contato, telefone, email, endereco FROM id_fornecedor;";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // tabela q vai receber o resultado
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }


    }
}
