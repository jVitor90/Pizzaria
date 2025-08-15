using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    public class OrdensComandas
    {

        public int id_comanda { get; set; }
        public int num_mesa { get; set; }
        public int id_resp { get; set; }
        public DateTime data_adic { get; set; }
        public int situacao { get; set; }
        public string metodo_pagamento { get; set; }

        public DataTable BuscarMesa { get; set; }

    }
}
