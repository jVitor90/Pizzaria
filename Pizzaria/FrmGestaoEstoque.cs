using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Pizzaria
{
    public partial class FrmGestaoEstoque : Form
    {
        
        Model.Estoque estoque = new Estoque();
        Model.Categoria categoria = new Categoria();
        Model.Usuario usuario = new Usuario();
        public FrmGestaoEstoque()
        {
            InitializeComponent();
            AtualizarDgv();


            //Obter as categorias do banco

            //Obter as categorias do banco
            DataTable resultadoCategoria = categoria.Listar2();
            foreach (DataRow linha in resultadoCategoria.Rows)
            {
                //Adicionar os Combobox
                cmbCategoria.Items.Add($"{linha["id_categoria"]} - {linha["nome_categoria"]}");
            }
        }
        public void AtualizarDgv()
        {
            dgvEstoque.DataSource = estoque.Listar();


            dgvEstoque.Columns["id_estoque"].HeaderText = "ID Estoque";
            dgvEstoque.Columns["nome_item"].HeaderText = "Item";
            dgvEstoque.Columns["quantidade"].HeaderText = "Quantidade";
            dgvEstoque.Columns["unidade"].HeaderText = "Unidade";
            dgvEstoque.Columns["id_Categoria"].HeaderText = "ID Categoria";
            dgvEstoque.Columns["atualizado_em"].HeaderText = "Data";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            //validar Erros
            if (txbQuantidade.Text.Length <= 0)
            {
                MessageBox.Show("A quantidade informada é invalido!", "ERRO",
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
            else if(txbUnidade.Text.Length <= 0)
            {
                MessageBox.Show("A unidade informada é invalido!", "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar no bd
                // Instanciar o produto
                Model.Produtos produto = new Model.Produtos();
                Model.Estoque estoque = new Model.Estoque();
                estoque.nome_item = txbNomeProduto.Text;
                estoque.quantidade = decimal.Parse(txbQuantidade.Text);
                estoque.unidade = txbUnidade.Text;
                estoque.id_Categoria = int.Parse(cmbCategoria.Text.Split('-')[0]);
                estoque.id_estoque = this.estoque.id_estoque;

                DialogResult editar = MessageBox.Show("Tem certeza que deseja Editar este Produto?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (editar == DialogResult.Yes)
                {
                    if (estoque.Modificar())
                    {
                        MessageBox.Show("Item editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpa os campos de cadastro
                        txbNomeProduto.Clear();
                        txbQuantidade.Clear();
                        txbUnidade.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        // Atualiza o dgv
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao editar o item", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este Produto?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                if (this.estoque.Remover())
                {
                    MessageBox.Show("Produto removido com sucesso", "Sucesso!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    // Limpar os campos
                    txbNomeProduto.Clear();
                    txbQuantidade.Clear();
                    txbUnidade.Clear();
                    cmbCategoria.SelectedIndex = -1;

                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto!!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvEstoque.SelectedCells[0].RowIndex;
            this.estoque.nome_item = dgvEstoque.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.estoque.quantidade = (decimal)dgvEstoque.Rows[linhaSelecionada].Cells[2].Value;
            this.estoque.unidade = dgvEstoque.Rows[linhaSelecionada].Cells[3].Value.ToString();
            this.estoque.id_Categoria = (int)dgvEstoque.Rows[linhaSelecionada].Cells[4].Value;
            this.estoque.id_estoque = (int)dgvEstoque.Rows[linhaSelecionada].Cells[0].Value;

            // Atribuir as linhas selecionadas
            txbNomeProduto.Text = this.estoque.nome_item;
            txbQuantidade.Text = this.estoque.quantidade.ToString();
            txbUnidade.Text = this.estoque.unidade.ToString();
            cmbCategoria.Text = this.estoque.id_Categoria.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            // Validar Erros
            if (txbNomeProduto.Text.Length <= 2)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbQuantidade.Text.Length <= 0)
            {
                MessageBox.Show("A quantidade informada é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbUnidade.Text.Length <= 0)
            {
                MessageBox.Show("A unidade informada é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoria.SelectedIndex <= 0)
            {
                Model.Estoque estoque = new Model.Estoque();
                estoque.nome_item = txbNomeProduto.Text;
                estoque.quantidade = decimal.Parse(txbQuantidade.Text);
                estoque.unidade = txbUnidade.Text;
                estoque.id_Categoria = int.Parse(cmbCategoria.Text.Split('-')[0]);

                if (estoque.VerificarProdutoEstoqueExistente(txbNomeProduto.Text))
                {
                    MessageBox.Show("Já existe um produto cadastrado com este nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult cadastrar = MessageBox.Show("Tem certeza que deseja cadastrar este item?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(cadastrar == DialogResult.Yes)
                {
                    if (estoque.Cadastrar())
                    {
                        MessageBox.Show("item cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpa os campos de edição
                        txbNomeProduto.Clear();
                        txbQuantidade.Clear();
                        txbUnidade.Clear();
                        cmbCategoria.SelectedIndex = -1;
                        // Atualiza o dgv
                        AtualizarDgv();
                    }
                    else
                    {
                        MessageBox.Show("falha ao cadastrar item", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



                //if (txbNomeProduto.Text.Length <= 2)
                //{
                //    MessageBox.Show("O Nome informado é invalido!", "ERRO",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (txbQuantidade.Text.Length <= 0)
                //{
                //    MessageBox.Show("A quantidade é invalido!", "ERRO",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else if (txbUnidade.Text.Length <= 0)
                //{
                //    MessageBox.Show("A unidade nao pode estar vazio!", "ERRO",
                //        MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    Model.Estoque estoque = new Model.Estoque();
                //    estoque.nome_item = txbNomeProduto.Text;
                //    estoque.quantidade = decimal.Parse(txbQuantidade.Text);
                //    estoque.unidade = txbUnidade.Text;
                //    // obter o id categoria
                //    estoque.id_estoque = int.Parse(cmbCategoria.Text.Split('-')[0]);

                //    DialogResult cadastrar = MessageBox.Show("Tem certeza que deseja Cadstrar este Produto?",
                //   "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //    if (cadastrar == DialogResult.Yes)
                //    {
                //        if (estoque.Cadastrar())
                //        {
                //            MessageBox.Show("Item cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            //Limpar os campos de cadastro
                //            txbNomeProduto.Clear();
                //            txbQuantidade.Clear();
                //            txbUnidade.Clear();
                //            cmbCategoria.SelectedIndex = -1;
                //            // Atualizar o dgv
                //            AtualizarDgv();
                //        }
                //        else
                //        {
                //            MessageBox.Show("falha ao cadastrar item", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }

            }
        }
    }
}
