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
    public class NgFu
    {
        Asqlbd acesso = new Asqlbd();
        public string Inserir(Funcionarios funcionarios)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Nome", funcionarios.Pessoa.Nome);
            acesso.AdicionarParametros("@PessoaTipo", funcionarios.Pessoa.PessoaTipo.IdTipo);
            acesso.AdicionarParametros("@Situacao", funcionarios.Pessoa.Situacao.IdSituacao);//Ficou Faltando
            acesso.AdicionarParametros("@Cadastro", funcionarios.Pessoa.Cadastro);
            acesso.AdicionarParametros("@Data_Nascimento", funcionarios.DataNascimento);
            acesso.AdicionarParametros("@RG", funcionarios.Documentos.RG);
            acesso.AdicionarParametros("@CPF", funcionarios.Documentos.CPF);
            acesso.AdicionarParametros("@Matricula", funcionarios.Documentos.Matricula);
            acesso.AdicionarParametros("@Rua", funcionarios.Endereco.Rua);
            acesso.AdicionarParametros("@Numero", funcionarios.Endereco.Numero);
            acesso.AdicionarParametros("@Complemento1", funcionarios.Endereco.Complemento1);
            acesso.AdicionarParametros("@Complemento2", funcionarios.Endereco.Complemento2);
            acesso.AdicionarParametros("@CEP", funcionarios.Endereco.CEP);
            acesso.AdicionarParametros("@Bairro", funcionarios.Endereco.Bairro);
            acesso.AdicionarParametros("@Cidade", funcionarios.Endereco.Cidade);
            acesso.AdicionarParametros("@Estado", funcionarios.Endereco.UF);
            acesso.AdicionarParametros("@Fixo1", funcionarios.Telefone.Fixo1);
            acesso.AdicionarParametros("@Fixo2", funcionarios.Telefone.Fixo2);
            acesso.AdicionarParametros("@Celular1", funcionarios.Telefone.Celular1);
            acesso.AdicionarParametros("@Celular2", funcionarios.Telefone.Celular2);
            acesso.AdicionarParametros("@Email1", funcionarios.Email.Email1);
            acesso.AdicionarParametros("@Email2", funcionarios.Email.Email2);
            

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirCadastroFuncionario").ToString();
            return IdCliente;
        }
        public string Alterar(Funcionarios funcionarios)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdFuncionario", funcionarios.Pessoa.Id);
            acesso.AdicionarParametros("@Situacao", funcionarios.Pessoa.Situacao.IdSituacao);
            acesso.AdicionarParametros("@Alteracao", funcionarios.Pessoa.Alteracao);
            acesso.AdicionarParametros("@Rua", funcionarios.Endereco.Rua);
            acesso.AdicionarParametros("@Numero", funcionarios.Endereco.Numero);
            acesso.AdicionarParametros("@Complemento1", funcionarios.Endereco.Complemento1);
            acesso.AdicionarParametros("@Complemento2", funcionarios.Endereco.Complemento2);
            acesso.AdicionarParametros("@Cep", funcionarios.Endereco.CEP);
            acesso.AdicionarParametros("@Bairro", funcionarios.Endereco.Bairro);
            acesso.AdicionarParametros("@Cidade", funcionarios.Endereco.Cidade);
            acesso.AdicionarParametros("@Estado", funcionarios.Endereco.UF);
            acesso.AdicionarParametros("@Fixo1", funcionarios.Telefone.Fixo1);
            acesso.AdicionarParametros("@Fixo2", funcionarios.Telefone.Fixo2);
            acesso.AdicionarParametros("@Celular1", funcionarios.Telefone.Celular1);
            acesso.AdicionarParametros("@Celular2", funcionarios.Telefone.Celular2);
            acesso.AdicionarParametros("@Email1", funcionarios.Email.Email1);
            acesso.AdicionarParametros("@Email2", funcionarios.Email.Email2);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarFuncionario").ToString();
            return IdCliente;
        }

        public string Deletar(Funcionarios funcionarios)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdClente", funcionarios.Pessoa.Id);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
            return IdCliente;
        }
        public FuncionariosColecao Consultar(int? id, string cliente)
        {
            FuncionariosColecao colecao = new FuncionariosColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdFuncionario", id);
                acesso.AdicionarParametros("@Nome", cliente);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarFuncionarioPorCodigoNome");

                foreach (DataRow linha in table.Rows)
                {

                    Funcionarios funcionarios = new Funcionarios();
                    funcionarios.Pessoa = new Pessoa();
                    funcionarios.Pessoa.PessoaTipo = new PessoaTipo();
                    funcionarios.Pessoa.Situacao = new Situacoes();
                    funcionarios.Documentos = new Documentos();
                    funcionarios.Telefone = new Telefone();
                    funcionarios.Email = new Email();
                    funcionarios.Endereco = new Endereco();

                    funcionarios.Pessoa.Id = Convert.ToInt32(linha["IdFuncionario"]);
                    funcionarios.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    funcionarios.Pessoa.PessoaTipo.Descricao = Convert.ToString(linha["Tipo_Pessoa"]);
                    funcionarios.Pessoa.Situacao.Situacao = Convert.ToString(linha["Situacao"]);
                    funcionarios.Pessoa.Cadastro = Convert.ToDateTime(linha["Cadastro"]);
                    funcionarios.DataNascimento = Convert.ToDateTime(linha["Data_Nascimento"]);
                    funcionarios.Documentos.RG = Convert.ToString(linha["RG"]);
                    funcionarios.Documentos.CPF = Convert.ToString(linha["CPF"]);
                    funcionarios.Documentos.Matricula = Convert.ToString(linha["Matricula"]);
                    funcionarios.Endereco.Rua = Convert.ToString(linha["Rua"]);
                    funcionarios.Endereco.Numero = Convert.ToString(linha["Numero"]);
                    funcionarios.Endereco.Complemento1 = Convert.ToString(linha["Complemento1"]);
                    funcionarios.Endereco.Complemento2 = Convert.ToString(linha["Complemento2"]);
                    funcionarios.Endereco.CEP = Convert.ToString(linha["CEP"]);
                    funcionarios.Endereco.Bairro = Convert.ToString(linha["Bairro"]);
                    funcionarios.Endereco.Cidade = Convert.ToString(linha["Cidade"]);
                    funcionarios.Endereco.UF = Convert.ToString(linha["Estado"]);
                    funcionarios.Telefone.Fixo1 = Convert.ToString(linha["Fixo1"]);
                    funcionarios.Telefone.Fixo2 = Convert.ToString(linha["Fixo2"]);
                    funcionarios.Telefone.Celular1 = Convert.ToString(linha["Celular1"]);
                    funcionarios.Telefone.Celular2 = Convert.ToString(linha["Celular2"]);
                    funcionarios.Email.Email1 = Convert.ToString(linha["Email1"]);
                    funcionarios.Email.Email2 = Convert.ToString(linha["Email2"]);

                    colecao.Add(funcionarios);
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
