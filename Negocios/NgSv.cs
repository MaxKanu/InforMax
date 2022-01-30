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
    public class NgSv
    {
        Asqlbd acesso = new Asqlbd();
        public string Inserir(Servicos servicos)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Descricao", servicos.Descricao);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirServicos").ToString();
            return IdCliente;
        }
        public ServicosColecao Consultar(int? id, string fab)
        {
            ServicosColecao colecao = new ServicosColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdServicos", id);
                acesso.AdicionarParametros("@Descricao", fab);
                //DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdFabricante, Descricao FROM tblFabricante");
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarServico");

                foreach (DataRow linha in table.Rows)
                {
                    Servicos prod = new Servicos { 
                        IdServicos = Convert.ToInt32(linha["IdServicos"]),
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
        public ServicosColecao Combo(string serv)
        {
            ServicosColecao colecao = new ServicosColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdServicos", serv);
                acesso.AdicionarParametros("@Descricao", serv);
                DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdServicos, Descricao FROM  tblServicos");
                //DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspComboServico");

                foreach (DataRow linha in table.Rows)
                {
                    Servicos prod = new Servicos
                    {
                        IdServicos = Convert.ToInt32(linha["IdServicos"]),
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
    }
}
