namespace Pizzaria
{
    partial class FrmGestaoProdutos
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
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            // sidebar
            this.lblSecaoCadastro = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
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
            System.Drawing.Font fBtn = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBtnSm = new System.Drawing.Font("Segoe UI", 9F);

            // ── lblTitulo ──────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = fHeader;
            this.lblTitulo.ForeColor = cBranco;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Gestão de Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);

            // ── pnlHeader ─────────────────────────────────────────────
            this.pnlHeader.BackColor = cHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Controls.Add(this.lblTitulo);

            // ── pnlHeaderLine ──────────────────────────────────────────
            this.pnlHeaderLine.BackColor = cAccent;
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Height = 2;
            this.pnlHeaderLine.Name = "pnlHeaderLine";

            // ── dgvProdutos ────────────────────────────────────────────
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = cCampo;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeight = 40;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Font = fCampo;
            this.dgvProdutos.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.TabIndex = 0;

            this.dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = cHeader;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = cSub;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.SelectionBackColor = cHeader;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.SelectionForeColor = cSub;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);

            this.dgvProdutos.DefaultCellStyle.BackColor = cCampo;
            this.dgvProdutos.DefaultCellStyle.ForeColor = cBranco;
            this.dgvProdutos.DefaultCellStyle.SelectionBackColor = cAccent;
            this.dgvProdutos.DefaultCellStyle.SelectionForeColor = cBranco;
            this.dgvProdutos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.dgvProdutos.RowTemplate.Height = 48;

            this.dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvProdutos.AlternatingRowsDefaultCellStyle.ForeColor = cBranco;

            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            this.dgvProdutos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_RowHeaderMouseClick);

            // ── pnlGrid ────────────────────────────────────────────────
            this.pnlGrid.BackColor = cFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.dgvProdutos);

            // ════════════════════════════════════════════════════════════
            // SIDEBAR
            // ════════════════════════════════════════════════════════════

            this.lblSecaoCadastro.AutoSize = true;
            this.lblSecaoCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblSecaoCadastro.Font = fLabel;
            this.lblSecaoCadastro.ForeColor = cSub;
            this.lblSecaoCadastro.Location = new System.Drawing.Point(24, 24);
            this.lblSecaoCadastro.Name = "lblSecaoCadastro";
            this.lblSecaoCadastro.Text = "DADOS DO PRODUTO";

            // PRODUTO
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = fLabel;
            this.lblProduto.ForeColor = cSub;
            this.lblProduto.Location = new System.Drawing.Point(24, 50);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Text = "PRODUTO";

            this.txbNomeProduto.BackColor = cCampo;
            this.txbNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeProduto.Font = fCampo;
            this.txbNomeProduto.ForeColor = cBranco;
            this.txbNomeProduto.Location = new System.Drawing.Point(24, 68);
            this.txbNomeProduto.Multiline = true;
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(272, 36);
            this.txbNomeProduto.TabIndex = 0;

            // PREÇO
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = fLabel;
            this.lblPreco.ForeColor = cSub;
            this.lblPreco.Location = new System.Drawing.Point(24, 118);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Text = "PREÇO";

            this.txbValor.BackColor = cCampo;
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValor.Font = fCampo;
            this.txbValor.ForeColor = cBranco;
            this.txbValor.Location = new System.Drawing.Point(24, 136);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(272, 36);
            this.txbValor.TabIndex = 1;

            // CATEGORIA
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = fLabel;
            this.lblCategoria.ForeColor = cSub;
            this.lblCategoria.Location = new System.Drawing.Point(24, 186);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "CATEGORIA";

            this.cmbCategoria.BackColor = cCampo;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = fCampo;
            this.cmbCategoria.ForeColor = cBranco;
            this.cmbCategoria.Location = new System.Drawing.Point(24, 204);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(272, 30);
            this.cmbCategoria.TabIndex = 2;

            // ── botões sidebar ─────────────────────────────────────────
            this.btnCadastrar.BackColor = cAccent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnCadastrar.Font = fBtn;
            this.btnCadastrar.ForeColor = cBranco;
            this.btnCadastrar.Location = new System.Drawing.Point(24, 256);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(272, 44);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar Produto";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            this.btnEditar.BackColor = cCampo;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderColor = cBorder;
            this.btnEditar.FlatAppearance.BorderSize = 1;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.btnEditar.Font = fBtnSm;
            this.btnEditar.ForeColor = cBranco;
            this.btnEditar.Location = new System.Drawing.Point(24, 312);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(272, 44);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Salvar Edição";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnExcluir.BackColor = cCampo;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.FlatAppearance.BorderColor = cBorder;
            this.btnExcluir.FlatAppearance.BorderSize = 1;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.btnExcluir.Font = fBtnSm;
            this.btnExcluir.ForeColor = cAccent;
            this.btnExcluir.Location = new System.Drawing.Point(24, 368);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(272, 44);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Produto";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = fBtnSm;
            this.btnLimpar.ForeColor = cSub;
            this.btnLimpar.Location = new System.Drawing.Point(24, 430);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = fBtnSm;
            this.btnVoltar.ForeColor = cSub;
            this.btnVoltar.Location = new System.Drawing.Point(152, 430);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(144, 30);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "\u21A9  Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // ── pnlSidebar ─────────────────────────────────────────────
            this.pnlSidebar.BackColor = cCard;
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Width = 320;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Controls.Add(this.lblSecaoCadastro);
            this.pnlSidebar.Controls.Add(this.lblProduto);
            this.pnlSidebar.Controls.Add(this.txbNomeProduto);
            this.pnlSidebar.Controls.Add(this.lblPreco);
            this.pnlSidebar.Controls.Add(this.txbValor);
            this.pnlSidebar.Controls.Add(this.lblCategoria);
            this.pnlSidebar.Controls.Add(this.cmbCategoria);
            this.pnlSidebar.Controls.Add(this.btnCadastrar);
            this.pnlSidebar.Controls.Add(this.btnEditar);
            this.pnlSidebar.Controls.Add(this.btnExcluir);
            this.pnlSidebar.Controls.Add(this.btnLimpar);
            this.pnlSidebar.Controls.Add(this.btnVoltar);

            // ── pnlBody ────────────────────────────────────────────────
            this.pnlBody.BackColor = cFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
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
            this.Name = "FrmGestaoProdutos";
            this.Text = "Gestão de Produtos";

            // Ordem: Fill → Top(line) → Top(header)
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSecaoCadastro;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;

        // aliases de compatibilidade
        private System.Windows.Forms.Panel pnlTopo { get { return pnlHeader; } }
        private System.Windows.Forms.Panel pnlCampos { get { return pnlSidebar; } }
        private System.Windows.Forms.Panel pnlBotoes { get { return pnlSidebar; } }
    }
}