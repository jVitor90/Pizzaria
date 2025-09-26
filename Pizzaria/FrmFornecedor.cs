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
    public partial class FundoFornecedor : Form
    {
        Forncedor fornecedor = new Forncedor();
        public FundoFornecedor()
        {
            InitializeComponent();
            AtualizarDGV();
        }
        public void AtualizarDGV()
        {
            dgvFornecedor.DataSource = fornecedor.Listar();

            //dgvFornecedor.Columns["id_fornecedor"].HeaderText = "ID Fornecedor";
            //dgvFornecedor.Columns["fornecedor"].HeaderText = "Fornecedor";
            //dgvFornecedor.Columns["cnpj"].HeaderText = "CNPJ";
            //dgvFornecedor.Columns["telefone"].HeaderText = "Telefone";
            //dgvFornecedor.Columns["email"].HeaderText = "E-mail";
            //dgvFornecedor.Columns["endereco"].HeaderText = "Enderço";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txbfornecedor.Text.Length < 3)
            {
                MessageBox.Show("O Fornecedor é invalido", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbcnpj.Text.Length < 14)
            {
                MessageBox.Show("O CNPJ é invalido", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbtelefone.Text.Length < 11)
            {
                MessageBox.Show("O Telefone é invalido", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbemail.Text.Length < 10)
            {
                MessageBox.Show("O E-mail é invalido", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbendereco.Text.Length < 8)
            {
                MessageBox.Show("O CEP é invalido", "ERRO",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Model.Forncedor fornecedor = new Model.Forncedor();                             
                fornecedor.fornecedor = txbfornecedor.Text;
                fornecedor.cnpj = txbcnpj.Text;
                fornecedor.telefone = txbtelefone.Text;
                fornecedor.email = txbemail.Text;
                fornecedor.endereco = txbendereco.Text;
                //fornecedor.id_fornecedor = int.Parse(txbfornecedor.Text.Split('-')[0]);

                DialogResult cadastrar = MessageBox.Show("Tem certeza que deseja Cadstrar este Fornecedor?",
              "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if(cadastrar == DialogResult.Yes)
                {
                    //MessageBox.Show($"{fornecedor.Inserir()}");
                    if (fornecedor.Inserir())
                    {
                        MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Limpar os campos de cadastro
                        txbfornecedor.Clear();
                        txbcnpj.Clear();
                        txbtelefone.Clear();
                        txbemail.Clear();
                        txbendereco.Clear();
                        AtualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show("falha ao cadastrar o fornecedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar esse fornecedor?",
              "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                if (this.fornecedor.Excluir())
                {
                    MessageBox.Show("Fornecedor removido com sucesso", "Sucesso!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDGV();
                    // Limpar os campos
                    txbfornecedor.Clear();
                    txbcnpj.Clear();
                    txbtelefone.Clear();
                    txbemail.Clear();
                    txbendereco.Clear();
                    AtualizarDGV();

                }
                else
                {
                    MessageBox.Show("Falha ao remover Fornecedor!!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaselecionada = dgvFornecedor.SelectedCells[0].RowIndex;
            this.fornecedor.fornecedor = dgvFornecedor.Rows[linhaselecionada].Cells[1].Value.ToString();
            this.fornecedor.cnpj = dgvFornecedor.Rows[linhaselecionada].Cells[2].Value.ToString();
            this.fornecedor.telefone = dgvFornecedor.Rows[linhaselecionada].Cells[3].Value.ToString();
            this.fornecedor.email = dgvFornecedor.Rows[linhaselecionada].Cells[4].Value.ToString();
            this.fornecedor.endereco = dgvFornecedor.Rows[linhaselecionada].Cells[5].Value.ToString();
            this.fornecedor.id_fornecedor = (int)dgvFornecedor.Rows[linhaselecionada].Cells[0].Value;



            txbfornecedor.Text = this.fornecedor.fornecedor;
            txbcnpj.Text = this.fornecedor.cnpj;
            txbtelefone.Text = this.fornecedor.telefone;
            txbemail.Text = this.fornecedor.email;
            txbendereco.Text = this.fornecedor.endereco;
            lblID.Text = this.fornecedor.id_fornecedor.ToString();

            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //validar Erros
            if (txbfornecedor.Text.Length <= 0)
            {
                MessageBox.Show("O Nome do fornecedor invalido!", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbcnpj.Text.Length <= 0)
            {
                MessageBox.Show("O CNPJ é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbemail.Text.Length <= 0)
            {
                MessageBox.Show("O Email informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbtelefone.Text.Length <= 0)
            {
                MessageBox.Show("O Telefone é invalido!", "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbendereco.Text.Length <= 0)
            {
                MessageBox.Show("O Endereço é invalido!", "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar no bd
                // Instanciar o fornecedor
                Forncedor fornecedor = new Forncedor();
                fornecedor.fornecedor = txbfornecedor.Text;
                fornecedor.cnpj = txbcnpj.Text;
                fornecedor.telefone = txbtelefone.Text;
                fornecedor.email = txbemail.Text;
                fornecedor.endereco = txbendereco.Text;
                fornecedor.id_fornecedor = this.fornecedor.id_fornecedor;
                //fornecedor.id_fornecedor

                DialogResult editar = MessageBox.Show("Tem certeza que deseja Editar este Fornecedor?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (editar == DialogResult.Yes)
                {
                    if (fornecedor.Modificar())
                    {
                        MessageBox.Show("Fornecedor editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpa os campos de cadastro
                        txbfornecedor.Clear();
                        txbcnpj.Clear();
                        txbtelefone.Clear();
                        txbemail.Clear();
                        txbendereco.Clear();
                        // Atualiza o dgv
                        AtualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao editar Fornecedor", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show($"{fornecedor.id_fornecedor}");
                    }
                }
            }
        }
    }
}
