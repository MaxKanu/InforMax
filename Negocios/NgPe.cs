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
    public class NgPe
    {
        Asqlbd acesso = new Asqlbd();
        public string InserirPedido(Pedidos pedido)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@DataHora", pedido.Cadastro);
            acesso.AdicionarParametros("@Operacao", pedido.Operacao.IdOperacao);
            acesso.AdicionarParametros("@Situacao", pedido.Situacao.IdSituacao);
            acesso.AdicionarParametros("@Cliente", pedido.Cliente.Pessoa.Id);
            acesso.AdicionarParametros("@Marcador", pedido.Marcador);

            string IdPedido = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirPedido").ToString();
            return IdPedido;
        }
        public PedidoColecao Pedidos(int? id, string pedido)
        {
            PedidoColecao colecao = new PedidoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdPedido", id);
                acesso.AdicionarParametros("@IdCliente", pedido);

                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "[uspConsultarPedidos]");

                foreach (DataRow linha in table.Rows) 
                {
                    Pedidos pedidos = new Pedidos
                    {
                        Operacao = new Operacao(),
                        Situacao = new PedidoSituacao(),
                        Cliente = new ClienteFisico()
                    };
                    pedidos.Cliente.Pessoa = new Pessoa();

                    pedidos.IdPedidos = Convert.ToInt32(linha["IdPedido"]);
                    pedidos.Cadastro = Convert.ToDateTime(linha["Cadastro"]);
                    pedidos.Operacao.Descricao = Convert.ToString(linha["Descricao"]);
                    pedidos.Situacao.Situacao = Convert.ToString(linha["Situacao"]);
                    pedidos.Cliente.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    pedidos.Marcador = Convert.ToString(linha["Marcador"]);

                    colecao.Add(pedidos);
                }
                return colecao;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
