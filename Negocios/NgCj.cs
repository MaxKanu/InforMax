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
        public string Inserir(PessoaJuridica juridica)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@Nome", juridica.Pessoa.Nome);
            acesso.AdicionarParametros("@PessoaTipo", juridica.Pessoa.PessoaTipo.IdTipo);
            acesso.AdicionarParametros("@Situacao", juridica.Pessoa.Situacao.IdSituacao);//Ficou Faltando
            acesso.AdicionarParametros("@Cadastro", juridica.Pessoa.Cadastro);
            acesso.AdicionarParametros("@Data_Registro", juridica.DataRegistro);
            acesso.AdicionarParametros("@Nome_Fantasia", juridica.NomeFantasia);
            acesso.AdicionarParametros("@CNPJ", juridica.Documentos.CNPJ);
            acesso.AdicionarParametros("@IE", juridica.Documentos.IE);
            acesso.AdicionarParametros("@Rua", juridica.Endereco.Rua);
            acesso.AdicionarParametros("@Numero", juridica.Endereco.Numero);
            acesso.AdicionarParametros("@Complemento1", juridica.Endereco.Complemento1);
            acesso.AdicionarParametros("@Complemento2", juridica.Endereco.Complemento2);
            acesso.AdicionarParametros("@CEP", juridica.Endereco.CEP);
            acesso.AdicionarParametros("@Bairro", juridica.Endereco.Bairro);
            acesso.AdicionarParametros("@Cidade", juridica.Endereco.Cidade);
            acesso.AdicionarParametros("@Estado", juridica.Endereco.UF);
            acesso.AdicionarParametros("@Fixo1", juridica.Telefone.Fixo1);
            acesso.AdicionarParametros("@Fixo2", juridica.Telefone.Fixo2);
            acesso.AdicionarParametros("@Celular1", juridica.Telefone.Celular1);
            acesso.AdicionarParametros("@Celular2", juridica.Telefone.Celular2);
            acesso.AdicionarParametros("@Email1", juridica.Email.Email1);
            acesso.AdicionarParametros("@Email2", juridica.Email.Email2);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspInserirCadastroJuridico").ToString();
            return IdCliente;
        }
        public string Alterar(PessoaJuridica juridica)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdJuridico", juridica.Pessoa.Id);
            acesso.AdicionarParametros("@Situacao", juridica.Pessoa.Situacao.IdSituacao);
            acesso.AdicionarParametros("@Alteracao", juridica.Pessoa.Alteracao);
            acesso.AdicionarParametros("@Nome_Fantasia", juridica.NomeFantasia);
            acesso.AdicionarParametros("@Rua", juridica.Endereco.Rua);
            acesso.AdicionarParametros("@Numero", juridica.Endereco.Numero);
            acesso.AdicionarParametros("@Complemento1", juridica.Endereco.Complemento1);
            acesso.AdicionarParametros("@Complemento2", juridica.Endereco.Complemento2);
            acesso.AdicionarParametros("@Cep", juridica.Endereco.CEP);
            acesso.AdicionarParametros("@Bairro", juridica.Endereco.Bairro);
            acesso.AdicionarParametros("@Cidade", juridica.Endereco.Cidade);
            acesso.AdicionarParametros("@Estado", juridica.Endereco.UF);
            acesso.AdicionarParametros("@Fixo1", juridica.Telefone.Fixo1);
            acesso.AdicionarParametros("@Fixo2", juridica.Telefone.Fixo2);
            acesso.AdicionarParametros("@Celular1", juridica.Telefone.Celular1);
            acesso.AdicionarParametros("@Celular2", juridica.Telefone.Celular2);
            acesso.AdicionarParametros("@Email1", juridica.Email.Email1);
            acesso.AdicionarParametros("@Email2", juridica.Email.Email2);

            string IdCliente = acesso.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlterarJuridico").ToString();
            return IdCliente;
        }

        public string Deletar(PessoaJuridica juridica)
        {
            acesso.LimparParametros();
            acesso.AdicionarParametros("@IdCliente", juridica.Pessoa.Id);

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

                    PessoaJuridica juridica = new PessoaJuridica
                    {
                        Pessoa = new Pessoa()
                    };
                    juridica.Pessoa.PessoaTipo = new PessoaTipo();
                    juridica.Pessoa.Situacao = new Situacoes();
                    juridica.Documentos = new DocumentosJuridicos();
                    juridica.Telefone = new Telefone();
                    juridica.Email = new Email();
                    juridica.Endereco = new Endereco();
                    

                    juridica.Pessoa.Id = Convert.ToInt32(linha["IdJuridico"]);
                    juridica.Pessoa.Nome = Convert.ToString(linha["Nome"]);
                    juridica.NomeFantasia = Convert.ToString(linha["Nome_Fantasia"]);
                    juridica.DataRegistro = Convert.ToDateTime(linha["Data_Registro"]);
                    juridica.Pessoa.Cadastro = Convert.ToDateTime(linha["Cadastro"]);
                    juridica.Documentos.IE = Convert.ToString(linha["IE"]);
                    juridica.Documentos.CNPJ = Convert.ToString(linha["CNPJ"]);
                    juridica.Pessoa.PessoaTipo.Descricao = Convert.ToString(linha["Tipo_Pessoa"]);
                    juridica.Pessoa.Situacao.Situacao = Convert.ToString(linha["Situacao"]);
                    //fisico.Pessoa.Alteracao = Convert.ToDateTime(linha["Alteracao"]);
                    juridica.Endereco.Rua = Convert.ToString(linha["Rua"]);
                    juridica.Endereco.Numero = Convert.ToString(linha["Numero"]);
                    juridica.Endereco.Complemento1 = Convert.ToString(linha["Complemento1"]);
                    juridica.Endereco.Complemento2 = Convert.ToString(linha["Complemento2"]);
                    juridica.Endereco.CEP = Convert.ToString(linha["CEP"]);
                    juridica.Endereco.Bairro = Convert.ToString(linha["Bairro"]);
                    juridica.Endereco.Cidade = Convert.ToString(linha["Cidade"]);
                    juridica.Endereco.UF = Convert.ToString(linha["Estado"]);
                    juridica.Telefone.Fixo1 = Convert.ToString(linha["Fixo1"]);
                    juridica.Telefone.Fixo2 = Convert.ToString(linha["Fixo2"]);
                    juridica.Telefone.Celular1 = Convert.ToString(linha["Celular1"]);
                    juridica.Telefone.Celular2 = Convert.ToString(linha["Celular2"]);
                    juridica.Email.Email1 = Convert.ToString(linha["Email1"]);
                    juridica.Email.Email2 = Convert.ToString(linha["Email2"]);

                    colecao.Add(juridica);
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