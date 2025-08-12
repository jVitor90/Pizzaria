namespace Pizzaria
{
    partial class FrmGestaoEstoque
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
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txbUnidade = new System.Windows.Forms.TextBox();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.txbNomeProduto = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(296, 68);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(52, 18);
            this.lblPreco.TabIndex = 65;
            this.lblPreco.Text = "Preço:";
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(150, 68);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(62, 18);
            this.lblUnidade.TabIndex = 64;
            this.lblUnidade.Text = "Unidade";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 68);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(83, 18);
            this.lblQuantidade.TabIndex = 63;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(358, 18);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblCategoria.TabIndex = 62;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(12, 18);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 18);
            this.lblProduto.TabIndex = 61;
            this.lblProduto.Text = "Produto";
            // 
            // txbUnidade
            // 
            this.txbUnidade.Location = new System.Drawing.Point(153, 89);
            this.txbUnidade.Multiline = true;
            this.txbUnidade.Name = "txbUnidade";
            this.txbUnidade.Size = new System.Drawing.Size(115, 26);
            this.txbUnidade.TabIndex = 59;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(299, 89);
            this.txbValor.Multiline = true;
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(115, 26);
            this.txbValor.TabIndex = 60;
            // 
            // txbNomeProduto
            // 
            this.txbNomeProduto.Location = new System.Drawing.Point(12, 39);
            this.txbNomeProduto.Multiline = true;
            this.txbNomeProduto.Name = "txbNomeProduto";
            this.txbNomeProduto.Size = new System.Drawing.Size(314, 26);
            this.txbNomeProduto.TabIndex = 58;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(361, 39);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(157, 26);
            this.cmbCategoria.TabIndex = 57;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(12, 89);
            this.txbQuantidade.Multiline = true;
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(115, 26);
            this.txbQuantidade.TabIndex = 56;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(530, 430);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 41);
            this.btnVoltar.TabIndex = 55;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(361, 430);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(135, 41);
            this.btnExcluir.TabIndex = 54;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(183, 430);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 41);
            this.btnEditar.TabIndex = 53;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(12, 430);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(135, 41);
            this.btnCadastrar.TabIndex = 52;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 141);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(794, 274);
            this.dgvProdutos.TabIndex = 51;
            // 
            // FrmGestaoEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(818, 485);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txbUnidade);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.txbNomeProduto);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Name = "FrmGestaoEstoque";
            this.Text = "FrmGestaoEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txbUnidade;
        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.TextBox txbNomeProduto;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.TextBox txbQuantidade;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvProdutos;
    }
}