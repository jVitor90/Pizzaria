using Pizzaria.Model;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmOpcoes : Form
    {
        Model.Usuario usuario;

        public FrmOpcoes(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        // ── Lógica original inalterada ──────────────────────────────────
        private void FrmOpcoes_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = SessaoUsuario.Nome;
            lblCargo.Text = SessaoUsuario.Cargo;
            lblSideGreeting.Text = "Olá, " + SessaoUsuario.Nome.Split(' ')[0];

            string cargo = SessaoUsuario.Cargo;

            bntcadastrarusuarios.Enabled = false;
            btnpedidos.Enabled = false;
            btnCadastrar.Enabled = false;
            btnCaixa.Enabled = false;
            btnComandas.Enabled = false;
            btnEstoque.Enabled = false;
            BtnFinanceiro.Enabled = false;

            if (cargo == "admin" || cargo == "Gerente")
            {
                bntcadastrarusuarios.Enabled = true;
                btnpedidos.Enabled = true;
                btnCadastrar.Enabled = true;
                btnCaixa.Enabled = true;
                btnComandas.Enabled = true;
                btnEstoque.Enabled = true;
                BtnFinanceiro.Enabled = true;
            }
            else if (cargo == "Garçom")
            { btnCaixa.Enabled = true; btnComandas.Enabled = true; }
            else if (cargo == "Estoquista")
            { btnCadastrar.Enabled = true; btnEstoque.Enabled = true; }
            else if (cargo == "Pizzaiolo" || cargo == "Chef de Cozinha")
            { btnpedidos.Enabled = true; }
            else if (cargo == "Caixa")
            { btnCaixa.Enabled = true; }

            AjustarLayout();
            AjustarCoresCards();
        }

        private void FrmOpcoes_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
            pnlSidebar.Invalidate();
        }

        // ── Layout ─────────────────────────────────────────────────────
        private void AjustarLayout()
        {
            int cW = pnlCards.ClientSize.Width;
            int cH = pnlCards.ClientSize.Height;

            int cols = 3;
            int pad = 36;
            int gap = 16;
            int cardW = (cW - pad * 2 - gap * (cols - 1)) / cols;
            int cardH = Math.Max(100, (int)(cH * 0.22));

            Button[] cards = {
                btnEstoque, btnCadastrar, btnCaixa,
                btnpedidos, btnComandas, bntcadastrarusuarios,
                BtnFinanceiro
            };

            for (int i = 0; i < cards.Length; i++)
            {
                int col = i % cols, row = i / cols;
                cards[i].SetBounds(
                    pad + col * (cardW + gap),
                    pad + row * (cardH + gap),
                    cardW, cardH);
            }

            // Sidebar — saudação e info
            int sH = pnlSidebar.ClientSize.Height;
            lblSideGreeting.SetBounds(24, (int)(sH * 0.30), 190, 34);
            lblSideInfo.SetBounds(24, lblSideGreeting.Bottom + 10, 190, 50);
            btnSair.SetBounds(16, sH - 48, 200, 32);
        }

        private void AjustarCoresCards()
        {
            Button[] cards = {
                btnEstoque, btnCadastrar, btnCaixa,
                btnpedidos, btnComandas, bntcadastrarusuarios,
                BtnFinanceiro
            };
            foreach (var btn in cards)
            {
                if (btn.Enabled)
                {
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(42, 42, 40);
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 26, 24);
                }
                else
                {
                    btn.ForeColor = Color.FromArgb(40, 40, 38);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(20, 20, 18);
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(18, 18, 18);
                }
            }
        }

        // ── Paint sidebar ───────────────────────────────────────────────
        private void PnlSidebar_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            var g = e.Graphics;
            var rc = pnlSidebar.ClientRectangle;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.FillRectangle(new SolidBrush(Color.FromArgb(8, 8, 8)), rc);

            // Linha vermelha à direita
            using (var pen = new Pen(Color.FromArgb(30, 196, 30, 30), 1f))
                g.DrawLine(pen, rc.Right - 1, 0, rc.Right - 1, rc.Bottom);

            // Ponto vermelho decorativo no topo
            using (var brush = new SolidBrush(Color.FromArgb(196, 30, 30)))
                g.FillEllipse(brush, 24, (int)(rc.Height * 0.30) - 30, 6, 6);
        }

        // ── Eventos originais inalterados ───────────────────────────────
        private void btnCadastrar_Click(object sender, EventArgs e)
        { var f = new FrmCadastrarProdutos(usuario); this.Hide(); f.ShowDialog(); this.Show(); }

        private void btnCaixa_Click(object sender, EventArgs e)
        { var f = new FrmGestaoCaixa(); this.Hide(); f.ShowDialog(); this.Show(); }

        private void btnComandas_Click(object sender, EventArgs e)
        { var f = new FrmGestaoComandas(usuario); this.Hide(); f.ShowDialog(); this.Show(); }

        private void btnEstoque_Click(object sender, EventArgs e)
        { var f = new FrmGestaoEstoque(); this.Hide(); f.ShowDialog(); this.Show(); }

        private void bntcadastrarusuarios_Click(object sender, EventArgs e)
        { var f = new FrmCadastroUsuario(); this.Hide(); f.ShowDialog(); this.Show(); }

        private void btnSair_Click(object sender, EventArgs e)
        { var f = new FrmLogin(); this.Hide(); f.ShowDialog(); this.Show(); }

        private void btnpedidos_Click(object sender, EventArgs e)
        { var f = new FrmPedidos(); this.Hide(); f.ShowDialog(); this.Show(); }

        private void btnFornecedor_Click(object sender, EventArgs e) { }

        private void BtnFinanceiro_Click(object sender, EventArgs e)
        { var f = new FrmFinanceiro(); this.Hide(); f.ShowDialog(); this.Show(); }
    }
}