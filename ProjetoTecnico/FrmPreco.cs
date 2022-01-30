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
        Precos precos = new Precos();
        PrecoColecao colecao = new PrecoColecao();
        NgPr Negocio = new NgPr();
        Acao_Tela acao;
        public FrmPreco(Acao_Tela acao_Tela)
        {
            InitializeComponent();
            acao = acao_Tela;
            dgwPrincipal.AutoGenerateColumns = false;
            if (acao_Tela.Equals(Acao_Tela.InserirProduto))
            {
                comboProdutos.ValueMember = "IdProdutos";
                comboServicos.ValueMember = "IdServicos";
                LblServicos.Visible = false;
                comboServicos.Visible = false;
                Produtos();
            }
            if (acao_Tela.Equals(Acao_Tela.InserirServico))
            {
                comboProdutos.ValueMember = "IdProdutos";
                comboServicos.ValueMember = "IdServicos";
                comboProdutos.Visible = false;
                LblProdutos.Visible = false;
                Servicos();
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
                precos.Preco = Convert.ToDecimal(value: TxtPreco.Text);

                string retorno = Negocio.Inserir(precos);
                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preco inserido com sucesso! \n\n O codigo gerado foi : " + IdPreco.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                precos.Preco = Convert.ToDecimal(value: TxtPreco.Text);

                string retorno = Negocio.Inserir(precos);
                try
                {
                    int IdPreco = Convert.ToInt32(retorno);
                    MessageBox.Show("Preco inserido com sucesso! \n\n O codigo gerado foi : " + IdPreco.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
