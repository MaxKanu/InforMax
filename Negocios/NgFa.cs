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
    public class NgFa
    {
        Asqlbd acesso = new Asqlbd();
        public string InserirMarca(Fabricante fabri)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Descricao", fabri.Descricao);
            string IdMarca = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirMarca").ToString();
            return IdMarca;
        }
        public string Inserir(Fabricante fabricante)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Descricao", fabricante.Descricao);

            string IdFabricante = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirFabricante").ToString();
            return IdFabricante;
        }
        public FabricanteColecao Consultar(int? id, string fab)
        {
            FabricanteColecao colecao = new FabricanteColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdFabricante", id);
                acesso.AdicionarParametros("@Descricao", fab);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarFabricante");

                foreach (DataRow linha in table.Rows)
                {
                    Fabricante fabri = new Fabricante
                    {
                        IdFabricante = Convert.ToInt32(linha["IdFabricante"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };
                    colecao.Add(fabri);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public FabricanteColecao ComboFabri(string fab)
        {
            FabricanteColecao colecao = new FabricanteColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdFabricante", fab);
                acesso.AdicionarParametros("@Descricao", fab);
                DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdFabricante, Descricao FROM tblFabricante");
                //DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarFabricante");

                foreach (DataRow linha in table.Rows)
                {
                    Fabricante fabri = new Fabricante
                    {
                        IdFabricante = Convert.ToInt32(linha["IdFabricante"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };
                    colecao.Add(fabri);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public FabricanteColecao ComboMarca(string fab)
        {
            FabricanteColecao colecao = new FabricanteColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdFabricante", fab);
                acesso.AdicionarParametros("@Descricao", fab);
                DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdMarca, Descricao FROM tblMarca");
                //DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarFabricante");

                foreach (DataRow linha in table.Rows)
                {
                    Fabricante fabri = new Fabricante
                    {
                        IdFabricante = Convert.ToInt32(linha["IdMarca"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };
                    colecao.Add(fabri);
                }
                return colecao;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public FabricanteColecao ComboAparelho(string fab)
        {
            FabricanteColecao colecao = new FabricanteColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdFabricante", fab);
                acesso.AdicionarParametros("@Descricao", fab);
                DataTable table = acesso.ExecutarConsulta(CommandType.Text, " SELECT IdTipoAparelho, Descricao FROM tblTipoAparelho");
                //DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarFabricante");

                foreach (DataRow linha in table.Rows)
                {
                    Fabricante fabri = new Fabricante
                    {
                        IdFabricante = Convert.ToInt32(linha["IdTipoAparelho"]),
                        Descricao = Convert.ToString(linha["Descricao"])
                    };
                    colecao.Add(fabri);
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
