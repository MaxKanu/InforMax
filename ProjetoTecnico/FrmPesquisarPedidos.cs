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
    public partial class FrmPesquisarPedidos : Form
    {
        Pedidos pedido = new Pedidos();
        PedidoColecao colecao = new PedidoColecao();
        NgPe negocioPedido = new NgPe();
        public FrmPesquisarPedidos()
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;
        }
        public void Pesquisa()
        {
            if (int.TryParse(TxtPesquisa.Text, out int codigoDigitado).Equals(true))
            {
                colecao = negocioPedido.Pedidos(codigoDigitado, null);
            }
            else
            {
                colecao = negocioPedido.Pedidos(null, TxtPesquisa.Text);
            }
            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecao;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            //A propriedade Substring junto com esta propriedade criada, percorre todo objeto ate o ponto, fazendo com que ele nao retorne nulo
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
                                retorno = CarregarPropriedade
                                    (
                                    propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1)
                                    );
                            }
                        }
                    }
                }
                else
                {
                    Type tpyPropertyTipe;
                    PropertyInfo pfoPropertyInfo;

                    if (propriedade != null)
                    {
                        tpyPropertyTipe = propriedade.GetType();
                        pfoPropertyInfo = tpyPropertyTipe.GetProperty(nomeDaPropriedade);
                        retorno = pfoPropertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
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
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa();
        }
    }
}
