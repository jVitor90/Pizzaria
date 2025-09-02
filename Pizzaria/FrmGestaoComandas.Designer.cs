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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestaoComandas));
            this.DgvProdutos = new System.Windows.Forms.DataGridView();
            this.DgvComandas = new System.Windows.Forms.DataGridView();
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.LblClientes = new System.Windows.Forms.Label();
            this.txbClientes = new System.Windows.Forms.TextBox();
            this.ChbAdicionais = new System.Windows.Forms.CheckBox();
            this.ChbBordas = new System.Windows.Forms.CheckBox();
            this.ChbBebidas = new System.Windows.Forms.CheckBox();
            this.ChbPizzas = new System.Windows.Forms.CheckBox();
            this.cmbAdicionais = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbBordas = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbPizzas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.txbObservecao = new System.Windows.Forms.TextBox();
            this.txbMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).BeginInit();
            this.grbPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProdutos
            // 
            this.DgvProdutos.AllowUserToAddRows = false;
            this.DgvProdutos.AllowUserToDeleteRows = false;
            this.DgvProdutos.AllowUserToResizeColumns = false;
            this.DgvProdutos.AllowUserToResizeRows = false;
            this.DgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.DgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdutos.Location = new System.Drawing.Point(581, 243);
            this.DgvProdutos.Name = "DgvProdutos";
            this.DgvProdutos.Size = new System.Drawing.Size(754, 367);
            this.DgvProdutos.TabIndex = 23;
            this.DgvProdutos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutos_CellDoubleClick);
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
            this.DgvComandas.Location = new System.Drawing.Point(18, 243);
            this.DgvComandas.Name = "DgvComandas";
            this.DgvComandas.Size = new System.Drawing.Size(557, 367);
            this.DgvComandas.TabIndex = 22;
            this.DgvComandas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvComandas_CellDoubleClick);
            this.DgvComandas.SelectionChanged += new System.EventHandler(this.DgvComandas_SelectionChanged);
            // 
            // grbPedidos
            // 
            this.grbPedidos.BackColor = System.Drawing.Color.Transparent;
            this.grbPedidos.Controls.Add(this.LblClientes);
            this.grbPedidos.Controls.Add(this.txbClientes);
            this.grbPedidos.Controls.Add(this.ChbAdicionais);
            this.grbPedidos.Controls.Add(this.ChbBordas);
            this.grbPedidos.Controls.Add(this.ChbBebidas);
            this.grbPedidos.Controls.Add(this.ChbPizzas);
            this.grbPedidos.Controls.Add(this.cmbAdicionais);
            this.grbPedidos.Controls.Add(this.btnCadastrar);
            this.grbPedidos.Controls.Add(this.cmbBordas);
            this.grbPedidos.Controls.Add(this.btnVoltar);
            this.grbPedidos.Controls.Add(this.btnLimpar);
            this.grbPedidos.Controls.Add(this.cmbPizzas);
            this.grbPedidos.Controls.Add(this.label2);
            this.grbPedidos.Controls.Add(this.lblObservacao);
            this.grbPedidos.Controls.Add(this.cmbBebidas);
            this.grbPedidos.Controls.Add(this.txbObservecao);
            this.grbPedidos.Controls.Add(this.txbMesa);
            this.grbPedidos.ForeColor = System.Drawing.Color.White;
            this.grbPedidos.Location = new System.Drawing.Point(12, 35);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Size = new System.Drawing.Size(1301, 202);
            this.grbPedidos.TabIndex = 21;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "Pedidos";
            // 
            // LblClientes
            // 
            this.LblClientes.AutoSize = true;
            this.LblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClientes.ForeColor = System.Drawing.Color.White;
            this.LblClientes.Location = new System.Drawing.Point(1100, 21);
            this.LblClientes.Name = "LblClientes";
            this.LblClientes.Size = new System.Drawing.Size(58, 17);
            this.LblClientes.TabIndex = 23;
            this.LblClientes.Text = "Clientes";
            // 
            // txbClientes
            // 
            this.txbClientes.Location = new System.Drawing.Point(1100, 47);
            this.txbClientes.Multiline = true;
            this.txbClientes.Name = "txbClientes";
            this.txbClientes.Size = new System.Drawing.Size(195, 28);
            this.txbClientes.TabIndex = 22;
            this.txbClientes.TextChanged += new System.EventHandler(this.txbClientes_TextChanged);
            this.txbClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClientes_KeyPress);
            // 
            // ChbAdicionais
            // 
            this.ChbAdicionais.AutoSize = true;
            this.ChbAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbAdicionais.ForeColor = System.Drawing.Color.White;
            this.ChbAdicionais.Location = new System.Drawing.Point(432, 19);
            this.ChbAdicionais.Name = "ChbAdicionais";
            this.ChbAdicionais.Size = new System.Drawing.Size(94, 22);
            this.ChbAdicionais.TabIndex = 21;
            this.ChbAdicionais.Text = "Adicionais";
            this.ChbAdicionais.UseVisualStyleBackColor = true;
            this.ChbAdicionais.CheckedChanged += new System.EventHandler(this.ChbAdicionais_CheckedChanged);
            // 
            // ChbBordas
            // 
            this.ChbBordas.AutoSize = true;
            this.ChbBordas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbBordas.ForeColor = System.Drawing.Color.White;
            this.ChbBordas.Location = new System.Drawing.Point(642, 21);
            this.ChbBordas.Name = "ChbBordas";
            this.ChbBordas.Size = new System.Drawing.Size(79, 22);
            this.ChbBordas.TabIndex = 20;
            this.ChbBordas.Text = "Bordas ";
            this.ChbBordas.UseVisualStyleBackColor = true;
            this.ChbBordas.CheckedChanged += new System.EventHandler(this.ChbBordas_CheckedChanged);
            // 
            // ChbBebidas
            // 
            this.ChbBebidas.AutoSize = true;
            this.ChbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbBebidas.ForeColor = System.Drawing.Color.White;
            this.ChbBebidas.Location = new System.Drawing.Point(216, 19);
            this.ChbBebidas.Name = "ChbBebidas";
            this.ChbBebidas.Size = new System.Drawing.Size(86, 24);
            this.ChbBebidas.TabIndex = 18;
            this.ChbBebidas.Text = "Bebidas";
            this.ChbBebidas.UseVisualStyleBackColor = true;
            this.ChbBebidas.CheckedChanged += new System.EventHandler(this.ChbBebidas_CheckedChanged);
            // 
            // ChbPizzas
            // 
            this.ChbPizzas.AutoSize = true;
            this.ChbPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbPizzas.ForeColor = System.Drawing.Color.White;
            this.ChbPizzas.Location = new System.Drawing.Point(10, 17);
            this.ChbPizzas.Name = "ChbPizzas";
            this.ChbPizzas.Size = new System.Drawing.Size(74, 24);
            this.ChbPizzas.TabIndex = 17;
            this.ChbPizzas.Text = "Pizzas";
            this.ChbPizzas.UseVisualStyleBackColor = true;
            this.ChbPizzas.CheckedChanged += new System.EventHandler(this.ChbPizzas_CheckedChanged);
            // 
            // cmbAdicionais
            // 
            this.cmbAdicionais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdicionais.Enabled = false;
            this.cmbAdicionais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAdicionais.FormattingEnabled = true;
            this.cmbAdicionais.Location = new System.Drawing.Point(432, 47);
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
            this.btnCadastrar.Location = new System.Drawing.Point(9, 155);
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
            this.cmbBordas.Enabled = false;
            this.cmbBordas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBordas.FormattingEnabled = true;
            this.cmbBordas.Location = new System.Drawing.Point(642, 47);
            this.cmbBordas.Name = "cmbBordas";
            this.cmbBordas.Size = new System.Drawing.Size(195, 28);
            this.cmbBordas.TabIndex = 14;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoltar.ForeColor = System.Drawing.Color.Black;
            this.btnVoltar.Location = new System.Drawing.Point(450, 155);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(174, 32);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(229, 155);
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
            this.cmbPizzas.Enabled = false;
            this.cmbPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizzas.FormattingEnabled = true;
            this.cmbPizzas.Location = new System.Drawing.Point(6, 47);
            this.cmbPizzas.Name = "cmbPizzas";
            this.cmbPizzas.Size = new System.Drawing.Size(195, 28);
            this.cmbPizzas.TabIndex = 2;
            this.cmbPizzas.SelectedIndexChanged += new System.EventHandler(this.cmbPizzas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(880, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "N° Da Mesa";
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.ForeColor = System.Drawing.Color.White;
            this.lblObservacao.Location = new System.Drawing.Point(11, 84);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(92, 17);
            this.lblObservacao.TabIndex = 7;
            this.lblObservacao.Text = "Observações";
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBebidas.Enabled = false;
            this.cmbBebidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(216, 47);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(195, 28);
            this.cmbBebidas.TabIndex = 4;
            // 
            // txbObservecao
            // 
            this.txbObservecao.Enabled = false;
            this.txbObservecao.Location = new System.Drawing.Point(6, 110);
            this.txbObservecao.Multiline = true;
            this.txbObservecao.Name = "txbObservecao";
            this.txbObservecao.Size = new System.Drawing.Size(405, 28);
            this.txbObservecao.TabIndex = 3;
            // 
            // txbMesa
            // 
            this.txbMesa.Location = new System.Drawing.Point(880, 47);
            this.txbMesa.Multiline = true;
            this.txbMesa.Name = "txbMesa";
            this.txbMesa.Size = new System.Drawing.Size(195, 28);
            this.txbMesa.TabIndex = 9;
            this.txbMesa.TextChanged += new System.EventHandler(this.txbMesa_TextChanged);
            this.txbMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMesa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Magneto", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Comandas";
            // 
            // FrmGestaoComandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 620);
            this.Controls.Add(this.DgvProdutos);
            this.Controls.Add(this.DgvComandas);
            this.Controls.Add(this.grbPedidos);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestaoComandas";
            this.Text = "Comandas";
            this.Load += new System.EventHandler(this.FrmGestaoComandas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComandas)).EndInit();
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
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
    }
}