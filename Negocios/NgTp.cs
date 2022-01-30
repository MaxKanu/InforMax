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
    public class NgTp
    {
        Asqlbd acesso = new Asqlbd();
        public PessoaTipoColecao CarregarCombo(string tipos)
        {
            PessoaTipoColecao tipoColecao = new PessoaTipoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("", tipos);

                DataTable table = acesso.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblPessoaTipo");
                foreach (DataRow linha in table.Rows)
                {
                    PessoaTipo tipo = new PessoaTipo();
                    tipo.IdTipo = Convert.ToInt32(linha["IdTipoPessoa"]);
                    tipo.Descricao = Convert.ToString(linha["Descricao"]);

                    tipoColecao.Add(tipo);
                }
                return tipoColecao;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public SituacaoColecao CarregarSituacao(string situacao)
        {
            SituacaoColecao situacaoColecao = new SituacaoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("",situacao);
                DataTable table = acesso.ExecutarConsulta(CommandType.Text, "SELECT * FROM tblPessoaSituacao");
                foreach (DataRow linha in table.Rows)
                {
                    Situacoes sit = new Situacoes();
                    sit.IdSituacao = Convert.ToInt32(linha["IdSituacao"]);
                    sit.Situacao = Convert.ToString(linha["Descricao"]);

                    situacaoColecao.Add(sit);
                }
                return situacaoColecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
