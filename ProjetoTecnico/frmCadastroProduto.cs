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
using System.Reflection;

namespace ProjetoTecnico
{
    public partial class frmCadastroProduto : Form
    {
        
        public frmCadastroProduto()
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;
            comboFabricante.ValueMember = "IdFabricante";
            TxtId.Enabled = false;
            LimparCaixas();
            Botoes(1);
            CarregarGrid();

        }
        void Botoes(int op)
        {
            BtnCancelar.Enabled = false;
            BtnSalvar.Enabled = false;
            BtnSair.Enabled = false;
            BtnNovo.Enabled = false;

            if (op.Equals(1))
            {
                BtnCancelar.Enabled = false;
                BtnSalvar.Enabled = false;
                BtnSair.Enabled = true;
                BtnNovo.Enabled = true;
            }
            if (op.Equals(2))
            {
                BtnCancelar.Enabled = true;
                BtnSalvar.Enabled = true;
                BtnSair.Enabled = true;
                BtnNovo.Enabled = false;
            }
        }
        void LimparCaixas()
        {
            TxtId.Clear();
            TxtNome.Clear();
            PnPrincipal.Enabled = false;
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            PnPrincipal.Enabled = true;
            Botoes(2);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimparCaixas();
            Botoes(1);
        }
        void CarregarGrid()
        {
            NgPd produto = new NgPd();
            ProdutosColecao colecao = new ProdutosColecao();

            if (int.TryParse(TxtNome.Text, out int codigoDigitado) == true)
            {
                colecao = produto.Consultar(codigoDigitado, null);
            }
            else
            {
                colecao = produto.Consultar(null, TxtNome.Text);

            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecao;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
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

        private void DgwPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos
            {
                Fabricante = new Fabricante()
            };
            NgPd negocio = new NgPd();

            produtos.Fabricante.IdFabricante = Convert.ToInt32(comboFabricante.SelectedValue);
            produtos.Descricao = TxtNome.Text;
            string retorno = negocio.Inserir(produtos);
            try
            {
                int IdProdutos = Convert.ToInt32(retorno);
                MessageBox.Show("Produto inserido com sucesso! \n\n O codigo gerado foi : " + IdProdutos.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCaixas();
                Botoes(1);
            }
            catch (Exception)
            {

                throw;
            }
            CarregarGrid();
        }

        private void FrmCadastroProduto_Load(object sender, EventArgs e)
        {
            NgFa fabricante = new NgFa();
            FabricanteColecao colecao = new FabricanteColecao();

            comboFabricante.DataSource = null;
            colecao = fabricante.ComboFabri("");
            comboFabricante.DataSource = colecao;
            comboFabricante.DisplayMember = "Descricao";
            comboFabricante.Refresh();
            
            CarregarGrid();
        }
    }
}
