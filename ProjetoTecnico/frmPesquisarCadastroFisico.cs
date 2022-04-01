using Objetos;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTecnico
{
    public partial class frmPesquisarCadastroFisico : Form
    {
        public Pedidos pedidoSelecionado;
        public ClienteFisico clienteSelecionado;
        public Funcionarios colaboradorSelecionado;
        public PessoaJuridica juridicoSelecionado;

        //Objetos
        PessoaJuridica juridica = new PessoaJuridica();
        PessoaJuridicaColecao colecaoJuridica = new PessoaJuridicaColecao();
        ClienteFisico cliente = new ClienteFisico();
        ClienteFisicoColecao colecao = new ClienteFisicoColecao();
        Funcionarios funcionarios = new Funcionarios();
        FuncionariosColecao colecaoFuncionarios = new FuncionariosColecao();
        
        //Negocios
        NgCl negocioCliente = new NgCl();
        NgFu negocioFuncionario = new NgFu();
        NgCj negocioJuridico = new NgCj();
        
        Acao_Tela enumSelecionado;
        public frmPesquisarCadastroFisico(Acao_Tela enumeradores)
        {
            InitializeComponent();
            enumSelecionado = enumeradores;
            dgwPrincipal.AutoGenerateColumns = false;
            //Recebe o controle da tela de menu
            if (enumeradores.Equals(Acao_Tela.ConsultarFuncionario))
            {
                Botoes(2);
            }
            if (enumeradores.Equals(Acao_Tela.ConsultarCliente))
            {
                Botoes(1);
            }
            if (enumeradores.Equals(Acao_Tela.ConsultarJuridico))
            {
                Botoes(3);
            }
            if (enumeradores.Equals(Acao_Tela.Consultar))
            {
                Botoes(1);
            }
        }

        //Controles dos Botoes
        void Botoes(int op)
        {
            BtnAlterCliente.Enabled = false;
            BtnAlterFuncio.Enabled = false;
            BtnConsCliente.Enabled = false;
            BtnConsulFuncio.Enabled = false;

            if (op.Equals(1))
            {
                BtnAlterCliente.Enabled = true;
                BtnConsCliente.Enabled = true;
                BtnAlterFuncio.Enabled = false;
                BtnConsulFuncio.Enabled = false;
                BtnAlterarJuridico.Enabled = false;
                BtnConsultarJuridico.Enabled = false;
            }
            if (op.Equals(2))
            {
                BtnAlterCliente.Enabled = false;
                BtnConsCliente.Enabled = false;
                BtnAlterFuncio.Enabled = true;
                BtnConsulFuncio.Enabled = true;
                BtnAlterarJuridico.Enabled = false;
                BtnConsultarJuridico.Enabled = false;
            }
            if (op.Equals(3))
            {
                BtnAlterCliente.Enabled = false;
                BtnConsCliente.Enabled = false;
                BtnAlterFuncio.Enabled = false;
                BtnConsulFuncio.Enabled = false;
                BtnAlterarJuridico.Enabled = true;
                BtnConsultarJuridico.Enabled = true;
            }
        }
        //Carrega as Propriedades que tem mais de um objeto
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";

                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = CarregarPropriedade(propertyInfo.GetValue(propriedade, null), nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1));
                            }
                        }
                    }
                }
                else
                {
                    Type tpyProperty;
                    PropertyInfo property;

                    if (propriedade != null)
                    {
                        tpyProperty = propriedade.GetType();
                        property = tpyProperty.GetProperty(nomeDaPropriedade);
                        retorno = property.GetValue(propriedade, null);
                    }
                }

                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
                throw;
            }
        }

        private void DataPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgwPrincipal.Rows[e.RowIndex].DataBoundItem != null) && (dgwPrincipal.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dgwPrincipal.Rows[e.RowIndex].DataBoundItem, dgwPrincipal.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void PesquisarFisico()
        {


            colecao = int.TryParse(TxtNome.Text, out int codigoDigitado).Equals(true)
                ? negocioCliente.Consultar(codigoDigitado, null)
                : negocioCliente.Consultar(null, TxtNome.Text);

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecao;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
        void PesquisarFuncionarios()
        {


            if (int.TryParse(TxtNome.Text, out int codigoDigitado) == true)
            {
                colecaoFuncionarios = negocioFuncionario.Consultar(codigoDigitado, null);
            }
            else
            {
                colecaoFuncionarios = negocioFuncionario.Consultar(null, TxtNome.Text);

            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecaoFuncionarios;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
        void PesquisarJuridico()
        {


            if (int.TryParse(TxtNome.Text, out int codigoDigitado) == true)
            {
                colecaoJuridica = negocioJuridico.Consultar(codigoDigitado, null);
            }
            else
            {
                colecaoJuridica = negocioJuridico.Consultar(null, TxtNome.Text);

            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecaoJuridica;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (enumSelecionado.Equals(Acao_Tela.ConsultarCliente))
            {
                PesquisarFisico();
            }
            if (enumSelecionado.Equals(Acao_Tela.ConsultarFuncionario))
            {
                PesquisarFuncionarios();
            }
            if (enumSelecionado.Equals(Acao_Tela.ConsultarJuridico))
            {
                PesquisarJuridico();
            }
            if (enumSelecionado.Equals(Acao_Tela.Consultar))
            {
                PesquisarFisico();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAlterCliente_Click(object sender, EventArgs e)
        {

            if (dgwPrincipal.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Escolha uma opção! ", "Atenção");
                return;
            }

            ClienteFisico fisicoSelecionado = (dgwPrincipal.SelectedRows[0].DataBoundItem as ClienteFisico);

            FrmCadastros cadastroPacientes = new FrmCadastros(Enumeradores.AlterarFisico, fisicoSelecionado, null);
            //cadastroPacientes.MdiParent = new FRMTelaInicial();
            cadastroPacientes.ShowDialog();
        }

        private void BtnConsCliente_Click(object sender, EventArgs e)
        {
            if (enumSelecionado.Equals(Acao_Tela.ConsultarCliente))
            {
                if (dgwPrincipal.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Escolha uma opção! ", "Atenção! ");
                    return;
                }

                ClienteFisico fisicoSelecionado = (dgwPrincipal.SelectedRows[0].DataBoundItem as ClienteFisico);

                FrmCadastros cadastroClientes = new FrmCadastros(Enumeradores.ConsultarFisico, fisicoSelecionado, null);
                //cadastroPacientes.MdiParent = new FRMTelaInicial();
                cadastroClientes.ShowDialog();
            }
            if (enumSelecionado.Equals(Acao_Tela.Consultar))
            {
                if (dgwPrincipal.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("Nenhuma linha selecionada");
                    return;
                }

                clienteSelecionado = dgwPrincipal.SelectedRows[0].DataBoundItem as ClienteFisico;

                DialogResult = DialogResult.OK;
                FrmPedido cadastro = new FrmPedido(Acao_Tela.Consultar, pedidoSelecionado);
                Close();
                //cadastro.Show();
            }
            
        }

        private void BtnAlterFuncio_Click(object sender, EventArgs e)
        {

            if (dgwPrincipal.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Escolha uma opção! ", "Atenção! ");
                return;
            }

            Funcionarios funcionarioSelecionado = (dgwPrincipal.SelectedRows[0].DataBoundItem as Funcionarios);

            FrmCadastros cadastroFuncionarios = new FrmCadastros(Enumeradores.AlterarFuncionario, null, funcionarioSelecionado);
            //cadastroPacientes.MdiParent = new FRMTelaInicial();
            cadastroFuncionarios.ShowDialog();
        }

        private void BtnConsulFuncio_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Escolha uma opção! ", "Atenção! ");
                return;
            }
            Funcionarios funcionarioSelecionado = (dgwPrincipal.SelectedRows[0].DataBoundItem as Funcionarios);

            FrmCadastros cadastroFuncionarios = new FrmCadastros(Enumeradores.ConsultarFuncionario, null, funcionarioSelecionado);
            cadastroFuncionarios.ShowDialog();

        }

        private void BtnAlterarJuridico_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Escolha uma opção! ", "Atenção! ");
                return;
            }

            PessoaJuridica juridicoSelecionado = (dgwPrincipal.SelectedRows[0].DataBoundItem as PessoaJuridica);

            frmCadastroJuridico cadastroJuridico = new frmCadastroJuridico(Enumeradores.AlterarJuridico, juridicoSelecionado);
            cadastroJuridico.ShowDialog();
        }

        private void BtnConsultarJuridico_Click(object sender, EventArgs e)
        {
            if (dgwPrincipal.SelectedRows.Count.Equals(0))
            {
                MessageBox.Show("Escolha uma opção! ", "Atenção! ");
                return;
            }

            PessoaJuridica juridicoSelecionado = (dgwPrincipal.SelectedRows[0].DataBoundItem as PessoaJuridica);

            frmCadastroJuridico cadastroJuridico = new frmCadastroJuridico(Enumeradores.ConsultarJuridico, juridicoSelecionado);
            cadastroJuridico.ShowDialog();
        }

        private void frmPesquisarCadastroFisico_Load(object sender, EventArgs e)
        {

        }
    }
}
