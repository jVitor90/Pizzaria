using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model
{
    internal class SessaoUsuario
    {

        public static string Nome { get; set; } = "";
        public static string Cargo { get; set; } = "";
        public static string Cpf { get; set; } = "";

        public static void Limpar()
        {
            Nome = "";
            Cargo = "";
            Cpf = "";
        }
    }
}
