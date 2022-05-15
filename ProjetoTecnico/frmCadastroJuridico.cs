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
    public partial class frmCadastroJuridico : Form
    {
        PessoaJuridica juridica = new PessoaJuridica();
        PessoaTipoColecao tipocolecao = new PessoaTipoColecao();
        SituacaoColecao situacaoColecao = new SituacaoColecao();

        NgCj negociJuridico = new NgCj();
        NgTp negocioTipo = new NgTp();

        Enumeradores enumSelecionado;
        public frmCadastroJuridico(Enumeradores enumerador, PessoaJuridica cliente)
        {
            InitializeComponent();
            enumSelecionado = enumerador;
            PnCadastro.Enabled = false;
            ComboTipo.ValueMember = "IdTipo";
            ComboSituacao.ValueMember = "IdSituacao";
            if (enumerador.Equals(Enumeradores.Juridico))
            {
                lblTitulo.Text = "Cadastro de Cliente Juridico";
                Botoes(1);
            }
            if (enumerador.Equals(Enumeradores.AlterarJuridico))
            {
                lblTitulo.Text = "Atualização de Cliente Juridico";
                TxtId.Text = cliente.Pessoa.Id.ToString();
                TxtNome.Text = cliente.Pessoa.Nome;
                TxtNomeFantasia.Text = cliente.NomeFantasia;
                DateNascimento.Value = cliente.DataRegistro;
                DateCadastro.Value = cliente.Pessoa.Cadastro;
                ComboSituacao.SelectedValue = cliente.Pessoa.Situacao.IdSituacao.ToString();
                ComboTipo.SelectedValue = cliente.Pessoa.PessoaTipo.IdTipo.ToString();
                MaskCel1.Text = cliente.Telefone.Celular1;
                MaskFixo1.Text = cliente.Telefone.Fixo1;
                MaskCel2.Text = cliente.Telefone.Celular2;
                MaskFixo2.Text = cliente.Telefone.Fixo2;
                TxtEmail1.Text = cliente.Email.Email1;
                TxtEmail2.Text = cliente.Email.Email2;
                MaskIE.Text = cliente.Documentos.IE;
                MaskCNPJ.Text = cliente.Documentos.CNPJ;
                TxtRua.Text = cliente.Endereco.Rua;
                TxtNumero.Text = cliente.Endereco.Numero;
                MaskCEP.Text = cliente.Endereco.CEP;
                TxtBairro.Text = cliente.Endereco.Bairro;
                TxtComplemento1.Text = cliente.Endereco.Complemento1;
                TxtComplemento2.Text = cliente.Endereco.Complemento2;
                TxtCidade.Text = cliente.Endereco.Cidade;
                MaskUF.Text = cliente.Endereco.UF;
                DateCadastro.Enabled = false;
                DateNascimento.Enabled = false;
                TxtNome.Enabled = false;
                MaskCNPJ.Enabled = false;
                MaskIE.Enabled = false;
                Botoes(3);
            }
            if (enumerador.Equals(Enumeradores.ConsultarJuridico))
            {
                lblTitulo.Text = "Consultar Cliente Juridico";
                TxtId.Text = cliente.Pessoa.Id.ToString();
                TxtNome.Text = cliente.Pessoa.Nome;
                TxtNomeFantasia.Text = cliente.NomeFantasia;
                DateNascimento.Value = cliente.DataRegistro;
                DateCadastro.Value = cliente.Pessoa.Cadastro;
                ComboSituacao.SelectedValue = cliente.Pessoa.Situacao.IdSituacao.ToString();
                ComboTipo.SelectedValue = cliente.Pessoa.PessoaTipo.IdTipo.ToString();
                MaskCel1.Text = cliente.Telefone.Celular1;
                MaskFixo1.Text = cliente.Telefone.Fixo1;
                MaskCel2.Text = cliente.Telefone.Celular2;
                MaskFixo2.Text = cliente.Telefone.Fixo2;
                TxtEmail1.Text = cliente.Email.Email1;
                TxtEmail2.Text = cliente.Email.Email2;
                MaskIE.Text = cliente.Documentos.IE;
                MaskCNPJ.Text = cliente.Documentos.CNPJ;
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
        }
        void Botoes(int op)
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
                BtnCancelar.Enabled = true;
                BtnAtualizar.Enabled = false;
                BtnNovo.Enabled = false;
                BtnSair.Enabled = true;
                ComboTipo.Enabled = false;
                TxtNome.Enabled = false;
                DateNascimento.Enabled = false;
                MaskIE.Enabled = false;
                MaskCNPJ.Enabled = false;
            }
            if (op.Equals(3))
            {
                PnCadastro.Enabled = true;
                BtnSalvar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnAtualizar.Enabled = true;
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
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCadastroJuridico_Load(object sender, EventArgs e)
        {
            ToolTip nomeObjeto = new ToolTip();

            nomeObjeto.AutoPopDelay = 5000;
            nomeObjeto.InitialDelay = 100;
            nomeObjeto.ReshowDelay = 100;
            nomeObjeto.ShowAlways = true;

            nomeObjeto.SetToolTip(this.BtnAtualizar, "Atualizar");
            nomeObjeto.SetToolTip(this.BtnCancelar, "Cancelar Cadastro");
            nomeObjeto.SetToolTip(this.BtnSair, "Fechar");
            nomeObjeto.SetToolTip(this.BtnNovo, "Novo Cadastro");
            nomeObjeto.SetToolTip(this.BtnSalvar, "Salvar Cliente");

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

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PnCadastro.Enabled = true;
            Botoes(2);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            juridica.Pessoa = new Pessoa();
            juridica.Pessoa.PessoaTipo = new PessoaTipo();
            juridica.Pessoa.Situacao = new Situacoes();
            juridica.Documentos = new DocumentosJuridicos();
            juridica.Telefone = new Telefone();
            juridica.Email = new Email();
            juridica.Endereco = new Endereco();

            juridica.Pessoa.Nome = TxtNome.Text;
            juridica.DataRegistro = DateNascimento.Value;
            juridica.NomeFantasia = TxtNomeFantasia.Text;
            juridica.Pessoa.Cadastro = DateCadastro.Value;
            juridica.Pessoa.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
            juridica.Pessoa.PessoaTipo.IdTipo = Convert.ToInt32(ComboTipo.SelectedValue);
            juridica.Telefone.Celular1 = MaskCel1.Text;
            juridica.Telefone.Fixo1 = MaskFixo1.Text;
            juridica.Telefone.Celular2 = MaskCel2.Text;
            juridica.Telefone.Fixo2 = MaskFixo2.Text;
            juridica.Email.Email1 = TxtEmail1.Text;
            juridica.Email.Email2 = TxtEmail2.Text;
            juridica.Documentos.IE = MaskIE.Text;
            juridica.Documentos.CNPJ = MaskCNPJ.Text;
            juridica.Endereco.Rua = TxtRua.Text;
            juridica.Endereco.Numero = TxtNumero.Text;
            juridica.Endereco.CEP = MaskCEP.Text;
            juridica.Endereco.Bairro = TxtBairro.Text;
            juridica.Endereco.Complemento1 = TxtComplemento1.Text;
            juridica.Endereco.Complemento2 = TxtComplemento2.Text;
            juridica.Endereco.Cidade = TxtCidade.Text;
            juridica.Endereco.UF = MaskUF.Text;

            string retorno = negociJuridico.Inserir(juridica);
            try
            {
                int IdCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente inserido com sucesso! \n\n O codigo gerado foi : " + retorno.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Botoes(1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {

            juridica.Pessoa = new Pessoa();
            juridica.Pessoa.PessoaTipo = new PessoaTipo();
            juridica.Pessoa.Situacao = new Situacoes();
            juridica.Documentos = new DocumentosJuridicos();
            juridica.Telefone = new Telefone();
            juridica.Email = new Email();
            juridica.Endereco = new Endereco();

            juridica.Pessoa.Id = Convert.ToInt32(TxtId.Text);
            juridica.Pessoa.Alteracao = DateCadastro.Value;
            juridica.Pessoa.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
            //juridica.Pessoa.PessoaTipo.IdTipo = Convert.ToInt32(ComboTipo.SelectedValue);
            //juridica.Pessoa.Nome = TxtNome.Text;
            //juridica.DataNascimento = DateNascimento.Value;
            //juridica.Documentos.RG = MaskRG.Text;
            //juridica.Documentos.CPF = MaskCPF.Text;
            juridica.NomeFantasia = TxtNomeFantasia.Text;
            juridica.Telefone.Celular1 = MaskCel1.Text;
            juridica.Telefone.Fixo1 = MaskFixo1.Text;
            juridica.Telefone.Celular2 = MaskCel2.Text;
            juridica.Telefone.Fixo2 = MaskFixo2.Text;
            juridica.Email.Email1 = TxtEmail1.Text;
            juridica.Email.Email2 = TxtEmail2.Text;
            juridica.Endereco.Rua = TxtRua.Text;
            juridica.Endereco.Numero = TxtNumero.Text;
            juridica.Endereco.CEP = MaskCEP.Text;
            juridica.Endereco.Bairro = TxtBairro.Text;
            juridica.Endereco.Complemento1 = TxtComplemento1.Text;
            juridica.Endereco.Complemento2 = TxtComplemento2.Text;
            juridica.Endereco.Cidade = TxtCidade.Text;
            juridica.Endereco.UF = MaskUF.Text;

            string retorno = negociJuridico.Alterar(juridica);
            try
            {
                int IdCliente = Convert.ToInt32(retorno);
                MessageBox.Show("Cliente alterado com sucesso! \n\n O codigo alterado foi : " + retorno.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Botoes(1);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Botoes(1);
        }
    }
}
