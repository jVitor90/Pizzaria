using Pizzaria.Model;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txbcpf.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnentrar_Click(s, e); };
            txbsenha.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnentrar_Click(s, e); };
            txbcpf.KeyPress += TxbCpf_KeyPress;
            txbcpf.TextChanged += TxbCpf_TextChanged;
            txbcpf.Click += (s, e) => txbcpf.SelectionStart = 0;
            txbcpf.GotFocus += Input_Focus;
            txbsenha.GotFocus += Input_Focus;
            txbcpf.LostFocus += Input_Blur;
            txbsenha.LostFocus += Input_Blur;
        }

        // ── Lógica original inalterada ──────────────────────────────────
        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (txbcpf.Text.Length < 6)
            { MessageBox.Show("CPF invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txbsenha.Text.Length < 3)
            { MessageBox.Show("Senha invalida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            Model.Usuario usuario = new Model.Usuario();
            usuario.cpf = txbcpf.Text.Replace(",", "").Replace(".", "").Replace("-", "");
            usuario.Senha = txbsenha.Text;
            DataTable resultado = usuario.Logar();

            if (resultado.Rows.Count > 0)
            {
                SessaoUsuario.Nome = resultado.Rows[0]["nome_usuario"].ToString();
                SessaoUsuario.Cargo = resultado.Rows[0]["cargo"].ToString();
                SessaoUsuario.Cpf = resultado.Rows[0]["cpf"].ToString();
                usuario.Nome_usuario = resultado.Rows[0]["nome_usuario"].ToString();
                usuario.id_usuario = (int)resultado.Rows[0]["Id_usuario"];
                FrmOpcoes frm = new FrmOpcoes(usuario);
                this.Hide();
                frm.ShowDialog();

                // Verifica se o form ainda pode ser exibido
                if (!this.IsDisposed)
                    this.Show();
                else
                    Application.Exit();
            }
            else
                MessageBox.Show("CPF ou senha invalida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnsair_Click(object sender, EventArgs e) => Application.Exit();

        // ── Layout responsivo ───────────────────────────────────────────
        private void FrmLogin_Load(object sender, EventArgs e) => DoLayout();
        private void FrmLogin_Resize(object sender, EventArgs e) => DoLayout();

        private void DoLayout()
        {
            int W = ClientSize.Width, H = ClientSize.Height;
            int leftW = (int)(W * 0.48);

            // Painel esquerdo
            pnlLeft.SetBounds(0, 0, leftW, H);
            pnlLeft.Invalidate();

            // Logo
            picblogo.Size = new System.Drawing.Size(80, 80);
            picblogo.Left = (leftW - 80) / 2;
            picblogo.Top = (int)(H * 0.30);

            // Brand
            lblBrand.SetBounds(40, picblogo.Bottom + 18, leftW - 80, 60);

            // Linha accent
            pnlAccent.SetBounds(leftW / 2 - 40, lblBrand.Bottom + 8, 80, 3);

            // Slogan
            lblSlogan.SetBounds(40, pnlAccent.Bottom + 12, leftW - 80, 30);

            // Painel direito
            pnlRight.SetBounds(leftW, 0, W - leftW, H);

            int rW = W - leftW;

            // Título
            lblBemVindo.SetBounds(0, (int)(H * 0.18), rW, 52);
            lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Subtítulo
            lblSubtitle.SetBounds(0, lblBemVindo.Bottom + 4, rW, 26);
            lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Card do formulário
            int formW = Math.Min(400, (int)(rW * 0.72));
            int formH = (int)(H * 0.48);
            int formX = (rW - formW) / 2;
            int formY = lblSubtitle.Bottom + (int)(H * 0.04);
            pnlForm.SetBounds(formX, formY, formW, formH);
            pnlForm.Invalidate();

            // Internos do form — posicionados relativos ao pnlForm
            int fW = formW, fH = formH;
            int px = 30, inputH = 42, gap = (int)(fH * 0.05);

            lblcpf.SetBounds(px, (int)(fH * 0.08), fW - px * 2, 18);
            txbcpf.SetBounds(px, lblcpf.Bottom + 4, fW - px * 2, inputH);
            lblsenha.SetBounds(px, txbcpf.Bottom + gap, fW - px * 2, 18);
            txbsenha.SetBounds(px, lblsenha.Bottom + 4, fW - px * 2, inputH);
            btnentrar.SetBounds(px, txbsenha.Bottom + (int)(fH * 0.10), fW - px * 2, 46);
            btnsair.SetBounds(px, btnentrar.Bottom + 10, fW - px * 2, 28);

            // Versão
            lblVersion.SetBounds(0, H - 26, rW - 14, 20);
        }

        // ── Paint do painel esquerdo ────────────────────────────────────
        private void PnlLeft_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            var rc = pnlLeft.ClientRectangle;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Fundo
            g.FillRectangle(new SolidBrush(Color.FromArgb(8, 8, 8)), rc);

            // Grade de pontos decorativa
            using (var dotBrush = new SolidBrush(Color.FromArgb(22, 255, 255, 255)))
            {
                for (int x = 20; x < rc.Width; x += 28)
                    for (int y = 20; y < rc.Height; y += 28)
                        g.FillEllipse(dotBrush, x, y, 2, 2);
            }

            // Círculo decorativo grande
            int cx = rc.Width / 2, cy = rc.Height / 2;
            int r = (int)(Math.Min(rc.Width, rc.Height) * 0.42);
            using (var pen = new Pen(Color.FromArgb(30, 196, 30, 30), 1f))
            {
                g.DrawEllipse(pen, cx - r, cy - r, r * 2, r * 2);
            }
            using (var pen = new Pen(Color.FromArgb(15, 196, 30, 30), 1f))
            {
                g.DrawEllipse(pen, cx - r - 30, cy - r - 30, (r + 30) * 2, (r + 30) * 2);
            }

            // Borda direita vermelha fina
            using (var pen = new Pen(Color.FromArgb(196, 30, 30), 1f))
                g.DrawLine(pen, rc.Right - 1, 0, rc.Right - 1, rc.Bottom);
        }

        // ── Paint do card do form ───────────────────────────────────────
        private void PnlForm_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            var rc = pnlForm.ClientRectangle;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), rc);

            // Borda fina
            using (var pen = new Pen(Color.FromArgb(38, 38, 35), 1f))
                g.DrawRectangle(pen, 0, 0, rc.Width - 1, rc.Height - 1);

            // Linha vermelha no topo do card
            using (var brush = new SolidBrush(Color.FromArgb(196, 30, 30)))
                g.FillRectangle(brush, 0, 0, rc.Width, 3);
        }

        // ── Foco/Blur nos inputs ────────────────────────────────────────
        private void Input_Focus(object sender, EventArgs e)
            => ((TextBox)sender).BackColor = Color.FromArgb(34, 34, 34);
        private void Input_Blur(object sender, EventArgs e)
            => ((TextBox)sender).BackColor = Color.FromArgb(28, 28, 28);

        // ── Máscara de CPF ──────────────────────────────────────────────
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