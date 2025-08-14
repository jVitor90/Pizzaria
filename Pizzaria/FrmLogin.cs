using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txbcpf.Mask = "000.000.000-00";
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            
            if(txbcpf.Text.Length < 6)
            {
                MessageBox.Show("CPF invalido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbsenha.Text.Length < 3)
            {
                MessageBox.Show("Senha invalido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Usuario usuario = new Model.Usuario();
                
                usuario.cpf = txbcpf.Text.Replace(",","").Replace(".","").Replace("-","");
                MessageBox.Show(usuario.cpf);
                usuario.Senha = txbsenha.Text;
                // Armazenar  o resultado de logar (SELECT)
                DataTable resultado = new DataTable();
                resultado = usuario.Logar();

                // Vai verfica se a tebela em alguma linha
                if(resultado.Rows.Count > 0)
                {
                    usuario.Nome_usuario = resultado.Rows[0]["nome_usuario"].ToString();
                    usuario.Id_usuario = (int)resultado.Rows[0]["Id_usuario"];

                    //Mudar para o FrmOpcoes
                    FrmOpcoes frmOpcoes = new FrmOpcoes(usuario);
                    this.Hide();
                    frmOpcoes.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("CPF ou senha invalida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        

        
    }
}
