using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Pizzaria.Model
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int cpf { get; set; }
        public int Cargo { get; set; }


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

    }
}
