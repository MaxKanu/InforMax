using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ItensDePedido
    {
        public Pedidos Pedidos { get; set; }
        public Precos Precos { get; set; }
        public int Quantidade { get; set; }
        public int IdPedidos { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Observacao { get; set; }
        public string Aparelho { get; set; }
        public decimal ValorPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
