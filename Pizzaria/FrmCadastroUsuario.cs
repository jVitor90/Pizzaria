using Pizzaria.Model;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmCadastroUsuario : Form
    {
        Usuario usuario = new Usuario();

        public FrmCadastroUsuario()
        {
            InitializeComponent();
        }

        // Centraliza o card no body ao redimensionar
        private void FrmCadastroUsuario_Resize(object sender, EventArgs e)
        {
            if (pnlForm == null || pnlBody == null) return;
            pnlForm.Left = (pnlBody.ClientSize.Width - pnlForm.Width) / 2;
            pnlForm.Top = (pnlBody.ClientSize.Height - pnlForm.Height) / 2;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;

            if (!string.IsNullOrWhiteSpace(nome))
            {
                TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                nome = textInfo.ToTitleCase(nome.ToLower());
            }

            string cpf = txbcpf.Text.Replace(".", "").Replace("-", "").Replace(",", "").Trim();
            string cargo = cmbCargo.Text.Trim();
            string senha = txbSenha.Text;

            if (nome.Length <= 2)
            {
                MessageBox.Show("Nome inválido! O nome deve ter pelo menos 3 caracteres.");
                return;
            }
            else if (cpf.Length != 11)
            {
                MessageBox.Show("CPF inválido! O CPF deve ter exatamente 11 números.");
                return;
            }
            else if (!cpf.All(char.IsDigit))
            {
                MessageBox.Show("CPF inválido! O CPF não pode conter letras ou símbolos.");
                return;
            }
            else if (string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Selecione um cargo!");
                return;
            }
            else if (txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Senha inválida! A senha deve ter pelo menos 4 caracteres.");
                return;
            }
            else
            {
                usuario.Nome_usuario = nome;
                usuario.cpf = cpf;
                usuario.Cargo = cargo;
                usuario.Senha = senha;

                if (usuario.Cadastrar())
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    txbNome.Clear();
                    txbcpf.Clear();
                    txbSenha.Clear();
                    cmbCargo.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o usuário!");
                }
            }
        }

        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void txbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '@' &&
                e.KeyChar != '#' &&
                e.KeyChar != '&')
            {
                e.Handled = true;
            }
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            cmbCargo.Items.Clear();
            cmbCargo.Items.Add("Estoquista");
            cmbCargo.Items.Add("Pizzaiolo");
            cmbCargo.Items.Add("Chef de Cozinha");
            cmbCargo.Items.Add("Garçom");
            cmbCargo.Items.Add("Gerente");
            cmbCargo.Items.Add("Caixa");
            cmbCargo.SelectedIndex = -1;

            // posiciona o card imediatamente após o Load
            FrmCadastroUsuario_Resize(sender, e);
        }

        // ── Máscara de CPF (idêntica ao FrmLogin) ──────────────────────
        private bool _updCpf = false;
        private void TxbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
        private void TxbCpf_TextChanged(object sender, EventArgs e)
        {
            if (_updCpf) return; _updCpf = true;
            string d = System.Text.RegularExpressions.Regex.Replace(txbcpf.Text, @"\D", "");
            if (d.Length > 11) d = d.Substring(0, 11);
            string f = d;
            if (d.Length > 9) f = $"{d.Substring(0, 3)}.{d.Substring(3, 3)}.{d.Substring(6, 3)}-{d.Substring(9)}";
            else if (d.Length > 6) f = $"{d.Substring(0, 3)}.{d.Substring(3, 3)}.{d.Substring(6)}";
            else if (d.Length > 3) f = $"{d.Substring(0, 3)}.{d.Substring(3)}";
            txbcpf.Text = f; txbcpf.SelectionStart = f.Length;
            _updCpf = false;
        }
    }
}