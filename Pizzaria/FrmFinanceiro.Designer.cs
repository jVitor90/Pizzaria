namespace Pizzaria
{
    partial class FrmFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinanceiro));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.DgvFaturamento = new System.Windows.Forms.DataGridView();
            // sidebar
            this.GrbFaturamentoPeriodo = new System.Windows.Forms.GroupBox();
            this.GrbFaturamentoMensal = new System.Windows.Forms.GroupBox();
            this.lblSecaoPeriodo = new System.Windows.Forms.Label();
            this.lblDe = new System.Windows.Forms.Label();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.BtnGerarRelatorio = new System.Windows.Forms.Button();
            this.lblSecaoMensal = new System.Windows.Forms.Label();
            this.BtnFaturamentoMensalAtual = new System.Windows.Forms.Button();
            this.BtnRelatorioMensalGeral = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();

            this.GrbFaturamentoPeriodo.SuspendLayout();
            this.GrbFaturamentoMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaturamento)).BeginInit();
            this.SuspendLayout();

            // ── cores (idênticas ao GerenciarUsuarios) ─────────────────
            System.Drawing.Color cFundo = System.Drawing.Color.FromArgb(12, 12, 12);
            System.Drawing.Color cHeader = System.Drawing.Color.FromArgb(10, 10, 10);
            System.Drawing.Color cAccent = System.Drawing.Color.FromArgb(196, 30, 30);
            System.Drawing.Color cCard = System.Drawing.Color.FromArgb(18, 18, 18);
            System.Drawing.Color cBorder = System.Drawing.Color.FromArgb(32, 32, 30);
            System.Drawing.Color cBranco = System.Drawing.Color.White;
            System.Drawing.Color cSub = System.Drawing.Color.FromArgb(80, 80, 75);
            System.Drawing.Color cCampo = System.Drawing.Color.FromArgb(24, 24, 24);

            // ── fontes ─────────────────────────────────────────────────
            System.Drawing.Font fHeader = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fBtn = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBtnSm = new System.Drawing.Font("Segoe UI", 9F);

            // ── lblTitulo ──────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = fHeader;
            this.lblTitulo.ForeColor = cBranco;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Financeiro";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);

            // ── pnlHeader ─────────────────────────────────────────────
            this.pnlHeader.BackColor = cHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblTitulo);

            // ── pnlHeaderLine ──────────────────────────────────────────
            this.pnlHeaderLine.BackColor = cAccent;
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Height = 2;
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.TabIndex = 1;

            // ── DgvFaturamento ─────────────────────────────────────────
            this.DgvFaturamento.AllowUserToAddRows = false;
            this.DgvFaturamento.AllowUserToDeleteRows = false;
            this.DgvFaturamento.AllowUserToResizeColumns = false;
            this.DgvFaturamento.AllowUserToResizeRows = false;
            this.DgvFaturamento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvFaturamento.BackgroundColor = cCampo;
            this.DgvFaturamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvFaturamento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvFaturamento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvFaturamento.ColumnHeadersHeight = 40;
            this.DgvFaturamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvFaturamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvFaturamento.EnableHeadersVisualStyles = false;
            this.DgvFaturamento.Font = fCampo;
            this.DgvFaturamento.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.DgvFaturamento.MultiSelect = false;
            this.DgvFaturamento.Name = "DgvFaturamento";
            this.DgvFaturamento.ReadOnly = true;
            this.DgvFaturamento.RowHeadersVisible = false;
            this.DgvFaturamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFaturamento.TabIndex = 0;

            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.BackColor = cHeader;
            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.ForeColor = cSub;
            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.SelectionBackColor = cHeader;
            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.SelectionForeColor = cSub;
            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvFaturamento.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);

            this.DgvFaturamento.DefaultCellStyle.BackColor = cCampo;
            this.DgvFaturamento.DefaultCellStyle.ForeColor = cBranco;
            this.DgvFaturamento.DefaultCellStyle.SelectionBackColor = cAccent;
            this.DgvFaturamento.DefaultCellStyle.SelectionForeColor = cBranco;
            this.DgvFaturamento.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.DgvFaturamento.RowTemplate.Height = 48;

            this.DgvFaturamento.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.DgvFaturamento.AlternatingRowsDefaultCellStyle.ForeColor = cBranco;

            // ── pnlGrid ────────────────────────────────────────────────
            this.pnlGrid.BackColor = cFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.TabIndex = 0;
            this.pnlGrid.Controls.Add(this.DgvFaturamento);

            // ═══════════════════════════════════════════════════════════
            // SIDEBAR — mesmas proporções do GerenciarUsuarios
            // ═══════════════════════════════════════════════════════════

            // ── seção período ──────────────────────────────────────────
            this.lblSecaoPeriodo.AutoSize = true;
            this.lblSecaoPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.lblSecaoPeriodo.Font = fLabel;
            this.lblSecaoPeriodo.ForeColor = cSub;
            this.lblSecaoPeriodo.Location = new System.Drawing.Point(24, 24);
            this.lblSecaoPeriodo.Name = "lblSecaoPeriodo";
            this.lblSecaoPeriodo.Text = "FATURAMENTO POR PERÍODO";

            this.lblDe.AutoSize = true;
            this.lblDe.BackColor = System.Drawing.Color.Transparent;
            this.lblDe.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDe.ForeColor = cSub;
            this.lblDe.Location = new System.Drawing.Point(24, 50);
            this.lblDe.Name = "lblDe";
            this.lblDe.Text = "Data Início:";

            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(24, 68);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(272, 28);
            this.dtpInicio.TabIndex = 0;
            this.dtpInicio.CalendarForeColor = cBranco;
            this.dtpInicio.CalendarMonthBackground = cCampo;
            this.dtpInicio.CalendarTitleBackColor = cAccent;

            this.lblAte.AutoSize = true;
            this.lblAte.BackColor = System.Drawing.Color.Transparent;
            this.lblAte.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAte.ForeColor = cSub;
            this.lblAte.Location = new System.Drawing.Point(24, 106);
            this.lblAte.Name = "lblAte";
            this.lblAte.Text = "Data Fim:";

            this.dtpFim.CustomFormat = "dd/MM/yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(24, 124);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(272, 28);
            this.dtpFim.TabIndex = 1;
            this.dtpFim.CalendarForeColor = cBranco;
            this.dtpFim.CalendarMonthBackground = cCampo;
            this.dtpFim.CalendarTitleBackColor = cAccent;

            this.BtnGerarRelatorio.BackColor = cAccent;
            this.BtnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.BtnGerarRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.BtnGerarRelatorio.Font = fBtn;
            this.BtnGerarRelatorio.ForeColor = cBranco;
            this.BtnGerarRelatorio.Location = new System.Drawing.Point(24, 164);
            this.BtnGerarRelatorio.Name = "BtnGerarRelatorio";
            this.BtnGerarRelatorio.Size = new System.Drawing.Size(272, 44);
            this.BtnGerarRelatorio.TabIndex = 2;
            this.BtnGerarRelatorio.Text = "Gerar Relatório por Período";
            this.BtnGerarRelatorio.UseVisualStyleBackColor = false;
            this.BtnGerarRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);

            // GroupBox invisível (mantido para compatibilidade com o .cs)
            this.GrbFaturamentoPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.GrbFaturamentoPeriodo.ForeColor = System.Drawing.Color.Transparent;
            this.GrbFaturamentoPeriodo.Location = new System.Drawing.Point(0, 0);
            this.GrbFaturamentoPeriodo.Size = new System.Drawing.Size(1, 1);
            this.GrbFaturamentoPeriodo.Name = "GrbFaturamentoPeriodo";
            this.GrbFaturamentoPeriodo.Text = " ";
            this.GrbFaturamentoPeriodo.TabStop = false;

            // ── seção mensal ───────────────────────────────────────────
            this.lblSecaoMensal.AutoSize = true;
            this.lblSecaoMensal.BackColor = System.Drawing.Color.Transparent;
            this.lblSecaoMensal.Font = fLabel;
            this.lblSecaoMensal.ForeColor = cSub;
            this.lblSecaoMensal.Location = new System.Drawing.Point(24, 230);
            this.lblSecaoMensal.Name = "lblSecaoMensal";
            this.lblSecaoMensal.Text = "FATURAMENTO MENSAL";

            this.BtnFaturamentoMensalAtual.BackColor = cCampo;
            this.BtnFaturamentoMensalAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaturamentoMensalAtual.FlatAppearance.BorderColor = cBorder;
            this.BtnFaturamentoMensalAtual.FlatAppearance.BorderSize = 1;
            this.BtnFaturamentoMensalAtual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.BtnFaturamentoMensalAtual.Font = fBtnSm;
            this.BtnFaturamentoMensalAtual.ForeColor = cBranco;
            this.BtnFaturamentoMensalAtual.Location = new System.Drawing.Point(24, 254);
            this.BtnFaturamentoMensalAtual.Name = "BtnFaturamentoMensalAtual";
            this.BtnFaturamentoMensalAtual.Size = new System.Drawing.Size(272, 44);
            this.BtnFaturamentoMensalAtual.TabIndex = 3;
            this.BtnFaturamentoMensalAtual.Text = "Faturamento Mês Atual";
            this.BtnFaturamentoMensalAtual.UseVisualStyleBackColor = false;
            this.BtnFaturamentoMensalAtual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFaturamentoMensalAtual.Click += new System.EventHandler(this.btnFaturamentoMensalAtual_Click);

            this.BtnRelatorioMensalGeral.BackColor = cCampo;
            this.BtnRelatorioMensalGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorioMensalGeral.FlatAppearance.BorderColor = cBorder;
            this.BtnRelatorioMensalGeral.FlatAppearance.BorderSize = 1;
            this.BtnRelatorioMensalGeral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.BtnRelatorioMensalGeral.Font = fBtnSm;
            this.BtnRelatorioMensalGeral.ForeColor = cBranco;
            this.BtnRelatorioMensalGeral.Location = new System.Drawing.Point(24, 310);
            this.BtnRelatorioMensalGeral.Name = "BtnRelatorioMensalGeral";
            this.BtnRelatorioMensalGeral.Size = new System.Drawing.Size(272, 44);
            this.BtnRelatorioMensalGeral.TabIndex = 4;
            this.BtnRelatorioMensalGeral.Text = "Relatório Mensal Geral";
            this.BtnRelatorioMensalGeral.UseVisualStyleBackColor = false;
            this.BtnRelatorioMensalGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRelatorioMensalGeral.Click += new System.EventHandler(this.btnRelatorioMensalGeral_Click);

            // GroupBox invisível (compatibilidade)
            this.GrbFaturamentoMensal.BackColor = System.Drawing.Color.Transparent;
            this.GrbFaturamentoMensal.ForeColor = System.Drawing.Color.Transparent;
            this.GrbFaturamentoMensal.Location = new System.Drawing.Point(0, 2);
            this.GrbFaturamentoMensal.Size = new System.Drawing.Size(1, 1);
            this.GrbFaturamentoMensal.Name = "GrbFaturamentoMensal";
            this.GrbFaturamentoMensal.Text = " ";
            this.GrbFaturamentoMensal.TabStop = false;

            // ── Voltar ─────────────────────────────────────────────────
            this.BtnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.FlatAppearance.BorderSize = 0;
            this.BtnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnVoltar.Font = fBtnSm;
            this.BtnVoltar.ForeColor = cSub;
            this.BtnVoltar.Location = new System.Drawing.Point(24, 374);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(144, 30);
            this.BtnVoltar.TabIndex = 5;
            this.BtnVoltar.Text = "\u21A9  Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);

            // ── pnlSidebar ─────────────────────────────────────────────
            this.pnlSidebar.BackColor = cCard;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Width = 320;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Controls.Add(this.lblSecaoPeriodo);
            this.pnlSidebar.Controls.Add(this.lblDe);
            this.pnlSidebar.Controls.Add(this.dtpInicio);
            this.pnlSidebar.Controls.Add(this.lblAte);
            this.pnlSidebar.Controls.Add(this.dtpFim);
            this.pnlSidebar.Controls.Add(this.BtnGerarRelatorio);
            this.pnlSidebar.Controls.Add(this.lblSecaoMensal);
            this.pnlSidebar.Controls.Add(this.BtnFaturamentoMensalAtual);
            this.pnlSidebar.Controls.Add(this.BtnRelatorioMensalGeral);
            this.pnlSidebar.Controls.Add(this.BtnVoltar);
            // GroupBoxes invisíveis (compatibilidade)
            this.pnlSidebar.Controls.Add(this.GrbFaturamentoPeriodo);
            this.pnlSidebar.Controls.Add(this.GrbFaturamentoMensal);

            // ── pnlBody ────────────────────────────────────────────────
            this.pnlBody.BackColor = cFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.TabIndex = 2;
            this.pnlBody.Controls.Add(this.pnlGrid);    // Fill
            this.pnlBody.Controls.Add(this.pnlSidebar); // Right

            // ── Form ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = cFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "FrmFinanceiro";
            this.Text = "Financeiro";

            // Ordem: Fill → Top(line) → Top(header)
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);

            this.GrbFaturamentoPeriodo.ResumeLayout(false);
            this.GrbFaturamentoMensal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaturamento)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSecaoPeriodo;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblSecaoMensal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Button BtnGerarRelatorio;
        private System.Windows.Forms.Button BtnFaturamentoMensalAtual;
        private System.Windows.Forms.Button BtnRelatorioMensalGeral;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.DataGridView DgvFaturamento;
        private System.Windows.Forms.GroupBox GrbFaturamentoPeriodo;
        private System.Windows.Forms.GroupBox GrbFaturamentoMensal;
    }
}