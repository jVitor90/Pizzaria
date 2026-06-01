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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvComanda = new System.Windows.Forms.DataGridView();
            // sidebar
            this.lblSecBusca = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            // GroupBoxes ocultos (compatibilidade)
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.grbPagamentos = new System.Windows.Forms.GroupBox();
            this.pnlBotoes = new System.Windows.Forms.Panel(); // alias
            this.pnlTopo = new System.Windows.Forms.Panel(); // alias
            this.pnlCampos = new System.Windows.Forms.Panel(); // alias

            this.grbInformacoes.SuspendLayout();
            this.grbPagamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).BeginInit();
            this.SuspendLayout();

            // ── cores ──────────────────────────────────────────────────
            System.Drawing.Color cFundo = System.Drawing.Color.FromArgb(12, 12, 12);
            System.Drawing.Color cHeader = System.Drawing.Color.FromArgb(10, 10, 10);
            System.Drawing.Color cAccent = System.Drawing.Color.FromArgb(196, 30, 30);
            System.Drawing.Color cCard = System.Drawing.Color.FromArgb(18, 18, 18);
            System.Drawing.Color cBorder = System.Drawing.Color.FromArgb(32, 32, 30);
            System.Drawing.Color cBranco = System.Drawing.Color.White;
            System.Drawing.Color cSub = System.Drawing.Color.FromArgb(80, 80, 75);
            System.Drawing.Color cCampo = System.Drawing.Color.FromArgb(24, 24, 24);

            System.Drawing.Font fHeader = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fValor = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBtn = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBtnSm = new System.Drawing.Font("Segoe UI", 9F);

            // ── lblTitulo ──────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = fHeader;
            this.lblTitulo.ForeColor = cBranco;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Gestão de Caixa";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);

            this.pnlHeader.BackColor = cHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitulo);

            this.pnlHeaderLine.BackColor = cAccent;
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Height = 2;
            this.pnlHeaderLine.Name = "pnlHeaderLine";

            // ── dgvComanda ─────────────────────────────────────────────
            this.dgvComanda.AllowUserToAddRows = false;
            this.dgvComanda.AllowUserToDeleteRows = false;
            this.dgvComanda.AllowUserToResizeColumns = false;
            this.dgvComanda.AllowUserToResizeRows = false;
            this.dgvComanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComanda.BackgroundColor = cCampo;
            this.dgvComanda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComanda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComanda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComanda.ColumnHeadersHeight = 40;
            this.dgvComanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComanda.EnableHeadersVisualStyles = false;
            this.dgvComanda.Font = fCampo;
            this.dgvComanda.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.dgvComanda.MultiSelect = false;
            this.dgvComanda.Name = "dgvComanda";
            this.dgvComanda.ReadOnly = true;
            this.dgvComanda.RowHeadersVisible = false;
            this.dgvComanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComanda.TabIndex = 0;

            this.dgvComanda.ColumnHeadersDefaultCellStyle.BackColor = cHeader;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.ForeColor = cSub;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvComanda.ColumnHeadersDefaultCellStyle.SelectionBackColor = cHeader;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.SelectionForeColor = cSub;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvComanda.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.dgvComanda.DefaultCellStyle.BackColor = cCampo;
            this.dgvComanda.DefaultCellStyle.ForeColor = cBranco;
            this.dgvComanda.DefaultCellStyle.SelectionBackColor = cAccent;
            this.dgvComanda.DefaultCellStyle.SelectionForeColor = cBranco;
            this.dgvComanda.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.dgvComanda.RowTemplate.Height = 48;
            this.dgvComanda.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvComanda.AlternatingRowsDefaultCellStyle.ForeColor = cBranco;

            this.pnlGrid.BackColor = cFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.dgvComanda);

            // ════════════════════════════════════════════════════════════
            // SIDEBAR
            // ════════════════════════════════════════════════════════════

            this.lblSecBusca.AutoSize = true;
            this.lblSecBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblSecBusca.Font = fLabel;
            this.lblSecBusca.ForeColor = cSub;
            this.lblSecBusca.Location = new System.Drawing.Point(24, 24);
            this.lblSecBusca.Name = "lblSecBusca";
            this.lblSecBusca.Text = "BUSCAR COMANDA";

            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.Transparent;
            this.lblMesa.Font = fLabel;
            this.lblMesa.ForeColor = cSub;
            this.lblMesa.Location = new System.Drawing.Point(24, 50);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Text = "NÚMERO DA MESA";

            this.txbMesa.BackColor = cCampo;
            this.txbMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMesa.Font = fCampo;
            this.txbMesa.ForeColor = cBranco;
            this.txbMesa.Location = new System.Drawing.Point(24, 68);
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(272, 28);
            this.txbMesa.TabIndex = 0;

            this.btnPesquisar.BackColor = cAccent;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnPesquisar.Font = fBtn;
            this.btnPesquisar.ForeColor = cBranco;
            this.btnPesquisar.Location = new System.Drawing.Point(24, 108);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(272, 44);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar Mesa";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);

            // valor a pagar
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblValorFinal.Font = fLabel;
            this.lblValorFinal.ForeColor = cSub;
            this.lblValorFinal.Location = new System.Drawing.Point(24, 178);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Text = "VALOR A PAGAR";

            this.lblValor.AutoSize = false;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = fValor;
            this.lblValor.ForeColor = cBranco;
            this.lblValor.Location = new System.Drawing.Point(22, 196);
            this.lblValor.Size = new System.Drawing.Size(276, 40);
            this.lblValor.Name = "lblValor";
            this.lblValor.Text = "—";

            // forma de pagamento
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = fLabel;
            this.label1.ForeColor = cSub;
            this.label1.Location = new System.Drawing.Point(24, 252);
            this.label1.Name = "label1";
            this.label1.Text = "FORMA DE PAGAMENTO";

            this.cmbFormaPagamento.BackColor = cCampo;
            this.cmbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPagamento.Enabled = false;
            this.cmbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPagamento.Font = fCampo;
            this.cmbFormaPagamento.ForeColor = cBranco;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(24, 270);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(272, 30);
            this.cmbFormaPagamento.TabIndex = 2;

            // btn finalizar
            this.btnFinalizar.BackColor = cAccent;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnFinalizar.Font = fBtn;
            this.btnFinalizar.ForeColor = cBranco;
            this.btnFinalizar.Location = new System.Drawing.Point(24, 318);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(272, 44);
            this.btnFinalizar.TabIndex = 3;
            this.btnFinalizar.Text = "Finalizar Comanda";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);

            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = fBtnSm;
            this.btnLimpar.ForeColor = cSub;
            this.btnLimpar.Location = new System.Drawing.Point(24, 382);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);

            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = fBtnSm;
            this.btnVoltar.ForeColor = cSub;
            this.btnVoltar.Location = new System.Drawing.Point(152, 382);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(144, 30);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "\u21A9  Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // ── pnlSidebar ─────────────────────────────────────────────
            this.pnlSidebar.BackColor = cCard;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Width = 320;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Controls.Add(this.lblSecBusca);
            this.pnlSidebar.Controls.Add(this.lblMesa);
            this.pnlSidebar.Controls.Add(this.txbMesa);
            this.pnlSidebar.Controls.Add(this.btnPesquisar);
            this.pnlSidebar.Controls.Add(this.lblValorFinal);
            this.pnlSidebar.Controls.Add(this.lblValor);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Controls.Add(this.cmbFormaPagamento);
            this.pnlSidebar.Controls.Add(this.btnFinalizar);
            this.pnlSidebar.Controls.Add(this.btnLimpar);
            this.pnlSidebar.Controls.Add(this.btnVoltar);

            // ── pnlBody ────────────────────────────────────────────────
            this.pnlBody.BackColor = cFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Controls.Add(this.pnlGrid);    // Fill
            this.pnlBody.Controls.Add(this.pnlSidebar); // Right

            // GroupBoxes ocultos (compatibilidade com o .cs)
            this.grbInformacoes.Controls.Add(new System.Windows.Forms.Label());
            this.grbInformacoes.Location = new System.Drawing.Point(-500, -500);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(10, 10);
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            this.grbInformacoes.Visible = false;

            this.grbPagamentos.Controls.Add(new System.Windows.Forms.Label());
            this.grbPagamentos.Location = new System.Drawing.Point(-500, -501);
            this.grbPagamentos.Name = "grbPagamentos";
            this.grbPagamentos.Size = new System.Drawing.Size(10, 10);
            this.grbPagamentos.TabStop = false;
            this.grbPagamentos.Text = "Pagamento";
            this.grbPagamentos.Visible = false;

            // aliases (ocultos, fora da tela)
            this.pnlBotoes.Location = new System.Drawing.Point(-500, -502);
            this.pnlBotoes.Size = new System.Drawing.Size(1, 1);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlCampos.Location = new System.Drawing.Point(-500, -503);
            this.pnlCampos.Size = new System.Drawing.Size(1, 1);
            this.pnlCampos.Name = "pnlCampos";
            this.pnlTopo.Location = new System.Drawing.Point(-500, -504);
            this.pnlTopo.Size = new System.Drawing.Size(1, 1);
            this.pnlTopo.Name = "pnlTopo";

            // ── Form ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = cFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmGestaoCaixa";
            this.Text = "Caixa";

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grbInformacoes);
            this.Controls.Add(this.grbPagamentos);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);

            this.grbInformacoes.ResumeLayout(false);
            this.grbPagamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComanda)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSecBusca;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMesa;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.DataGridView dgvComanda;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.GroupBox grbPagamentos;
        // aliases de compatibilidade
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Panel pnlBotoes;
    }
}