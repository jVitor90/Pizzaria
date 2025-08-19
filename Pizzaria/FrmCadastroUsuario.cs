using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;

            // Deixar primeira letra maiúscula
            if (!string.IsNullOrWhiteSpace(nome))
            {
                TextInfo textInfo = new CultureInfo("pt-BR", false).TextInfo;
                nome = textInfo.ToTitleCase(nome.ToLower());
            }
            string cpf = txbcpf.Text.Replace(".", "").Replace("-", "").Trim(); // remove máscara
            string cargo = cmbCargo.Text.Trim();
            string senha = txbSenha.Text;

            // Validações
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

                    // Limpar os campos
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
            // Só permite letras (inclusive acentuadas), espaço e backspace
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txbSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, dígitos, backspace e os caracteres especiais @ # &
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '@' &&
                e.KeyChar != '#' &&
                e.KeyChar != '&')
            {
                e.Handled = true; // bloqueia qualquer outro caractere
            }

        }
    }
    }

