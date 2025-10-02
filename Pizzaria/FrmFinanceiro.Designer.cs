namespace Pizzaria
{
    partial class FrmFinanceiro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.GrbFaturamentoPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.BtnGerarRelatorio = new System.Windows.Forms.Button();
            this.GrbFaturamentoMensal = new System.Windows.Forms.GroupBox();
            this.BtnFaturamentoMensalAtual = new System.Windows.Forms.Button();
            this.BtnRelatorioMensalGeral = new System.Windows.Forms.Button();
            this.DgvFaturamento = new System.Windows.Forms.DataGridView();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.GrbFaturamentoPeriodo.SuspendLayout();
            this.GrbFaturamentoMensal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaturamento)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbFaturamentoPeriodo
            // 
            this.GrbFaturamentoPeriodo.Controls.Add(this.dtpInicio);
            this.GrbFaturamentoPeriodo.Controls.Add(this.dtpFim);
            this.GrbFaturamentoPeriodo.Controls.Add(this.BtnGerarRelatorio);
            this.GrbFaturamentoPeriodo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbFaturamentoPeriodo.Location = new System.Drawing.Point(12, 50);
            this.GrbFaturamentoPeriodo.Name = "GrbFaturamentoPeriodo";
            this.GrbFaturamentoPeriodo.Size = new System.Drawing.Size(760, 100);
            this.GrbFaturamentoPeriodo.TabIndex = 1;
            this.GrbFaturamentoPeriodo.TabStop = false;
            this.GrbFaturamentoPeriodo.Text = "Faturamento por Período";
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(10, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(180, 23);
            this.dtpInicio.TabIndex = 0;
            // 
            // dtpFim
            // 
            this.dtpFim.CustomFormat = "dd/MM/yyyy";
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(200, 30);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(180, 23);
            this.dtpFim.TabIndex = 1;
            // 
            // BtnGerarRelatorio
            // 
            this.BtnGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGerarRelatorio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerarRelatorio.Location = new System.Drawing.Point(390, 30);
            this.BtnGerarRelatorio.Name = "BtnGerarRelatorio";
            this.BtnGerarRelatorio.Size = new System.Drawing.Size(268, 30);
            this.BtnGerarRelatorio.TabIndex = 2;
            this.BtnGerarRelatorio.Text = "Gerar Relatório por Período";
            this.BtnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // GrbFaturamentoMensal
            // 
            this.GrbFaturamentoMensal.Controls.Add(this.BtnFaturamentoMensalAtual);
            this.GrbFaturamentoMensal.Controls.Add(this.BtnRelatorioMensalGeral);
            this.GrbFaturamentoMensal.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbFaturamentoMensal.Location = new System.Drawing.Point(12, 160);
            this.GrbFaturamentoMensal.Name = "GrbFaturamentoMensal";
            this.GrbFaturamentoMensal.Size = new System.Drawing.Size(760, 76);
            this.GrbFaturamentoMensal.TabIndex = 2;
            this.GrbFaturamentoMensal.TabStop = false;
            this.GrbFaturamentoMensal.Text = "Faturamento Mensal";
            // 
            // BtnFaturamentoMensalAtual
            // 
            this.BtnFaturamentoMensalAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFaturamentoMensalAtual.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFaturamentoMensalAtual.Location = new System.Drawing.Point(10, 30);
            this.BtnFaturamentoMensalAtual.Name = "BtnFaturamentoMensalAtual";
            this.BtnFaturamentoMensalAtual.Size = new System.Drawing.Size(180, 30);
            this.BtnFaturamentoMensalAtual.TabIndex = 0;
            this.BtnFaturamentoMensalAtual.Text = "Gerar Faturamento Mensal Atual";
            this.BtnFaturamentoMensalAtual.Click += new System.EventHandler(this.btnFaturamentoMensalAtual_Click);
            // 
            // BtnRelatorioMensalGeral
            // 
            this.BtnRelatorioMensalGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRelatorioMensalGeral.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorioMensalGeral.Location = new System.Drawing.Point(200, 30);
            this.BtnRelatorioMensalGeral.Name = "BtnRelatorioMensalGeral";
            this.BtnRelatorioMensalGeral.Size = new System.Drawing.Size(180, 30);
            this.BtnRelatorioMensalGeral.TabIndex = 2;
            this.BtnRelatorioMensalGeral.Text = "Relatório Mensal Geral";
            this.BtnRelatorioMensalGeral.Click += new System.EventHandler(this.btnRelatorioMensalGeral_Click);
            // 
            // DgvFaturamento
            // 
            this.DgvFaturamento.Location = new System.Drawing.Point(6, 248);
            this.DgvFaturamento.Name = "DgvFaturamento";
            this.DgvFaturamento.Size = new System.Drawing.Size(760, 150);
            this.DgvFaturamento.TabIndex = 3;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoltar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(6, 404);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(196, 36);
            this.BtnVoltar.TabIndex = 3;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FrmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 442);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.GrbFaturamentoPeriodo);
            this.Controls.Add(this.GrbFaturamentoMensal);
            this.Controls.Add(this.DgvFaturamento);
            this.Name = "FrmFinanceiro";
            this.Text = "Financeiro";
            this.GrbFaturamentoPeriodo.ResumeLayout(false);
            this.GrbFaturamentoMensal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFaturamento)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox GrbFaturamentoPeriodo;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Button BtnGerarRelatorio;
        private System.Windows.Forms.GroupBox GrbFaturamentoMensal;
        private System.Windows.Forms.Button BtnFaturamentoMensalAtual;
        private System.Windows.Forms.Button BtnRelatorioMensalGeral;
        private System.Windows.Forms.DataGridView DgvFaturamento;
        private System.Windows.Forms.Button BtnVoltar;
    }
}
