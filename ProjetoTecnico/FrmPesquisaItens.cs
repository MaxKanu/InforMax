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
    public partial class FrmPesquisaItens : Form
    {
        public Pedidos Propriedade = new Pedidos();
        public ItensDePedido pedidoSelecionado; //vai pegar os dados selecionado e armazenar no objeto criado
        public Precos precoSelecionado;
        ItensDePedidoColecao colecaoItens = new ItensDePedidoColecao();
        ItensDePedido itens = new ItensDePedido();
        NgIp negocioItens = new NgIp();
        Pedidos pedido = new Pedidos(); //objeto da classe pedido
        public FrmPesquisaItens()
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;
            
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void dgwPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
        void PesquisarNotas()
        { /*int i;
            if (int.TryParse(TxtPesquisa.Text, out int codigoDigitado) == true)
            {
                colecaoItens = negocioItens.ConsultarValorTotalPedidos(codigoDigitado);
            }
            for (i = 0; i <= dgwPrincipal.Rows.Count; i++)
                ltvPrincipal.Items.Add(dgwPrincipal.Rows[i].ItemArray[0].Tostring());*/
        }
        void PesquisarLista()
        {
            if (int.TryParse(TxtPesquisa.Text, out int codigoDigitado) == true)
            {
                colecaoItens = negocioItens.ConsultarValorTotalPedidos(codigoDigitado);
            }

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecaoItens;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarLista();
        }

        private void BtnSelecionar_Click(object sender, EventArgs e)
        {
                if (dgwPrincipal.SelectedRows.Count.Equals(0))
                {
                    MessageBox.Show("Nenhuma linha selecionada");
                    return;
                }

                pedidoSelecionado = dgwPrincipal.SelectedRows[0].DataBoundItem as ItensDePedido;

            FrmOrdemServico cadastro = new FrmOrdemServico(Acao_Tela.ConsultarCliente, pedidoSelecionado);
                cadastro.Show();
                Close();
                //cadastro.Show();
        }
    }
}
