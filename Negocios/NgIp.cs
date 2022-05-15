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
            acesso.AdicionarParametros("@IdPedido", itens.Pedidos.IdPedidos);
            acesso.AdicionarParametros("@IdProduto", itens.Pedidos.Tarefas.Produtos.IdProdutos);
            acesso.AdicionarParametros("@Quantidade", itens.Quantidade);
            acesso.AdicionarParametros("@ValorUnitario", itens.Precos.ValorUnitario);
            acesso.AdicionarParametros("@Percentual", itens.Precos.Percentual);
            acesso.AdicionarParametros("@ValorDesconto", itens.Precos.ValorDesconto);
            acesso.AdicionarParametros("@ValorTotal", itens.Precos.ValorTotal);

            string IdItens = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirItensPedidos").ToString();
            return IdItens;
        }
        public string InserirValorTotal(ItensDePedido itens)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdPedido", itens.Pedidos.IdPedidos);
            acesso.AdicionarParametros("@ValorTotal", itens.Precos.ValorTotal);

            string retorno = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirIPedidosValorTotal").ToString();

            return retorno;
        }
        public ItensDePedidoColecao ConsultarPedidos(int? id)
        {
            ItensDePedidoColecao colecao = new ItensDePedidoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdPedido", id);
                //acesso.AdicionarParametros("@IdCliente", ids);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarItensPedidos");

                foreach (DataRow linha in table.Rows)
                {
                    ItensDePedido itens = new ItensDePedido();
                    itens.Pedidos = new Pedidos();
                    itens.Precos = new Precos();
                    itens.Pedidos.Cliente = new ClienteFisico();
                    itens.Pedidos.Cliente.Pessoa = new Pessoa();
                    /*
                                        itens.Pedidos.IdPedidos = Convert.ToInt32(linha["IdPedido"]);
                                        itens.Pedidos.Cliente.Pessoa.Id = Convert.ToInt32(linha["IdPessoa"]);
                                        itens.Pedidos.Cliente.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                                        itens.Pedidos.TipoAparelho = Convert.ToString(linha["Aparelho"]);
                                        itens.Pedidos.Modelo = Convert.ToString(linha["Modelo"]);
                                        itens.Pedidos.Observacoes = Convert.ToString(linha["Observacoes"]);
                                        itens.Precos.Descricao = Convert.ToString(linha["Descricao"]);
                                        itens.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                                        itens.Precos.ValorUnitario = Convert.ToDecimal(linha["ValorUnitario"]);
                                        itens.Precos.Percentual = Convert.ToDecimal(linha["PercentualDesconto"]);
                                        itens.Precos.ValorDesconto = Convert.ToDecimal(linha["ValorDesconto"]);
                                        itens.Precos.ValorTotal = Convert.ToDecimal(linha["ValorTotal"]);
                                        itens.Precos.Preco = Convert.ToDecimal(linha["ValorPedido"]);
                    */
                    itens.IdPedidos = Convert.ToInt32(linha["IdPedido"]);
                    itens.Pedidos.Cliente.Pessoa.Id = Convert.ToInt32(linha["IdPessoa"]);
                    itens.Pedidos.Cliente.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    itens.Pedidos.TipoAparelho = Convert.ToString(linha["Aparelho"]);
                    itens.Pedidos.Modelo = Convert.ToString(linha["Modelo"]);
                    itens.Pedidos.Observacoes = Convert.ToString(linha["Observacoes"]);
                    itens.Descricao = Convert.ToString(linha["Descricao"]);
                    itens.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    itens.ValorUnitario = Convert.ToDouble(linha["ValorUnitario"]);
                    itens.Precos.Percentual = Convert.ToDecimal(linha["PercentualDesconto"]);
                    itens.ValorDesconto = Convert.ToDouble(linha["ValorDesconto"]);
                    itens.ValorTotal = Convert.ToDouble(linha["ValorTotal"]);
                    itens.ValorPedido = Convert.ToDouble(linha["ValorPedido"]);

                    colecao.Add(itens);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ItensDePedidoColecao ConsultarPedidos()
        {
            ItensDePedidoColecao colecao = new ItensDePedidoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdPedido", null);
                //acesso.AdicionarParametros("@IdCliente", ids);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarItensPedidos");

                foreach (DataRow linha in table.Rows)
                {
                    ItensDePedido itens = new ItensDePedido();
                    itens.Pedidos = new Pedidos();
                    itens.Precos = new Precos();
                    itens.Pedidos.Cliente = new ClienteFisico();
                    itens.Pedidos.Cliente.Pessoa = new Pessoa();

                    itens.IdPedidos = Convert.ToInt32(linha["IdPedido"]);
                    itens.Pedidos.Cliente.Pessoa.Id = Convert.ToInt32(linha["IdPessoa"]);
                    itens.Pedidos.Cliente.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    itens.Pedidos.TipoAparelho = Convert.ToString(linha["Aparelho"]);
                    itens.Pedidos.Modelo = Convert.ToString(linha["Modelo"]);
                    itens.Pedidos.Observacoes = Convert.ToString(linha["Observacoes"]);
                    itens.Descricao = Convert.ToString(linha["Descricao"]);
                    itens.Quantidade = Convert.ToInt32(linha["Quantidade"]);
                    itens.ValorUnitario = Convert.ToDouble(linha["ValorUnitario"]);
                    itens.Precos.Percentual = Convert.ToDecimal(linha["PercentualDesconto"]);
                    itens.ValorDesconto = Convert.ToDouble(linha["ValorDesconto"]);
                    itens.ValorTotal = Convert.ToDouble(linha["ValorTotal"]);
                    itens.ValorPedido = Convert.ToDouble(linha["ValorPedido"]);

                    colecao.Add(itens);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ItensDePedidoColecao ConsultarValorTotalPedidos(int? id)
        {
            ItensDePedidoColecao colecao = new ItensDePedidoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdPedido", id);
                //acesso.AdicionarParametros("@IdCliente", ids);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPedidosValorTotal");

                foreach (DataRow linha in table.Rows)
                {
                    ItensDePedido itens = new ItensDePedido();
                    itens.Pedidos = new Pedidos();
                    itens.Precos = new Precos();
                    itens.Pedidos.Cliente = new ClienteFisico();
                    itens.Pedidos.Cliente.Pessoa = new Pessoa();

                    itens.Pedidos.IdPedidos = Convert.ToInt32(linha["IdPedido"]);
                    itens.Pedidos.Cliente.Pessoa.Id = Convert.ToInt32(linha["IdCliente"]);
                    itens.Pedidos.Cliente.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    itens.Pedidos.TipoAparelho = Convert.ToString(linha["Aparelho"]);
                    itens.Pedidos.Modelo = Convert.ToString(linha["Modelo"]);
                    itens.Pedidos.Observacoes = Convert.ToString(linha["Observacoes"]);
                    itens.Pedidos.Marcador = Convert.ToString(linha["Marcador"]);
                    itens.Precos.Preco = Convert.ToDecimal(linha["ValorPedido"]);

                    colecao.Add(itens);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ItensDePedidoColecao ConsultarValorTotalPedido(int? id)
        {
            ItensDePedidoColecao colecao = new ItensDePedidoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdPedido", id);
                //acesso.AdicionarParametros("@IdCliente", ids);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPedidosValorTotal");
                
                foreach (DataRow linha in table.Rows)
                {
                    ItensDePedido itens = new ItensDePedido();
                    itens.Pedidos = new Pedidos();
                    itens.Precos = new Precos();
                    itens.Pedidos.Cliente = new ClienteFisico();
                    itens.Pedidos.Cliente.Pessoa = new Pessoa();

                    itens.Pedidos.IdPedidos = Convert.ToInt32(linha["IdPedido"]);
                    itens.Pedidos.Cliente.Pessoa.Id = Convert.ToInt32(linha["IdCliente"]);
                    itens.Pedidos.Cliente.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    itens.Precos.Preco = Convert.ToDecimal(linha["ValorPedido"]);

                    colecao.Add(itens);
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
