 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace Pizzaria.Model
{
    internal class Itens_comandas
    {
        public int id_item {  get; set; }
        public int id_Comanda { get; set; }
        public int id_produto { get; set; }
        public int quantidade { get; set; }
        public string situacao_pedido { get; set; }

    }
}
