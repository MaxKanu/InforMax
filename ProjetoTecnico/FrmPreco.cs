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
    public partial class FrmPreco : Form
    {
        public Precos precoSelecionado;
        public ItensDePedido itensSelecionado;
        Precos precos = new Precos();
        PrecoColecao colecao = new PrecoColecao();
        NgPr Negocio = new NgPr();
        Acao_Tela acao;
        public FrmPreco(Acao_Tela acao_Tela)
        {
            InitializeComponent();
            acao = acao_Tela;
            dgwPrincipal.AutoGenerateColumns = false;
            comboProdutos.ValueMember = "IdProdutos";
            comboServicos.ValueMember = "IdServicos";

            if (acao_Tela.Equals(Acao_Tela.InserirProduto))
            {
                VisibilidadeProd();
                Pesquisa();
                Botoes(1);
                Produtos();
            }

            if (acao_Tela.Equals(Acao_Tela.InserirServico))
            {
                VisibilidadeServ();
                Pesquisa();
                Botoes(1);
                Servicos();
            }

            if (acao_Tela.Equals(Acao_Tela.AlterarProduto))
            {
                VisibilidadeProd();
                Pesquisa();
                Botoes(3);
                Produtos();
            }

            if (acao_Tela.Equals(Acao_Tela.AlterarServico))
            {
                VisibilidadeServ();
                Pesquisa();
                Botoes(3);
                Servicos();
            }

            if (acao_Tela.Equals(Acao_Tela.ConsultarProdutos))
            {
                VisibilidadeServ();
                VisibilidadeProd();
                Botoes(4);
                Produtos();
            }

            if (acao_Tela.Equals(Acao_Tela.ConsultarServicos))
            {
                VisibilidadeServ();
                VisibilidadeProd();
                Botoes(4);
                Servicos();
            }

            if (acao_Tela.Equals(Acao_Tela.Produto))
            {
                VisibilidadeServ();
                VisibilidadeProd();
                Botoes(4);
                Produtos();
            }

            if (acao_Tela.Equals(Acao_Tela.Servico))
            {
                VisibilidadeServ();
                VisibilidadeProd();
                Botoes(4);
                Servicos();
            }
        }
        void Pesquisa()
        {
            BtnPesquisar.Visible = false;
            LblId.Visible = false;
            TxtId.Visible = false;
        }
        void VisibilidadeProd()
        {
            LblPreco1.Visible = false;
            TxtPreco1.Visible = false;
            comboServicos.Visible = false;
            LblServicos.Visible = false;
        }
        void VisibilidadeServ()
        {
            LblPreco2.Visible = false;
            TxtPreco2.Visible = false;
            comboProdutos.Visible = false;
            LblProdutos.Visible = false;
        }
        void LimparCaixas()
        {
            TxtId.Clear();
            TxtPreco1.Clear();
            TxtPreco2.Clear();
        }
        void Botoes(int op)
        {
            BtnAlterar.Enabled = false;
            BtnCancelar.Enabled = false;
            BtnNovo.Enabled = false;
            BtnPesquisar.Enabled = false;
            BtnSair.Enabled = false;
            BtnSalvar.Enabled = false;
            PnPrincipal.Enabled = false;

            if (op.Equals(1))
            {
                //Novo cadastro
                BtnAlterar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNovo.Enabled = true;
                BtnPesquisar.Visible = false;
                BtnSair.Enabled = true;
                BtnSalvar.Enabled = false;
            }
            if (op.Equals(2))
            {
                //Salvar ou Cancelar
                BtnAlterar.Enabled = false;
                BtnCancelar.Enabled = true;
                BtnNovo.Enabled = false;
                BtnPesquisar.Enabled = false;
                BtnSair.Enabled = true;
                BtnSalvar.Enabled = true;
                PnPrincipal.Enabled = true;
            }
            if (op.Equals(3))
            {
                //Alterar ou Cnacelar
                BtnAlterar.Enabled = true;
                BtnCancelar.Enabled = true;
                BtnNovo.Enabled = false;
                BtnPesquisar.Enabled = false;
                BtnSair.Enabled = true;
                BtnSalvar.Enabled = false;
                PnPrincipal.Enabled = true;
            }
            if (op.Equals(4))
            {
                //Pesquisar
                BtnAlterar.Enabled = false;
                BtnCancelar.Enabled = false;
                BtnNovo.Enabled = false;
                BtnPesquisar.Enabled = true;
                BtnSair.Enabled = true;
                BtnSalvar.Enabled = false;
                PnPrincipal.Enabled = true;
            }
        }
        private void FrmPreco_Load(object sender, EventArgs e)
        {
            NgPd prod = new NgPd();
            NgSv serv = new NgSv();

            ProdutosColecao produtos = new ProdutosColecao();
            ServicosColecao servicos = new ServicosColecao();

            comboProdutos.DataSource = null;
            produtos = prod.Combo("");
            comboProdutos.DataSource = produtos;
            comboProdutos.DisplayMember = "Descricao";
            comboProdutos.Refresh();

            comboServicos.DataSource = null;
            servicos = serv.Combo("");
            comboServicos.DataSource = servicos;
            comboServicos.DisplayMember = "Descricao";
            comboServicos.Refresh();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            
            if (acao.Equals(Acao_Tela.InserirProduto))
            {
                precos.Id = Convert.ToInt32(comboProdutos.SelectedValue);
                precos.Preco = Convert.ToDecimal(value: TxtPreco2.Text);

                string retorno = Negocio.Inserir(precos);
                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preco inserido com sucesso! \n\n O codigo gerado foi : " + IdPreco.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCaixas();
                }
                catch (Exception)
                {
                    throw;
                }
                Produtos();
            }
            if (acao.Equals(Acao_Tela.InserirServico))
            {
                precos.Id = Convert.ToInt32(comboServicos.SelectedValue);
                precos.Preco = Convert.ToDecimal(value: TxtPreco1.Text);

                string retorno = Negocio.Inserir(precos);
                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preco inserido com sucesso! \n\n O codigo gerado foi : " + IdPreco.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCaixas();
                }
                catch (Exception)
                {
                    throw;
                }
                Servicos();
            }
        }
        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            if (acao.Equals(Acao_Tela.AlterarProduto))
            {
                precos.Id = Convert.ToInt32(comboProdutos.SelectedValue);
                precos.Preco = Convert.ToDecimal(value: TxtPreco2.Text);

                string retorno = Negocio.Alterar(precos);
                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preço alterado com sucesso! \n\n O codigo gerado foi : " + IdPreco.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCaixas();
                }
                catch (Exception)
                {
                    throw;
                }
                Produtos();
            }
            if (acao.Equals(Acao_Tela.AlterarServico))
            {
                precos.Id = Convert.ToInt32(comboServicos.SelectedValue);
                precos.Preco = Convert.ToDecimal(value: TxtPreco1.Text);

                string retorno = Negocio.Alterar(precos);
                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preço alterado com sucesso! \n\n O codigo gerado foi : " + IdPreco.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCaixas();
                }
                catch (Exception)
                {
                    throw;
                }
                Servicos();
            }
        }
        private void Produtos()
        {
            if (int.TryParse(TxtId.Text, out int codigoDigitado) == true)
            {
                colecao = Negocio.ConsultarProduto(codigoDigitado, null);
            }
            else
            {
                colecao = Negocio.ConsultarProduto(null, TxtId.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecao;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
        private void Servicos()
        {
            if (int.TryParse(TxtId.Text, out int codigoDigitado) == true)
            {
                colecao = Negocio.ConsultarServico(codigoDigitado, null);
            }
            else
            {
                colecao = Negocio.ConsultarServico(null, TxtId.Text);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecao;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (acao.Equals(Acao_Tela.ConsultarServicos))
            {
                Servicos();
            }
            if (acao.Equals(Acao_Tela.ConsultarProdutos))
            {
                Produtos();
            }
            if (acao.Equals(Acao_Tela.Servico))
            {
                Servicos();
            }
            if (acao.Equals(Acao_Tela.Produto))
            {
                Produtos();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCaixas();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Botoes(2);
        }

        private void TxtPreco2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void TxtPreco1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
            //Acao que vai comparar a solicitacao da tela anterior
            if (acao.Equals(Acao_Tela.Produto))
            {
                if(dgwPrincipal.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("Nenhuma linha selecionada");
                    return;
                }
                precoSelecionado = dgwPrincipal.SelectedRows[0].DataBoundItem as Precos;

                DialogResult = DialogResult.OK;
                FrmOrdemServico os = new FrmOrdemServico(Acao_Tela.Produto, itensSelecionado);
                Close();
            }
            if (acao.Equals(Acao_Tela.Servico))
            {
                if (dgwPrincipal.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("Nenhuma linha selecionada");
                    return;
                }
                precoSelecionado = dgwPrincipal.SelectedRows[0].DataBoundItem as Precos;

                DialogResult = DialogResult.OK;
                FrmOrdemServico os = new FrmOrdemServico(Acao_Tela.Servico, itensSelecionado);
                Close();
            }
        }

        private void PnPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
