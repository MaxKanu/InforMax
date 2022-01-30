using AcessoDados;
using Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NgPr
    {
        Asqlbd acesso = new Asqlbd();
        public string Inserir(Precos precos)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdTarefa", precos.Id);
            acesso.AdicionarParametros("@Preco", precos.Preco);

            string IdPreco = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirPrecos").ToString();
            return IdPreco;
        }
        public string Alterar(Precos precos)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Id", precos.Id);
            acesso.AdicionarParametros("@Preco", precos.Preco);

            string IdPreco = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
            return IdPreco;
        }
        public PrecoColecao ConsultarProduto(int? id, string desc)
        {
            PrecoColecao colecao = new PrecoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdTarefas", id);
                acesso.AdicionarParametros("@Descricao", desc);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPrecosProdutos");

                foreach (DataRow linha in table.Rows)
                {
                    Precos preco = new Precos
                    {
                        Id = Convert.ToInt32(linha["IdProdutos"]),
                        Descricao = Convert.ToString(linha["Produtos"]),
                        Preco = Convert.ToDecimal(linha["Preco"])
                    };

                    colecao.Add(preco);
                }
                return colecao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public PrecoColecao ConsultarServico(int? id, string desc)
        {
            PrecoColecao colecao = new PrecoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdTarefas", id);
                acesso.AdicionarParametros("@Descricao", desc);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPrecosServicos");

                foreach (DataRow linha in table.Rows)
                {
                    Precos preco = new Precos
                    {
                        Id = Convert.ToInt32(linha["IdServicos"]),
                        Descricao = Convert.ToString(linha["Servicos"]),
                        Preco = Convert.ToDecimal(linha["Preco"])
                    };

                    colecao.Add(preco);
                }
                return colecao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public PrecoColecao ConsultarProduto(string desc)
        {
            PrecoColecao colecao = new PrecoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdTarefas", desc);
                acesso.AdicionarParametros("@Descricao", desc);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPrecosProdutos");

                foreach (DataRow linha in table.Rows)
                {
                    Precos preco = new Precos
                    {
                        Id = Convert.ToInt32(linha["IdProdutos"]),
                        Descricao = Convert.ToString(linha["Produtos"]),
                        Preco = Convert.ToDecimal(linha["Preco"])
                    };

                    colecao.Add(preco);
                }
                return colecao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public PrecoColecao ConsultarServico(string desc)
        {
            PrecoColecao colecao = new PrecoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdTarefas", desc);
                acesso.AdicionarParametros("@Descricao", desc);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarPrecosServicos");

                foreach (DataRow linha in table.Rows)
                {
                    Precos preco = new Precos
                    {
                        Id = Convert.ToInt32(linha["IdServicos"]),
                        Descricao = Convert.ToString(linha["Servicos"]),
                        Preco = Convert.ToDecimal(linha["Preco"])
                    };

                    colecao.Add(preco);
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