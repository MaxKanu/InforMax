using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Precos
    {
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal Percentual { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int IdPreco { get; set; }
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Produtos { get; set; }
        public string Servicos { get; set; }
    }
}
