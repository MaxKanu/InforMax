using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Produtos
    {
        public int IdProdutos { get; set; }
        public string Descricao { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
