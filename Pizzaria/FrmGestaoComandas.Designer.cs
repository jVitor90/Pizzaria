namespace Pizzaria
{
    partial class FrmGestaoComandas
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
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.pnlGridBot = new System.Windows.Forms.Panel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlTopo = new System.Windows.Forms.Panel(); // alias oculto

            // grids
            this.DgvComandas = new System.Windows.Forms.DataGridView();
            this.DgvProdutos = new System.Windows.Forms.DataGridView();

            // painel esquerdo — campos do pedido
            this.grbPedidos = new System.Windows.Forms.Panel();
            this.ChbPizzas = new System.Windows.Forms.CheckBox();
            this.cmbPizzas = new System.Windows.Forms.ComboBox();
            this.ChbAdicionais = new System.Windows.Forms.CheckBox();
            this.cmbAdicionais = new System.Windows.Forms.ComboBox();
            this.ChbBebidas = new System.Windows.Forms.CheckBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.ChbBordas = new System.Windows.Forms.CheckBox();
            this.cmbBordas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.LblClientes = new System.Windows.Forms.Label();
            this.txbClientes = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txbObservecao = new System.Windows.Forms.TextBox();

            // labels de seção
            this.lblSecComandas = new System.Windows.Forms.Label();
            this.lblSecProdutos = new System.Windows.Forms.Label();

            // botões rodapé
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            // label1 oculto (compatibilidade)
            this.label1 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
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
            System.Drawing.Font fChk = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Drawing.Font fBtn = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBtnSm = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fGrid = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font fSec = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);

            // ── header ────────────────────────────────────────────────
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = fHeader;
            this.lblTitulo.ForeColor = cBranco;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Gestão de Comandas";
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

            // ── rodapé (pnlBotoes) ─────────────────────────────────────
            this.pnlBotoes.BackColor = cCard;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Height = 68;
            this.pnlBotoes.Name = "pnlBotoes";

            this.btnCadastrar.BackColor = cAccent;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnCadastrar.Font = fBtn;
            this.btnCadastrar.ForeColor = cBranco;
            this.btnCadastrar.Location = new System.Drawing.Point(20, 14);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 40);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            this.btnLimpar.BackColor = cCampo;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderColor = cBorder;
            this.btnLimpar.FlatAppearance.BorderSize = 1;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.btnLimpar.Font = fBtnSm;
            this.btnLimpar.ForeColor = cSub;
            this.btnLimpar.Location = new System.Drawing.Point(192, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 40);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            this.btnVoltar.BackColor = cCampo;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderColor = cBorder;
            this.btnVoltar.FlatAppearance.BorderSize = 1;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.btnVoltar.Font = fBtnSm;
            this.btnVoltar.ForeColor = cSub;
            this.btnVoltar.Location = new System.Drawing.Point(352, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 40);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "\u21A9  Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);

            // ════════════════════════════════════════════════════════════
            // PAINEL ESQUERDO — formulário do pedido
            // ════════════════════════════════════════════════════════════

            // pnlPedidos: painel simples, sem borda nativa
            this.grbPedidos.BackColor = System.Drawing.Color.FromArgb(18, 18, 18);
            this.grbPedidos.Location = new System.Drawing.Point(12, 8);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Size = new System.Drawing.Size(292, 560);
            this.grbPedidos.TabStop = false;

            // Pizzas
            this.ChbPizzas.AutoSize = true;
            this.ChbPizzas.BackColor = System.Drawing.Color.Transparent;
            this.ChbPizzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbPizzas.Font = fChk;
            this.ChbPizzas.ForeColor = cBranco;
            this.ChbPizzas.Location = new System.Drawing.Point(10, 18);
            this.ChbPizzas.Name = "ChbPizzas";
            this.ChbPizzas.Text = "Pizzas";
            this.ChbPizzas.UseVisualStyleBackColor = false;
            this.ChbPizzas.CheckedChanged += new System.EventHandler(this.ChbPizzas_CheckedChanged);

            this.cmbPizzas.BackColor = cCampo;
            this.cmbPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzas.Enabled = false;
            this.cmbPizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPizzas.Font = fCampo;
            this.cmbPizzas.ForeColor = cBranco;
            this.cmbPizzas.Location = new System.Drawing.Point(10, 42);
            this.cmbPizzas.Name = "cmbPizzas";
            this.cmbPizzas.Size = new System.Drawing.Size(268, 26);
            this.cmbPizzas.TabIndex = 2;
            this.cmbPizzas.SelectedIndexChanged += new System.EventHandler(this.cmbPizzas_SelectedIndexChanged);

            // Adicionais
            this.ChbAdicionais.AutoSize = true;
            this.ChbAdicionais.BackColor = System.Drawing.Color.Transparent;
            this.ChbAdicionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbAdicionais.Enabled = false;
            this.ChbAdicionais.Font = fChk;
            this.ChbAdicionais.ForeColor = cSub;
            this.ChbAdicionais.Location = new System.Drawing.Point(10, 82);
            this.ChbAdicionais.Name = "ChbAdicionais";
            this.ChbAdicionais.Text = "Adicionais";
            this.ChbAdicionais.UseVisualStyleBackColor = false;
            this.ChbAdicionais.CheckedChanged += new System.EventHandler(this.ChbAdicionais_CheckedChanged);

            this.cmbAdicionais.BackColor = cCampo;
            this.cmbAdicionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdicionais.Enabled = false;
            this.cmbAdicionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdicionais.Font = fCampo;
            this.cmbAdicionais.ForeColor = cBranco;
            this.cmbAdicionais.Location = new System.Drawing.Point(10, 106);
            this.cmbAdicionais.Name = "cmbAdicionais";
            this.cmbAdicionais.Size = new System.Drawing.Size(268, 26);
            this.cmbAdicionais.TabIndex = 15;

            // Bebidas
            this.ChbBebidas.AutoSize = true;
            this.ChbBebidas.BackColor = System.Drawing.Color.Transparent;
            this.ChbBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbBebidas.Font = fChk;
            this.ChbBebidas.ForeColor = cBranco;
            this.ChbBebidas.Location = new System.Drawing.Point(10, 146);
            this.ChbBebidas.Name = "ChbBebidas";
            this.ChbBebidas.Text = "Bebidas";
            this.ChbBebidas.UseVisualStyleBackColor = false;
            this.ChbBebidas.CheckedChanged += new System.EventHandler(this.ChbBebidas_CheckedChanged);

            this.cmbBebidas.BackColor = cCampo;
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.Enabled = false;
            this.cmbBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBebidas.Font = fCampo;
            this.cmbBebidas.ForeColor = cBranco;
            this.cmbBebidas.Location = new System.Drawing.Point(10, 170);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(268, 26);
            this.cmbBebidas.TabIndex = 4;

            // Bordas
            this.ChbBordas.AutoSize = true;
            this.ChbBordas.BackColor = System.Drawing.Color.Transparent;
            this.ChbBordas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbBordas.Enabled = false;
            this.ChbBordas.Font = fChk;
            this.ChbBordas.ForeColor = cSub;
            this.ChbBordas.Location = new System.Drawing.Point(10, 210);
            this.ChbBordas.Name = "ChbBordas";
            this.ChbBordas.Text = "Bordas";
            this.ChbBordas.UseVisualStyleBackColor = false;
            this.ChbBordas.CheckedChanged += new System.EventHandler(this.ChbBordas_CheckedChanged);

            this.cmbBordas.BackColor = cCampo;
            this.cmbBordas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBordas.Enabled = false;
            this.cmbBordas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBordas.Font = fCampo;
            this.cmbBordas.ForeColor = cBranco;
            this.cmbBordas.Location = new System.Drawing.Point(10, 234);
            this.cmbBordas.Name = "cmbBordas";
            this.cmbBordas.Size = new System.Drawing.Size(268, 26);
            this.cmbBordas.TabIndex = 14;

            // Mesa
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = fLabel;
            this.label2.ForeColor = cSub;
            this.label2.Location = new System.Drawing.Point(10, 276);
            this.label2.Name = "label2";
            this.label2.Text = "Nº DA MESA";

            this.txbMesa.BackColor = cCampo;
            this.txbMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMesa.Font = fCampo;
            this.txbMesa.ForeColor = cBranco;
            this.txbMesa.Location = new System.Drawing.Point(10, 294);
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(268, 26);
            this.txbMesa.TabIndex = 9;
            this.txbMesa.TextChanged += new System.EventHandler(this.txbMesa_TextChanged);
            this.txbMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMesa_KeyPress);

            // Cliente
            this.LblClientes.AutoSize = true;
            this.LblClientes.BackColor = System.Drawing.Color.Transparent;
            this.LblClientes.Font = fLabel;
            this.LblClientes.ForeColor = cSub;
            this.LblClientes.Location = new System.Drawing.Point(10, 336);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Text = "CLIENTE";

            this.txbClientes.BackColor = cCampo;
            this.txbClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbClientes.Font = fCampo;
            this.txbClientes.ForeColor = cBranco;
            this.txbClientes.Location = new System.Drawing.Point(10, 354);
            this.txbClientes.Name = "txbClientes";
            this.txbClientes.Size = new System.Drawing.Size(268, 26);
            this.txbClientes.TabIndex = 22;
            this.txbClientes.TextChanged += new System.EventHandler(this.txbClientes_TextChanged);
            this.txbClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClientes_KeyPress);

            // Observações
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.BackColor = System.Drawing.Color.Transparent;
            this.lblObservacao.Font = fLabel;
            this.lblObservacao.ForeColor = cSub;
            this.lblObservacao.Location = new System.Drawing.Point(10, 396);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Text = "OBSERVAÇÕES";

            this.txbObservecao.BackColor = cCampo;
            this.txbObservecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbObservecao.Enabled = false;
            this.txbObservecao.Font = fCampo;
            this.txbObservecao.ForeColor = cBranco;
            this.txbObservecao.Location = new System.Drawing.Point(10, 414);
            this.txbObservecao.Multiline = true;
            this.txbObservecao.Name = "txbObservecao";
            this.txbObservecao.Size = new System.Drawing.Size(268, 64);
            this.txbObservecao.TabIndex = 3;

            this.grbPedidos.Controls.Add(this.ChbPizzas);
            this.grbPedidos.Controls.Add(this.cmbPizzas);
            this.grbPedidos.Controls.Add(this.ChbAdicionais);
            this.grbPedidos.Controls.Add(this.cmbAdicionais);
            this.grbPedidos.Controls.Add(this.ChbBebidas);
            this.grbPedidos.Controls.Add(this.cmbBebidas);
            this.grbPedidos.Controls.Add(this.ChbBordas);
            this.grbPedidos.Controls.Add(this.cmbBordas);
            this.grbPedidos.Controls.Add(this.label2);
            this.grbPedidos.Controls.Add(this.txbMesa);
            this.grbPedidos.Controls.Add(this.LblClientes);
            this.grbPedidos.Controls.Add(this.txbClientes);
            this.grbPedidos.Controls.Add(this.lblObservacao);
            this.grbPedidos.Controls.Add(this.txbObservecao);

            this.pnlEsquerda.BackColor = cCard;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Width = 320;
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Controls.Add(this.grbPedidos);

            // separador direito do painel esquerdo
            System.Windows.Forms.Panel pnlSepEsq = new System.Windows.Forms.Panel();
            pnlSepEsq.BackColor = cBorder;
            pnlSepEsq.Dock = System.Windows.Forms.DockStyle.Right;
            pnlSepEsq.Width = 1;
            this.pnlEsquerda.Controls.Add(pnlSepEsq);

            // ════════════════════════════════════════════════════════════
            // PAINEL DIREITO — grids de comandas e itens
            // ════════════════════════════════════════════════════════════

            // DgvComandas
            this.DgvComandas.AllowUserToAddRows = false;
            this.DgvComandas.AllowUserToDeleteRows = false;
            this.DgvComandas.AllowUserToResizeColumns = false;
            this.DgvComandas.AllowUserToResizeRows = false;
            this.DgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComandas.BackgroundColor = cCampo;
            this.DgvComandas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvComandas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvComandas.ColumnHeadersHeight = 36;
            this.DgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvComandas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvComandas.EnableHeadersVisualStyles = false;
            this.DgvComandas.Font = fGrid;
            this.DgvComandas.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.DgvComandas.Name = "DgvComandas";
            this.DgvComandas.ReadOnly = true;
            this.DgvComandas.RowHeadersVisible = false;
            this.DgvComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvComandas.TabIndex = 22;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.BackColor = cHeader;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.ForeColor = cSub;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.DgvComandas.ColumnHeadersDefaultCellStyle.SelectionBackColor = cHeader;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.SelectionForeColor = cSub;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DgvComandas.DefaultCellStyle.BackColor = cCampo;
            this.DgvComandas.DefaultCellStyle.ForeColor = cBranco;
            this.DgvComandas.DefaultCellStyle.SelectionBackColor = cAccent;
            this.DgvComandas.DefaultCellStyle.SelectionForeColor = cBranco;
            this.DgvComandas.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.DgvComandas.RowTemplate.Height = 42;
            this.DgvComandas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.DgvComandas.AlternatingRowsDefaultCellStyle.ForeColor = cBranco;
            this.DgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellClick);
            this.DgvComandas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellDoubleClick);

            this.lblSecComandas.AutoSize = true;
            this.lblSecComandas.BackColor = System.Drawing.Color.Transparent;
            this.lblSecComandas.Font = fSec;
            this.lblSecComandas.ForeColor = cSub;
            this.lblSecComandas.Location = new System.Drawing.Point(0, 0);
            this.lblSecComandas.Name = "lblSecComandas";
            this.lblSecComandas.Text = "COMANDAS ABERTAS";

            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Height = 0; // ajustado pelo Resize
            this.pnlGridTop.BackColor = cFundo;
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnlGridTop.Controls.Add(this.DgvComandas);
            this.pnlGridTop.Controls.Add(this.lblSecComandas);

            // DgvProdutos
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToResizeColumns = false;
            this.DgvProdutos.AllowUserToResizeRows = false;
            this.DgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProdutos.BackgroundColor = cCampo;
            this.DgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvProdutos.ColumnHeadersHeight = 36;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProdutos.EnableHeadersVisualStyles = false;
            this.DgvProdutos.Font = fGrid;
            this.DgvProdutos.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.RowHeadersVisible = false;
            this.DgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProdutos.TabIndex = 23;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = cHeader;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = cSub;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.SelectionBackColor = cHeader;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.SelectionForeColor = cSub;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DgvProdutos.DefaultCellStyle.BackColor = cCampo;
            this.DgvProdutos.DefaultCellStyle.ForeColor = cBranco;
            this.DgvProdutos.DefaultCellStyle.SelectionBackColor = cAccent;
            this.DgvProdutos.DefaultCellStyle.SelectionForeColor = cBranco;
            this.DgvProdutos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.DgvProdutos.RowTemplate.Height = 40;
            this.DgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.DgvProdutos.AlternatingRowsDefaultCellStyle.ForeColor = cBranco;
            this.DgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellDoubleClick);

            this.lblSecProdutos.AutoSize = true;
            this.lblSecProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblSecProdutos.Font = fSec;
            this.lblSecProdutos.ForeColor = cSub;
            this.lblSecProdutos.Location = new System.Drawing.Point(0, 8);
            this.lblSecProdutos.Name = "lblSecProdutos";
            this.lblSecProdutos.Text = "ITENS DA COMANDA";

            this.pnlGridBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridBot.BackColor = cFundo;
            this.pnlGridBot.Name = "pnlGridBot";
            this.pnlGridBot.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlGridBot.Controls.Add(this.DgvProdutos);
            this.pnlGridBot.Controls.Add(this.lblSecProdutos);

            this.pnlDireita.BackColor = cFundo;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);
            this.pnlDireita.Controls.Add(this.pnlGridBot);  // Fill
            this.pnlDireita.Controls.Add(this.pnlGridTop);  // Top

            this.pnlDireita.Resize += (s, e2) => {
                int metade = this.pnlDireita.ClientSize.Height / 2;
                this.pnlGridTop.Height = metade;
            };

            // pnlBody agrupa esquerda + direita
            this.pnlBody.BackColor = cFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Controls.Add(this.pnlDireita);   // Fill
            this.pnlBody.Controls.Add(this.pnlEsquerda);  // Left

            // label1 oculto (compatibilidade)
            this.label1.Visible = false;
            this.label1.Name = "label1";
            this.label1.Text = "Comandas";
            this.label1.Location = new System.Drawing.Point(-500, -500);

            // pnlTopo alias oculto
            this.pnlTopo.Location = new System.Drawing.Point(-500, -501);
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
            this.Name = "FrmGestaoComandas";
            this.Text = "Comandas";
            this.Load += new System.EventHandler(this.FrmGestaoComandas_Load);

            // Ordem: Fill → Bottom → Top(line) → Top(header)
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTopo);

            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlGridTop;
        private System.Windows.Forms.Panel pnlGridBot;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Panel pnlTopo;        // alias oculto
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSecComandas;
        private System.Windows.Forms.Label lblSecProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.DataGridView DgvComandas;
        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.Panel grbPedidos;
        private System.Windows.Forms.CheckBox ChbPizzas;
        private System.Windows.Forms.CheckBox ChbAdicionais;
        private System.Windows.Forms.CheckBox ChbBebidas;
        private System.Windows.Forms.CheckBox ChbBordas;
        private System.Windows.Forms.ComboBox cmbPizzas;
        private System.Windows.Forms.ComboBox cmbAdicionais;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.ComboBox cmbBordas;
        private System.Windows.Forms.TextBox txbMesa;
        private System.Windows.Forms.TextBox txbClientes;
        private System.Windows.Forms.TextBox txbObservecao;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnVoltar;
    }
}