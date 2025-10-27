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
        public FrmCadastrarProdutos(Model.Usuario usuario)
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

            dgvProdutos.Columns["id_produto"].HeaderText = "ID Produto";
            dgvProdutos.Columns["nome_produto"].HeaderText = "Produto";
            dgvProdutos.Columns["preco"].HeaderText = "Nome Responsável";
            dgvProdutos.Columns["id_categoria"].HeaderText = "Categorias";
            dgvProdutos.Columns["disponivel"].HeaderText = "Disponivel";
            dgvProdutos.Columns["atualizado_em"].HeaderText = "Data";
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
                Model.Produtos produtos = new Model.Produtos();
                produtos.nome_produto = txbNomeProduto.Text;
                produtos.preco = decimal.Parse(txbValor.Text);
                // obter o id-categoria do cbb
                produtos.id_categoria = int.Parse(cmbCategoria.Text.Split('-')[0]);

                if (produtos.VerificarProdutoExistente(txbNomeProduto.Text))
                {
                    MessageBox.Show("Já existe um produto cadastrado com este nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult cadastrar = MessageBox.Show("Tem certeza que deseja Cadstrar este Produto?",
               "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (cadastrar == DialogResult.Yes)
                {
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

                //if (produtos.Cadastrar())
                //{
                //    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    //Limpar os campos de cadastro
                //    txbNomeProduto.Clear();
                //    txbValor.Clear();
                //    cmbCategoria.SelectedIndex = -1;
                //    // Atualizar o dgv
                //    AtualizarDgv();

                //}
                //else
                //{
                //    MessageBox.Show("falha ao cadastrar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
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
                // Iniciar no bd
                // Instanciar o produto
                Model.Produtos produtos = new Model.Produtos();
                produtos.nome_produto = txbNomeProduto.Text;
                produtos.preco = decimal.Parse(txbValor.Text);
                produtos.id_categoria = int.Parse(cmbCategoria.Text.Split('-')[0]);
                produtos.Id_produto = this.produtos.Id_produto;

                DialogResult editar = MessageBox.Show("Tem certeza que deseja Editar este Produto?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (editar == DialogResult.Yes)
                {
                    if (produtos.Modificar())
                    {
                        MessageBox.Show("Produto editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpa os campos de cadastro
                        txbNomeProduto.Clear();
                        txbValor.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        // Atualiza o dgv
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("falha ao editar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //if (produtos.Modificar())
                //{
                //    MessageBox.Show("Produto editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    // Limpa os campos de cadastro
                //    txbNomeProduto.Clear();
                //    txbValor.Clear();
                //    cmbCategoria.SelectedIndex = -1;
                //    // Atualiza o dgv
                //    AtualizarDgv();
                //}
                //else
                //{
                //    MessageBox.Show("falha ao editar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }
        

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este Produto?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(apagar == DialogResult.Yes)
            {
                if (this.produtos.Remover())
                {
                    MessageBox.Show("Produto removido com sucesso", "Sucesso!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    // Limpar os campos
                    txbNomeProduto.Clear();
                    txbValor.Clear();
                    cmbCategoria.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto!!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
            this.produtos.nome_produto = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.produtos.preco = (decimal)dgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
            this.produtos.id_categoria = (int)dgvProdutos.Rows[linhaSelecionada].Cells[3].Value;
            this.produtos.Id_produto = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;

            // Atribuir as linhas selecionadas
            txbNomeProduto.Text = this.produtos.nome_produto;
            txbValor.Text = this.produtos.preco.ToString();
            cmbCategoria.Text = this.produtos.id_categoria.ToString();

        }

        private void dgvProdutos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
