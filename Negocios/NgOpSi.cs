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
    public class NgOpSi
    {
        Asqlbd acesso = new Asqlbd();
        public OperacaoColecao ComboOperacao(string op)
        {
            OperacaoColecao colecao = new OperacaoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdOperacao", op);
                acesso.AdicionarParametros("@Operacao", op);

                DataTable table = acesso.ExecutarConsulta(CommandType.Text, "SELECT IdOperacao, Descricao FROM tblOperacao");
                foreach (DataRow linha in table.Rows)
                {
                    Operacao operacao = new Operacao
                    {
                        IdOperacao = Convert.ToInt32(linha["IdOperacao"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };
                    colecao.Add(operacao);
                }
                return colecao;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public SituacaoColecao ComboSituacao(string op)
        {
            SituacaoColecao colecao = new SituacaoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdSituacao", op);
                acesso.AdicionarParametros("@Situacao", op);

                DataTable table = acesso.ExecutarConsulta(CommandType.Text, "SELECT IdSituacao, Situacao FROM tblPedidoSituacao");
                {
                    foreach (DataRow linha in table.Rows)
                    {
                        Situacoes situacao = new Situacoes
                        {
                            IdSituacao = Convert.ToInt32(linha["IdSituacao"]),
                            Situacao = Convert.ToString(linha["Situacao"])
                        };
                        colecao.Add(situacao);
                    }
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
