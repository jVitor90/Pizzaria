using Pizzaria.Model;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmGerenciarUsuarios : Form
    {
        Model.Usuario usuario = new Usuario();

        public FrmGerenciarUsuarios()
        {
            InitializeComponent();
        }

        private void FrmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            cmbCargo.Items.Clear();
            cmbCargo.Items.Add("Estoquista");
            cmbCargo.Items.Add("Pizzaiolo");
            cmbCargo.Items.Add("Chef de Cozinha");
            cmbCargo.Items.Add("Garçom");
            cmbCargo.Items.Add("Gerente");
            cmbCargo.Items.Add("Caixa");
            cmbCargo.SelectedIndex = -1;

            AtualizarDgv();
        }

        // Abre FrmCadastroUsuario e atualiza a grid ao voltar
        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            var fCadastro = new FrmCadastroUsuario();
            fCadastro.ShowDialog(this);
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvUsuarios.DataSource = usuario.Listar();

            if (dgvUsuarios.Columns.Contains("id_usuario"))
                dgvUsuarios.Columns["id_usuario"].HeaderText = "ID";
            if (dgvUsuarios.Columns.Contains("nome_usuario"))
                dgvUsuarios.Columns["nome_usuario"].HeaderText = "Nome";
            if (dgvUsuarios.Columns.Contains("cpf"))
                dgvUsuarios.Columns["cpf"].HeaderText = "CPF";
            if (dgvUsuarios.Columns.Contains("cargo"))
                dgvUsuarios.Columns["cargo"].HeaderText = "Cargo";

            if (dgvUsuarios.Columns.Contains("senha"))
                dgvUsuarios.Columns["senha"].Visible = false;
        }

        private void LimparCampos()
        {
            this.usuario.id_usuario = 0;
            txbNome.Clear();
            txbCpf.Clear();
            txbSenha.Clear();
            cmbCargo.SelectedIndex = -1;
            dgvUsuarios.ClearSelection();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int linha = e.RowIndex;
            this.usuario.id_usuario = (int)dgvUsuarios.Rows[linha].Cells["id_usuario"].Value;
            this.usuario.Nome_usuario = dgvUsuarios.Rows[linha].Cells["nome_usuario"].Value.ToString();
            this.usuario.cpf = dgvUsuarios.Rows[linha].Cells["cpf"].Value.ToString();
            this.usuario.Cargo = dgvUsuarios.Rows[linha].Cells["cargo"].Value.ToString();

            txbNome.Text = this.usuario.Nome_usuario;
            txbCpf.Text = this.usuario.cpf;
            txbSenha.Text = "";

            int idx = cmbCargo.Items.IndexOf(this.usuario.Cargo);
            cmbCargo.SelectedIndex = idx >= 0 ? idx : -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.usuario.id_usuario <= 0)
            {
                MessageBox.Show("Selecione um funcionário na lista antes de editar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txbNome.Text.Trim();
            string cpf = txbCpf.Text.Replace(".", "").Replace("-", "").Replace(",", "").Trim();
            string cargo = cmbCargo.Text.Trim();

            if (nome.Length <= 2)
            {
                MessageBox.Show("Nome inválido! O nome deve ter pelo menos 3 caracteres.");
                return;
            }
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                MessageBox.Show("CPF inválido! O CPF deve ter exatamente 11 números.");
                return;
            }
            if (string.IsNullOrWhiteSpace(cargo))
            {
                MessageBox.Show("Selecione um cargo!");
                return;
            }
            if (!string.IsNullOrWhiteSpace(txbSenha.Text) && txbSenha.Text.Length < 4)
            {
                MessageBox.Show("Senha inválida! A senha deve ter pelo menos 4 caracteres.");
                return;
            }

            TextInfo ti = new CultureInfo("pt-BR", false).TextInfo;
            nome = ti.ToTitleCase(nome.ToLower());

            this.usuario.Nome_usuario = nome;
            this.usuario.cpf = cpf;
            this.usuario.Cargo = cargo;

            if (!string.IsNullOrWhiteSpace(txbSenha.Text))
                this.usuario.Senha = txbSenha.Text;

            DialogResult editar = MessageBox.Show("Tem certeza que deseja editar este funcionário?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (editar == DialogResult.Yes)
            {
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("Funcionário editado com sucesso!", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao editar o funcionário.", "ERRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (this.usuario.id_usuario <= 0)
            {
                MessageBox.Show("Selecione um funcionário na lista antes de excluir.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este funcionário?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (apagar == DialogResult.Yes)
            {
                if (this.usuario.Excluir())
                {
                    MessageBox.Show("Funcionário removido com sucesso!", "Sucesso!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao remover funcionário!", "ERRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        // ── Máscara de CPF (idêntica ao FrmLogin) ──────────────────────
        private bool _updCpf = false;
        private void TxbCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }
        private void TxbCpf_TextChanged(object sender, EventArgs e)
        {
            if (_updCpf) return; _updCpf = true;
            string d = System.Text.RegularExpressions.Regex.Replace(txbCpf.Text, @"\D", "");
            if (d.Length > 11) d = d.Substring(0, 11);
            string f = d;
            if (d.Length > 9) f = $"{d.Substring(0, 3)}.{d.Substring(3, 3)}.{d.Substring(6, 3)}-{d.Substring(9)}";
            else if (d.Length > 6) f = $"{d.Substring(0, 3)}.{d.Substring(3, 3)}.{d.Substring(6)}";
            else if (d.Length > 3) f = $"{d.Substring(0, 3)}.{d.Substring(3)}";
            txbCpf.Text = f; txbCpf.SelectionStart = f.Length;
            _updCpf = false;
        }
    }
}