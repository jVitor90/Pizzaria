using MySqlConnector;
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
        //Variaveis globais
        Model.Usuario usuario;
        Model.Categoria categoria = new Model.Categoria();
        Model.Produtos produto = new Model.Produtos();
        Model.Mesas mesas = new Model.Mesas();
        Model.Mesas_lancamentos mesas_Lancamentos = new Mesas_lancamentos();

        public FrmGestaoComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;         
            atualizarComanda();
        }

        public void atualizarComanda()
        {
            DataTable dt = mesas.ListarMesas();
            DgvComandas.DataSource = dt;

            DgvComandas.Columns["id_mesa"].HeaderText = "ID Mesa";
            DgvComandas.Columns["num_mesa"].HeaderText = "Nº Mesa";
            DgvComandas.Columns["responsavel"].HeaderText = "Nome Responsável";
            DgvComandas.Columns["data_adic"].HeaderText = "Data";
            DgvComandas.Columns["nome_cliente"].HeaderText = "Nome do Cliente";
            DgvComandas.Columns["ativa"].HeaderText = "Ativa";
            if (DgvComandas.Columns.Contains("metodo_pagamento"))
            {
                DgvComandas.Columns["metodo_pagamento"].HeaderText = "Método de Pagamento";
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
            mesas.num_mesa = int.Parse(txbMesa.Text);
            mesas.id_resp = usuario.id_usuario;
            mesas.nome_cliente = txbClientes.Text;
            mesas.ativa = true;

            if (mesas.Cadastrar())
            {
                // Obter o ID da comanda recém-criada
                DataTable dtComanda = mesas.BuscarMesa();
                if (dtComanda.Rows.Count > 0)
                {
                    int numeroMesa = (int)dtComanda.Rows[0]["num_mesa"];

                    // Cadastrar itens selecionados
                    Mesas_lancamentos lancamento = new Mesas_lancamentos();
                    lancamento.num_mesa = numeroMesa;

                    // Adicionar pizza, se selecionada
                    if (cmbPizzas.SelectedIndex != -1)
                    {
                        produto.id_categoria = 1;
                        DataTable dtPizzas = produto.ListarPorCategoria();
                        lancamento.id_Produto = Convert.ToInt32(dtPizzas.Rows[cmbPizzas.SelectedIndex]["id_produto"]);
                        lancamento.quantidade = 1;
                        lancamento.cozinha = 1; 
                        lancamento.pagamento = 1; 
                        lancamento.Cadastrar();
                    }

                    // Adicionar bebida, se selecionada
                    if (cmbBebidas.SelectedIndex != -1)
                    {
                        produto.id_categoria = 2;
                        DataTable dtBebidas = produto.ListarPorCategoria();
                        lancamento.id_Produto = Convert.ToInt32(dtBebidas.Rows[cmbBebidas.SelectedIndex]["id_produto"]);
                        lancamento.quantidade = 1;
                        lancamento.cozinha = 1; 
                        lancamento.pagamento = 1; 
                        lancamento.Cadastrar();
                    }

                    // Adicionar adicional, se selecionado
                    if (cmbAdicionais.SelectedIndex != -1)
                    {
                        produto.id_categoria = 3;
                        DataTable dtAdicionais = produto.ListarPorCategoria();
                        lancamento.id_Produto = Convert.ToInt32(dtAdicionais.Rows[cmbAdicionais.SelectedIndex]["id_produto"]);
                        lancamento.quantidade = 1;
                        lancamento.cozinha = 1; 
                        lancamento.pagamento = 1; 
                        lancamento.Cadastrar();
                    }

                    // Adicionar borda, se selecionada
                    if (cmbBordas.SelectedIndex != -1)
                    {
                        produto.id_categoria = 4;
                        DataTable dtBordas = produto.ListarPorCategoria();
                        lancamento.id_Produto = Convert.ToInt32(dtBordas.Rows[cmbBordas.SelectedIndex]["id_produto"]);
                        lancamento.quantidade = 1;
                        lancamento.cozinha = 1; 
                        lancamento.pagamento = 1; 
                        lancamento.Cadastrar();
                    }

                    MessageBox.Show("Comanda lançada com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbPizzas.SelectedIndex = -1;
                    cmbBebidas.SelectedIndex = -1;
                    cmbBordas.SelectedIndex = -1;
                    cmbAdicionais.SelectedIndex = -1;
                    txbClientes.Clear();
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
                txbClientes.Clear();
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
            if (this.DesignMode) return; 

            // Verifica se o clique foi em uma linha válida
            if (e.RowIndex >= 0 && DgvComandas.Rows[e.RowIndex].Cells["id_mesa"].Value != DBNull.Value)
            {
                int idMesa = Convert.ToInt32(DgvComandas.Rows[e.RowIndex].Cells["id_mesa"].Value);
                int numMesa = Convert.ToInt32(DgvComandas.Rows[e.RowIndex].Cells["num_mesa"].Value);

                // Confirmação para evitar deleções acidentais
                DialogResult confirmar = MessageBox.Show("Tem certeza que deseja excluir a comanda e todos os seus lançamentos?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmar == DialogResult.Yes)
                {
                    // Instancia as classes
                    Mesas mesa = new Mesas { num_mesa = numMesa };
                    mesas_Lancamentos.num_mesa = numMesa;

                    // Deleta todos os lançamentos da mesa
                    bool lancamentosExcluidos = mesas_Lancamentos.ExcluirPorMesa();

                    if (lancamentosExcluidos)
                    {
                        // Deleta a mesa
                        bool mesaExcluida = mesa.ExcluirPorMesa();
                        if (mesaExcluida)
                        {
                            MessageBox.Show("Comanda e todos os seus lançamentos excluídos com sucesso!", "Sucesso!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            atualizarComanda();                          
                            DgvProdutos.DataSource = null; // Limpa os produtos
                            DgvProdutos.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao excluir a comanda. Verifique os dados e tente novamente.", "ERRO!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Falha ao excluir os lançamentos da comanda.", "ERRO!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma comanda válida para excluir.", "Aviso!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (char.IsControl(e.KeyChar)) return;
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }



        //Os checkbox para confirmar os pedidos da comanda
        private void ChbPizzas_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbPizzas.Checked)
            {
                cmbPizzas.Enabled = true;
                txbObservecao.Enabled = true;
                txbClientes.Enabled = true;

            }
            else
            {
                cmbPizzas.SelectedIndex = -1;
                cmbPizzas.Enabled = false;
                txbObservecao.Clear();
                txbObservecao.Enabled = false;
                txbClientes.Clear();
                txbClientes.Enabled = false;
                // Só desabilita txbClientes se ChbBebidas também estiver desmarcado
                if (!ChbBebidas.Checked)
                {
                    txbClientes.Clear();
                    txbClientes.Enabled = false;
                }
            }
        }
        private void ChbBebidas_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbBebidas.Checked)
            {
                cmbBebidas.Enabled = true;
                txbClientes.Enabled = true;
            }
            else
            {
                cmbBebidas.SelectedIndex = -1;
                cmbBebidas.Enabled = false;
                txbClientes.Clear();
                txbClientes.Enabled = false;
                // Só desabilita txbClientes se ChbPizzas também estiver desmarcado
                if (!ChbBebidas.Checked)
                {
                    txbClientes.Clear();
                    txbClientes.Enabled = false;
                }
            }
        }
        private void ChbBordas_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbBordas.Checked)
            {
                cmbBordas.Enabled = true;
            }
            else
            {
                cmbBordas.SelectedIndex = -1;
                cmbBordas.Enabled = false;             
            }
        }
        private void ChbAdicionais_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbAdicionais.Checked)
            {
                cmbAdicionais.Enabled = true;
            }
            else
            {
                cmbAdicionais.SelectedIndex = -1;
                cmbAdicionais.Enabled = false;
                // Só desabilita txbClientes se ChbPizzas também estiver desmarcado
                if (!ChbPizzas.Checked)
                {
                txbClientes.Clear();
                txbClientes.Enabled = false;
                }
            }
          
        }

        private void txbClientes_TextChanged(object sender, EventArgs e)
        {
            var txb = (TextBox)sender;
            if (txb.Text.Length == 0) return;

            int caracter = txb.SelectionStart;
            // Mantém apenas letras e espaços
            string apenasLetras = new string(txb.Text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c)).ToArray());

            if (apenasLetras != txb.Text)
            {
                txb.Text = apenasLetras;
                txb.SelectionStart = Math.Min(caracter, txb.Text.Length);
            }
        }

        private void txbClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            // Bloqueia números (permite só letras e espaço)
            if (!(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }


        private void DgvComandas_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvComandas.SelectedCells.Count == 0) return;

            int linhaSelecionada = DgvComandas.SelectedCells[0].RowIndex;

            // Agora pega direto pelo nome da coluna (seguro contra mudanças de ordem)
            int numMesa = (int)DgvComandas.Rows[linhaSelecionada].Cells["num_mesa"].Value;

            // Passa para as classes
            mesas.num_mesa = numMesa;
            mesas_Lancamentos.num_mesa = numMesa;

            DgvProdutos.DataSource = null; // Limpa antes
            DataTable dados = mesas_Lancamentos.ListarProdutos();  

            if (dados.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum dado encontrado para a mesa selecionada.");
                return;
            }

            DgvProdutos.DataSource = dados;

            // Configurações das colunas
            if (DgvProdutos.Columns.Contains("id_Produto"))
                DgvProdutos.Columns["id_Produto"].HeaderText = "ID Produto";
            if (DgvProdutos.Columns.Contains("nome_produto"))
                DgvProdutos.Columns["nome_produto"].HeaderText = "Produto";
            if (DgvProdutos.Columns.Contains("quantidade"))
                DgvProdutos.Columns["quantidade"].HeaderText = "Quantidade";
            if (DgvProdutos.Columns.Contains("nome_cliente"))
                DgvProdutos.Columns["nome_cliente"].HeaderText = "Nome do Cliente";

            // Oculta colunas indesejadas
            if (DgvProdutos.Columns.Contains("id_lancamento"))
                DgvProdutos.Columns["id_lancamento"].Visible = false;
            if (DgvProdutos.Columns.Contains("num_mesa"))
                DgvProdutos.Columns["num_mesa"].Visible = false;
            if (DgvProdutos.Columns.Contains("preco"))
                DgvProdutos.Columns["preco"].Visible = false;
            if (DgvProdutos.Columns.Contains("total_item"))
                DgvProdutos.Columns["total_item"].Visible = false;

        }

        private void DgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            // Pega o ID do lançamento da linha selecionada
            int idLancamento = (int)DgvProdutos.Rows[e.RowIndex].Cells["id_lancamento"].Value;

            // Confirmação para evitar deleções acidentais
            DialogResult confirmar = MessageBox.Show("Tem certeza que deseja excluir este lançamento?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                Mesas_lancamentos lancamento = new Mesas_lancamentos { id_lancamento = idLancamento };

                if (lancamento.ExcluirPorId())
                {
                    MessageBox.Show("Lançamento excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                    atualizarComanda();
                    // Força atualização dos produtos da mesa selecionada
                    DgvComandas_SelectionChanged(null, null); 
                }
                else
                {
                    MessageBox.Show("Falha ao excluir o lançamento.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}