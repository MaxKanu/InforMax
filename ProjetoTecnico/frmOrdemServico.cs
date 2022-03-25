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
        public Precos precoSelecionado;
        ItensDePedidoColecao colecaoItens = new ItensDePedidoColecao();
        ItensDePedido itens = new ItensDePedido();
        NgIp negocioItens = new NgIp();

        double preco = 0;
        decimal subtotal = 0;
        double percentagem = 0;
        decimal precoDesconto = 0;
        decimal total = 0;
        int quantidade = 0;

        Acao_Tela telaSelecionada;

        public FrmOrdemServico(Acao_Tela acao_Tela, ItensDePedido itensPedidos)
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;
            telaSelecionada = acao_Tela;
            if (acao_Tela.Equals(Acao_Tela.Inserir))
            {
                PesquisarLista();
            }
            if (acao_Tela.Equals(Acao_Tela.InserirServico))
            {
                PesquisarLista();
            }
        }
        void Apagar()
        {
            TxtIdTarefa.Clear(); TxtProdutos.Clear(); TxtServico.Clear();
            TxtQuantidade.Clear(); TxtPreco.Clear(); TxtPercentual.Clear();
            TxtDesconto.Clear(); TxtTotal.Clear(); BtnProdutos.Enabled = true;
            TxtProdutos.Enabled = true; TxtServico.Enabled = true; BtnServico.Enabled = true;
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
        void PesquisarLista()
        {
            if (int.TryParse(txtIdPedido.Text, out int codigoDigitado) == true)
            {
                colecaoItens = negocioItens.ConsultarPedidos(codigoDigitado);
            }
            /*if (int.TryParse(TxtId.Text, out int codigo) == true)
            {
                colecaoItens = negocioItens.ConsultarPedidos(null, codigo);
            }*/

            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecaoItens;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Apagar();
        }
            public static decimal valorTotal;
        void SomaTotal()
        {
            subtotal = Convert.ToDecimal(TxtTotal.Text);
            total += subtotal;
            TxtValorTotal.Text = total.ToString();
        }
        void Soma() //Metodo para realizar o calculo entre as TextBoxes
        {
            decimal resultado = 0;

            if (TxtPreco.Text != "" && TxtPercentual.Text != "")
            {
                preco = Convert.ToDouble(TxtPreco.Text);//recebe o valor do preco
                quantidade = Convert.ToInt32(TxtQuantidade.Text); //recebe a quantidade
                percentagem = (100 - Convert.ToDouble(TxtPercentual.Text)) / 100;//pega a porcentagem
                precoDesconto = Convert.ToDecimal(preco * percentagem);
                subtotal = precoDesconto * quantidade;
                resultado = precoDesconto;
            }
            TxtDesconto.Text = resultado.ToString();
            TxtTotal.Text = subtotal.ToString();

        }
        private void FrmOrdemServico_Load(object sender, EventArgs e)
        {
            if (telaSelecionada.Equals(Acao_Tela.Inserir))
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
                PesquisarLista();
            }
                //SomaTotal();
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

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            itens.Pedidos = new Pedidos();
            itens.Pedidos.Tarefas = new Tarefas();
            itens.Pedidos.Tarefas.Produtos = new Produtos();
            itens.Precos = new Precos();
            itens.Pedidos.Cliente = new ClienteFisico();
            itens.Pedidos.Cliente.Pessoa = new Pessoa();

            itens.Pedidos.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
            itens.Pedidos.Tarefas.Produtos.IdProdutos = Convert.ToInt32(TxtIdTarefa.Text);
            itens.Quantidade = Convert.ToInt32(TxtQuantidade.Text);
            itens.Precos.ValorUnitario = Convert.ToDecimal(TxtPreco.Text);
            itens.Precos.Percentual = Convert.ToDecimal(TxtPercentual.Text);
            itens.Precos.ValorDesconto = Convert.ToDecimal(TxtDesconto.Text);
            itens.Precos.ValorTotal = Convert.ToDecimal(TxtTotal.Text);

            string retorno = negocioItens.InserirItensPedido(itens);
            try
            {
                int IdItem = Convert.ToInt32(retorno);
                MessageBox.Show("Item inserido com sucesso! \n\n O codigo gerado foi : " + IdItem.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PesquisarLista();
                SomaTotal();
                Apagar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.Produto);
            DialogResult resultado = preco.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                TxtIdTarefa.Text = preco.precoSelecionado.Id.ToString();
                TxtProdutos.Text = preco.precoSelecionado.Descricao;
                TxtPreco.Text = preco.precoSelecionado.Preco.ToString();
                precoSelecionado = preco.precoSelecionado;
                TxtServico.Enabled = false;
                BtnServico.Enabled = false;
            }
        }

        private void BtnServico_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.Servico);
            DialogResult resultado = preco.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                TxtIdTarefa.Text = preco.precoSelecionado.Id.ToString();
                TxtServico.Text = preco.precoSelecionado.Descricao;
                TxtPreco.Text = preco.precoSelecionado.Preco.ToString();
                precoSelecionado = preco.precoSelecionado;
                TxtProdutos.Enabled = false;
                BtnProdutos.Enabled = false;
            }
        }

        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {
            Soma();
        }

        private void TxtPercentual_TextChanged(object sender, EventArgs e)
        {
            Soma();
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
           //SomaTotal();
        }

    }
}
