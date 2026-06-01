namespace Pizzaria
{
    partial class FrmGerenciarUsuarios
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

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblDica = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            this.lblTitulo.Text = "Gerenciar Funcionários";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);

            // ── btnAdicionarUsuario ────────────────────────────────────
            this.btnAdicionarUsuario.BackColor = cAccent;
            this.btnAdicionarUsuario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdicionarUsuario.Width = 200;
            this.btnAdicionarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarUsuario.FlatAppearance.BorderSize = 0;
            this.btnAdicionarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnAdicionarUsuario.Font = fBtnSm;
            this.btnAdicionarUsuario.ForeColor = cBranco;
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Text = "+  Adicionar Usuário";
            this.btnAdicionarUsuario.UseVisualStyleBackColor = false;
            this.btnAdicionarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);

            // ── pnlHeader ─────────────────────────────────────────────
            this.pnlHeader.BackColor = cHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.btnAdicionarUsuario); // Right primeiro
            this.pnlHeader.Controls.Add(this.lblTitulo);           // Fill depois

            // ── pnlHeaderLine ──────────────────────────────────────────
            this.pnlHeaderLine.BackColor = cAccent;
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Height = 2;
            this.pnlHeaderLine.Name = "pnlHeaderLine";
            this.pnlHeaderLine.TabIndex = 1;

            // ── dgvUsuarios ────────────────────────────────────────────
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = cCampo;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuarios.ColumnHeadersHeight = 40;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Font = fCampo;
            this.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(28, 28, 26);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.TabIndex = 0;

            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = cHeader;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = cSub;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = cHeader;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionForeColor = cSub;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);

            this.dgvUsuarios.DefaultCellStyle.BackColor = cCampo;
            this.dgvUsuarios.DefaultCellStyle.ForeColor = cBranco;
            this.dgvUsuarios.DefaultCellStyle.SelectionBackColor = cAccent;
            this.dgvUsuarios.DefaultCellStyle.SelectionForeColor = cBranco;
            this.dgvUsuarios.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.dgvUsuarios.RowTemplate.Height = 48;

            this.dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle.ForeColor = cBranco;

            this.dgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellClick);

            // ── pnlGrid ────────────────────────────────────────────────
            this.pnlGrid.BackColor = cFundo;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.TabIndex = 0;
            this.pnlGrid.Controls.Add(this.dgvUsuarios);

            // ── sidebar: label dica ────────────────────────────────────
            this.lblDica.AutoSize = false;
            this.lblDica.BackColor = System.Drawing.Color.Transparent;
            this.lblDica.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDica.ForeColor = cSub;
            this.lblDica.Location = new System.Drawing.Point(24, 24);
            this.lblDica.Size = new System.Drawing.Size(272, 28);
            this.lblDica.Name = "lblDica";
            this.lblDica.Text = "Selecione um funcionário na lista para editar.";

            // ── NOME ───────────────────────────────────────────────────
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = fLabel;
            this.lblNome.ForeColor = cSub;
            this.lblNome.Location = new System.Drawing.Point(24, 68);
            this.lblNome.Name = "lblNome";
            this.lblNome.Text = "NOME";

            this.txbNome.BackColor = cCampo;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = fCampo;
            this.txbNome.ForeColor = cBranco;
            this.txbNome.Location = new System.Drawing.Point(24, 88);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(272, 36);
            this.txbNome.TabIndex = 0;
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNome_KeyPress);

            // ── CPF — MaskedTextBox, sem seleção automática ────────────
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = fLabel;
            this.lblCpf.ForeColor = cSub;
            this.lblCpf.Location = new System.Drawing.Point(24, 144);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Text = "CPF";

            this.txbCpf.BackColor = cCampo;
            this.txbCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCpf.Font = fCampo;
            this.txbCpf.ForeColor = cBranco;
            this.txbCpf.Location = new System.Drawing.Point(24, 164);
            this.txbCpf.MaxLength = 14;
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(272, 36);
            this.txbCpf.TabIndex = 1;
            this.txbCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCpf_KeyPress);
            this.txbCpf.TextChanged += new System.EventHandler(this.TxbCpf_TextChanged);

            // ── CARGO — ComboBox escuro com FlatStyle ──────────────────
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = fLabel;
            this.lblCargo.ForeColor = cSub;
            this.lblCargo.Location = new System.Drawing.Point(24, 220);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Text = "CARGO";

            this.cmbCargo.BackColor = cCampo;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;  // << cor escura
            this.cmbCargo.Font = fCampo;
            this.cmbCargo.ForeColor = cBranco;
            this.cmbCargo.Location = new System.Drawing.Point(24, 240);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(272, 30);
            this.cmbCargo.TabIndex = 2;

            // ── NOVA SENHA ─────────────────────────────────────────────
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = fLabel;
            this.lblSenha.ForeColor = cSub;
            this.lblSenha.Location = new System.Drawing.Point(24, 290);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Text = "NOVA SENHA  (vazio = manter atual)";

            this.txbSenha.BackColor = cCampo;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = fCampo;
            this.txbSenha.ForeColor = cBranco;
            this.txbSenha.Location = new System.Drawing.Point(24, 310);
            this.txbSenha.Multiline = true;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '\u25CF';
            this.txbSenha.Size = new System.Drawing.Size(272, 36);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSenha_KeyPress);

            // ── botões sidebar ─────────────────────────────────────────
            this.btnEditar.BackColor = cAccent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnEditar.Font = fBtn;
            this.btnEditar.ForeColor = cBranco;
            this.btnEditar.Location = new System.Drawing.Point(24, 372);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(272, 44);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Salvar Alterações";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnExcluir.BackColor = cCampo;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.FlatAppearance.BorderColor = cBorder;
            this.btnExcluir.FlatAppearance.BorderSize = 1;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(30, 10, 10);
            this.btnExcluir.Font = fBtn;
            this.btnExcluir.ForeColor = cAccent;
            this.btnExcluir.Location = new System.Drawing.Point(24, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(272, 44);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir Funcionário";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);

            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.Font = fBtnSm;
            this.btnLimpar.ForeColor = cSub;
            this.btnLimpar.Location = new System.Drawing.Point(24, 490);
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
            this.btnVoltar.Location = new System.Drawing.Point(152, 490);
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
            this.pnlSidebar.TabIndex = 1;
            this.pnlSidebar.Controls.Add(this.lblDica);
            this.pnlSidebar.Controls.Add(this.lblNome);
            this.pnlSidebar.Controls.Add(this.txbNome);
            this.pnlSidebar.Controls.Add(this.lblCpf);
            this.pnlSidebar.Controls.Add(this.txbCpf);
            this.pnlSidebar.Controls.Add(this.lblCargo);
            this.pnlSidebar.Controls.Add(this.cmbCargo);
            this.pnlSidebar.Controls.Add(this.lblSenha);
            this.pnlSidebar.Controls.Add(this.txbSenha);
            this.pnlSidebar.Controls.Add(this.btnEditar);
            this.pnlSidebar.Controls.Add(this.btnExcluir);
            this.pnlSidebar.Controls.Add(this.btnLimpar);
            this.pnlSidebar.Controls.Add(this.btnVoltar);

            // ── pnlBody ────────────────────────────────────────────────
            this.pnlBody.BackColor = cFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.TabIndex = 2;
            this.pnlBody.Controls.Add(this.pnlGrid);     // Fill
            this.pnlBody.Controls.Add(this.pnlSidebar);  // Right

            // ── Form ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = cFundo;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Name = "FrmGerenciarUsuarios";
            this.Text = "Gerenciar Funcionários";
            this.Load += new System.EventHandler(this.FrmGerenciarUsuarios_Load);

            // Ordem: Fill → Top(line) → Top(header)
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.DataGridView dgvUsuarios;
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