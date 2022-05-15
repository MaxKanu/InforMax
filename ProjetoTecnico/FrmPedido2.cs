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
    public partial class FrmPedido : Form
    {
        public Pedidos pedidosSelecionado;
        public ClienteFisico clienteSelecionado;
        Pedidos pedidos = new Pedidos();
        NgOpSi Operacao = new NgOpSi();
        NgPe NegocioPedido = new NgPe();
        NgFa fabricante = new NgFa();
        FabricanteColecao colecaoFabricante = new FabricanteColecao();
        OperacaoColecao colecaoOperacao = new OperacaoColecao();
        SituacaoColecao colecaoSituacao = new SituacaoColecao();
        Acao_Tela telaSelecionada;
        
        public FrmPedido(Acao_Tela acao, Pedidos pedido)
        {
            InitializeComponent();
            telaSelecionada = acao;
            ComboOperacao.ValueMember = "IdOperacao";
            ComboSituacao.ValueMember = "IdSituacao";
            ComboMarca.ValueMember = "IdFabricante";
            ComboAparelho.ValueMember = "IdFabricante";
            if (acao.Equals(Acao_Tela.Inserir))
            {

            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisarCadastroFisico pesquisa = new frmPesquisarCadastroFisico(Acao_Tela.Consultar);
            DialogResult resultado = pesquisa.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                lblTitulo.Text = "Cadastro de Pedidos";
                LblID.Text = pesquisa.clienteSelecionado.Pessoa.Id.ToString();
                LblNome.Text = pesquisa.clienteSelecionado.Pessoa.Nome;
                clienteSelecionado = pesquisa.clienteSelecionado;
            }
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            if (telaSelecionada.Equals(Acao_Tela.Inserir))
            {
                //txtIdPedido.Text = 1.ToString();
                FrmOrdemServico itens = new FrmOrdemServico(Acao_Tela.Inserir, null)
                {
                    Propriedade = new Pedidos()
                };
                itens.Propriedade.Cliente = new ClienteFisico
                {
                    Pessoa = new Pessoa()
                };
                itens.Propriedade.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
                itens.Propriedade.Cliente.Pessoa.Id = Convert.ToInt32(LblID.Text);
                itens.Propriedade.Cliente.Pessoa.Nome = LblNome.Text;
                itens.Propriedade.Marcador = txtMarcador.Text;
                itens.Propriedade.Marca = ComboMarca.Text;
                itens.Propriedade.TipoAparelho = ComboAparelho.Text;
                itens.Propriedade.Observacoes = RctObservacoes.Text;
                itens.Propriedade.Modelo = TxtModelo.Text;
                itens.ShowDialog();
            }
            if (telaSelecionada.Equals(Acao_Tela.InserirProduto))
            {
<<<<<<< Updated upstream
                Pessoa = new Pessoa()
            };
            itens.Propriedade.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
            itens.Propriedade.Cliente.Pessoa.Id = Convert.ToInt32(LblID.Text);
            itens.Propriedade.Cliente.Pessoa.Nome = LblNome.Text;
            itens.Propriedade.Marcador = txtMarcador.Text;
            itens.Propriedade.TipoAparelho = ComboAparelho.Text;
            itens.Propriedade.Observacoes = RctObservacoes.Text;
            itens.Propriedade.Modelo = TxtModelo.Text;
            itens.ShowDialog();
=======
                //txtIdPedido.Text = 1.ToString();
                FrmVendas itens = new FrmVendas(Acao_Tela.Inserir, null)
                {
                    Propriedade = new Pedidos()
                };
                itens.Propriedade.Cliente = new ClienteFisico
                {
                    Pessoa = new Pessoa()
                };
                itens.Propriedade.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
                itens.Propriedade.Cliente.Pessoa.Id = Convert.ToInt32(LblID.Text);
                itens.Propriedade.Cliente.Pessoa.Nome = LblNome.Text;
                itens.Propriedade.Marcador = txtMarcador.Text;
                itens.ShowDialog();
            }
>>>>>>> Stashed changes
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            ToolTip nomeObjeto = new ToolTip();

            nomeObjeto.AutoPopDelay = 5000;
            nomeObjeto.InitialDelay = 100;
            nomeObjeto.ReshowDelay = 100;
            nomeObjeto.ShowAlways = true;

            nomeObjeto.SetToolTip(this.btnAtualizar, "Atualizar");
            nomeObjeto.SetToolTip(this.btnConsultarPedidos, "Consultar Pedidos");
            nomeObjeto.SetToolTip(this.btnNovoCadastro, "Novo Cadastro");
            nomeObjeto.SetToolTip(this.btnPesquisa, "Pesquisar Clientes");
            nomeObjeto.SetToolTip(this.BtnSair, "Sair");
            nomeObjeto.SetToolTip(this.btnSalvar, "Salvar");
            nomeObjeto.SetToolTip(this.btnVendas, "Vendas");

            ComboOperacao.DataSource = null;
            colecaoOperacao = Operacao.ComboOperacao("");
            ComboOperacao.DataSource = colecaoOperacao;
            ComboOperacao.DisplayMember = "Descricao";
            ComboOperacao.Refresh();

            ComboSituacao.DataSource = null;
            colecaoSituacao = Operacao.ComboSituacao("");
            ComboSituacao.DataSource = colecaoSituacao;
            ComboSituacao.DisplayMember = "Situacao";
            ComboSituacao.Refresh();

            ComboAparelho.DataSource = null;
            colecaoFabricante = fabricante.ComboAparelho("");
            ComboAparelho.DataSource = colecaoFabricante;
            ComboAparelho.DisplayMember = "Descricao";
            ComboAparelho.Refresh();

            ComboMarca.DataSource = null;
            colecaoFabricante = fabricante.ComboMarca("");
            ComboMarca.DataSource = colecaoFabricante;
            ComboMarca.DisplayMember = "Descricao";
            ComboMarca.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Instanciar os objetos que pedido tem como referencia
                pedidos.Operacao = new Operacao();
                pedidos.Situacao = new PedidoSituacao();
                pedidos.Cliente = new ClienteFisico();
                pedidos.Cliente.Pessoa = new Pessoa();
                if (lblIDCliente.Text.Equals("Id:") || LblNome.Text.Equals("Cliente:"))
                {
                    MessageBox.Show("Necessário inserir um cliente no pedido");
                    return;
                }
                //pedidos.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
                pedidos.Cadastro = dateCadastro.Value;
                pedidos.Operacao.IdOperacao = Convert.ToInt32(ComboOperacao.SelectedValue);
                pedidos.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
                pedidos.IdTipoAparelho = Convert.ToInt32(ComboAparelho.SelectedValue);
                pedidos.IdMarca = Convert.ToInt32(ComboMarca.SelectedValue);
                pedidos.Cliente.Pessoa.Id = Convert.ToInt32(LblID.Text);
                pedidos.Marcador = txtMarcador.Text;
                pedidos.Modelo = TxtModelo.Text;
                pedidos.Observacoes = RctObservacoes.Text;

                string retorno = NegocioPedido.InserirPedido(pedidos);
                try
                {
                    int IdPedido = Convert.ToInt32(retorno);
                    MessageBox.Show("Pedido anotado", "Numero do pedido: " + IdPedido.ToString());
                    txtIdPedido.Text = IdPedido.ToString();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnConsultarPedidos_Click(object sender, EventArgs e)
        {
            FrmPesquisarPedidos pedidos = new FrmPesquisarPedidos(Acao_Tela.Consultar);
            DialogResult resultado = pedidos.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                lblTitulo.Text = "Cadastro de Pedidos";
                txtIdPedido.Text = pedidos.pedidoSelecionado.IdPedidos.ToString();
                LblID.Text = pedidos.pedidoSelecionado.Cliente.Pessoa.Id.ToString();
                LblNome.Text = pedidos.pedidoSelecionado.Cliente.Pessoa.Nome;
                ComboOperacao.Text = pedidos.pedidoSelecionado.Operacao.Descricao;
                ComboSituacao.Text = pedidos.pedidoSelecionado.Situacao.Situacao;
                ComboAparelho.Text = pedidos.pedidoSelecionado.TipoAparelho;
                ComboMarca.Text = pedidos.pedidoSelecionado.Marca;
                dateCadastro.Value = pedidos.pedidoSelecionado.Cadastro;
                txtMarcador.Text = pedidos.pedidoSelecionado.Marcador;
                TxtModelo.Text = pedidos.pedidoSelecionado.Modelo;
                RctObservacoes.Text = pedidos.pedidoSelecionado.Observacoes;
                
                pedidosSelecionado = pedidos.pedidoSelecionado;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                //Instanciar os objetos que pedido tem como referencia
                pedidos.Operacao = new Operacao();
                pedidos.Situacao = new PedidoSituacao();
                pedidos.Cliente = new ClienteFisico();
                pedidos.Cliente.Pessoa = new Pessoa();
                if (lblIDCliente.Text.Equals("Id:") || LblNome.Text.Equals("Cliente:"))
                {
                    MessageBox.Show("Necessário inserir um cliente no pedido");
                    return;
                }
                pedidos.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
                pedidos.Cadastro = dateCadastro.Value;
                pedidos.Operacao.IdOperacao = Convert.ToInt32(ComboOperacao.SelectedValue);
                pedidos.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);
                pedidos.IdTipoAparelho = Convert.ToInt32(ComboAparelho.SelectedValue);
                pedidos.IdMarca = Convert.ToInt32(ComboMarca.SelectedValue);
                pedidos.Cliente.Pessoa.Id = Convert.ToInt32(LblID.Text);
                pedidos.Marcador = txtMarcador.Text;
                pedidos.Modelo = TxtModelo.Text;
                pedidos.Observacoes = RctObservacoes.Text;

                string retorno = NegocioPedido.AtualizarPedido(pedidos);
                try
                {
                    int IdPedido = Convert.ToInt32(retorno);
                    MessageBox.Show("Pedido alterado", "Numero do pedido: " + IdPedido.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
