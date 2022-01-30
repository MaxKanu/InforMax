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
        OperacaoColecao colecaoOperacao = new OperacaoColecao();
        SituacaoColecao colecaoSituacao = new SituacaoColecao();
        Acao_Tela telaSelecionada;
        
        public FrmPedido(Acao_Tela acao, Pedidos pedido)
        {
            InitializeComponent();
            telaSelecionada = acao;
            ComboOperacao.ValueMember = "IdOperacao";
            ComboSituacao.ValueMember = "IdSituacao";
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
                txtID.Text = pesquisa.clienteSelecionado.Pessoa.Id.ToString();
                LblNome.Text = pesquisa.clienteSelecionado.Pessoa.Nome;
                clienteSelecionado = pesquisa.clienteSelecionado;
            }
        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            //txtIdPedido.Text = 1.ToString();
            FrmOrdemServico itens = new FrmOrdemServico
            {
                Propriedade = new Pedidos()
            };
            itens.Propriedade.Cliente = new ClienteFisico
            {
                Pessoa = new Pessoa()
            };
            itens.Propriedade.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
            itens.Propriedade.Cliente.Pessoa.Id = Convert.ToInt32(txtID.Text);
            itens.Propriedade.Cliente.Pessoa.Nome = LblNome.Text;
            itens.Propriedade.Marcador = txtMarcador.Text;
            itens.ShowDialog();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
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

                //pedidos.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
                pedidos.Cadastro = dateCadastro.Value;
                pedidos.Cliente.Pessoa.Id = Convert.ToInt32(txtID.Text);
                pedidos.Marcador = txtMarcador.Text;
                pedidos.Operacao.IdOperacao = Convert.ToInt32(ComboOperacao.SelectedValue);
                pedidos.Situacao.IdSituacao = Convert.ToInt32(ComboSituacao.SelectedValue);

                string retorno = NegocioPedido.InserirPedido(pedidos);
                try
                {
                    int IdPedido = Convert.ToInt32(retorno);
                    MessageBox.Show("Pedido anotado", "Numero do pedido: " + IdPedido.ToString());
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
