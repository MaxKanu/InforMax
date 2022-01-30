using Objetos;
using AcessoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Negocios
{
    public class NgPd
    {
        Asqlbd acesso = new Asqlbd();
        public string Inserir(Produtos produtos)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdFabricante", produtos.Fabricante.IdFabricante);
            acesso.AdicionarParametros("@Descricao", produtos.Descricao);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirProdutos").ToString();
            return IdCliente;
        }
        public ProdutosColecao Combo(string fab)
        {
            ProdutosColecao colecao = new ProdutosColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdProdutos", fab);
                acesso.AdicionarParametros("@Descricao", fab);
                DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdProdutos, Descricao FROM tblProdutos");
                //DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspComboProduto");

                foreach (DataRow linha in table.Rows)
                {
                    Produtos prod = new Produtos
                    {
                        IdProdutos = Convert.ToInt32(linha["IdProdutos"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };

                    colecao.Add(prod);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ProdutosColecao Consultar(int? id, string fab)
        {
            ProdutosColecao colecao = new ProdutosColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdProdutos", id);
                acesso.AdicionarParametros("@Descricao", fab);
                //DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdFabricante, Descricao FROM tblFabricante");
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarProdutos");

                foreach (DataRow linha in table.Rows)
                {
                    Produtos prod = new Produtos
                    {
                        Fabricante = new Fabricante(),

                        IdProdutos = Convert.ToInt32(linha["IdProdutos"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };
                    prod.Fabricante.Descricao = Convert.ToString(linha["Fabricante"]);

                    colecao.Add(prod);
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
