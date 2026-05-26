namespace Pizzaria
{
    partial class FrmOpcoes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmOpcoes));

            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSideGreeting = new System.Windows.Forms.Label();
            this.lblSideInfo = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();

            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnpedidos = new System.Windows.Forms.Button();
            this.btnComandas = new System.Windows.Forms.Button();
            this.bntcadastrarusuarios = new System.Windows.Forms.Button();
            this.BtnFinanceiro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlCards.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ────────────────────────────────────────────────
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 80;

            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Text = "Painel de Controle";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lblTitulo.Name = "lblTitulo";

            this.lblUsuario.AutoSize = false;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUsuario.Width = 220;
            this.lblUsuario.Text = "";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(0, 0, 28, 8);
            this.lblUsuario.Name = "lblUsuario";

            this.lblCargo.AutoSize = false;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.lblCargo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCargo.Width = 180;
            this.lblCargo.Text = "";
            this.lblCargo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblCargo.Padding = new System.Windows.Forms.Padding(0, 0, 28, 10);
            this.lblCargo.Name = "lblCargo";

            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Controls.Add(this.lblUsuario);
            this.pnlHeader.Controls.Add(this.lblCargo);

            // Linha vermelha abaixo do header
            this.pnlHeaderLine.BackColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Height = 2;
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.TabIndex = 81;

            // ── pnlBody ──────────────────────────────────────────────────
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.TabIndex = 82;

            // ── pnlSidebar ───────────────────────────────────────────────
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(8, 8, 8);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Width = 240;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSidebar_Paint);

            this.lblSideGreeting.AutoSize = false;
            this.lblSideGreeting.BackColor = System.Drawing.Color.Transparent;
            this.lblSideGreeting.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.lblSideGreeting.ForeColor = System.Drawing.Color.White;
            this.lblSideGreeting.Name = "lblSideGreeting";
            this.lblSideGreeting.Text = "Olá,";

            this.lblSideInfo.AutoSize = false;
            this.lblSideInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblSideInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSideInfo.ForeColor = System.Drawing.Color.FromArgb(80, 80, 75);
            this.lblSideInfo.Name = "lblSideInfo";
            this.lblSideInfo.Text = "Selecione um módulo\npara continuar.";

            this.pnlSidebar.Controls.Add(this.lblSideGreeting);
            this.pnlSidebar.Controls.Add(this.lblSideInfo);

            // ── pnlCards ─────────────────────────────────────────────────
            this.pnlCards.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCards.Name = "pnlCards";

            // Cards
            ConfigCard(this.btnEstoque, "btnEstoque", "Estoque", 12);
            ConfigCard(this.btnCadastrar, "btnCadastrar", "Cadastrar Produtos", 9);
            ConfigCard(this.btnCaixa, "btnCaixa", "Caixa", 10);
            ConfigCard(this.btnpedidos, "btnpedidos", "Pedidos", 14);
            ConfigCard(this.btnComandas, "btnComandas", "Comandas", 11);
            // ← texto alterado de "Usuários" para "Gerenciar Usuários"
            ConfigCard(this.bntcadastrarusuarios, "bntcadastrarusuarios", "Gerenciar Usuários", 15);
            ConfigCard(this.BtnFinanceiro, "BtnFinanceiro", "Financeiro", 17);

            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            this.btnpedidos.Click += new System.EventHandler(this.btnpedidos_Click);
            this.btnComandas.Click += new System.EventHandler(this.btnComandas_Click);
            this.bntcadastrarusuarios.Click += new System.EventHandler(this.bntcadastrarusuarios_Click);
            this.BtnFinanceiro.Click += new System.EventHandler(this.BtnFinanceiro_Click);

            // btnSair
            this.btnSair.Name = "btnSair";
            this.btnSair.Text = "↩  Sair";
            this.btnSair.TabIndex = 13;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(80, 80, 75);
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.pnlSidebar.Controls.Add(this.btnSair);

            // btnFornecedor oculto
            this.btnFornecedor.Visible = false;
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);

            this.pnlCards.Controls.Add(this.btnEstoque);
            this.pnlCards.Controls.Add(this.btnCadastrar);
            this.pnlCards.Controls.Add(this.btnCaixa);
            this.pnlCards.Controls.Add(this.btnpedidos);
            this.pnlCards.Controls.Add(this.btnComandas);
            this.pnlCards.Controls.Add(this.bntcadastrarusuarios);
            this.pnlCards.Controls.Add(this.BtnFinanceiro);
            this.pnlCards.Controls.Add(this.btnFornecedor);

            this.pnlBody.Controls.Add(this.pnlCards);
            this.pnlBody.Controls.Add(this.pnlSidebar);

            // ── FrmOpcoes ────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(12, 12, 12);
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.Name = "FrmOpcoes";
            this.Text = "Opções";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Load += new System.EventHandler(this.FrmOpcoes_Load);
            this.Resize += new System.EventHandler(this.FrmOpcoes_Resize);

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlCards.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void ConfigCard(System.Windows.Forms.Button btn, string name, string text, int tabIndex)
        {
            btn.Name = name;
            btn.Text = text;
            btn.TabIndex = tabIndex;
            btn.Font = new System.Drawing.Font("Segoe UI", 12F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(32, 32, 30);
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 30, 28);
            btn.UseVisualStyleBackColor = false;
            btn.Cursor = System.Windows.Forms.Cursors.Hand;
            btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSideGreeting;
        private System.Windows.Forms.Label lblSideInfo;
        private System.Windows.Forms.Button bntcadastrarusuarios;
        private System.Windows.Forms.Button btnpedidos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnComandas;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Button BtnFinanceiro;
    }
}