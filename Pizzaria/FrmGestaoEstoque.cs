using Pizzaria.Model;
using System;
using System.Data;
using System.Windows.Forms;

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
            // Fix double-buffer para evitar flickering no DataGridView
            typeof(System.Windows.Forms.DataGridView)
                .InvokeMember("DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.SetProperty,
                    null, dgvEstoque, new object[] { true });
            AtualizarDgv();

            DataTable resultadoCategoria = categoria.Listar2();
            foreach (DataRow linha in resultadoCategoria.Rows)
            {
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

        private void LimparCampos()
        {
            txbNomeProduto.Clear();
            txbQuantidade.Clear();
            txbUnidade.Clear();
            cmbCategoria.SelectedIndex = -1;
        }

        private bool ParseQuantidade(out decimal quantidade)
        {
            if (decimal.TryParse(txbQuantidade.Text.Replace(".", ","), out quantidade))
                return true;
            MessageBox.Show("Quantidade inválida! Use apenas números (ex: 10 ou 10,5).", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeProduto.Text.Trim().Length <= 2)
            {
                MessageBox.Show("O Nome informado é inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbQuantidade.Text.Trim().Length <= 0)
            {
                MessageBox.Show("A quantidade informada é inválida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbUnidade.Text.Trim().Length <= 0)
            {
                MessageBox.Show("A unidade informada é inválida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma categoria!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ParseQuantidade(out decimal quantidade)) return;

            Model.Estoque novoEstoque = new Model.Estoque();
            novoEstoque.nome_item = txbNomeProduto.Text.Trim();
            novoEstoque.quantidade = quantidade;
            novoEstoque.unidade = txbUnidade.Text.Trim();
            novoEstoque.id_Categoria = int.Parse(cmbCategoria.Text.Split('-')[0].Trim());

            if (novoEstoque.VerificarProdutoEstoqueExistente(novoEstoque.nome_item))
            {
                MessageBox.Show("Já existe um produto cadastrado com este nome!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cadastrar = MessageBox.Show("Tem certeza que deseja cadastrar este item?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cadastrar == DialogResult.Yes)
            {
                if (novoEstoque.Cadastrar())
                {
                    MessageBox.Show("Item cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar item.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeProduto.Text.Trim().Length <= 3)
            {
                MessageBox.Show("O Nome informado é inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbQuantidade.Text.Trim().Length <= 0)
            {
                MessageBox.Show("A quantidade informada é inválida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txbUnidade.Text.Trim().Length <= 0)
            {
                MessageBox.Show("A unidade informada é inválida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma categoria!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ParseQuantidade(out decimal quantidade)) return;

            Model.Estoque editEstoque = new Model.Estoque();
            editEstoque.nome_item = txbNomeProduto.Text.Trim();
            editEstoque.quantidade = quantidade;
            editEstoque.unidade = txbUnidade.Text.Trim();
            editEstoque.id_Categoria = int.Parse(cmbCategoria.Text.Split('-')[0].Trim());
            editEstoque.id_estoque = this.estoque.id_estoque;

            DialogResult editar = MessageBox.Show("Tem certeza que deseja editar este item?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (editar == DialogResult.Yes)
            {
                if (editEstoque.Modificar())
                {
                    MessageBox.Show("Item editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao editar o item.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este item?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (apagar == DialogResult.Yes)
            {
                if (this.estoque.Remover())
                {
                    MessageBox.Show("Item removido com sucesso!", "Sucesso!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao remover item!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int linha = e.RowIndex;
            this.estoque.nome_item = dgvEstoque.Rows[linha].Cells[1].Value.ToString();
            this.estoque.quantidade = (decimal)dgvEstoque.Rows[linha].Cells[2].Value;
            this.estoque.unidade = dgvEstoque.Rows[linha].Cells[3].Value.ToString();
            this.estoque.id_Categoria = (int)dgvEstoque.Rows[linha].Cells[4].Value;
            this.estoque.id_estoque = (int)dgvEstoque.Rows[linha].Cells[0].Value;

            txbNomeProduto.Text = this.estoque.nome_item;
            txbQuantidade.Text = this.estoque.quantidade.ToString();
            txbUnidade.Text = this.estoque.unidade;
            cmbCategoria.Text = this.estoque.id_Categoria.ToString();
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}