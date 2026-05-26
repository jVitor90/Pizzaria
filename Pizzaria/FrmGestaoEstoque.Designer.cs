namespace Pizzaria
{
    partial class FrmGestaoEstoque
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoEstoque));

            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlCampos = new System.Windows.Forms.Panel();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            this.pnlTopo.SuspendLayout();
            this.pnlCampos.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(15, 20, 40);
            System.Drawing.Color corPainel = System.Drawing.Color.FromArgb(22, 30, 55);
            System.Drawing.Color corCampo = System.Drawing.Color.FromArgb(30, 40, 70);
            System.Drawing.Color corDestaque = System.Drawing.Color.FromArgb(220, 70, 50);
            System.Drawing.Color corBranco = System.Drawing.Color.FromArgb(220, 225, 240);
            System.Drawing.Color corSub = System.Drawing.Color.FromArgb(120, 135, 170);
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(40, 55, 90);

            System.Drawing.Font fTitulo = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 10F);
            System.Drawing.Font fBotao = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fGrid = new System.Drawing.Font("Segoe UI", 9F);

            // pnlTopo
            this.pnlTopo.BackColor = corPainel;
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 56;
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Controls.Add(this.lblTitulo);

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = fTitulo;
            this.lblTitulo.ForeColor = corBranco;
            this.lblTitulo.Text = "Gestao de Estoque";
            this.lblTitulo.Location = new System.Drawing.Point(16, 18);
            this.lblTitulo.Name = "lblTitulo";

            // pnlCampos
            this.pnlCampos.BackColor = corFundo;
            this.pnlCampos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCampos.Height = 80;
            this.pnlCampos.Name = "pnlCampos";

            // lblProduto
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = fLabel;
            this.lblProduto.ForeColor = corSub;
            this.lblProduto.Location = new System.Drawing.Point(14, 14);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Text = "PRODUTO";

            // txbNomeProduto
            this.txbNomeProduto.BackColor = corCampo;
            this.txbNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNomeProduto.Font = fCampo;
            this.txbNomeProduto.ForeColor = corBranco;
            this.txbNomeProduto.Location = new System.Drawing.Point(14, 36);
            this.txbNomeProduto.Multiline = true;
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(320, 38);
            this.txbNomeProduto.TabIndex = 0;

            // lblCategoria
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoria.Font = fLabel;
            this.lblCategoria.ForeColor = corSub;
            this.lblCategoria.Location = new System.Drawing.Point(348, 14);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "CATEGORIA";

            // cmbCategoria
            this.cmbCategoria.BackColor = corCampo;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = fCampo;
            this.cmbCategoria.ForeColor = corBranco;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(348, 36);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(220, 28);
            this.cmbCategoria.TabIndex = 1;

            // lblUnidade
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.Transparent;
            this.lblUnidade.Font = fLabel;
            this.lblUnidade.ForeColor = corSub;
            this.lblUnidade.Location = new System.Drawing.Point(582, 14);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Text = "UNIDADE";

            // txbUnidade
            this.txbUnidade.BackColor = corCampo;
            this.txbUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUnidade.Font = fCampo;
            this.txbUnidade.ForeColor = corBranco;
            this.txbUnidade.Location = new System.Drawing.Point(582, 36);
            this.txbUnidade.Multiline = true;
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(150, 38);
            this.txbUnidade.TabIndex = 2;

            // lblQuantidade
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = fLabel;
            this.lblQuantidade.ForeColor = corSub;
            this.lblQuantidade.Location = new System.Drawing.Point(746, 14);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Text = "QUANTIDADE";

            // txbQuantidade
            this.txbQuantidade.BackColor = corCampo;
            this.txbQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbQuantidade.Font = fCampo;
            this.txbQuantidade.ForeColor = corBranco;
            this.txbQuantidade.Location = new System.Drawing.Point(746, 36);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(160, 38);
            this.txbQuantidade.TabIndex = 3;

            this.pnlCampos.Controls.Add(this.lblProduto);
            this.pnlCampos.Controls.Add(this.txbNomeProduto);
            this.pnlCampos.Controls.Add(this.lblCategoria);
            this.pnlCampos.Controls.Add(this.cmbCategoria);
            this.pnlCampos.Controls.Add(this.lblUnidade);
            this.pnlCampos.Controls.Add(this.txbUnidade);
            this.pnlCampos.Controls.Add(this.lblQuantidade);
            this.pnlCampos.Controls.Add(this.txbQuantidade);

            // pnlBotoes
            this.pnlBotoes.BackColor = corPainel;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Height = 72;
            this.pnlBotoes.Name = "pnlBotoes";

            // btnCadastrar
            this.btnCadastrar.BackColor = corDestaque;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = fBotao;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(14, 14);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(170, 44);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            // btnEditar
            this.btnEditar.BackColor = corCampo;
            this.btnEditar.FlatAppearance.BorderColor = corBorda;
            this.btnEditar.FlatAppearance.BorderSize = 1;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = fBotao;
            this.btnEditar.ForeColor = corBranco;
            this.btnEditar.Location = new System.Drawing.Point(194, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(170, 44);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            // btnExcluir
            this.btnExcluir.BackColor = corCampo;
            this.btnExcluir.FlatAppearance.BorderColor = corBorda;
            this.btnExcluir.FlatAppearance.BorderSize = 1;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = fBotao;
            this.btnExcluir.ForeColor = corBranco;
            this.btnExcluir.Location = new System.Drawing.Point(374, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(170, 44);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            // btnVoltar
            this.btnVoltar.BackColor = corCampo;
            this.btnVoltar.FlatAppearance.BorderColor = corBorda;
            this.btnVoltar.FlatAppearance.BorderSize = 1;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = fBotao;
            this.btnVoltar.ForeColor = corSub;
            this.btnVoltar.Location = new System.Drawing.Point(554, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(170, 44);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnEditar);
            this.pnlBotoes.Controls.Add(this.btnExcluir);
            this.pnlBotoes.Controls.Add(this.btnVoltar);

            // pnlGrid
            this.pnlGrid.BackColor = corFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(14, 8, 14, 8);
            this.pnlGrid.Controls.Add(this.dgvEstoque);

            // dgvEstoque
            this.dgvEstoque.AllowUserToAddRows = false;
            this.dgvEstoque.AllowUserToDeleteRows = false;
            this.dgvEstoque.AllowUserToResizeColumns = false;
            this.dgvEstoque.AllowUserToResizeRows = false;
            this.dgvEstoque.ColumnHeadersVisible = true;
            this.dgvEstoque.ColumnHeadersHeight = 36;
            this.dgvEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstoque.BackgroundColor = corCampo;
            this.dgvEstoque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEstoque.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstoque.EnableHeadersVisualStyles = false;
            this.dgvEstoque.Font = fGrid;
            this.dgvEstoque.GridColor = corBorda;
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.ReadOnly = true;
            this.dgvEstoque.RowHeadersVisible = false;
            this.dgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstoque.TabIndex = 51;

            this.dgvEstoque.ColumnHeadersDefaultCellStyle.BackColor = corPainel;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.dgvEstoque.ColumnHeadersDefaultCellStyle.SelectionBackColor = corPainel;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvEstoque.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);

            this.dgvEstoque.DefaultCellStyle.BackColor = corCampo;
            this.dgvEstoque.DefaultCellStyle.ForeColor = corBranco;
            this.dgvEstoque.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(60, 220, 70, 50);
            this.dgvEstoque.DefaultCellStyle.SelectionForeColor = corBranco;
            this.dgvEstoque.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.dgvEstoque.RowTemplate.Height = 40;

            this.dgvEstoque.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 36, 62);
            this.dgvEstoque.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;

            this.dgvEstoque.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellClick);
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);

            // FrmGestaoEstoque
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestaoEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";

            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlCampos);
            this.Controls.Add(this.pnlTopo);


            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlCampos.ResumeLayout(false);
            this.pnlCampos.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
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
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.TextBox txbUnidade;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.DataGridView dgvEstoque;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
    }
}