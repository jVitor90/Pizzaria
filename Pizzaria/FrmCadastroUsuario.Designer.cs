namespace Pizzaria
{
    partial class FrmCadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));

            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderLine = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();

            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btrnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();

            // cores
            System.Drawing.Color cFundo = System.Drawing.Color.FromArgb(12, 12, 12);
            System.Drawing.Color cHeader = System.Drawing.Color.FromArgb(10, 10, 10);
            System.Drawing.Color cAccent = System.Drawing.Color.FromArgb(196, 30, 30);
            System.Drawing.Color cCard = System.Drawing.Color.FromArgb(18, 18, 18);
            System.Drawing.Color cBorder = System.Drawing.Color.FromArgb(32, 32, 30);
            System.Drawing.Color cBranco = System.Drawing.Color.White;
            System.Drawing.Color cSub = System.Drawing.Color.FromArgb(100, 100, 95);
            System.Drawing.Color cCampo = System.Drawing.Color.FromArgb(24, 24, 24);
            System.Drawing.Color cCampoBrd = System.Drawing.Color.FromArgb(42, 42, 40);

            // fontes
            System.Drawing.Font fHeader = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fLabel = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font fCampo = new System.Drawing.Font("Segoe UI", 11F);
            System.Drawing.Font fBtn = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader ──────────────────────────────────────────────
            this.pnlHeader.BackColor = cHeader;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 64;
            this.pnlHeader.Name = "pnlHeader";

            this.lblTitulo.AutoSize = false;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = fHeader;
            this.lblTitulo.ForeColor = cBranco;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Cadastro de Usuário";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);

            // Label logo reutilizado como título — mantemos o nome original na declaração
            this.lblLogo = this.lblTitulo;

            this.pnlHeader.Controls.Add(this.lblTitulo);

            // ── linha vermelha ──────────────────────────────────────────
            this.pnlHeaderLine.BackColor = cAccent;
            this.pnlHeaderLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderLine.Height = 2;
            this.pnlHeaderLine.Name = "pnlHeaderLine";

            // ── pnlBody ────────────────────────────────────────────────
            this.pnlBody.BackColor = cFundo;
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Name = "pnlBody";

            // ── pnlForm (card centralizado) ────────────────────────────
            this.pnlForm.BackColor = cCard;
            this.pnlForm.Name = "pnlForm";
            // posicionado via Resize; tamanho inicial:
            this.pnlForm.Size = new System.Drawing.Size(540, 460);
            this.pnlForm.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ── NOME ───────────────────────────────────────────────────
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = fLabel;
            this.lblNome.ForeColor = cSub;
            this.lblNome.Location = new System.Drawing.Point(32, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Text = "NOME";

            this.txbNome.BackColor = cCampo;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Font = fCampo;
            this.txbNome.ForeColor = cBranco;
            this.txbNome.Location = new System.Drawing.Point(32, 56);
            this.txbNome.Multiline = true;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(476, 38);
            this.txbNome.TabIndex = 0;
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNome_KeyPress);

            // ── CPF ────────────────────────────────────────────────────
            this.lblCpf.AutoSize = true;
            this.lblCpf.BackColor = System.Drawing.Color.Transparent;
            this.lblCpf.Font = fLabel;
            this.lblCpf.ForeColor = cSub;
            this.lblCpf.Location = new System.Drawing.Point(32, 116);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Text = "CPF";

            this.txbcpf.BackColor = cCampo;
            this.txbcpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbcpf.Font = fCampo;
            this.txbcpf.ForeColor = cBranco;
            this.txbcpf.Location = new System.Drawing.Point(32, 136);
            this.txbcpf.MaxLength = 14;
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(230, 38);
            this.txbcpf.TabIndex = 1;
            this.txbcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbCpf_KeyPress);
            this.txbcpf.TextChanged += new System.EventHandler(this.TxbCpf_TextChanged);

            // ── CARGO ──────────────────────────────────────────────────
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = fLabel;
            this.lblCargo.ForeColor = cSub;
            this.lblCargo.Location = new System.Drawing.Point(278, 116);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Text = "CARGO";

            this.cmbCargo.BackColor = cCampo;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCargo.Font = fCampo;
            this.cmbCargo.ForeColor = cBranco;
            this.cmbCargo.Location = new System.Drawing.Point(278, 136);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(230, 32);
            this.cmbCargo.TabIndex = 2;

            // ── SENHA ──────────────────────────────────────────────────
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = fLabel;
            this.lblSenha.ForeColor = cSub;
            this.lblSenha.Location = new System.Drawing.Point(32, 198);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Text = "SENHA";

            this.txbSenha.BackColor = cCampo;
            this.txbSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSenha.Font = fCampo;
            this.txbSenha.ForeColor = cBranco;
            this.txbSenha.Location = new System.Drawing.Point(32, 218);
            this.txbSenha.Multiline = true;
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '●';
            this.txbSenha.Size = new System.Drawing.Size(476, 38);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSenha_KeyPress);

            // ── btrnCadastrar ──────────────────────────────────────────
            this.btrnCadastrar.BackColor = cAccent;
            this.btrnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btrnCadastrar.FlatAppearance.BorderSize = 0;
            this.btrnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btrnCadastrar.Font = fBtn;
            this.btrnCadastrar.ForeColor = cBranco;
            this.btrnCadastrar.Location = new System.Drawing.Point(32, 290);
            this.btrnCadastrar.Name = "btrnCadastrar";
            this.btrnCadastrar.Size = new System.Drawing.Size(476, 46);
            this.btrnCadastrar.TabIndex = 4;
            this.btrnCadastrar.Text = "Cadastrar";
            this.btrnCadastrar.UseVisualStyleBackColor = false;
            this.btrnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btrnCadastrar.Click += new System.EventHandler(this.btrnCadastrar_Click);

            // ── btnVoltar ──────────────────────────────────────────────
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVoltar.ForeColor = cSub;
            this.btnVoltar.Location = new System.Drawing.Point(32, 350);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(476, 32);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "↩  Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);

            // monta pnlForm
            this.pnlForm.Controls.Add(this.lblNome);
            this.pnlForm.Controls.Add(this.txbNome);
            this.pnlForm.Controls.Add(this.lblCpf);
            this.pnlForm.Controls.Add(this.txbcpf);
            this.pnlForm.Controls.Add(this.lblCargo);
            this.pnlForm.Controls.Add(this.cmbCargo);
            this.pnlForm.Controls.Add(this.lblSenha);
            this.pnlForm.Controls.Add(this.txbSenha);
            this.pnlForm.Controls.Add(this.btrnCadastrar);
            this.pnlForm.Controls.Add(this.btnVoltar);

            this.pnlBody.Controls.Add(this.pnlForm);

            // ── FrmCadastroUsuario ─────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = cFundo;
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroUsuario";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FrmCadastroUsuario_Load);
            this.Resize += new System.EventHandler(this.FrmCadastroUsuario_Resize);

            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeaderLine);
            this.Controls.Add(this.pnlHeader);

            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderLine;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblLogo;   // alias de lblTitulo — mantido para compatibilidade
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbcpf;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btrnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
    }
}