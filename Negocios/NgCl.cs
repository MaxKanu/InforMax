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
    public class NgCl
    {
        Asqlbd acesso = new Asqlbd();
        public string Inserir(ClienteFisico cliente)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Nome", cliente.Pessoa.Nome);
            acesso.AdicionarParametros("@PessoaTipo", cliente.Pessoa.PessoaTipo.IdTipo);
            acesso.AdicionarParametros("@Situacao", cliente.Pessoa.Situacao.IdSituacao);//Ficou Faltando
            acesso.AdicionarParametros("@Cadastro", cliente.Pessoa.Cadastro);
            acesso.AdicionarParametros("@Data_Nascimento", cliente.DataNascimento);
            acesso.AdicionarParametros("@RG", cliente.Documentos.RG);
            acesso.AdicionarParametros("@CPF", cliente.Documentos.CPF);
            acesso.AdicionarParametros("@Rua", cliente.Endereco.Rua);
            acesso.AdicionarParametros("@Numero", cliente.Endereco.Numero);
            acesso.AdicionarParametros("@Complemento1", cliente.Endereco.Complemento1);
            acesso.AdicionarParametros("@Complemento2", cliente.Endereco.Complemento2);
            acesso.AdicionarParametros("@CEP", cliente.Endereco.CEP);
            acesso.AdicionarParametros("@Bairro", cliente.Endereco.Bairro);
            acesso.AdicionarParametros("@Cidade", cliente.Endereco.Cidade);
            acesso.AdicionarParametros("@Estado", cliente.Endereco.UF);
            acesso.AdicionarParametros("@Fixo1", cliente.Telefone.Fixo1);
            acesso.AdicionarParametros("@Fixo2", cliente.Telefone.Fixo2);
            acesso.AdicionarParametros("@Celular1", cliente.Telefone.Celular1);
            acesso.AdicionarParametros("@Celular2", cliente.Telefone.Celular2);
            acesso.AdicionarParametros("@Email1", cliente.Email.Email1);
            acesso.AdicionarParametros("@Email2", cliente.Email.Email2);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirCadastroFisico").ToString();
            return IdCliente;
        }
        public string Alterar(ClienteFisico cliente)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdCliente", cliente.Pessoa.Id);
            //acesso.AdicionarParametros("@Nome", cliente.Pessoa.Nome);
            //acesso.AdicionarParametros("@TipoPessoa", cliente.Pessoa.PessoaTipo.IdTipo);
            acesso.AdicionarParametros("@Situacao", cliente.Pessoa.Situacao.IdSituacao);
            //acesso.AdicionarParametros("@Cadastro", cliente.Pessoa.Cadastro);
            acesso.AdicionarParametros("@Alteracao", cliente.Pessoa.Cadastro);
            //acesso.AdicionarParametros("@DataNascimento", cliente.DataNascimento);
            //acesso.AdicionarParametros("@RG", cliente.Documentos.RG);
            //acesso.AdicionarParametros("@CPF", cliente.Documentos.CPF);
            acesso.AdicionarParametros("@Rua", cliente.Endereco.Rua);
            acesso.AdicionarParametros("@Numero", cliente.Endereco.Numero);
            acesso.AdicionarParametros("@Complemento1", cliente.Endereco.Complemento1);
            acesso.AdicionarParametros("@Complemento2", cliente.Endereco.Complemento2);
            acesso.AdicionarParametros("@Cep", cliente.Endereco.CEP);
            acesso.AdicionarParametros("@Bairro", cliente.Endereco.Bairro);
            acesso.AdicionarParametros("@Cidade", cliente.Endereco.Cidade);
            acesso.AdicionarParametros("@Estado", cliente.Endereco.UF);
            acesso.AdicionarParametros("@Fixo1", cliente.Telefone.Fixo1);
            acesso.AdicionarParametros("@Fixo2", cliente.Telefone.Fixo2);
            acesso.AdicionarParametros("@Celular1", cliente.Telefone.Celular1);
            acesso.AdicionarParametros("@Celular2", cliente.Telefone.Celular2);
            acesso.AdicionarParametros("@Email1", cliente.Email.Email1);
            acesso.AdicionarParametros("@Email2", cliente.Email.Email2);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarFisico").ToString();
            return IdCliente;
        }

        public string Deletar(ClienteFisico cliente)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdCliente", cliente.Pessoa.Id);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
            return IdCliente;
        }
        public ClienteFisicoColecao Consultar(int? id, string cliente)
        {
            ClienteFisicoColecao colecao = new ClienteFisicoColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdCliente", id);
                acesso.AdicionarParametros("@Nome", cliente);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarClientePorCodigoNome");

                foreach (DataRow linha in table.Rows)
                {

                    ClienteFisico fisico = new ClienteFisico
                    {
                        Pessoa = new Pessoa()
                    };
                    fisico.Pessoa.PessoaTipo = new PessoaTipo();
                    fisico.Pessoa.Situacao = new Situacoes();
                    fisico.Documentos = new Documentos();
                    fisico.Telefone = new Telefone();
                    fisico.Email = new Email();
                    fisico.Endereco = new Endereco();

                    fisico.Pessoa.Id = Convert.ToInt32(linha["IdCliente"]);
                    fisico.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    fisico.Pessoa.PessoaTipo.Descricao = Convert.ToString(linha["Tipo_Pessoa"]);
                    fisico.Pessoa.Situacao.Situacao = Convert.ToString(linha["Situacao"]);
                    fisico.Pessoa.Cadastro = Convert.ToDateTime(linha["Cadastro"]);
                    //fisico.Pessoa.Alteracao = Convert.ToDateTime(linha["Alteracao"]);
                    fisico.DataNascimento = Convert.ToDateTime(linha["Data_Nascimento"]);
                    fisico.Documentos.RG = Convert.ToString(linha["RG"]);
                    fisico.Documentos.CPF = Convert.ToString(linha["CPF"]);
                    fisico.Endereco.Rua = Convert.ToString(linha["Rua"]);
                    fisico.Endereco.Numero = Convert.ToString(linha["Numero"]);
                    fisico.Endereco.Complemento1 = Convert.ToString(linha["Complemento1"]);
                    fisico.Endereco.Complemento2 = Convert.ToString(linha["Complemento2"]);
                    fisico.Endereco.CEP = Convert.ToString(linha["CEP"]);
                    fisico.Endereco.Bairro = Convert.ToString(linha["Bairro"]);
                    fisico.Endereco.Cidade = Convert.ToString(linha["Cidade"]);
                    fisico.Endereco.UF = Convert.ToString(linha["Estado"]);
                    fisico.Telefone.Fixo1 = Convert.ToString(linha["Fixo1"]);
                    fisico.Telefone.Fixo2 = Convert.ToString(linha["Fixo2"]);
                    fisico.Telefone.Celular1 = Convert.ToString(linha["Celular1"]);
                    fisico.Telefone.Celular2 = Convert.ToString(linha["Celular2"]);
                    fisico.Email.Email1 = Convert.ToString(linha["Email1"]);
                    fisico.Email.Email2 = Convert.ToString(linha["Email2"]);

                    colecao.Add(fisico);
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
