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
     partial class FrmGestaoComandas : Form
    {
        Model.Usuario usuario;
        public FrmGestaoComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void FrmGestaoComandas_Load(object sender, EventArgs e)
        {

        }
    }
}
