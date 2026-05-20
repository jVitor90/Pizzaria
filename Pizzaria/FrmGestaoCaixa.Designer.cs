namespace Pizzaria
{
    partial class FrmGestaoCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoCaixa));

            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grbPagamentos = new System.Windows.Forms.GroupBox();
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();

            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();

            this.grbPagamentos.SuspendLayout();
            this.grbInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(10, 14, 30);
            System.Drawing.Color corPainel = System.Drawing.Color.FromArgb(17, 24, 46);
            System.Drawing.Color corCampo = System.Drawing.Color.FromArgb(25, 34, 62);
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(42, 55, 95);
            System.Drawing.Color corBranco = System.Drawing.Color.FromArgb(215, 220, 238);
            System.Drawing.Color corSub = System.Drawing.Color.FromArgb(100, 118, 160);
            System.Drawing.Color corAcento = System.Drawing.Color.FromArgb(204, 64, 44);
            System.Drawing.Color corTitleBar = System.Drawing.Color.FromArgb(8, 11, 24);

            System.Drawing.Font fTitulo = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Drawing.Font fBotao = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fGrid = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fAppName = new System.Drawing.Font("Segoe UI", 8F);
            System.Drawing.Font fWinBtn = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fValor = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);

            // ── pnlTitleBar
            this.pnlTitleBar.BackColor = corTitleBar;
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Height = 32;
            this.pnlTitleBar.Name = "pnlTitleBar";

            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = fAppName;
            this.lblAppName.ForeColor = corSub;
            this.lblAppName.Text = "🍕  Pizzaria — Gestão de Caixa";
            this.lblAppName.Location = new System.Drawing.Point(12, 8);
            this.lblAppName.Name = "lblAppName";

            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.ForeColor = corSub;
            this.btnClose.Font = fWinBtn;
            this.btnClose.Text = "✕";
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Name = "btnClose";
            this.btnClose.TabStop = false;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler((s, e2) => { System.Windows.Forms.Application.Exit(); });

            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(35, 45, 75);
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.ForeColor = corSub;
            this.btnMinimize.Font = fWinBtn;
            this.btnMinimize.Text = "─";
            this.btnMinimize.Size = new System.Drawing.Size(46, 32);
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Click += new System.EventHandler((s, e2) => { this.WindowState = System.Windows.Forms.FormWindowState.Minimized; });

            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler((s, e2) => {
                if (e2.Button == System.Windows.Forms.MouseButtons.Left)
                {


                }
            });
            this.lblAppName.MouseDown += new System.Windows.Forms.MouseEventHandler((s, e2) => {
                if (e2.Button == System.Windows.Forms.MouseButtons.Left)
                {


                }
            });

            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.lblAppName);

            // ── pnlTopo
            this.pnlTopo.BackColor = corPainel;
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 58;
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Controls.Add(this.lblTitulo);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = fTitulo;
            this.lblTitulo.ForeColor = corBranco;
            this.lblTitulo.Text = "Gestão de Caixa";
            this.lblTitulo.Location = new System.Drawing.Point(20, 13);
            this.lblTitulo.Name = "lblTitulo";

            System.Windows.Forms.Panel pnlAcento = new System.Windows.Forms.Panel();
            pnlAcento.BackColor = corAcento;
            pnlAcento.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlAcento.Height = 2;
            this.pnlTopo.Controls.Add(pnlAcento);

            // ── pnlCampos — barra de campos
            this.pnlCampos.BackColor = corPainel;
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCampos.Height = 86;
            this.pnlCampos.Name = "pnlCampos";
            this.pnlCampos.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);

            System.Windows.Forms.Panel pnlSepCampos = new System.Windows.Forms.Panel();
            pnlSepCampos.BackColor = corBorda;
            pnlSepCampos.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlSepCampos.Height = 1;
            this.pnlCampos.Controls.Add(pnlSepCampos);

            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = fLabel;
            this.lblMesa.ForeColor = corSub;
            this.lblMesa.Location = new System.Drawing.Point(22, 16);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Text = "NÚMERO DA MESA";

            this.txbMesa.BackColor = corCampo;
            this.txbMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMesa.Font = fCampo;
            this.txbMesa.ForeColor = corBranco;
            this.txbMesa.Location = new System.Drawing.Point(22, 36);
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(160, 28);
            this.txbMesa.TabIndex = 4;

            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = fLabel;
            this.lblValorFinal.ForeColor = corSub;
            this.lblValorFinal.Location = new System.Drawing.Point(220, 16);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Text = "VALOR A PAGAR";

            this.lblValor.AutoSize = true;
            this.lblValor.Font = fValor;
            this.lblValor.ForeColor = corBranco;
            this.lblValor.Location = new System.Drawing.Point(218, 34);
            this.lblValor.Name = "lblValor";
            this.lblValor.Text = "—";

            this.label1.AutoSize = true;
            this.label1.Font = fLabel;
            this.label1.ForeColor = corSub;
            this.label1.Location = new System.Drawing.Point(420, 16);
            this.label1.Name = "label1";
            this.label1.Text = "FORMA DE PAGAMENTO";

            this.cmbFormaPagamento.BackColor = corCampo;
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPagamento.Font = fCampo;
            this.cmbFormaPagamento.ForeColor = corBranco;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(420, 36);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(260, 28);
            this.cmbFormaPagamento.TabIndex = 10;
            this.cmbFormaPagamento.Enabled = false;

            this.pnlCampos.Controls.Add(this.lblMesa);
            this.pnlCampos.Controls.Add(this.txbMesa);
            this.pnlCampos.Controls.Add(this.lblValorFinal);
            this.pnlCampos.Controls.Add(this.lblValor);
            this.pnlCampos.Controls.Add(this.label1);
            this.pnlCampos.Controls.Add(this.cmbFormaPagamento);

            // ── pnlBotoes
            this.pnlBotoes.BackColor = corPainel;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Height = 68;
            this.pnlBotoes.Name = "pnlBotoes";

            System.Windows.Forms.Panel pnlSepBotoes = new System.Windows.Forms.Panel();
            pnlSepBotoes.BackColor = corBorda;
            pnlSepBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSepBotoes.Height = 1;
            this.pnlBotoes.Controls.Add(pnlSepBotoes);

            this.btnPesquisar.BackColor = corCampo;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.FlatAppearance.BorderColor = corBorda;
            this.btnPesquisar.FlatAppearance.BorderSize = 1;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 50, 85);
            this.btnPesquisar.Font = fBotao;
            this.btnPesquisar.ForeColor = corBranco;
            this.btnPesquisar.Location = new System.Drawing.Point(20, 14);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(148, 40);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);

            this.btnLimpar.BackColor = corCampo;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderColor = corBorda;
            this.btnLimpar.FlatAppearance.BorderSize = 1;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 50, 85);
            this.btnLimpar.Font = fBotao;
            this.btnLimpar.ForeColor = corSub;
            this.btnLimpar.Location = new System.Drawing.Point(180, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 40);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);

            this.btnFinalizar.BackColor = corBorda;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.Font = fBotao;
            this.btnFinalizar.ForeColor = corBranco;
            this.btnFinalizar.Location = new System.Drawing.Point(340, 14);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(188, 40);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar Pedido";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);

            this.btnVoltar.BackColor = corCampo;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderColor = corBorda;
            this.btnVoltar.FlatAppearance.BorderSize = 1;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 50, 85);
            this.btnVoltar.Font = fBotao;
            this.btnVoltar.ForeColor = corSub;
            this.btnVoltar.Location = new System.Drawing.Point(540, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 40);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "← Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            this.pnlBotoes.Controls.Add(this.btnPesquisar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnFinalizar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);

            // ── pnlGrid
            this.pnlGrid.BackColor = corFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.dgvComanda);

            // ── dgvComanda
            this.dgvComanda.AllowUserToAddRows = false;
            this.dgvComanda.AllowUserToDeleteRows = false;
            this.dgvComanda.AllowUserToResizeColumns = false;
            this.dgvComanda.AllowUserToResizeRows = false;
            this.dgvComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComanda.BackgroundColor = corCampo;
            this.dgvComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComanda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvComanda.GridColor = System.Drawing.Color.FromArgb(30, 40, 68);
            this.dgvComanda.ColumnHeadersHeight = 36;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComanda.EnableHeadersVisualStyles = false;
            this.dgvComanda.Font = fGrid;
            this.dgvComanda.MultiSelect = false;
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.ReadOnly = true;
            this.dgvComanda.RowHeadersVisible = false;
            this.dgvComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComanda.TabIndex = 18;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(14, 20, 42);
            this.dgvComanda.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.dgvComanda.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(14, 20, 42);
            this.dgvComanda.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dgvComanda.DefaultCellStyle.BackColor = corCampo;
            this.dgvComanda.DefaultCellStyle.ForeColor = corBranco;
            this.dgvComanda.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 204, 64, 44);
            this.dgvComanda.DefaultCellStyle.SelectionForeColor = corBranco;
            this.dgvComanda.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 7, 0, 7);
            this.dgvComanda.RowTemplate.Height = 42;
            this.dgvComanda.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 26, 50);
            this.dgvComanda.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;

            // GroupBoxes mantidos ocultos para compatibilidade
            this.grbInformacoes.Controls.Add(new System.Windows.Forms.Label());
            this.grbInformacoes.Location = new System.Drawing.Point(-500, -500);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(10, 10);
            this.grbInformacoes.TabIndex = 16;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            this.grbInformacoes.Visible = false;

            this.grbPagamentos.Controls.Add(new System.Windows.Forms.Label());
            this.grbPagamentos.Location = new System.Drawing.Point(-500, -500);
            this.grbPagamentos.Name = "grbPagamentos";
            this.grbPagamentos.Size = new System.Drawing.Size(10, 10);
            this.grbPagamentos.TabIndex = 17;
            this.grbPagamentos.TabStop = false;
            this.grbPagamentos.Text = "Pagamento";
            this.grbPagamentos.Visible = false;

            // ── Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestaoCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa";

            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.grbPagamentos);

            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.grbInformacoes.ResumeLayout(false);
            this.grbPagamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.GroupBox grbPagamentos;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.TextBox txbMesa;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
    }
}