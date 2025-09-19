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
        Forncedor forncedor = new Forncedor();
        public FundoFornecedor()
        {
            InitializeComponent();
        }
        public void AtualizarDGV()
        {
            dgvFornecedor.DataSource = forncedor.Listar();

            dgvFornecedor.Columns["id_fornecedor"].HeaderText = "ID Fornecedor";
            dgvFornecedor.Columns["fornecedor"].HeaderText = "Fornecedor";
            dgvFornecedor.Columns["cnpj"].HeaderText = "CNPJ";
            dgvFornecedor.Columns["telefone"].HeaderText = "Telefone";
            dgvFornecedor.Columns["email"].HeaderText = "E-mail";
            dgvFornecedor.Columns["endereco"].HeaderText = "Enderço";
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
                Model.Forncedor fornecedor = new Model.Forncedor();                             
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
    }
}
