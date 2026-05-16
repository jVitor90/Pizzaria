namespace Pizzaria
{
    partial class FrmLogin
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
                new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));

            this.picblogo = new System.Windows.Forms.PictureBox();
            this.lblcadastrar = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.txbcpf = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();

            // paineis estruturais
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();

            // labels decorativos do lado esquerdo
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picblogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();

            // ── pnlLeft — lado esquerdo escuro ───────────────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(8, 8, 8);
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.TabIndex = 60;
            this.pnlLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlLeft_Paint);

            // Logo
            this.picblogo.BackColor = System.Drawing.Color.Transparent;
            this.picblogo.Image = ((System.Drawing.Image)(resources.GetObject("picblogo.Image")));
            this.picblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picblogo.Name = "picblogo";
            this.picblogo.Size = new System.Drawing.Size(90, 90);
            this.picblogo.TabStop = false;
            this.pnlLeft.Controls.Add(this.picblogo);

            // Nome da pizzaria
            this.lblBrand.AutoSize = false;
            this.lblBrand.BackColor = System.Drawing.Color.Transparent;
            this.lblBrand.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBrand.Text = "PIZZARIA";
            this.pnlLeft.Controls.Add(this.lblBrand);

            // Linha decorativa vermelha
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Height = 3;
            this.pnlLeft.Controls.Add(this.pnlAccent);

            // Slogan
            this.lblSlogan.AutoSize = false;
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Italic);
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(160, 160, 150);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSlogan.Text = "Sistema de Gestão";
            this.pnlLeft.Controls.Add(this.lblSlogan);

            // lblcadastrar mantido oculto
            this.lblcadastrar.AutoSize = true;
            this.lblcadastrar.Visible = false;
            this.lblcadastrar.Name = "lblcadastrar";
            this.pnlLeft.Controls.Add(this.lblcadastrar);

            // ── pnlRight — lado direito formulário ───────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.FromArgb(13, 13, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.TabIndex = 61;

            // Bem-vindo
            this.lblBemVindo.AutoSize = false;
            this.lblBemVindo.BackColor = System.Drawing.Color.Transparent;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblBemVindo.ForeColor = System.Drawing.Color.White;
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Text = "Entrar";
            this.pnlRight.Controls.Add(this.lblBemVindo);

            // Subtítulo
            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 100, 95);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Text = "Acesse sua conta para continuar";
            this.pnlRight.Controls.Add(this.lblSubtitle);

            // ── pnlForm — card flutuante ─────────────────────────────────
            this.pnlForm.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.TabIndex = 62;
            this.pnlForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlForm_Paint);

            // lblcpf
            this.lblcpf.AutoSize = false;
            this.lblcpf.BackColor = System.Drawing.Color.Transparent;
            this.lblcpf.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblcpf.ForeColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Text = "CPF";
            this.pnlForm.Controls.Add(this.lblcpf);

            // txbcpf
            this.txbcpf.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.txbcpf.ForeColor = System.Drawing.Color.White;
            this.txbcpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbcpf.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txbcpf.MaxLength = 14;
            this.txbcpf.Name = "txbcpf";
            this.pnlForm.Controls.Add(this.txbcpf);

            // lblsenha
            this.lblsenha.AutoSize = false;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblsenha.ForeColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Text = "SENHA";
            this.pnlForm.Controls.Add(this.lblsenha);

            // txbsenha
            this.txbsenha.BackColor = System.Drawing.Color.FromArgb(28, 28, 28);
            this.txbsenha.ForeColor = System.Drawing.Color.White;
            this.txbsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbsenha.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txbsenha.PasswordChar = '●';
            this.txbsenha.Name = "txbsenha";
            this.pnlForm.Controls.Add(this.txbsenha);

            // btnentrar
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(196, 30, 30);
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.FlatAppearance.BorderSize = 0;
            this.btnentrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(215, 45, 45);
            this.btnentrar.ForeColor = System.Drawing.Color.White;
            this.btnentrar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnentrar.Text = "ENTRAR";
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            this.pnlForm.Controls.Add(this.btnentrar);

            // btnsair
            this.btnsair.BackColor = System.Drawing.Color.Transparent;
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.FlatAppearance.BorderSize = 0;
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsair.ForeColor = System.Drawing.Color.FromArgb(80, 80, 75);
            this.btnsair.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsair.Text = "Sair do sistema";
            this.btnsair.Name = "btnsair";
            this.btnsair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            this.pnlForm.Controls.Add(this.btnsair);

            this.pnlRight.Controls.Add(this.pnlForm);

            // lblVersion
            this.lblVersion.AutoSize = false;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(45, 45, 42);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Text = "v1.0  •  Pizzaria Sistema";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pnlRight.Controls.Add(this.lblVersion);

            // ── FrmLogin ─────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(8, 8, 8);
            this.BackgroundImage = null;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.Text = " ";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);

            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);

            ((System.ComponentModel.ISupportInitialize)(this.picblogo)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picblogo;
        private System.Windows.Forms.Label lblcadastrar;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.TextBox txbcpf;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblVersion;
    }
}