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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoComandas));

            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.DgvComandas = new System.Windows.Forms.DataGridView();
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.LblClientes = new System.Windows.Forms.Label();
            this.ChbAdicionais = new System.Windows.Forms.CheckBox();
            this.ChbBordas = new System.Windows.Forms.CheckBox();
            this.txbClientes = new System.Windows.Forms.TextBox();
            this.ChbBebidas = new System.Windows.Forms.CheckBox();
            this.ChbPizzas = new System.Windows.Forms.CheckBox();
            this.cmbAdicionais = new System.Windows.Forms.ComboBox();
            this.txbObservecao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.cmbPizzas = new System.Windows.Forms.ComboBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.cmbBordas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();

            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.pnlEsquerda = new System.Windows.Forms.Panel();
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.pnlGridBot = new System.Windows.Forms.Panel();
            this.lblSecComandas = new System.Windows.Forms.Label();
            this.lblSecProdutos = new System.Windows.Forms.Label();

            // Barra de titulo customizada
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).BeginInit();
            this.grbPedidos.SuspendLayout();
            this.pnlTopo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.pnlEsquerda.SuspendLayout();
            this.pnlDireita.SuspendLayout();
            this.pnlGridTop.SuspendLayout();
            this.pnlGridBot.SuspendLayout();
            this.SuspendLayout();

            // Paleta
            System.Drawing.Color corFundo = System.Drawing.Color.FromArgb(10, 14, 30);
            System.Drawing.Color corPainel = System.Drawing.Color.FromArgb(17, 24, 46);
            System.Drawing.Color corCampo = System.Drawing.Color.FromArgb(25, 34, 62);
            System.Drawing.Color corBorda = System.Drawing.Color.FromArgb(42, 55, 95);
            System.Drawing.Color corBranco = System.Drawing.Color.FromArgb(215, 220, 238);
            System.Drawing.Color corSub = System.Drawing.Color.FromArgb(100, 118, 160);
            System.Drawing.Color corAcento = System.Drawing.Color.FromArgb(204, 64, 44);

            System.Drawing.Font fTitulo = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fSec = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 9.5F);
            System.Drawing.Font fChk = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fBotao = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fGrid = new System.Drawing.Font("Segoe UI", 9F);

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
            this.lblTitulo.Text = "Gestão de Comandas";
            this.lblTitulo.Location = new System.Drawing.Point(20, 13);
            this.lblTitulo.Name = "lblTitulo";

            // Linha de acento sob o titulo
            System.Windows.Forms.Panel pnlAcento = new System.Windows.Forms.Panel();
            pnlAcento.BackColor = corAcento;
            pnlAcento.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlAcento.Height = 2;
            this.pnlTopo.Controls.Add(pnlAcento);

            // label1 oculto
            this.label1.Visible = false;
            this.label1.Name = "label1";
            this.label1.Text = "Comandas";

            // ── pnlBotoes (rodapé)
            this.pnlBotoes.BackColor = corPainel;
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotoes.Height = 68;
            this.pnlBotoes.Name = "pnlBotoes";

            // Linha de separacao no topo do rodapé
            System.Windows.Forms.Panel pnlSepBotoes = new System.Windows.Forms.Panel();
            pnlSepBotoes.BackColor = corBorda;
            pnlSepBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSepBotoes.Height = 1;
            this.pnlBotoes.Controls.Add(pnlSepBotoes);

            this.btnCadastrar.BackColor = corAcento;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 80, 58);
            this.btnCadastrar.Font = fBotao;
            this.btnCadastrar.ForeColor = corBranco;
            this.btnCadastrar.Location = new System.Drawing.Point(20, 14);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(160, 40);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);

            this.btnLimpar.BackColor = corCampo;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderColor = corBorda;
            this.btnLimpar.FlatAppearance.BorderSize = 1;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 50, 85);
            this.btnLimpar.Font = fBotao;
            this.btnLimpar.ForeColor = corSub;
            this.btnLimpar.Location = new System.Drawing.Point(192, 14);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(148, 40);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);

            this.btnVoltar.BackColor = corCampo;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderColor = corBorda;
            this.btnVoltar.FlatAppearance.BorderSize = 1;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(38, 50, 85);
            this.btnVoltar.Font = fBotao;
            this.btnVoltar.ForeColor = corSub;
            this.btnVoltar.Location = new System.Drawing.Point(352, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(148, 40);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "← Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            this.pnlBotoes.Controls.Add(this.btnCadastrar);
            this.pnlBotoes.Controls.Add(this.btnLimpar);
            this.pnlBotoes.Controls.Add(this.btnVoltar);

            // ── pnlEsquerda
            this.pnlEsquerda.BackColor = corPainel;
            this.pnlEsquerda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEsquerda.Width = 320;
            this.pnlEsquerda.Name = "pnlEsquerda";
            this.pnlEsquerda.Padding = new System.Windows.Forms.Padding(0);

            // Separador direito do painel esquerdo
            System.Windows.Forms.Panel pnlSepEsq = new System.Windows.Forms.Panel();
            pnlSepEsq.BackColor = corBorda;
            pnlSepEsq.Dock = System.Windows.Forms.DockStyle.Right;
            pnlSepEsq.Width = 1;
            this.pnlEsquerda.Controls.Add(pnlSepEsq);

            this.grbPedidos.BackColor = System.Drawing.Color.Transparent;
            this.grbPedidos.ForeColor = System.Drawing.Color.FromArgb(17, 24, 46);
            this.grbPedidos.Font = fLabel;
            this.grbPedidos.Location = new System.Drawing.Point(16, 10);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Size = new System.Drawing.Size(288, 530);
            this.grbPedidos.TabIndex = 21;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "Novo Pedido";

            this.ChbPizzas.AutoSize = true;
            this.ChbPizzas.Font = fChk;
            this.ChbPizzas.ForeColor = corBranco;
            this.ChbPizzas.Location = new System.Drawing.Point(10, 24);
            this.ChbPizzas.Name = "ChbPizzas";
            this.ChbPizzas.TabIndex = 17;
            this.ChbPizzas.Text = "Pizzas";
            this.ChbPizzas.UseVisualStyleBackColor = false;
            this.ChbPizzas.BackColor = System.Drawing.Color.Transparent;
            this.ChbPizzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbPizzas.CheckedChanged += new System.EventHandler(this.ChbPizzas_CheckedChanged);

            this.cmbPizzas.BackColor = corCampo;
            this.cmbPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzas.Enabled = false;
            this.cmbPizzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPizzas.Font = fCampo;
            this.cmbPizzas.ForeColor = corBranco;
            this.cmbPizzas.FormattingEnabled = true;
            this.cmbPizzas.Location = new System.Drawing.Point(10, 48);
            this.cmbPizzas.Name = "cmbPizzas";
            this.cmbPizzas.Size = new System.Drawing.Size(265, 26);
            this.cmbPizzas.TabIndex = 2;
            this.cmbPizzas.SelectedIndexChanged += new System.EventHandler(this.cmbPizzas_SelectedIndexChanged);

            this.ChbAdicionais.AutoSize = true;
            this.ChbAdicionais.Enabled = false;
            this.ChbAdicionais.Font = fChk;
            this.ChbAdicionais.ForeColor = corSub;
            this.ChbAdicionais.Location = new System.Drawing.Point(10, 88);
            this.ChbAdicionais.Name = "ChbAdicionais";
            this.ChbAdicionais.TabIndex = 21;
            this.ChbAdicionais.Text = "Adicionais";
            this.ChbAdicionais.UseVisualStyleBackColor = false;
            this.ChbAdicionais.BackColor = System.Drawing.Color.Transparent;
            this.ChbAdicionais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbAdicionais.CheckedChanged += new System.EventHandler(this.ChbAdicionais_CheckedChanged);

            this.cmbAdicionais.BackColor = corCampo;
            this.cmbAdicionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdicionais.Enabled = false;
            this.cmbAdicionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdicionais.Font = fCampo;
            this.cmbAdicionais.ForeColor = corBranco;
            this.cmbAdicionais.FormattingEnabled = true;
            this.cmbAdicionais.Location = new System.Drawing.Point(10, 112);
            this.cmbAdicionais.Name = "cmbAdicionais";
            this.cmbAdicionais.Size = new System.Drawing.Size(265, 26);
            this.cmbAdicionais.TabIndex = 15;

            this.ChbBebidas.AutoSize = true;
            this.ChbBebidas.Font = fChk;
            this.ChbBebidas.ForeColor = corBranco;
            this.ChbBebidas.Location = new System.Drawing.Point(10, 152);
            this.ChbBebidas.Name = "ChbBebidas";
            this.ChbBebidas.TabIndex = 18;
            this.ChbBebidas.Text = "Bebidas";
            this.ChbBebidas.UseVisualStyleBackColor = false;
            this.ChbBebidas.BackColor = System.Drawing.Color.Transparent;
            this.ChbBebidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbBebidas.CheckedChanged += new System.EventHandler(this.ChbBebidas_CheckedChanged);

            this.cmbBebidas.BackColor = corCampo;
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.Enabled = false;
            this.cmbBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBebidas.Font = fCampo;
            this.cmbBebidas.ForeColor = corBranco;
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(10, 176);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(265, 26);
            this.cmbBebidas.TabIndex = 4;

            this.ChbBordas.AutoSize = true;
            this.ChbBordas.Enabled = false;
            this.ChbBordas.Font = fChk;
            this.ChbBordas.ForeColor = corSub;
            this.ChbBordas.Location = new System.Drawing.Point(10, 216);
            this.ChbBordas.Name = "ChbBordas";
            this.ChbBordas.TabIndex = 20;
            this.ChbBordas.Text = "Bordas";
            this.ChbBordas.UseVisualStyleBackColor = false;
            this.ChbBordas.BackColor = System.Drawing.Color.Transparent;
            this.ChbBordas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChbBordas.CheckedChanged += new System.EventHandler(this.ChbBordas_CheckedChanged);

            this.cmbBordas.BackColor = corCampo;
            this.cmbBordas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBordas.Enabled = false;
            this.cmbBordas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBordas.Font = fCampo;
            this.cmbBordas.ForeColor = corBranco;
            this.cmbBordas.FormattingEnabled = true;
            this.cmbBordas.Location = new System.Drawing.Point(10, 240);
            this.cmbBordas.Name = "cmbBordas";
            this.cmbBordas.Size = new System.Drawing.Size(265, 26);
            this.cmbBordas.TabIndex = 14;

            this.label2.AutoSize = true;
            this.label2.Font = fLabel;
            this.label2.ForeColor = corSub;
            this.label2.Location = new System.Drawing.Point(10, 282);
            this.label2.Name = "label2";
            this.label2.Text = "Nº DA MESA";

            this.txbMesa.BackColor = corCampo;
            this.txbMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbMesa.Font = fCampo;
            this.txbMesa.ForeColor = corBranco;
            this.txbMesa.Location = new System.Drawing.Point(10, 300);
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(265, 26);
            this.txbMesa.TabIndex = 9;
            this.txbMesa.TextChanged += new System.EventHandler(this.txbMesa_TextChanged);
            this.txbMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMesa_KeyPress);

            this.LblClientes.AutoSize = true;
            this.LblClientes.Font = fLabel;
            this.LblClientes.ForeColor = corSub;
            this.LblClientes.Location = new System.Drawing.Point(10, 342);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Text = "CLIENTE";

            this.txbClientes.BackColor = corCampo;
            this.txbClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbClientes.Font = fCampo;
            this.txbClientes.ForeColor = corBranco;
            this.txbClientes.Location = new System.Drawing.Point(10, 360);
            this.txbClientes.Name = "txbClientes";
            this.txbClientes.Size = new System.Drawing.Size(265, 26);
            this.txbClientes.TabIndex = 22;
            this.txbClientes.TextChanged += new System.EventHandler(this.txbClientes_TextChanged);
            this.txbClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClientes_KeyPress);

            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = fLabel;
            this.lblObservacao.ForeColor = corSub;
            this.lblObservacao.Location = new System.Drawing.Point(10, 402);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Text = "OBSERVAÇÕES";

            this.txbObservecao.BackColor = corCampo;
            this.txbObservecao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbObservecao.Enabled = false;
            this.txbObservecao.Font = fCampo;
            this.txbObservecao.ForeColor = corBranco;
            this.txbObservecao.Location = new System.Drawing.Point(10, 420);
            this.txbObservecao.Multiline = true;
            this.txbObservecao.Name = "txbObservecao";
            this.txbObservecao.Size = new System.Drawing.Size(265, 64);
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

            this.pnlEsquerda.Controls.Add(this.grbPedidos);

            // ── pnlDireita
            this.pnlDireita.BackColor = corFundo;
            this.pnlDireita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Padding = new System.Windows.Forms.Padding(16, 10, 16, 10);

            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Height = 0;
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.BackColor = corFundo;
            this.pnlGridTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);

            this.lblSecComandas.AutoSize = true;
            this.lblSecComandas.Font = fSec;
            this.lblSecComandas.ForeColor = corSub;
            this.lblSecComandas.Location = new System.Drawing.Point(0, 0);
            this.lblSecComandas.Name = "lblSecComandas";
            this.lblSecComandas.Text = "COMANDAS ABERTAS";

            this.DgvComandas.AllowUserToAddRows = false;
            this.DgvComandas.AllowUserToDeleteRows = false;
            this.DgvComandas.AllowUserToResizeColumns = false;
            this.DgvComandas.AllowUserToResizeRows = false;
            this.DgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComandas.BackgroundColor = corCampo;
            this.DgvComandas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvComandas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvComandas.GridColor = System.Drawing.Color.FromArgb(30, 40, 68);
            this.DgvComandas.ColumnHeadersHeight = 36;
            this.DgvComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvComandas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvComandas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvComandas.EnableHeadersVisualStyles = false;
            this.DgvComandas.Font = fGrid;
            this.DgvComandas.Name = "DgvComandas";
            this.DgvComandas.ReadOnly = true;
            this.DgvComandas.RowHeadersVisible = false;
            this.DgvComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvComandas.TabIndex = 22;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(14, 20, 42);
            this.DgvComandas.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.DgvComandas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(14, 20, 42);
            this.DgvComandas.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvComandas.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DgvComandas.DefaultCellStyle.BackColor = corCampo;
            this.DgvComandas.DefaultCellStyle.ForeColor = corBranco;
            this.DgvComandas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 204, 64, 44);
            this.DgvComandas.DefaultCellStyle.SelectionForeColor = corBranco;
            this.DgvComandas.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.DgvComandas.RowTemplate.Height = 40;
            this.DgvComandas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 26, 50);
            this.DgvComandas.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;
            this.DgvComandas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellClick);
            this.DgvComandas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellDoubleClick);

            this.pnlGridTop.Controls.Add(this.DgvComandas);
            this.pnlGridTop.Controls.Add(this.lblSecComandas);

            this.pnlGridBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridBot.Name = "pnlGridBot";
            this.pnlGridBot.BackColor = corFundo;
            this.pnlGridBot.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);

            this.lblSecProdutos.AutoSize = true;
            this.lblSecProdutos.Font = fSec;
            this.lblSecProdutos.ForeColor = corSub;
            this.lblSecProdutos.Location = new System.Drawing.Point(0, 8);
            this.lblSecProdutos.Name = "lblSecProdutos";
            this.lblSecProdutos.Text = "ITENS DA COMANDA";

            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToResizeColumns = false;
            this.DgvProdutos.AllowUserToResizeRows = false;
            this.DgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProdutos.BackgroundColor = corCampo;
            this.DgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProdutos.GridColor = System.Drawing.Color.FromArgb(30, 40, 68);
            this.DgvProdutos.ColumnHeadersHeight = 36;
            this.DgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProdutos.EnableHeadersVisualStyles = false;
            this.DgvProdutos.Font = fGrid;
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.ReadOnly = true;
            this.DgvProdutos.RowHeadersVisible = false;
            this.DgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProdutos.TabIndex = 23;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(14, 20, 42);
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.ForeColor = corSub;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(14, 20, 42);
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.SelectionForeColor = corSub;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DgvProdutos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DgvProdutos.DefaultCellStyle.BackColor = corCampo;
            this.DgvProdutos.DefaultCellStyle.ForeColor = corBranco;
            this.DgvProdutos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 204, 64, 44);
            this.DgvProdutos.DefaultCellStyle.SelectionForeColor = corBranco;
            this.DgvProdutos.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 6, 0, 6);
            this.DgvProdutos.RowTemplate.Height = 40;
            this.DgvProdutos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(18, 26, 50);
            this.DgvProdutos.AlternatingRowsDefaultCellStyle.ForeColor = corBranco;
            this.DgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellDoubleClick);

            this.pnlGridBot.Controls.Add(this.DgvProdutos);
            this.pnlGridBot.Controls.Add(this.lblSecProdutos);

            this.pnlDireita.Controls.Add(this.pnlGridBot);
            this.pnlDireita.Controls.Add(this.pnlGridTop);

            this.pnlDireita.Resize += (s, e2) => {
                int metade = this.pnlDireita.ClientSize.Height / 2;
                this.pnlGridTop.Height = metade;
            };

            // ── Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = corFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestaoComandas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comandas";
            this.Load += new System.EventHandler(this.FrmGestaoComandas_Load);

            this.Controls.Add(this.pnlDireita);
            this.Controls.Add(this.pnlEsquerda);
            this.Controls.Add(this.pnlBotoes);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.label1);

            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlEsquerda.ResumeLayout(false);
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
            this.pnlDireita.ResumeLayout(false);
            this.pnlGridTop.ResumeLayout(false);
            this.pnlGridTop.PerformLayout();
            this.pnlGridBot.ResumeLayout(false);
            this.pnlGridBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProdutos;
        private System.Windows.Forms.DataGridView DgvComandas;
        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.Label LblClientes;
        private System.Windows.Forms.TextBox txbClientes;
        private System.Windows.Forms.CheckBox ChbAdicionais;
        private System.Windows.Forms.CheckBox ChbBordas;
        private System.Windows.Forms.CheckBox ChbBebidas;
        private System.Windows.Forms.CheckBox ChbPizzas;
        private System.Windows.Forms.ComboBox cmbAdicionais;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbBordas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbPizzas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.TextBox txbObservecao;
        private System.Windows.Forms.TextBox txbMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.Panel pnlEsquerda;
        private System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Panel pnlGridTop;
        private System.Windows.Forms.Panel pnlGridBot;
        private System.Windows.Forms.Label lblSecComandas;
        private System.Windows.Forms.Label lblSecProdutos;
    }
}