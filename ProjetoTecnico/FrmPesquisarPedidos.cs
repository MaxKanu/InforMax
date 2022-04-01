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
        public Pedidos pedidoSelecionado; //vai pegar os dados selecionado e armazenar no objeto criado
        Pedidos pedido = new Pedidos(); //objeto da classe pedido
        PedidoColecao colecao = new PedidoColecao();//objeto da classe pedido coleção
        NgPe negocioPedido = new NgPe();//objeto da classe negocio pedido
        Acao_Tela enumSelecionado;//Selecionar o enumerador da tela
        public FrmPesquisarPedidos(Acao_Tela enumeradores)
        {
            InitializeComponent();
            enumSelecionado = enumeradores;
            dgwPrincipal.AutoGenerateColumns = false;
            if (enumeradores.Equals(Acao_Tela.PesquisarPedidos))
            {
                BtnSelecionar.Enabled = false;
            }
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtPesquisa.Clear();
            dgwPrincipal.DataSource = null;
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {

            if (enumSelecionado.Equals(Acao_Tela.Consultar))
            {
                if (dgwPrincipal.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("Nenhuma linha selecionada");
                    return;
                }

                pedidoSelecionado = dgwPrincipal.SelectedRows[0].DataBoundItem as Pedidos;

                DialogResult = DialogResult.OK;
                FrmPedido cadastro = new FrmPedido(Acao_Tela.Consultar, pedidoSelecionado);
                Close();
                //cadastro.Show();
            }
        }

    }
}
