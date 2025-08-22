using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    partial class FrmGestaoComandas : Form
    {
        Model.Usuario usuario;
        Model.Categoria categoria = new Model.Categoria();
        Model.Produtos produto = new Model.Produtos();
        Model.Mesas ordemComanda = new Model.Mesas();

        public FrmGestaoComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            atualizarComanda();
        }

        public void atualizarComanda()
        {
            DataTable dt = ordemComanda.ListarComanda();
            DgvComandas.DataSource = dt;

            // Personalizar colunas
            if (dt.Rows.Count > 0)
            {
                DgvComandas.Columns["id_comanda"].HeaderText = "ID Comanda";
                DgvComandas.Columns["num_mesa"].HeaderText = "Nº Mesa";
                DgvComandas.Columns["id_resp"].HeaderText = "ID Responsável";
                DgvComandas.Columns["data_adic"].HeaderText = "Data";
                DgvComandas.Columns["situacao"].HeaderText = "Situação";
                if (DgvComandas.Columns.Contains("metodo_pagamento"))
                {
                    DgvComandas.Columns["metodo_pagamento"].HeaderText = "Método de Pagamento";
                }
            }
            else
            {
               
            }
        }

        private void FrmGestaoComandas_Load(object sender, EventArgs e)
        {
            // Carregar Pizzas (categoria 1)
            produto.id_categoria = 1;
            DataTable dtPizzas = produto.ListarPorCategoria();
            foreach (DataRow linha in dtPizzas.Rows)
            {
                cmbPizzas.Items.Add($"{linha["nome_produto"]}");
            }

            // Carregar Bebidas (categoria 2)
            produto.id_categoria = 2;
            DataTable dtBebidas = produto.ListarPorCategoria();
            foreach (DataRow linha in dtBebidas.Rows)
            {
                cmbBebidas.Items.Add($"{linha["nome_produto"]}");
            }

            // Carregar Adicionais (categoria 3)
            produto.id_categoria = 3;
            DataTable dtAdicionais = produto.ListarPorCategoria();
            foreach (DataRow linha in dtAdicionais.Rows)
            {
                cmbAdicionais.Items.Add($"{linha["nome_produto"]}");
            }

            // Carregar Bordas (categoria 4)
            produto.id_categoria = 4;
            DataTable dtBordas = produto.ListarPorCategoria();
            foreach (DataRow linha in dtBordas.Rows)
            {
                cmbBordas.Items.Add($"{linha["nome_produto"]}");
            }

            atualizarComanda();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbMesa.Text))
            {
                MessageBox.Show("Por favor, insira o número da mesa!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPizzas.SelectedIndex == -1 && cmbBebidas.SelectedIndex == -1 &&
                cmbAdicionais.SelectedIndex == -1 && cmbBordas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione pelo menos um item (pizza, bebida, adicional ou borda)!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cadastrar a comanda
            ordemComanda.num_mesa = int.Parse(txbMesa.Text);
            ordemComanda.id_resp = usuario.id_usuario;
            ordemComanda.situacao = 1;

            if (ordemComanda.Cadastrar())
            {
                // Obter o ID da comanda recém-criada
                DataTable dtComanda = ordemComanda.BuscarMesa();
                if (dtComanda.Rows.Count > 0)
                {
                    int idComanda = Convert.ToInt32(dtComanda.Rows[0]["id_comanda"]);

                    // Cadastrar itens selecionados
                    Mesas_lancamentos itemComanda = new Mesas_lancamentos();
                    itemComanda.id_Comanda = idComanda;

                    // Adicionar pizza, se selecionada
                    if (cmbPizzas.SelectedIndex != -1)
                    {
                        produto.id_categoria = 1;
                        DataTable dtPizzas = produto.ListarPorCategoria();
                        itemComanda.id_produto = Convert.ToInt32(dtPizzas.Rows[cmbPizzas.SelectedIndex]["id_produto"]);
                        itemComanda.quantidade = 1;
                        itemComanda.situacao_pedido = "pendente";
                        itemComanda.Cadastrar();
                    }

                    // Adicionar bebida, se selecionada
                    if (cmbBebidas.SelectedIndex != -1)
                    {
                        produto.id_categoria = 2;
                        DataTable dtBebidas = produto.ListarPorCategoria();
                        itemComanda.id_produto = Convert.ToInt32(dtBebidas.Rows[cmbBebidas.SelectedIndex]["id_produto"]);
                        itemComanda.quantidade = 1;
                        itemComanda.situacao_pedido = "pendente";
                        itemComanda.Cadastrar();
                    }

                    // Adicionar adicional, se selecionado
                    if (cmbAdicionais.SelectedIndex != -1)
                    {
                        produto.id_categoria = 3;
                        DataTable dtAdicionais = produto.ListarPorCategoria();
                        itemComanda.id_produto = Convert.ToInt32(dtAdicionais.Rows[cmbAdicionais.SelectedIndex]["id_produto"]);
                        itemComanda.quantidade = 1;
                        itemComanda.situacao_pedido = "pendente";
                        itemComanda.Cadastrar();
                    }

                    // Adicionar borda, se selecionada
                    if (cmbBordas.SelectedIndex != -1)
                    {
                        produto.id_categoria = 4;
                        DataTable dtBordas = produto.ListarPorCategoria();
                        itemComanda.id_produto = Convert.ToInt32(dtBordas.Rows[cmbBordas.SelectedIndex]["id_produto"]);
                        itemComanda.quantidade = 1;
                        itemComanda.situacao_pedido = "pendente";
                        itemComanda.Cadastrar();
                    }

                    MessageBox.Show("Comanda lançada com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPizzas.SelectedIndex = -1;
                    cmbBebidas.SelectedIndex = -1;
                    cmbBordas.SelectedIndex = -1;
                    cmbAdicionais.SelectedIndex = -1;
                    txbMesa.Clear();
                    txbObservecao.Clear();
                    atualizarComanda();
                }
            }
            else
            {
                MessageBox.Show("Falha ao lançar comanda!", "ERRO!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Verificar se o usuarios deseja limpar os campos
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja limpar os campos?", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                //Limpar os campos
                cmbPizzas.SelectedIndex = -1;
                cmbBebidas.SelectedIndex = -1;
                cmbBordas.SelectedIndex = -1;
                cmbAdicionais.SelectedIndex = -1;
                txbMesa.Clear();
                txbObservecao.Clear();
                MessageBox.Show("Campos limpos com sucesso!", "Sucesso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarComanda();
            }
            else
            {
                MessageBox.Show("Ação cancelada!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbPizzas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Verificar se há uma coluna selecionada
            if (cmbPizzas.SelectedIndex == -1) return;

            cmbAdicionais.Items.Clear();
            cmbBordas.Items.Clear();

            string pizzaEscolhida = cmbPizzas.SelectedItem.ToString();

            // Verifica se é pizza doce
            bool pizzaDoce = pizzaEscolhida.Contains("Chocolate") ||
                             pizzaEscolhida.Contains("Nutella") ||
                             pizzaEscolhida.Contains("Morango") ||
                             pizzaEscolhida.Contains("Banana");

            if (pizzaDoce)
            {
                // Adicionais para pizzas doces
                cmbAdicionais.Items.Add("Banana extra");
                cmbAdicionais.Items.Add("Morango extra");
                cmbAdicionais.Items.Add("Chocolate extra");

                // Bordas para pizzas doces
                cmbBordas.Items.Add("Chocolate");
                cmbBordas.Items.Add("Nutella");
            }
            else
            {
                // Adicionais para pizzas salgadas
                cmbAdicionais.Items.Add("Queijo extra");
                cmbAdicionais.Items.Add("Calabresa extra");
                cmbAdicionais.Items.Add("Frango extra");
                cmbAdicionais.Items.Add("Presunto extra");
                cmbAdicionais.Items.Add("Ovo extra");
                cmbAdicionais.Items.Add("Catupiry extra");
                cmbAdicionais.Items.Add("Bacon extra");
                cmbAdicionais.Items.Add("Pepperoni extra");
                cmbAdicionais.Items.Add("Champignon extra");
                cmbAdicionais.Items.Add("Tomate extra");
                cmbAdicionais.Items.Add("Milho extra");
                cmbAdicionais.Items.Add("Rúcula extra");
                cmbAdicionais.Items.Add("Lombo extra");
                cmbAdicionais.Items.Add("Carne extra");
                cmbAdicionais.Items.Add("Linguiça extra");
                cmbAdicionais.Items.Add("Cebola extra");
                cmbAdicionais.Items.Add("Azeitona extra");

                // Bordas para pizzas salgadas
                cmbBordas.Items.Add("Catupiry");
                cmbBordas.Items.Add("Cheddar");
            }

        }

        private void DgvComandas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.DesignMode) return; // Evita execução no designer
                                         // Verifica se o clique foi em uma linha válida 
            if (e.RowIndex >= 0 && DgvComandas.Rows[e.RowIndex].Cells["id_comanda"].Value != DBNull.Value)
            {
                int id_comanda = Convert.ToInt32(DgvComandas.Rows[e.RowIndex].Cells["id_comanda"].Value);

                OrdensComandas ordens = new OrdensComandas { id_comanda = id_comanda };

                // Excluir a comanda pelo ID
                if (ordens.ExcluirPorId())
                {
                    MessageBox.Show("Comanda excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarComanda();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir a comanda.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (this.DesignMode) return; // Evita execução no designer

            this.Hide();

            // Abre a tela de opções
            FrmOpcoes telaOpcoes = new FrmOpcoes(usuario);
            telaOpcoes.ShowDialog();

            // Fecha definitivamente a tela de comandas
            this.Close();
        }

        private void txbMesa_TextChanged(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (txb.Text.Length == 0) return;

            int caracter = txb.SelectionStart;
            string apenasDigitos = new string(txb.Text.Where(char.IsDigit).ToArray());

            if (apenasDigitos != txb.Text)
            {
                txb.Text = apenasDigitos;
                txb.SelectionStart = Math.Min(caracter, txb.Text.Length); // mantém a posição do cursor
            }
        }

        private void txbMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;     // permite teclas de controle
            if (!char.IsDigit(e.KeyChar)) e.Handled = true; // bloqueia letras/símbolos
        }
    }
}

