namespace Pizzaria
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkblcadastrar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcadastrar = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txbsenha = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.txbcpf = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(350, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // linkblcadastrar
            // 
            this.linkblcadastrar.AutoSize = true;
            this.linkblcadastrar.BackColor = System.Drawing.Color.Transparent;
            this.linkblcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkblcadastrar.LinkColor = System.Drawing.Color.Lime;
            this.linkblcadastrar.Location = new System.Drawing.Point(481, 363);
            this.linkblcadastrar.Name = "linkblcadastrar";
            this.linkblcadastrar.Size = new System.Drawing.Size(87, 20);
            this.linkblcadastrar.TabIndex = 17;
            this.linkblcadastrar.TabStop = true;
            this.linkblcadastrar.Text = "Clique aqui";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Deseja se cadastrar?";
            // 
            // lblcadastrar
            // 
            this.lblcadastrar.AutoSize = true;
            this.lblcadastrar.Location = new System.Drawing.Point(327, 363);
            this.lblcadastrar.Name = "lblcadastrar";
            this.lblcadastrar.Size = new System.Drawing.Size(0, 13);
            this.lblcadastrar.TabIndex = 15;
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.BackColor = System.Drawing.Color.Transparent;
            this.lblsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha.ForeColor = System.Drawing.Color.Transparent;
            this.lblsenha.Location = new System.Drawing.Point(147, 257);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(100, 31);
            this.lblsenha.TabIndex = 14;
            this.lblsenha.Text = "Senha:";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.Color.Transparent;
            this.lblcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.Color.White;
            this.lblcpf.Location = new System.Drawing.Point(147, 195);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(77, 31);
            this.lblcpf.TabIndex = 13;
            this.lblcpf.Text = "CPF:";
            // 
            // txbsenha
            // 
            this.txbsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbsenha.Location = new System.Drawing.Point(253, 248);
            this.txbsenha.Name = "txbsenha";
            this.txbsenha.PasswordChar = '•';
            this.txbsenha.Size = new System.Drawing.Size(351, 47);
            this.txbsenha.TabIndex = 11;
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(253, 304);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(351, 52);
            this.btnentrar.TabIndex = 10;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // txbcpf
            // 
            this.txbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcpf.Location = new System.Drawing.Point(253, 195);
            this.txbcpf.Mask = "000,000,000-00";
            this.txbcpf.Name = "txbcpf";
            this.txbcpf.Size = new System.Drawing.Size(351, 47);
            this.txbcpf.TabIndex = 19;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.txbcpf);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkblcadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcadastrar);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.txbsenha);
            this.Controls.Add(this.btnentrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkblcadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcadastrar;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txbsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.MaskedTextBox txbcpf;
    }
}