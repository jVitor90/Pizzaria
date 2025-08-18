using Pizzaria.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria
{
    public partial class FrmGestaoCaixa : Form
    {
        Model.OrdensComandas comandas = new Model.OrdensComandas();
        Model.Metodos_pagamento metodos = new Metodos_pagamento();
        public FrmGestaoCaixa()
        {
            InitializeComponent();
            //Obter as categorias do banco
            DataTable resultado = metodos.Listar();
            foreach(DataRow linha in resultado.Rows)
            {
                // Adiconar o combobox
                cmbFormaPagamento.Items.Add($"{linha["id_metodo"]} - {linha["nome_metodo"]}");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
