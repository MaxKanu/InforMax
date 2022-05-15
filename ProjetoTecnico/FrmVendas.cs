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
    public partial class FrmVendas : Form
    {
        public Pedidos Propriedade = new Pedidos();
        //vai pegar os dados selecionado e armazenar no objeto criado
        public ItensDePedidoColecao pedidoSelecionado;
        public Precos precoSelecionado;
        ItensDePedidoColecao colecaoItens = new ItensDePedidoColecao();
        ItensDePedido itens = new ItensDePedido();
        NgIp negocioItens = new NgIp();
        NgFa fabricante = new NgFa();
        FabricanteColecao colecaoFabricante = new FabricanteColecao();

        Acao_Tela telaSelecionada;
        double preco = 0;
        double percentagem = 0;
        decimal subtotal = 0;
        decimal precoDesconto = 0;
        decimal total = 0;
        int quantidade = 0;
        public FrmVendas(Acao_Tela acao_Tela, ItensDePedido itensPedidos)
        {
            InitializeComponent();
            
            telaSelecionada = acao_Tela;
            ComboMarca.ValueMember = "IdFabricante";
            ComboAparelho.ValueMember = "IdFabricante";
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
        void Apagar()
        {
            TxtIdTarefa.Clear(); TxtProdutos.Clear(); 
            TxtQuantidade.Clear(); TxtPreco.Clear(); TxtPercentual.Clear();
            TxtDesconto.Clear(); TxtTotal.Clear(); BtnProdutos.Enabled = true;
            TxtProdutos.Enabled = true; 
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
            TxtDesconto.Text = resultado.ToString("N");
            TxtTotal.Text = subtotal.ToString("N");

        }
        void PesquisarLista()
        {
            if (int.TryParse(txtIdPedido.Text, out int codigoDigitado) == true)
            {
                colecaoItens = negocioItens.ConsultarPedidos(codigoDigitado);
            }
            
            dgwPrincipal.DataSource = null;
            dgwPrincipal.DataSource = colecaoItens;
            dgwPrincipal.Update();
            dgwPrincipal.Refresh();
        }
        private bool Validar() // Metodo de validação das TextBox
        {
            bool valid = true;
            StringBuilder msg = new StringBuilder();

            if (txtIdPedido.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "Precisa inserir o Código do pedido" : "");
                valid = false;
                txtIdPedido.BackColor = Color.LightBlue;
            }

            if (TxtId.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : " O Id do Cliente");
                valid = false;
                TxtId.BackColor = Color.LightBlue;
            }

            if (TxtCliente.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ",O nome do cliente");
                valid = false;
                TxtCliente.BackColor = Color.LightBlue;
            }

            if (TxtIdTarefa.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Id do Produto");
                valid = false;
                TxtIdTarefa.BackColor = Color.DarkCyan;
            }

            if (TxtQuantidade.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Quantidade");
                valid = false;
                TxtQuantidade.BackColor = Color.GreenYellow;
            }

            if (TxtPreco.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Preço");
                valid = false;
                TxtPreco.BackColor = Color.GreenYellow;
            }

            if (TxtPercentual.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Percentual");
                valid = false;
                TxtPercentual.BackColor = Color.GreenYellow;
            }

            if (TxtDesconto.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Desconto");
                valid = false;
                TxtDesconto.BackColor = Color.Green;
            }

            if (TxtTotal.Text.Equals(String.Empty))
            {
                msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Valor Total");
                valid = false;
                TxtTotal.BackColor = Color.Green;
            }

            if (!valid)
            {
                MessageBox.Show("O(s) campo(s) são obrigatorios: " + msg.ToString(),
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);

                return valid;
            }
            return valid;
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnInserir_Click(object sender, EventArgs e)
        {

            // Metodo para para o codigo
            if (!Validar())
                return;
            itens.Pedidos = new Pedidos();
            itens.Pedidos.Tarefas = new Tarefas();
            itens.Pedidos.Tarefas.Produtos = new Produtos();
            itens.Precos = new Precos();
            itens.Pedidos.Cliente = new ClienteFisico();
            itens.Pedidos.Cliente.Pessoa = new Pessoa();

            if (TxtTotal.Text != "")
            {
                subtotal = Convert.ToDecimal(TxtTotal.Text);
            }
            else
            {
                MessageBox.Show("Não e possivel salvar com o valor em branco");
            }
            total = total + subtotal;
            TxtValorTotal.Text = total.ToString("N");
            

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
                
                Apagar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nao foi possível concluir a ação");
            }
            PesquisarLista();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            if (telaSelecionada.Equals(Acao_Tela.Inserir))
            {
                if (!Propriedade.Equals(""))
                {
                    txtIdPedido.Text = Propriedade.IdPedidos.ToString();
                    TxtId.Text = Propriedade.Cliente.Pessoa.Id.ToString();
                    TxtCliente.Text = Propriedade.Cliente.Pessoa.Nome;
                    LblNomeOperador.Text = Propriedade.Marcador;
                }
                else
                {
                    MessageBox.Show("Insira os dados obrigatórios para abrir o formulário!");
                }
                PesquisarLista();
            }
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

        private void TxtPreco_TextChanged(object sender, EventArgs e)
        {
            Soma();
        }

        private void TxtPercentual_TextChanged(object sender, EventArgs e)
        {
            Soma();
        }
        private void BtnProdutos_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.Produto);
            DialogResult resultado = preco.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                TxtIdTarefa.Text = preco.precoSelecionado.Id.ToString();
                TxtProdutos.Text = preco.precoSelecionado.Descricao;
                TxtPreco.Text = preco.precoSelecionado.Preco.ToString("N");
                precoSelecionado = preco.precoSelecionado;
            }
        }
    }
}
