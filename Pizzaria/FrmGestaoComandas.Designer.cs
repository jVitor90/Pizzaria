namespace Pizzaria
{
    partial class FrmGestaoComandas
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
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.lblAdicionais = new System.Windows.Forms.Label();
            this.cmbAdicionais = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbBordas = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblBordas = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbPizzas = new System.Windows.Forms.ComboBox();
            this.lblPIzzas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.txbObservecao = new System.Windows.Forms.TextBox();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.lblBebidas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvComandas = new System.Windows.Forms.DataGridView();
            this.grbPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPedidos
            // 
            this.grbPedidos.BackColor = System.Drawing.Color.Transparent;
            this.grbPedidos.Controls.Add(this.lblAdicionais);
            this.grbPedidos.Controls.Add(this.cmbAdicionais);
            this.grbPedidos.Controls.Add(this.btnCadastrar);
            this.grbPedidos.Controls.Add(this.cmbBordas);
            this.grbPedidos.Controls.Add(this.btnVoltar);
            this.grbPedidos.Controls.Add(this.lblBordas);
            this.grbPedidos.Controls.Add(this.btnLimpar);
            this.grbPedidos.Controls.Add(this.cmbPizzas);
            this.grbPedidos.Controls.Add(this.lblPIzzas);
            this.grbPedidos.Controls.Add(this.label2);
            this.grbPedidos.Controls.Add(this.lblObservacao);
            this.grbPedidos.Controls.Add(this.cmbBebidas);
            this.grbPedidos.Controls.Add(this.txbObservecao);
            this.grbPedidos.Controls.Add(this.txbMesa);
            this.grbPedidos.Controls.Add(this.lblBebidas);
            this.grbPedidos.ForeColor = System.Drawing.Color.Black;
            this.grbPedidos.Location = new System.Drawing.Point(12, 34);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Size = new System.Drawing.Size(449, 404);
            this.grbPedidos.TabIndex = 13;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "Pedidos";
            // 
            // lblAdicionais
            // 
            this.lblAdicionais.AutoSize = true;
            this.lblAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionais.ForeColor = System.Drawing.Color.Black;
            this.lblAdicionais.Location = new System.Drawing.Point(6, 164);
            this.lblAdicionais.Name = "lblAdicionais";
            this.lblAdicionais.Size = new System.Drawing.Size(72, 17);
            this.lblAdicionais.TabIndex = 16;
            this.lblAdicionais.Text = "Adicionais";
            // 
            // cmbAdicionais
            // 
            this.cmbAdicionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdicionais.FormattingEnabled = true;
            this.cmbAdicionais.Location = new System.Drawing.Point(9, 184);
            this.cmbAdicionais.Name = "cmbAdicionais";
            this.cmbAdicionais.Size = new System.Drawing.Size(195, 28);
            this.cmbAdicionais.TabIndex = 15;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(121, 341);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(174, 32);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbBordas
            // 
            this.cmbBordas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBordas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBordas.FormattingEnabled = true;
            this.cmbBordas.Location = new System.Drawing.Point(229, 118);
            this.cmbBordas.Name = "cmbBordas";
            this.cmbBordas.Size = new System.Drawing.Size(195, 28);
            this.cmbBordas.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(232, 303);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(174, 32);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblBordas
            // 
            this.lblBordas.AutoSize = true;
            this.lblBordas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBordas.ForeColor = System.Drawing.Color.Black;
            this.lblBordas.Location = new System.Drawing.Point(226, 96);
            this.lblBordas.Name = "lblBordas";
            this.lblBordas.Size = new System.Drawing.Size(53, 17);
            this.lblBordas.TabIndex = 13;
            this.lblBordas.Text = "Bordas";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(12, 303);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(174, 32);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cmbPizzas
            // 
            this.cmbPizzas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizzas.FormattingEnabled = true;
            this.cmbPizzas.Location = new System.Drawing.Point(6, 39);
            this.cmbPizzas.Name = "cmbPizzas";
            this.cmbPizzas.Size = new System.Drawing.Size(195, 28);
            this.cmbPizzas.TabIndex = 2;
            this.cmbPizzas.SelectedIndexChanged += new System.EventHandler(this.cmbPizzas_SelectedIndexChanged);
            // 
            // lblPIzzas
            // 
            this.lblPIzzas.AutoSize = true;
            this.lblPIzzas.BackColor = System.Drawing.Color.Transparent;
            this.lblPIzzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIzzas.ForeColor = System.Drawing.Color.Black;
            this.lblPIzzas.Location = new System.Drawing.Point(6, 16);
            this.lblPIzzas.Name = "lblPIzzas";
            this.lblPIzzas.Size = new System.Drawing.Size(49, 17);
            this.lblPIzzas.TabIndex = 5;
            this.lblPIzzas.Text = "Pizzas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "N° Da Mesa";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.Black;
            this.lblObservacao.Location = new System.Drawing.Point(9, 243);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(92, 17);
            this.lblObservacao.TabIndex = 7;
            this.lblObservacao.Text = "Observações";
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(229, 39);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(195, 28);
            this.cmbBebidas.TabIndex = 4;
            // 
            // txbObservecao
            // 
            this.txbObservecao.Location = new System.Drawing.Point(9, 263);
            this.txbObservecao.Multiline = true;
            this.txbObservecao.Name = "txbObservecao";
            this.txbObservecao.Size = new System.Drawing.Size(397, 34);
            this.txbObservecao.TabIndex = 3;
            // 
            // txbMesa
            // 
            this.txbMesa.Location = new System.Drawing.Point(9, 118);
            this.txbMesa.Multiline = true;
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(195, 28);
            this.txbMesa.TabIndex = 9;
            this.txbMesa.TextChanged += new System.EventHandler(this.txbMesa_TextChanged);
            this.txbMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMesa_KeyPress);
            // 
            // lblBebidas
            // 
            this.lblBebidas.AutoSize = true;
            this.lblBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBebidas.ForeColor = System.Drawing.Color.Black;
            this.lblBebidas.Location = new System.Drawing.Point(226, 16);
            this.lblBebidas.Name = "lblBebidas";
            this.lblBebidas.Size = new System.Drawing.Size(59, 17);
            this.lblBebidas.TabIndex = 6;
            this.lblBebidas.Text = "Bebidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Comandas";
            // 
            // DgvComandas
            // 
            this.DgvComandas.AllowUserToAddRows = false;
            this.DgvComandas.AllowUserToDeleteRows = false;
            this.DgvComandas.AllowUserToResizeColumns = false;
            this.DgvComandas.AllowUserToResizeRows = false;
            this.DgvComandas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComandas.BackgroundColor = System.Drawing.Color.White;
            this.DgvComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComandas.Location = new System.Drawing.Point(467, 6);
            this.DgvComandas.Name = "DgvComandas";
            this.DgvComandas.Size = new System.Drawing.Size(360, 426);
            this.DgvComandas.TabIndex = 14;
            this.DgvComandas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellDoubleClick);
            // 
            // FrmGestaoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.DgvComandas);
            this.Controls.Add(this.grbPedidos);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestaoComandas";
            this.Text = "FrmGestaoComandas";
            this.Load += new System.EventHandler(this.FrmGestaoComandas_Load);
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.Label lblAdicionais;
        private System.Windows.Forms.ComboBox cmbAdicionais;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbBordas;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblBordas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbPizzas;
        private System.Windows.Forms.Label lblPIzzas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.TextBox txbObservecao;
        private System.Windows.Forms.TextBox txbMesa;
        private System.Windows.Forms.Label lblBebidas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvComandas;
    }
}