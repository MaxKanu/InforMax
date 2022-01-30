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
    public partial class FrmOrdemServico : Form
    {
        public Pedidos Propriedade = new Pedidos();

        double preco = 0;
        decimal subtotal = 0;
        double percentagem = 0;
        decimal precoDesconto = 0;
        decimal total = 0;
        int quantidade = 0;

        public FrmOrdemServico()
        {
            InitializeComponent();

        }

        private void DgwPrincipal(object sender, DataGridViewCellFormattingEventArgs e)
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
       /* void PesquisarLista()
        {

            if (int.TryParse(txtIdPedido.Text, out int codigoDigitado) == true)
            {
                colecaoItens = negocioItens.ConsultarPedidos(codigoDigitado);
            }


            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecaoItens;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }*/
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmOrdemServico_Load(object sender, EventArgs e)
        {
            if (!Propriedade.Equals(""))
            {
                txtIdPedido.Text = Propriedade.IdPedidos.ToString();
                LblNomeOperado.Text = Propriedade.Marcador;
                TxtId.Text = Propriedade.Cliente.Pessoa.Id.ToString();
                TxtCliente.Text = Propriedade.Cliente.Pessoa.Nome;
            }
            else
            {
                MessageBox.Show("Insira os dados obrigatórios para abrir o formulário!");
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ItensDePedido itens = new ItensDePedido
            {
                Pedidos = new Pedidos()
            };

            if (dgwPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum item selecionado");
            }
            DialogResult resultado = MessageBox.Show("Deseja mesmo excluir o item?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            //Excluir Produtos da lista
            itens.Pedidos.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
            itens.Pedidos.Id = Convert.ToInt32(TxtIdTarefa.Text);

            //string retorno = negocioItens.ExcluirProduto(itens);
            try
            {
                //int IdPedido = Convert.ToInt32(retorno);
                //MessageBox.Show("Pedido Nº " + IdPedido.ToString() + " Excluido!", "Sucesso!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //LimparCaixas();
                //PesquisarLista();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Esta  " + erro, "ATENÇÃO!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
            //Pedidos pedidoSelecionado = new Pedidos();
            //pedidoSelecionado = (dgvPrincipal.SelectedRows[0].DataBoundItem as Pedidos);
        }
    }
}
