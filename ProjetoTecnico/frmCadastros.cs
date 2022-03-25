using Objetos;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTecnico
{
    public partial class FrmCadastros : Form
    {
        ClienteFisico fisico = new ClienteFisico();
        PessoaJuridica juridica = new PessoaJuridica();
        Funcionarios funcionarios = new Funcionarios();
        PessoaTipoColecao tipocolecao = new PessoaTipoColecao();
        SituacaoColecao situacaoColecao = new SituacaoColecao();

        NgFu negocioFuncionario = new NgFu();
        NgCl negocioCliente = new NgCl();
        NgTp negocioTipo = new NgTp();

        Enumeradores enumSelecionado;
        public FrmCadastros(Enumeradores enumerador, ClienteFisico cliente, Funcionarios funcionarios)
        {
            InitializeComponent();
            enumSelecionado = enumerador;
            PnCadastro.Enabled = false;
            ComboTipo.ValueMember = "IdTipo";
            ComboSituacao.ValueMember = "IdSituacao";
            if (enumerador.Equals(Enumeradores.Fisico))
            {
                lblTitulo.Text = "Cadastro de Clientes";
                LblMatricula.Enabled = false;
                MaskMatricula.Enabled = false;
                ComboTipo.ValueMember = "IdTipo";
                ComboSituacao.ValueMember = "IdSituacao";
                Botoes(1);
            }
            if (enumerador.Equals(Enumeradores.AlterarFisico))
            {
                TxtId.Text = cliente.Pessoa.Id.ToString();
                TxtNome.Text = cliente.Pessoa.Nome;
                DateNascimento.Value = cliente.DataNascimento;
                DateCadastro.Value = cliente.Pessoa.Cadastro;
                ComboSituacao.SelectedValue = cliente.Pessoa.Situacao.IdSituacao.ToString();
                ComboTipo.SelectedValue = cliente.Pessoa.PessoaTipo.IdTipo.ToString();
                MaskCel1.Text = cliente.Telefone.Celular1;
                MaskFixo1.Text = cliente.Telefone.Fixo1;
                MaskCel2.Text = cliente.Telefone.Celular2;
                MaskFixo2.Text = cliente.Telefone.Fixo2;
                TxtEmail1.Text = cliente.Email.Email1;
                TxtEmail2.Text = cliente.Email.Email2;
                MaskRG.Text = cliente.Documentos.RG;
                MaskCPF.Text = cliente.Documentos.CPF;
                TxtRua.Text = cliente.Endereco.Rua;
                TxtNumero.Text = cliente.Endereco.Numero;
                MaskCEP.Text = cliente.Endereco.CEP;
                TxtBairro.Text = cliente.Endereco.Bairro;
                TxtComplemento1.Text = cliente.Endereco.Complemento1;
                TxtComplemento2.Text = cliente.Endereco.Complemento2;
                TxtCidade.Text = cliente.Endereco.Cidade;
                MaskUF.Text = cliente.Endereco.UF;
                Botoes(3);
            }
            if (enumerador.Equals(Enumeradores.ConsultarFisico))
            {

                TxtId.Text = cliente.Pessoa.Id.ToString();
                TxtNome.Text = cliente.Pessoa.Nome;
                DateNascimento.Value = cliente.DataNascimento;
                DateCadastro.Value = cliente.Pessoa.Cadastro;
                ComboSituacao.SelectedValue = cliente.Pessoa.Situacao.IdSituacao.ToString();
                ComboTipo.SelectedValue = cliente.Pessoa.PessoaTipo.IdTipo.ToString();
                MaskCel1.Text = cliente.Telefone.Celular1;
                MaskFixo1.Text = cliente.Telefone.Fixo1;
                MaskCel2.Text = cliente.Telefone.Celular2;
                MaskFixo2.Text = cliente.Telefone.Fixo2;
                TxtEmail1.Text = cliente.Email.Email1;
                TxtEmail2.Text = cliente.Email.Email2;
                MaskRG.Text = cliente.Documentos.RG;
                MaskCPF.Text = cliente.Documentos.CPF;
                TxtRua.Text = cliente.Endereco.Rua;
                TxtNumero.Text = cliente.Endereco.Numero;
                MaskCEP.Text = cliente.Endereco.CEP;
                TxtBairro.Text = cliente.Endereco.Bairro;
                TxtComplemento1.Text = cliente.Endereco.Complemento1;
                TxtComplemento2.Text = cliente.Endereco.Complemento2;
                TxtCidade.Text = cliente.Endereco.Cidade;
                MaskUF.Text = cliente.Endereco.UF;
                Botoes(4);
            }
            if (enumerador.Equals(Enumeradores.Funcionario))
            {
                lblTitulo.Text = "Cadastro de Funcionarios";
                LblMatricula.Enabled = true;
                MaskMatricula.Enabled = true;
                ComboTipo.ValueMember = "IdTipo";
                ComboSituacao.ValueMember = "IdSituacao";
                Botoes(1);
            }
            if (enumerador.Equals(Enumeradores.AlterarFuncionario))
            {
                lblTitulo.Text = "Alterar Dados de Funcionarios";
                ComboTipo.ValueMember = "IdTipo";
                ComboSituacao.ValueMember = "IdSituacao";
                TxtId.Text = funcionarios.Pessoa.Id.ToString();
                TxtNome.Text = funcionarios.Pessoa.Nome;
                DateNascimento.Value = funcionarios.DataNascimento;
                DateCadastro.Value = funcionarios.Pessoa.Cadastro;
                ComboSituacao.SelectedValue = funcionarios.Pessoa.Situacao.IdSituacao.ToString();
                ComboTipo.SelectedValue = funcionarios.Pessoa.PessoaTipo.IdTipo.ToString();
                MaskCel1.Text = funcionarios.Telefone.Celular1;
                MaskFixo1.Text = funcionarios.Telefone.Fixo1;
                MaskCel2.Text = funcionarios.Telefone.Celular2;
                MaskFixo2.Text = funcionarios.Telefone.Fixo2;
                TxtEmail1.Text = funcionarios.Email.Email1;
                TxtEmail2.Text = funcionarios.Email.Email2;
                MaskRG.Text = funcionarios.Documentos.RG;
                MaskCPF.Text = funcionarios.Documentos.CPF;
                MaskMatricula.Text = funcionarios.Documentos.Matricula;
                TxtRua.Text = funcionarios.Endereco.Rua;
                TxtNumero.Text = funcionarios.Endereco.Numero;
                MaskCEP.Text = funcionarios.Endereco.CEP;
                TxtBairro.Text = funcionarios.Endereco.Bairro;
                TxtComplemento1.Text = funcionarios.Endereco.Complemento1;
                TxtComplemento2.Text = funcionarios.Endereco.Complemento2;
                TxtCidade.Text = funcionarios.Endereco.Cidade;
                MaskUF.Text = funcionarios.Endereco.UF;
                Botoes(3);
            }
            if (enumerador.Equals(Enumeradores.ConsultarFuncionario))
            {
                lblTitulo.Text = "Consultar Dados de Funcionarios";
                TxtId.Text = funcionarios.Pessoa.Id.ToString();
                TxtNome.Text = funcionarios.Pessoa.Nome;
                DateNascimento.Value = funcionarios.DataNascimento;
                DateCadastro.Value = funcionarios.Pessoa.Cadastro;
                ComboSituacao.SelectedValue = funcionarios.Pessoa.Situacao.IdSituacao.ToString();
                ComboTipo.SelectedValue = funcionarios.Pessoa.PessoaTipo.IdTipo.ToString();
                MaskCel1.Text = funcionarios.Telefone.Celular1;
                MaskFixo1.Text = funcionarios.Telefone.Fixo1;
                MaskCel2.Text = funcionarios.Telefone.Celular2;
                MaskFixo2.Text = funcionarios.Telefone.Fixo2;
                TxtEmail1.Text = funcionarios.Email.Email1;
                TxtEmail2.Text = funcionarios.Email.Email2;
                MaskRG.Text = funcionarios.Documentos.RG;
                MaskCPF.Text = funcionarios.Documentos.CPF;
                MaskMatricula.Text = funcionarios.Documentos.Matricula;
                TxtRua.Text = funcionarios.Endereco.Rua;
                TxtNumero.Text = funcionarios.Endereco.Numero;
                MaskCEP.Text = funcionarios.Endereco.CEP;
                TxtBairro.Text = funcionarios.Endereco.Bairro;
                TxtComplemento1.Text = funcionarios.Endereco.Complemento1;
                TxtComplemento2.Text = funcionarios.Endereco.Complemento2;
                TxtCidade.Text = funcionarios.Endereco.Cidade;
                MaskUF.Text = funcionarios.Endereco.UF;
                Botoes(4);
            }
        }
        private void Botoes(int op)
        {
            PnCadastro.Enabled = false;
            BtnNovo.Enabled = false;
            BtnAtualizar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnSair.Enabled = false;
            BtnSalvar.Enabled = false;

            if (op.Equals(1))
            {
                PnCadastro.Enabled = false;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnAtualizar.Enabled = false;
                BtnNovo.Enabled = true;
                BtnSair.Enabled = true;
            }
            if (op.Equals(2))
            {
                PnCadastro.Enabled = true;
                BtnSalvar.Enabled = true;
                BtnCancelar.Enabled = false;
                BtnAtualizar.Enabled = false;
                BtnNovo.Enabled = false;
                BtnSair.Enabled = true;
            }
            if (op.Equals(3))
            {
                PnCadastro.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnAtualizar.Enabled = true;
                TxtNome.Enabled = false;
                DateNascimento.Enabled = false;
                ComboTipo.Enabled = false;
                MaskRG.Enabled = false;;
                BtnNovo.Enabled = false;
                BtnSair.Enabled = true;
            }
            if (op.Equals(4))
            {
                PnCadastro.Enabled = false;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnAtualizar.Enabled = false;
                BtnNovo.Enabled = false;
                BtnSair.Enabled = true;
            }
        }
        private void FrmCadastros_Load(object sender, EventArgs e)
        {
            ComboTipo.DataSource = null;
            tipocolecao = negocioTipo.CarregarCombo("");
            ComboTipo.DataSource = tipocolecao;
            ComboTipo.DisplayMember = "Descricao";
            ComboTipo.Refresh();

            ComboSituacao.DataSource = null;
            situacaoColecao = negocioTipo.CarregarSituacao("");
            ComboSituacao.DataSource = situacaoColecao;
            ComboSituacao.DisplayMember = "Situacao";
            ComboSituacao.Refresh();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PnCadastro.Enabled = true;
            Botoes(2);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PnCadastro.Enabled = false;
            Botoes(1);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (enumSelecionado.Equals(Enumeradores.Fisico))
            {
                fisico.Pessoa = new Pessoa
                {
                    PessoaTipo = new PessoaTipo(),
                    Situacao = new Situacoes()
                };
                fisico.Documentos = new Documentos();
                fisico.Telefone = new Telefone();
                fisico.Email = new Email();
                fisico.Endereco = new Endereco();

                fisico.Pessoa.Nome = TxtNome.Text;
                fisico.DataNascimento = DateNascimento.Value;
                fisico.Pessoa.Cadastro = DateCadastro.Value;
                fisico.Pessoa.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
                fisico.Pessoa.PessoaTipo.IdTipo = Convert.ToInt32(ComboTipo.SelectedValue);
                fisico.Telefone.Celular1 = MaskCel1.Text;
                fisico.Telefone.Fixo1 = MaskFixo1.Text;
                fisico.Telefone.Celular2 = MaskCel2.Text;
                fisico.Telefone.Fixo2 = MaskFixo2.Text;
                fisico.Email.Email1 = TxtEmail1.Text;
                fisico.Email.Email2 = TxtEmail2.Text;
                fisico.Documentos.RG = MaskRG.Text;
                fisico.Documentos.CPF = MaskCPF.Text;
                fisico.Endereco.Rua = TxtRua.Text;
                fisico.Endereco.Numero = TxtNumero.Text;
                fisico.Endereco.CEP = MaskCEP.Text;
                fisico.Endereco.Bairro = TxtBairro.Text;
                fisico.Endereco.Complemento1 = TxtComplemento1.Text;
                fisico.Endereco.Complemento2 = TxtComplemento2.Text;
                fisico.Endereco.Cidade = TxtCidade.Text;
                fisico.Endereco.UF = MaskUF.Text;

                string retorno = negocioCliente.Inserir(fisico);
                try
                {
                    int IdCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente inserido com sucesso! \n\n O codigo gerado foi : " + retorno.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {

                    throw;
                }
            }
            if (enumSelecionado.Equals(Enumeradores.Funcionario))
            {
                funcionarios.Pessoa = new Pessoa
                {
                    PessoaTipo = new PessoaTipo(),
                    Situacao = new Situacoes()
                };
                funcionarios.Documentos = new Documentos();
                funcionarios.Telefone = new Telefone();
                funcionarios.Email = new Email();
                funcionarios.Endereco = new Endereco();

                funcionarios.Pessoa.Nome = TxtNome.Text;
                funcionarios.DataNascimento = DateNascimento.Value;
                funcionarios.Pessoa.Cadastro = DateCadastro.Value;
                funcionarios.Pessoa.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
                funcionarios.Pessoa.PessoaTipo.IdTipo = Convert.ToInt32(ComboTipo.SelectedValue);
                funcionarios.Telefone.Celular1 = MaskCel1.Text;
                funcionarios.Telefone.Fixo1 = MaskFixo1.Text;
                funcionarios.Telefone.Celular2 = MaskCel2.Text;
                funcionarios.Telefone.Fixo2 = MaskFixo2.Text;
                funcionarios.Email.Email1 = TxtEmail1.Text;
                funcionarios.Email.Email2 = TxtEmail2.Text;
                funcionarios.Documentos.RG = MaskRG.Text;
                funcionarios.Documentos.CPF = MaskCPF.Text;
                funcionarios.Documentos.Matricula = MaskMatricula.Text;
                funcionarios.Endereco.Rua = TxtRua.Text;
                funcionarios.Endereco.Numero = TxtNumero.Text;
                funcionarios.Endereco.CEP = MaskCEP.Text;
                funcionarios.Endereco.Bairro = TxtBairro.Text;
                funcionarios.Endereco.Complemento1 = TxtComplemento1.Text;
                funcionarios.Endereco.Complemento2 = TxtComplemento2.Text;
                funcionarios.Endereco.Cidade = TxtCidade.Text;
                funcionarios.Endereco.UF = MaskUF.Text;

                string retorno = negocioFuncionario.Inserir(funcionarios);
                try
                {
                    int IdFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show("Funcionario inserido com sucesso! \n\n O codigo gerado foi :  " + retorno.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void PnCadastro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            if (enumSelecionado.Equals(Enumeradores.AlterarFisico))
            {
                fisico.Pessoa = new Pessoa
                {
                    PessoaTipo = new PessoaTipo(),
                    Situacao = new Situacoes()
                };
                fisico.Documentos = new Documentos();
                fisico.Telefone = new Telefone();
                fisico.Email = new Email();
                fisico.Endereco = new Endereco();

                fisico.Pessoa.Id = Convert.ToInt32(TxtId.Text);
                //fisico.Pessoa.Nome = TxtNome.Text;
                //fisico.DataNascimento = DateNascimento.Value;
                fisico.Pessoa.Alteracao = DateCadastro.Value;
                fisico.Pessoa.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
                //fisico.Pessoa.PessoaTipo.IdTipo = Convert.ToInt32(ComboTipo.SelectedValue);
                fisico.Telefone.Celular1 = MaskCel1.Text;
                fisico.Telefone.Fixo1 = MaskFixo1.Text;
                fisico.Telefone.Celular2 = MaskCel2.Text;
                fisico.Telefone.Fixo2 = MaskFixo2.Text;
                fisico.Email.Email1 = TxtEmail1.Text;
                fisico.Email.Email2 = TxtEmail2.Text;
                //fisico.Documentos.RG = MaskRG.Text;
                //fisico.Documentos.CPF = MaskCPF.Text;
                fisico.Endereco.Rua = TxtRua.Text;
                fisico.Endereco.Numero = TxtNumero.Text;
                fisico.Endereco.CEP = MaskCEP.Text;
                fisico.Endereco.Bairro = TxtBairro.Text;
                fisico.Endereco.Complemento1 = TxtComplemento1.Text;
                fisico.Endereco.Complemento2 = TxtComplemento2.Text;
                fisico.Endereco.Cidade = TxtCidade.Text;
                fisico.Endereco.UF = MaskUF.Text;

                string retorno = negocioCliente.Alterar(fisico);
                try
                {
                    int IdCliente = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente alterado com sucesso! \n\n O codigo alterado foi : " + retorno.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (enumSelecionado.Equals(Enumeradores.AlterarFuncionario))
            {
                funcionarios.Pessoa = new Pessoa
                {
                    PessoaTipo = new PessoaTipo(),
                    Situacao = new Situacoes()
                };
                funcionarios.Documentos = new Documentos();
                funcionarios.Email = new Email();
                funcionarios.Endereco = new Endereco();
                funcionarios.Telefone = new Telefone();

                funcionarios.Pessoa.Id = Convert.ToInt32(TxtId.Text);
                //funcionarios.Pessoa.Nome = TxtNome.Text;
                //funcionarios.DataNascimento = DateNascimento.Value;
                //funcionarios.Pessoa.PessoaTipo.IdTipo = Convert.ToInt32(ComboTipo.SelectedValue);
                //funcionarios.Documentos.RG = MaskRG.Text;
                //funcionarios.Documentos.CPF = MaskCPF.Text;
                funcionarios.Pessoa.Alteracao = DateCadastro.Value;
                funcionarios.Pessoa.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
                funcionarios.Telefone.Celular1 = MaskCel1.Text;
                funcionarios.Telefone.Fixo1 = MaskFixo1.Text;
                funcionarios.Telefone.Celular2 = MaskCel2.Text;
                funcionarios.Telefone.Fixo2 = MaskFixo2.Text;
                funcionarios.Email.Email1 = TxtEmail1.Text;
                funcionarios.Email.Email2 = TxtEmail2.Text;
                funcionarios.Endereco.Rua = TxtRua.Text;
                funcionarios.Endereco.Numero = TxtNumero.Text;
                funcionarios.Endereco.CEP = MaskCEP.Text;
                funcionarios.Endereco.Bairro = TxtBairro.Text;
                funcionarios.Endereco.Complemento1 = TxtComplemento1.Text;
                funcionarios.Endereco.Complemento2 = TxtComplemento2.Text;
                funcionarios.Endereco.Cidade = TxtCidade.Text;
                funcionarios.Endereco.UF = MaskUF.Text;

                string retorno = negocioFuncionario.Alterar(funcionarios);
                try
                {
                    int IdFuncionario = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente alterado com sucesso! \n\n O codigo alterado foi : " + retorno.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void PnBotoes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
