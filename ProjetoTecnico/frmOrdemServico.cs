﻿using Objetos;
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
using System.Drawing.Printing;

namespace ProjetoTecnico
{
    public partial class FrmOrdemServico : Form
    {
        private BindingSource BsPrincipal = new BindingSource();
        public Pedidos Propriedade = new Pedidos();
        //vai pegar os dados selecionado e armazenar no objeto criado
        public ItensDePedidoColecao pedidoSelecionado;
        public Precos precoSelecionado;
        ItensDePedidoColecao colecaoItens = new ItensDePedidoColecao();
        ItensDePedido itens = new ItensDePedido();
        NgIp negocioItens = new NgIp();

        double preco = 0;
        double percentagem = 0;
        decimal resultado = 0;
        decimal subtotal = 0;
        decimal precoDesconto = 0;
        decimal total = 0;
        int quantidade = 0;

        Acao_Tela telaSelecionada;
        private Button printButton = new Button();
        private PrintDocument imprimirOrdem = new PrintDocument();
        public FrmOrdemServico(Acao_Tela acao_Tela, ItensDePedido itensPedidos)
        {
            InitializeComponent();
            dgwPrincipal.AutoGenerateColumns = false;
            telaSelecionada = acao_Tela;
            if (acao_Tela.Equals(Acao_Tela.Inserir))
            {
                PesquisarLista();
                BtnPesquisar.Visible = false;
                txtIdPedido.Enabled = false;
            }
            if (acao_Tela.Equals(Acao_Tela.InserirServico))
            {
                PesquisarLista();
                BtnPesquisar.Visible = false;
                txtIdPedido.Enabled = false;
            }
            if (acao_Tela.Equals(Acao_Tela.Consultar))
            {
                txtIdPedido.Enabled = true;
                BtnPesquisar.Enabled = true;
                BtnProdutos.Enabled = false;
                BtnServico.Enabled = false;
                BtnInserir.Enabled = false;
                Caixas();
            }
            if (acao_Tela.Equals(Acao_Tela.ConsultarCliente))
            {
                txtIdPedido.Text = itensPedidos.Pedidos.IdPedidos.ToString();
                TxtId.Text = itensPedidos.Pedidos.Cliente.Pessoa.Id.ToString();
                TxtCliente.Text = itensPedidos.Pedidos.Cliente.Pessoa.Nome;
                TxtValorTotal.Text = itensPedidos.Precos.Preco.ToString();
                TxtAparelho.Text = itensPedidos.Pedidos.TipoAparelho;
                TxtModelo.Text = itensPedidos.Pedidos.Modelo;
                TxtDefeito.Text = itensPedidos.Pedidos.Observacoes;
                LblNomeOperado.Text = itensPedidos.Pedidos.Marcador;
                BtnProdutos.Enabled = false; BtnServico.Enabled = false;
                Caixas(); BtnInserir.Enabled = false; PesquisarLista();
                printButton.Text = "Print Form";
                BtnImprimir.Click += new EventHandler(BtnImprimir_Click);
                imprimirOrdem.PrintPage += new PrintPageEventHandler(PdImprimirOrdem_PrintPage);
                this.Controls.Add(printButton);
            }
        }
        void Botoes(int op)
        {

        }
        void Caixas()
        {
            TxtCliente.Enabled = false; TxtDesconto.Enabled = false;
            TxtId.Enabled = false; //txtIdPedido.Enabled = false;
            TxtIdTarefa.Enabled = false; TxtPercentual.Enabled = false;
            TxtPreco.Enabled = false; TxtProdutos.Enabled = false;
            TxtServico.Enabled = false; TxtQuantidade.Enabled = false;
            TxtTotal.Enabled = false;
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
        private bool Validar1() // Metodo de validação das TextBox
        {
            bool valid = true;
            StringBuilder msg = new StringBuilder();
            
             if (TxtValorTotal.Text.Equals(String.Empty))
             {
                 msg.Append(msg.ToString().Equals(String.Empty) ? "" : ", Valor da Nota");
                 valid = false;
                 TxtValorTotal.BackColor = Color.DarkRed;
             }

            if (!valid)
            {
                MessageBox.Show("O(s) campo(s) são obrigatorios: " + msg.ToString(),
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);

                return valid;
            }
            return valid;
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
            BsPrincipal.DataSource = colecaoItens;
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
        private DataTable dt;

        void SomaTotal()
        {
            // vamos somar todos os valores da coluna de preços
            // note que a coluna de preços possui o índice 2

            double total = 0;

            foreach (DataGridViewRow item in dgwPrincipal.Rows)
            {
                // os valores na ListView não são do tipo double
                string valor = item.Cells[5].ToString();

                // vamos converter para double
                double preco = double.Parse(valor);

                // vamos adicionar o valor deste item à soma atual
                total = total + preco;
                TxtValorTotal.Text = total.ToString();
            }
            /*
            foreach (DataGridViewRow col in dgwPrincipal.Rows)
            {
                valorTotal = valorTotal += Convert.ToDecimal(col.Cells[1].Value);
            }

            TxtValorTotal.Text = Convert.ToString(valorTotal);
             subtotal = Convert.ToDecimal(TxtTotal.Text);
             total += subtotal;
             TxtValorTotal.Text = total.ToString();
             */
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
                    TxtDefeito.Text = Propriedade.Observacoes;
                    TxtAparelho.Text = Propriedade.TipoAparelho;
                    TxtModelo.Text = Propriedade.Modelo;
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
            // Metodo para para o codigo
            if (!Validar())
                return;
            string[] itp = new string[6];
            ListViewItem l = new ListViewItem(itp);
            itens.Pedidos = new Pedidos();
            itens.Pedidos.Tarefas = new Tarefas();
            itens.Pedidos.Tarefas.Produtos = new Produtos();
            itens.Precos = new Precos();
            itens.Pedidos.Cliente = new ClienteFisico();
            itens.Pedidos.Cliente.Pessoa = new Pessoa();
            /*
            preco = Convert.ToDouble(TxtPreco.Text);//recebe o valor do preco
            quantidade = Convert.ToInt32(TxtQuantidade.Text); //recebe a quantidade
            percentagem = (100 - Convert.ToDouble(TxtPercentual.Text)) / 100;//pega a porcentagem
            precoDesconto = Convert.ToDecimal(preco * percentagem);
            subtotal = precoDesconto * quantidade;
            resultado = precoDesconto;
           
            TxtDesconto.Text = resultado.ToString(); */
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
            
            itp[0] = TxtIdTarefa.Text;
            itp[4] = TxtProdutos.Text;
            itp[1] = TxtQuantidade.Text;
            itp[2] = TxtPreco.Text;
            itp[3] = TxtDesconto.Text;
            itp[5] = TxtTotal.Text;
            

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
              catch (Exception ex)
              {
                //throw;
                MessageBox.Show("Nao foi possível concluir a ação");
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
                TxtPreco.Text = preco.precoSelecionado.Preco.ToString("N");
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

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Metodo para para o codigo
            if (!Validar1())
                return;

            itens.Pedidos = new Pedidos();
            itens.Precos = new Precos();
            //itens.Precos.Lanches = new Lanches();

            itens.Pedidos.IdPedidos = Convert.ToInt32(txtIdPedido.Text);
            itens.Precos.ValorTotal = Convert.ToDecimal(TxtValorTotal.Text);

            string retorno = negocioItens.InserirValorTotal(itens);
            try
            {
                int IdPedido = Convert.ToInt32(retorno);
                MessageBox.Show("Pedido Nº " + IdPedido.ToString() + " Fechado!", "Sucesso!! ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult resultado = MessageBox.Show("Deseja Abrir um novo pedido?", "PERGUNTA!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.No)
                {
                    Close();
                    Dispose();
                }
                else
                {
                    FrmPedido pedidos = new FrmPedido(Acao_Tela.Inserir, null);
                    Close();
                    Dispose();
                    pedidos.Show();
                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Esta  " + erro, "ATENÇÃO!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtIdPedido.Text.Equals(""))
            {
                MessageBox.Show("Insira o Número do pedido!");
                return;
            }
                PesquisarLista();
            //SomaTotal();
            
        }
        void ImprimirGrade()
        {
            DGVPrinter imprimir = new DGVPrinter();
            
            imprimir.Title = "Ordem de Serviço";
            imprimir.SubTitle = "Informax Informática e Componentes";
            imprimir.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            imprimir.PageNumbers = true;
            imprimir.PageNumberInHeader = false;
            imprimir.PorportionalColumns = true;
            imprimir.HeaderCellAlignment = StringAlignment.Near;
            imprimir.Footer = "Informax Informática";
            imprimir.FooterSpacing = 15;

            imprimir.PrintDataGridView(dgwPrincipal);
        }
        //recebe os controles para o objeto imprimir
        private void PdImprimirOrdem_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtIdPedido.Text, txtIdPedido.Font, Brushes.Black, 100, 100);
            e.Graphics.DrawString(TxtId.Text, TxtId.Font, Brushes.Black, 100, 150);
            e.Graphics.DrawString(TxtCliente.Text, TxtCliente.Font, Brushes.Black, 150, 150);
            e.Graphics.DrawString(TxtAparelho.Text, TxtAparelho.Font, Brushes.Black, 100, 180);
            e.Graphics.DrawString(TxtModelo.Text, TxtModelo.Font, Brushes.Black, 100, 210);
            e.Graphics.DrawString(TxtDefeito.Text, TxtDefeito.Font, Brushes.Black, 100, 250);
        }
        /*private DataTable GerarO_S()
        {
            var dt = new DataTable();
            dt.Columns.Add("IdPedido", typeof(int));
            dt.Columns.Add("Quantidade", typeof(int));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Preço", typeof(decimal));
            dt.Columns.Add("Desconto", typeof(decimal));
            dt.Columns.Add("Valor_Total", typeof(decimal));
            foreach (DataGridViewRow item in dgwPrincipal.Rows)
            {
                dt.Rows.Add(item.Cells["IdPedidos"].Value);
                dt.Rows.Add(item.Cells["Quant"].Value);
                dt.Rows.Add(item.Cells["Descricao"].Value);
                dt.Rows.Add(item.Cells["Valor"].Value);
                dt.Rows.Add(item.Cells["Desconto"].Value);
                dt.Rows.Add(item.Cells["Valor_Total"].Value);
            }
            return dt;
        }*/
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            pedidoSelecionado = dgwPrincipal.DataSource as ItensDePedidoColecao;
            //var dt = GerarO_S();
            using (var relatorio = new FrmRelatorio(pedidoSelecionado, TxtAparelho.Text, TxtModelo.Text, DateTime.Now.ToString("dd/MM/yyyy"), TxtCliente.Text, TxtDefeito.Text, string.Format("R$ {0:0.00}", TxtValorTotal.Text)))
            {
                relatorio.ShowDialog();
            }
            /*using (var relatorio = new FrmRelatorio(dt, TxtAparelho.Text, TxtModelo.Text, DateTime.Now.ToString("dd/MM/yyyy"), TxtCliente.Text, TxtDefeito.Text, string.Format("R$ {0:0.00}", TxtValorTotal.Text)))
            {
                relatorio.ShowDialog();
            }
            //CaptureScreen();
            if(PDialImpressoras.ShowDialog() == DialogResult.OK)
            {
                
                
                PdImprimirOrdem.PrinterSettings = PDialImpressoras.PrinterSettings; //Escolhe a Impressora
                PdImprimirOrdem.DefaultPageSettings.Landscape = true;//Define a orientação da pagina
                PrintPreviewDialog ppd = new PrintPreviewDialog { Document = PdImprimirOrdem };//abre uma janela de dialogo com a vizualição do documento
                ((Form)ppd).WindowState = FormWindowState.Maximized;//Abertura da tela maximizada
                PdImprimirOrdem.PrintPage += delegate (object ev, PrintPageEventArgs ep)
                {
                    const int DGV_ALTO = 35;
                    int left = ep.MarginBounds.Left, top = ep.MarginBounds.Top;//define a area dentro da pagina(retangular)
                    foreach(DataGridViewColumn col in dgwPrincipal.Columns)
                    {
                        ep.Graphics.DrawString(col.HeaderText, new Font("Segoe Print", 16, FontStyle.Bold), Brushes.Black, left ,top);//Define a cor e a fonte do cabeçalho
                        left += col.Width;
                    }
                    left = ep.MarginBounds.Left;
                    ep.Graphics.FillRectangle(Brushes.Black,left, top + 40, ep.MarginBounds.Right - left, 3);//preenche o tamanho interno do cabeçalho
                    foreach(DataGridViewRow linha in dgwPrincipal.Rows)//percorre cada linha do datagrid
                    {
                        if (linha.Index.Equals(dgwPrincipal.RowCount - 1)) break;//para a leitura, se nao houver nenhuma linha
                        left = ep.MarginBounds.Left;
                        foreach(DataGridViewCell celula in linha.Cells)//faz a contagem de cada celula na linha
                        {
                            ep.Graphics.DrawString(Convert.ToString(celula.Value), new Font("Segoe Print", 13), Brushes.Black, left, top + 4);//ira fazer os textos, com as fontes e as cores das letras
                            left += celula.OwningColumn.Width;//Pega a coluna que tem a celula
                        }
                        top += DGV_ALTO;
                    }
                };
                //PdImprimirOrdem.Print();
                //ImprimirGrade();
                
            }*/

            /*
            FrmRelatorio relatorio = new FrmRelatorio();
            relatorio.ShowDialog();
            relatorio.Dispose();
            */
        }
        private void CaptureScreen()
        {
            /*
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            */
        }

        
    }
}
