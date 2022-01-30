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
    public class NgCj
    {
        Asqlbd acesso = new Asqlbd();
        public string Inserir(PessoaJuridica cliente)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Nome", cliente.Pessoa.Nome);
            acesso.AdicionarParametros("@PessoaTipo", cliente.Pessoa.PessoaTipo.IdTipo);
            acesso.AdicionarParametros("@Situacao", cliente.Pessoa.Situacao.IdSituacao);//Ficou Faltando
            acesso.AdicionarParametros("@Cadastro", cliente.Pessoa.Cadastro);
            acesso.AdicionarParametros("@Data_Registro", cliente.DataRegistro);
            acesso.AdicionarParametros("@Nome_Fantasia", cliente.NomeFantasia);
            acesso.AdicionarParametros("@CNPJ", cliente.Documentos.CNPJ);
            acesso.AdicionarParametros("@IE", cliente.Documentos.IE);
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

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirCadastroJuridico").ToString();
            return IdCliente;
        }
        public string Alterar(PessoaJuridica cliente)
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

        public string Deletar(PessoaJuridica cliente)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdCliente", cliente.Pessoa.Id);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "").ToString();
            return IdCliente;
        }
        public PessoaJuridicaColecao Consultar(int? id, string cliente)
        {
            PessoaJuridicaColecao colecao = new PessoaJuridicaColecao();
            try
            {
                acesso.LimparParametros();
                acesso.AdicionarParametros("@IdJuridico", id);
                acesso.AdicionarParametros("@Nome", cliente);
                DataTable table = acesso.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarJuridicoPorCodigoNome");

                foreach (DataRow linha in table.Rows)
                {

                    PessoaJuridica fisico = new PessoaJuridica
                    {
                        Pessoa = new Pessoa()
                    };
                    fisico.Pessoa.PessoaTipo = new PessoaTipo();
                    fisico.Pessoa.Situacao = new Situacoes();
                    fisico.Documentos = new DocumentosJuridicos();
                    fisico.Telefone = new Telefone();
                    fisico.Email = new Email();
                    fisico.Endereco = new Endereco();
                    

                    fisico.Pessoa.Id = Convert.ToInt32(linha["IdJuridico"]);
                    fisico.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    fisico.NomeFantasia = Convert.ToString(linha["Nome_Fantasia"]);
                    fisico.DataRegistro = Convert.ToDateTime(linha["Data_Registro"]);
                    fisico.Pessoa.Cadastro = Convert.ToDateTime(linha["Cadastro"]);
                    fisico.Documentos.IE = Convert.ToString(linha["IE"]);
                    fisico.Documentos.CNPJ = Convert.ToString(linha["CNPJ"]);
                    fisico.Pessoa.PessoaTipo.Descricao = Convert.ToString(linha["Tipo_Pessoa"]);
                    fisico.Pessoa.Situacao.Situacao = Convert.ToString(linha["Situacao"]);
                    //fisico.Pessoa.Alteracao = Convert.ToDateTime(linha["Alteracao"]);
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