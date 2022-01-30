using Objetos;
using AcessoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NgIp
    {
        Asqlbd acesso = new Asqlbd();
        public string InserirItensPedido(ItensDePedido itens)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdProduto", itens.Pedidos.IdPedidos);
            acesso.AdicionarParametros("@Quantidade", itens.Quantidade);
            acesso.AdicionarParametros("@ValorUnitario", itens.Precos.ValorUnitario);
            acesso.AdicionarParametros("@Percentual", itens.Precos.Percentual);
            acesso.AdicionarParametros("@ValorDesconto", itens.Precos.ValorDesconto);
            acesso.AdicionarParametros("@ValorTotal", itens.Precos.ValorTotal);

            string IdItens = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirItensPedidos").ToString();
            return IdItens;
        }
    }
}
