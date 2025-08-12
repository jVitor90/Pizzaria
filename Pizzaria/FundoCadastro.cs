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
    public partial class FundoCadastro : Form
    {
        public FundoCadastro()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //Inicializar o Inicializador (form)
            Form1 inicializador = new Form1();
            inicializador.ShowDialog();
            Application.Exit(); // Fechar o programa todo ao sair do inicializador
        } 

        private void FundoCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
