using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.Model;

namespace Pizzaria
{
    public partial class FrmCadastrarProdutos : Form
    {
        Model.Usuario usuario = new Usuario();
        Model.Produtos produtos = new Produtos();
        Model.Categoria categoria = new Categoria();
        public FrmCadastrarProdutos()
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();


            //Obter as categorias do banco
            DataTable resultadoCategoria = categoria.Listar();
            foreach(DataRow linha in resultadoCategoria.Rows)
            {
                //Adicionar os Combobox
                cmbCategoria.Items.Add($"{linha["id_categoria"]} - {linha["nome_categoria"]}");
            } 
        }
        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produtos.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //validar Erros
            if (double.Parse(txbValor.Text) == 0.00)
            {
                MessageBox.Show("O preço e invalido", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbNomeProduto.Text.Length <= 3)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoria.Text.Length <= 0)
            {
                MessageBox.Show("A categoria nao pode ser null cacacteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar o cadastro no Banco de dados
                // Model.Produtos produtos = new Model.Produtos();
                produtos.nome_produto = txbNomeProduto.Text;
                produtos.preco = decimal.Parse(txbValor.Text);
                // obter o id-categoria do cbb
                produtos.id_categoria = int.Parse(cmbCategoria.Text.Split('-')[0]);

                if (produtos.Cadastrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campos de cadastro
                    txbNomeProduto.Clear();
                    txbValor.Clear();
                    cmbCategoria.SelectedIndex = -1;
                    // Atualizar o dgv
                    AtualizarDgv();
                    
                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCadastrarProdutos_Load(object sender, EventArgs e)
        {

        }
    }
}
