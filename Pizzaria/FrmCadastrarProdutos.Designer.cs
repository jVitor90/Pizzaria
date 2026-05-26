namespace Pizzaria
{
    partial class FrmCadastrarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarProdutos));

            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();

            // ── Cores
            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(15, 20, 40);
            System.Drawing.Color corPainel = System.Drawing.Color.FromArgb(22, 30, 55);
            System.Drawing.Color corCampo = System.Drawing.Color.FromArgb(30, 40, 70);
            System.Drawing.Color corDestaque = System.Drawing.Color.FromArgb(220, 70, 50);
            System.Drawing.Color corBranco = System.Drawing.Color.FromArgb(220, 225, 240);
            System.Drawing.Color corSub = System.Drawing.Color.FromArgb(120, 135, 170);
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(40, 55, 90);

            // ── Fontes
            System.Drawing.Font fTitulo = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fBotao = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fGrid = new System.Drawing.Font("Segoe UI", 10F);

            // ── pnlTopo
            this.pnlTopo.BackColor = corPainel;
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 56;
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Controls.Add(this.lblTitulo);

            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = fTitulo;
            this.lblTitulo.ForeColor = corBranco;
            this.lblTitulo.Text = "Cadastrar Produto";
            this.lblTitulo.Location = new System.Drawing.Point(18, 14);
            this.lblTitulo.Name = "lblTitulo";

            // ── pnlCampos
            this.pnlCampos.BackColor = corFundo;
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCampos.Height = 80;
            this.pnlCampos.Name = "pnlCampos";

            // PRODUTO
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = fLabel;
            this.lblProduto.ForeColor = corSub;
            this.lblProduto.Location = new System.Drawing.Point(18, 10);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Text = "PRODUTO";

            this.txbNomeProduto.BackColor = corCampo;
            this.txbNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeProduto.Font = fCampo;
            this.txbNomeProduto.ForeColor = corBranco;
            this.txbNomeProduto.Location = new System.Drawing.Point(18, 28);
            this.txbNomeProduto.Multiline = true;
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(300, 36);
            this.txbNomeProduto.TabIndex = 73;

            // PREÇO
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = fLabel;
            this.lblPreco.ForeColor = corSub;
            this.lblPreco.Location = new System.Drawing.Point(332, 10);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Text = "PREÇO";

            this.txbValor.BackColor = corCampo;
            this.txbValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbValor.Font = fCampo;
            this.txbValor.ForeColor = corBranco;
            this.txbValor.Location = new System.Drawing.Point(332, 28);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(180, 36);
            this.txbValor.TabIndex = 75;

            // CATEGORIA
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = fLabel;
            this.lblCategoria.ForeColor = corSub;
            this.lblCategoria.Location = new System.Drawing.Point(526, 10);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "CATEGORIA";

            this.cmbCategoria.BackColor = corCampo;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = fCampo;
            this.cmbCategoria.ForeColor = corBranco;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Location = new System.Drawing.Point(526, 28);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(220, 28);
            this.cmbCategoria.TabIndex = 72;

            this.pnlCampos.Controls.Add(this.lblProduto);
            this.pnlCampos.Controls.Add(this.txbNomeProduto);
            this.pnlCampos.Controls.Add(this.lblPreco);
            this.pnlCampos.Controls.Add(this.txbValor);
            this.pnlCampos.Controls.Add(this.lblCategoria);
            this.pnlCampos.Controls.Add(this.cmbCategoria);

            // ── pnlBotoes
            this.pnlBotoes.BackColor = corPainel;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Height = 70;
            this.pnlBotoes.Name = "pnlBotoes";

            this.btnCadastrar.BackColor = corDestaque;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = fBotao;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(18, 13);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 44);
            this.btnCadastrar.TabIndex = 67;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            this.btnEditar.BackColor = corCampo;
            this.btnEditar.FlatAppearance.BorderColor = corBorda;
            this.btnEditar.FlatAppearance.BorderSize = 1;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = fBotao;
            this.btnEditar.ForeColor = corBranco;
            this.btnEditar.Location = new System.Drawing.Point(188, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 44);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnExcluir.BackColor = corCampo;
            this.btnExcluir.FlatAppearance.BorderColor = corBorda;
            this.btnExcluir.FlatAppearance.BorderSize = 1;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = fBotao;
            this.btnExcluir.ForeColor = corBranco;
            this.btnExcluir.Location = new System.Drawing.Point(358, 13);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(160, 44);
            this.btnExcluir.TabIndex = 69;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            this.btnVoltar.BackColor = corCampo;
            this.btnVoltar.FlatAppearance.BorderColor = corBorda;
            this.btnVoltar.FlatAppearance.BorderSize = 1;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = fBotao;
            this.btnVoltar.ForeColor = corSub;
            this.btnVoltar.Location = new System.Drawing.Point(528, 13);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(160, 44);
            this.btnVoltar.TabIndex = 70;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnVoltar);

            // ── pnlGrid
            this.pnlGrid.BackColor = corFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Controls.Add(this.dgvProdutos);

            // ── dgvProdutos
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = corCampo;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeight = 36;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProdutos.ColumnHeadersVisible = true;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.Font = fGrid;
            this.dgvProdutos.GridColor = corBorda;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.TabIndex = 66;

            this.dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = corPainel;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.SelectionBackColor = corPainel;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);

            this.dgvProdutos.DefaultCellStyle.BackColor = corCampo;
            this.dgvProdutos.DefaultCellStyle.ForeColor = corBranco;
            this.dgvProdutos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(80, 220, 70, 50);
            this.dgvProdutos.DefaultCellStyle.SelectionForeColor = corBranco;
            this.dgvProdutos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 6, 0, 6);
            this.dgvProdutos.RowTemplate.Height = 44;

            this.dgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 28, 54);
            this.dgvProdutos.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;

            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            this.dgvProdutos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProdutos_RowHeaderMouseClick);

            // ── Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.KeyPreview = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrarProdutos";
            this.Text = "Cadastrar Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // ORDEM CRÍTICA: Fill → Bottom → Top → Top
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);

            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlCampos;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlBotoes;
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
        private System.Windows.Forms.Button btnVoltar;
    }
}