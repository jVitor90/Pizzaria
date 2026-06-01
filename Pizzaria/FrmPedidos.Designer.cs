namespace Pizzaria
{
    partial class FrmPedidos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedidos));

            this.brnFinalizar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.pnlGridBot = new System.Windows.Forms.Panel();
            this.lblSecPedidos = new System.Windows.Forms.Label();
            this.lblSecProdutos = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.pnlGridTop.SuspendLayout();
            this.pnlGridBot.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(12, 12, 12);
            System.Drawing.Color corPainel = System.Drawing.Color.FromArgb(10, 10, 10);
            System.Drawing.Color corCampo = System.Drawing.Color.FromArgb(24, 24, 24);
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(32, 32, 30);
            System.Drawing.Color corBranco = System.Drawing.Color.White;
            System.Drawing.Color corSub = System.Drawing.Color.FromArgb(80, 80, 75);
            System.Drawing.Color corAcento = System.Drawing.Color.FromArgb(196, 30, 30);

            System.Drawing.Font fTitulo = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fSec = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBotao = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fGrid = new System.Drawing.Font("Segoe UI", 9F);

            // ── pnlTopo
            this.pnlTopo.BackColor = corPainel;
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 64;
            this.pnlTopo.Name = "pnlTopo";

            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = fTitulo;
            this.lblTitulo.ForeColor = corBranco;
            this.lblTitulo.Text = "Pedidos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lblTitulo.Name = "lblTitulo";

            System.Windows.Forms.Panel pnlAcento = new System.Windows.Forms.Panel();
            pnlAcento.BackColor = corAcento;
            pnlAcento.Dock = System.Windows.Forms.DockStyle.Top;
            pnlAcento.Height = 2;

            // pnlTopo: adiciona linha de acento (Top) depois do Fill para que fique acima
            this.pnlTopo.Controls.Add(this.lblTitulo);
            this.pnlTopo.Controls.Add(pnlAcento);

            this.lblLogo.Visible = false;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Text = "Pedidos";

            // ── pnlBotoes
            this.pnlBotoes.BackColor = corPainel;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Height = 68;
            this.pnlBotoes.Name = "pnlBotoes";

            System.Windows.Forms.Panel pnlSepBotoes = new System.Windows.Forms.Panel();
            pnlSepBotoes.BackColor = System.Drawing.Color.FromArgb(32, 32, 30);
            pnlSepBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSepBotoes.Height = 1;
            this.pnlBotoes.Controls.Add(pnlSepBotoes);

            this.brnFinalizar.BackColor = corAcento;
            this.brnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnFinalizar.FlatAppearance.BorderSize = 0;
            this.brnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 80, 58);
            this.brnFinalizar.Font = fBotao;
            this.brnFinalizar.ForeColor = corBranco;
            this.brnFinalizar.Location = new System.Drawing.Point(20, 14);
            this.brnFinalizar.Name = "brnFinalizar";
            this.brnFinalizar.Size = new System.Drawing.Size(188, 40);
            this.brnFinalizar.TabIndex = 9;
            this.brnFinalizar.Text = "Finalizar Pedido";
            this.brnFinalizar.UseVisualStyleBackColor = false;
            this.brnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.brnFinalizar.Click += new System.EventHandler(this.brnFinalizar_Click);

            this.btnVoltar.BackColor = corCampo;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderColor = corBorda;
            this.btnVoltar.FlatAppearance.BorderSize = 1;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.btnVoltar.Font = fBotao;
            this.btnVoltar.ForeColor = corSub;
            this.btnVoltar.Location = new System.Drawing.Point(220, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 40);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "← Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            this.pnlBotoes.Controls.Add(this.brnFinalizar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);

            // ── pnlConteudo
            this.pnlConteudo.BackColor = corFundo;
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.pnlConteudo.Name = "pnlConteudo";

            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.BackColor = corFundo;
            this.pnlGridTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlGridTop.Name = "pnlGridTop";

            this.lblSecPedidos.AutoSize = true;
            this.lblSecPedidos.Font = fSec;
            this.lblSecPedidos.ForeColor = corSub;
            this.lblSecPedidos.Location = new System.Drawing.Point(0, 0);
            this.lblSecPedidos.Name = "lblSecPedidos";
            this.lblSecPedidos.Text = "PEDIDOS EM ABERTO";

            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AllowUserToResizeRows = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = corCampo;
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidos.GridColor = System.Drawing.Color.FromArgb(30, 40, 68);
            this.dgvPedidos.ColumnHeadersHeight = 36;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.Font = fGrid;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersVisible = false;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.TabIndex = 5;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvPedidos.DefaultCellStyle.BackColor = corCampo;
            this.dgvPedidos.DefaultCellStyle.ForeColor = corBranco;
            this.dgvPedidos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.dgvPedidos.DefaultCellStyle.SelectionForeColor = corBranco;
            this.dgvPedidos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.dgvPedidos.RowTemplate.Height = 40;
            this.dgvPedidos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvPedidos.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;
            this.dgvPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellClick);

            this.pnlGridTop.Controls.Add(this.dgvPedidos);
            this.pnlGridTop.Controls.Add(this.lblSecPedidos);

            this.pnlGridBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridBot.BackColor = corFundo;
            this.pnlGridBot.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlGridBot.Name = "pnlGridBot";

            this.lblSecProdutos.AutoSize = true;
            this.lblSecProdutos.Font = fSec;
            this.lblSecProdutos.ForeColor = corSub;
            this.lblSecProdutos.Location = new System.Drawing.Point(0, 8);
            this.lblSecProdutos.Name = "lblSecProdutos";
            this.lblSecProdutos.Text = "ITENS DO PEDIDO";

            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = corCampo;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.dgvProdutos.ColumnHeadersHeight = 36;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Font = fGrid;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.TabIndex = 12;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(10, 10, 10);
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvProdutos.DefaultCellStyle.BackColor = corCampo;
            this.dgvProdutos.DefaultCellStyle.ForeColor = corBranco;
            this.dgvProdutos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.dgvProdutos.DefaultCellStyle.SelectionForeColor = corBranco;
            this.dgvProdutos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.dgvProdutos.RowTemplate.Height = 40;
            this.dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvProdutos.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;

            this.pnlGridBot.Controls.Add(this.dgvProdutos);
            this.pnlGridBot.Controls.Add(this.lblSecProdutos);

            this.pnlConteudo.Controls.Add(this.pnlGridBot);
            this.pnlConteudo.Controls.Add(this.pnlGridTop);

            this.pnlConteudo.Resize += (s, e2) => {
                this.pnlGridTop.Height = this.pnlConteudo.ClientSize.Height / 2;
            };

            // ── Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";

            this.Controls.Add(this.pnlConteudo);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.lblLogo);

            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.pnlGridTop.ResumeLayout(false);
            this.pnlGridTop.PerformLayout();
            this.pnlGridBot.ResumeLayout(false);
            this.pnlGridBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button brnFinalizar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.Panel pnlGridTop;
        private System.Windows.Forms.Panel pnlGridBot;
        private System.Windows.Forms.Label lblSecPedidos;
        private System.Windows.Forms.Label lblSecProdutos;
    }
}