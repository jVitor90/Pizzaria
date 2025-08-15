using System;
using System.Collections.Generic;
using System.Data;
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
        public int id_Resp {  get; set; }

        public bool Cadastrar()
        {
            string comando = " INSERT INTO produtos (nome_produto, preco, id_categoria, disponivel, atualizado_em, id_Resp) " +
                "VALUES (@nome_produto, @preco, @id_categoria, @disponivel, @atualizado_em, @id_Resp)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome_produto", nome_produto);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@disponivel", disponivel);
            cmd.Parameters.AddWithValue("@atualizado_em", atualizado_em);
            cmd.Parameters.AddWithValue("@id_Resp", id_Resp);
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
    }
}
