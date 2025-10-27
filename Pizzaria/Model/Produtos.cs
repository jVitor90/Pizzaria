using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Produtos
    {
        public int Id_produto {  get; set; }
        public string nome_produto { get; set; }
        public decimal preco {  get; set; }
        public int id_categoria { get; set; }
        public int disponivel { get; set; }
        public DateTime atualizado_em { get; set; }
        
        public bool Cadastrar()
        {
            string comando = " INSERT INTO produtos (nome_produto, preco, id_categoria) " +
                "VALUES (@nome_produto, @preco, @id_categoria)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Prepare();
            // impede que o programa quebre
            try
            {
                if(cmd.ExecuteNonQuery() == 0)
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
        public DataTable Listar()
        {
            string comando = "SELECT id_produto, nome_produto, preco, id_categoria, disponivel, atualizado_em FROM produtos;";

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

        public DataTable ListarPorCategoria(string tipo_pizza = null)
        {
            string comando = "SELECT id_produto, nome_produto, tipo_pizza " +
                     "FROM produtos " +
                     "WHERE id_Categoria = @id_categoria AND disponivel = 1";

            if (!string.IsNullOrEmpty(tipo_pizza))
            {
                comando += " AND tipo_pizza = @tipo_pizza";
            }

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            if (!string.IsNullOrEmpty(tipo_pizza))
            {
                cmd.Parameters.AddWithValue("@tipo_pizza", tipo_pizza);
            }
            cmd.Prepare();

            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Modificar()
        {
            string comando = "UPDATE produtos SET nome_produto = @nome_produto, preco = @preco, id_categoria = @id_categoria WHERE id_produto = @id_produto";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand( comando, con);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@id_produto", Id_produto);



            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {

                }
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
        public bool Remover()
        {
            string comando  = "DELETE FROM produtos WHERE id_produto = @id_produto";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_produto", Id_produto);

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
        public DataTable ObterTipoPizza()
        {
            string comando = "SELECT tipo_pizza FROM produtos WHERE id_produto = @id_produto";

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@id_produto", Id_produto);

            cmd.Prepare();
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool VerificarProdutoExistente(string nome)
        {
            string comando = "SELECT COUNT(*) FROM produtos WHERE nome_produto = @nome_produto";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_produto", nome);

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
