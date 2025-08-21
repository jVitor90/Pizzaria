namespace Pizzaria
{
    partial class FrmPedidos
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
            this.brnFinalizar = new System.Windows.Forms.Button();
            this.txbPedido = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmdMesa = new System.Windows.Forms.ComboBox();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // brnFinalizar
            // 
            this.brnFinalizar.Location = new System.Drawing.Point(40, 277);
            this.brnFinalizar.Name = "brnFinalizar";
            this.brnFinalizar.Size = new System.Drawing.Size(242, 36);
            this.brnFinalizar.TabIndex = 9;
            this.brnFinalizar.Text = "Finalizar";
            this.brnFinalizar.UseVisualStyleBackColor = true;
            this.brnFinalizar.Click += new System.EventHandler(this.brnFinalizar_Click);
            // 
            // txbPedido
            // 
            this.txbPedido.Location = new System.Drawing.Point(16, 219);
            this.txbPedido.Multiline = true;
            this.txbPedido.Name = "txbPedido";
            this.txbPedido.Size = new System.Drawing.Size(314, 32);
            this.txbPedido.TabIndex = 8;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(40, 144);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(242, 38);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdMesa
            // 
            this.cmdMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMesa.FormattingEnabled = true;
            this.cmdMesa.Location = new System.Drawing.Point(12, 97);
            this.cmdMesa.Name = "cmdMesa";
            this.cmdMesa.Size = new System.Drawing.Size(314, 32);
            this.cmdMesa.TabIndex = 6;
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Location = new System.Drawing.Point(394, 12);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.Size = new System.Drawing.Size(390, 426);
            this.dgvPedidos.TabIndex = 5;
            this.dgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidos_CellContentClick);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(10, 12);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(112, 31);
            this.lblLogo.TabIndex = 10;
            this.lblLogo.Text = "Pedidos";
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.brnFinalizar);
            this.Controls.Add(this.txbPedido);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cmdMesa);
            this.Controls.Add(this.dgvPedidos);
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnFinalizar;
        private System.Windows.Forms.TextBox txbPedido;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmdMesa;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblLogo;
    }
}