namespace ProjetoTecnico
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnBotoes = new System.Windows.Forms.Panel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.LblNomeOperador = new System.Windows.Forms.Label();
            this.LblOperador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.DateNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.LblIdTarefa = new System.Windows.Forms.Label();
            this.TxtIdTarefa = new System.Windows.Forms.TextBox();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.TxtProdutos = new System.Windows.Forms.TextBox();
            this.LblProdutos = new System.Windows.Forms.Label();
            this.TxtPercentual = new System.Windows.Forms.TextBox();
            this.LblPercentual = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.LblDesconto = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ComboAparelho = new System.Windows.Forms.ComboBox();
            this.LblAparelho = new System.Windows.Forms.Label();
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.LblMarca = new System.Windows.Forms.Label();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnBotoes.SuspendLayout();
            this.PnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtnImprimir);
            this.PnBotoes.Controls.Add(this.TxtValorTotal);
            this.PnBotoes.Controls.Add(this.LblValor);
            this.PnBotoes.Controls.Add(this.btnConsultarPedidos);
            this.PnBotoes.Controls.Add(this.btnSalvar);
            this.PnBotoes.Controls.Add(this.btnPesquisa);
            this.PnBotoes.Controls.Add(this.btnVendas);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Location = new System.Drawing.Point(3, 658);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(724, 63);
            this.PnBotoes.TabIndex = 5;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.Location = new System.Drawing.Point(385, 9);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(40, 47);
            this.BtnImprimir.TabIndex = 53;
            this.BtnImprimir.UseVisualStyleBackColor = true;
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtValorTotal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtValorTotal.Location = new System.Drawing.Point(588, 21);
            this.TxtValorTotal.MaxLength = 50;
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(127, 25);
            this.TxtValorTotal.TabIndex = 52;
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblValor.Location = new System.Drawing.Point(492, 25);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(69, 17);
            this.LblValor.TabIndex = 51;
            this.LblValor.Text = "Valor Total:";
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.btnConsultarPedidos.Location = new System.Drawing.Point(85, 7);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(70, 50);
            this.btnConsultarPedidos.TabIndex = 21;
            this.btnConsultarPedidos.Text = "Pesquisar Pedidos";
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.btnSalvar.Location = new System.Drawing.Point(9, 7);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(70, 50);
            this.btnSalvar.TabIndex = 16;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.btnPesquisa.Location = new System.Drawing.Point(161, 7);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(70, 50);
            this.btnPesquisa.TabIndex = 18;
            this.btnPesquisa.Text = "Pesquisar Clientes";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.btnVendas.Location = new System.Drawing.Point(237, 7);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(70, 50);
            this.btnVendas.TabIndex = 19;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            this.BtnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSair.Location = new System.Drawing.Point(309, 7);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(70, 50);
            this.BtnSair.TabIndex = 20;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.LblNomeOperador);
            this.PnPrincipal.Controls.Add(this.LblOperador);
            this.PnPrincipal.Controls.Add(this.button1);
            this.PnPrincipal.Controls.Add(this.LblCadastro);
            this.PnPrincipal.Controls.Add(this.DateNascimento);
            this.PnPrincipal.Controls.Add(this.TxtCliente);
            this.PnPrincipal.Controls.Add(this.LblCliente);
            this.PnPrincipal.Controls.Add(this.LblId);
            this.PnPrincipal.Controls.Add(this.TxtId);
            this.PnPrincipal.Controls.Add(this.lblIdPedido);
            this.PnPrincipal.Controls.Add(this.txtIdPedido);
            this.PnPrincipal.Controls.Add(this.LblIdTarefa);
            this.PnPrincipal.Controls.Add(this.TxtIdTarefa);
            this.PnPrincipal.Controls.Add(this.BtnProdutos);
            this.PnPrincipal.Controls.Add(this.TxtProdutos);
            this.PnPrincipal.Controls.Add(this.LblProdutos);
            this.PnPrincipal.Controls.Add(this.TxtPercentual);
            this.PnPrincipal.Controls.Add(this.LblPercentual);
            this.PnPrincipal.Controls.Add(this.TxtQuantidade);
            this.PnPrincipal.Controls.Add(this.LblQuantidade);
            this.PnPrincipal.Controls.Add(this.TxtDesconto);
            this.PnPrincipal.Controls.Add(this.LblDesconto);
            this.PnPrincipal.Controls.Add(this.TxtTotal);
            this.PnPrincipal.Controls.Add(this.LblTotal);
            this.PnPrincipal.Controls.Add(this.BtnInserir);
            this.PnPrincipal.Controls.Add(this.TxtPreco);
            this.PnPrincipal.Controls.Add(this.LblPreco);
            this.PnPrincipal.Controls.Add(this.lblTitulo);
            this.PnPrincipal.Controls.Add(this.ComboAparelho);
            this.PnPrincipal.Controls.Add(this.LblAparelho);
            this.PnPrincipal.Controls.Add(this.ComboMarca);
            this.PnPrincipal.Controls.Add(this.LblMarca);
            this.PnPrincipal.Controls.Add(this.dgwPrincipal);
            this.PnPrincipal.Location = new System.Drawing.Point(3, 4);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(859, 648);
            this.PnPrincipal.TabIndex = 4;
            // 
            // LblNomeOperador
            // 
            this.LblNomeOperador.AutoSize = true;
            this.LblNomeOperador.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.LblNomeOperador.Location = new System.Drawing.Point(663, 47);
            this.LblNomeOperador.Name = "LblNomeOperador";
            this.LblNomeOperador.Size = new System.Drawing.Size(116, 23);
            this.LblNomeOperador.TabIndex = 99;
            this.LblNomeOperador.Text = "Nome Operador";
            // 
            // LblOperador
            // 
            this.LblOperador.AutoSize = true;
            this.LblOperador.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.LblOperador.Location = new System.Drawing.Point(676, 7);
            this.LblOperador.Name = "LblOperador";
            this.LblOperador.Size = new System.Drawing.Size(77, 23);
            this.LblOperador.TabIndex = 98;
            this.LblOperador.Text = "Operador:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.button1.Location = new System.Drawing.Point(689, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 29);
            this.button1.TabIndex = 97;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCadastro.Location = new System.Drawing.Point(588, 128);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(57, 17);
            this.LblCadastro.TabIndex = 95;
            this.LblCadastro.Text = "Cadastro:";
            // 
            // DateNascimento
            // 
            this.DateNascimento.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.DateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNascimento.Location = new System.Drawing.Point(651, 124);
            this.DateNascimento.Name = "DateNascimento";
            this.DateNascimento.Size = new System.Drawing.Size(127, 25);
            this.DateNascimento.TabIndex = 96;
            // 
            // TxtCliente
            // 
            this.TxtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtCliente.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtCliente.Location = new System.Drawing.Point(259, 124);
            this.TxtCliente.MaxLength = 50;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(303, 25);
            this.TxtCliente.TabIndex = 94;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCliente.Location = new System.Drawing.Point(207, 128);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(46, 17);
            this.LblCliente.TabIndex = 93;
            this.LblCliente.Text = "Cliente:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblId.Location = new System.Drawing.Point(21, 128);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 17);
            this.LblId.TabIndex = 91;
            this.LblId.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtId.Location = new System.Drawing.Point(48, 125);
            this.TxtId.MaxLength = 50;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(127, 25);
            this.TxtId.TabIndex = 92;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.lblIdPedido.Location = new System.Drawing.Point(6, 42);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(62, 17);
            this.lblIdPedido.TabIndex = 90;
            this.lblIdPedido.Text = "Nº Pedido:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtIdPedido.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.txtIdPedido.Location = new System.Drawing.Point(74, 39);
            this.txtIdPedido.MaxLength = 50;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(84, 25);
            this.txtIdPedido.TabIndex = 89;
            this.txtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblIdTarefa
            // 
            this.LblIdTarefa.AutoSize = true;
            this.LblIdTarefa.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblIdTarefa.Location = new System.Drawing.Point(671, 182);
            this.LblIdTarefa.Name = "LblIdTarefa";
            this.LblIdTarefa.Size = new System.Drawing.Size(21, 17);
            this.LblIdTarefa.TabIndex = 87;
            this.LblIdTarefa.Text = "Id:";
            // 
            // TxtIdTarefa
            // 
            this.TxtIdTarefa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtIdTarefa.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtIdTarefa.Location = new System.Drawing.Point(700, 178);
            this.TxtIdTarefa.MaxLength = 50;
            this.TxtIdTarefa.Name = "TxtIdTarefa";
            this.TxtIdTarefa.Size = new System.Drawing.Size(78, 25);
            this.TxtIdTarefa.TabIndex = 88;
            this.TxtIdTarefa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnProdutos.Location = new System.Drawing.Point(645, 217);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(28, 29);
            this.BtnProdutos.TabIndex = 86;
            this.BtnProdutos.Text = "...";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // TxtProdutos
            // 
            this.TxtProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtProdutos.Location = new System.Drawing.Point(423, 219);
            this.TxtProdutos.MaxLength = 50;
            this.TxtProdutos.Name = "TxtProdutos";
            this.TxtProdutos.Size = new System.Drawing.Size(216, 25);
            this.TxtProdutos.TabIndex = 85;
            this.TxtProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblProdutos
            // 
            this.LblProdutos.AutoSize = true;
            this.LblProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblProdutos.Location = new System.Drawing.Point(360, 223);
            this.LblProdutos.Name = "LblProdutos";
            this.LblProdutos.Size = new System.Drawing.Size(57, 17);
            this.LblProdutos.TabIndex = 84;
            this.LblProdutos.Text = "Produtos:";
            // 
            // TxtPercentual
            // 
            this.TxtPercentual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPercentual.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPercentual.Location = new System.Drawing.Point(203, 262);
            this.TxtPercentual.MaxLength = 50;
            this.TxtPercentual.Name = "TxtPercentual";
            this.TxtPercentual.Size = new System.Drawing.Size(66, 25);
            this.TxtPercentual.TabIndex = 83;
            this.TxtPercentual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPercentual.TextChanged += new System.EventHandler(this.TxtPercentual_TextChanged);
            // 
            // LblPercentual
            // 
            this.LblPercentual.AutoSize = true;
            this.LblPercentual.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblPercentual.Location = new System.Drawing.Point(164, 266);
            this.LblPercentual.Name = "LblPercentual";
            this.LblPercentual.Size = new System.Drawing.Size(33, 17);
            this.LblPercentual.TabIndex = 82;
            this.LblPercentual.Text = "Perc:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtQuantidade.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtQuantidade.Location = new System.Drawing.Point(108, 219);
            this.TxtQuantidade.MaxLength = 50;
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(83, 25);
            this.TxtQuantidade.TabIndex = 81;
            this.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblQuantidade.Location = new System.Drawing.Point(31, 223);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(71, 17);
            this.LblQuantidade.TabIndex = 80;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtDesconto.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtDesconto.Location = new System.Drawing.Point(345, 262);
            this.TxtDesconto.MaxLength = 50;
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(127, 25);
            this.TxtDesconto.TabIndex = 79;
            this.TxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDesconto
            // 
            this.LblDesconto.AutoSize = true;
            this.LblDesconto.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblDesconto.Location = new System.Drawing.Point(282, 266);
            this.LblDesconto.Name = "LblDesconto";
            this.LblDesconto.Size = new System.Drawing.Size(57, 17);
            this.LblDesconto.TabIndex = 78;
            this.LblDesconto.Text = "Desconto:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtTotal.Location = new System.Drawing.Point(569, 266);
            this.TxtTotal.MaxLength = 50;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(104, 25);
            this.TxtTotal.TabIndex = 77;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblTotal.Location = new System.Drawing.Point(494, 270);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(69, 17);
            this.LblTotal.TabIndex = 76;
            this.LblTotal.Text = "Valor Total:";
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnInserir.Location = new System.Drawing.Point(876, 174);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(63, 29);
            this.BtnInserir.TabIndex = 75;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            // 
            // TxtPreco
            // 
            this.TxtPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPreco.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPreco.Location = new System.Drawing.Point(58, 262);
            this.TxtPreco.MaxLength = 50;
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(100, 25);
            this.TxtPreco.TabIndex = 74;
            this.TxtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPreco.TextChanged += new System.EventHandler(this.TxtPreco_TextChanged);
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblPreco.Location = new System.Drawing.Point(13, 266);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(39, 17);
            this.LblPreco.TabIndex = 73;
            this.LblPreco.Text = "Preço:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 22F);
            this.lblTitulo.Location = new System.Drawing.Point(376, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(132, 52);
            this.lblTitulo.TabIndex = 72;
            this.lblTitulo.Text = "Vendas";
            // 
            // ComboAparelho
            // 
            this.ComboAparelho.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.ComboAparelho.FormattingEnabled = true;
            this.ComboAparelho.Location = new System.Drawing.Point(75, 177);
            this.ComboAparelho.Name = "ComboAparelho";
            this.ComboAparelho.Size = new System.Drawing.Size(169, 25);
            this.ComboAparelho.TabIndex = 69;
            // 
            // LblAparelho
            // 
            this.LblAparelho.AutoSize = true;
            this.LblAparelho.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblAparelho.Location = new System.Drawing.Point(11, 181);
            this.LblAparelho.Name = "LblAparelho";
            this.LblAparelho.Size = new System.Drawing.Size(56, 17);
            this.LblAparelho.TabIndex = 68;
            this.LblAparelho.Text = "Aparelho:";
            // 
            // ComboMarca
            // 
            this.ComboMarca.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(385, 177);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(179, 25);
            this.ComboMarca.TabIndex = 67;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblMarca.Location = new System.Drawing.Point(337, 181);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(42, 17);
            this.LblMarca.TabIndex = 66;
            this.LblMarca.Text = "Marca:";
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.Quant,
            this.Descricao,
            this.Valor,
            this.Desconto,
            this.Valor_Total});
            this.dgwPrincipal.Location = new System.Drawing.Point(74, 317);
            this.dgwPrincipal.MultiSelect = false;
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.ReadOnly = true;
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(720, 319);
            this.dgwPrincipal.TabIndex = 17;
            this.dgwPrincipal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgwPrincipal_CellFormatting);
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "IdPedidos";
            this.IdPedido.HeaderText = "Id_Pedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            this.IdPedido.Width = 80;
            // 
            // Quant
            // 
            this.Quant.DataPropertyName = "Quantidade";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quant.DefaultCellStyle = dataGridViewCellStyle3;
            this.Quant.HeaderText = "Quantidade";
            this.Quant.Name = "Quant";
            this.Quant.ReadOnly = true;
            this.Quant.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "ValorUnitario";
            this.Valor.HeaderText = "Preço";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 90;
            // 
            // Desconto
            // 
            this.Desconto.DataPropertyName = "ValorDesconto";
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 80;
            // 
            // Valor_Total
            // 
            this.Valor_Total.DataPropertyName = "ValorTotal";
            this.Valor_Total.HeaderText = "Valor_Total";
            this.Valor_Total.Name = "Valor_Total";
            this.Valor_Total.ReadOnly = true;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 724);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PnPrincipal);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecao";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.PnBotoes.ResumeLayout(false);
            this.PnBotoes.PerformLayout();
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.ComboBox ComboAparelho;
        private System.Windows.Forms.Label LblAparelho;
        private System.Windows.Forms.ComboBox ComboMarca;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox TxtPercentual;
        private System.Windows.Forms.Label LblPercentual;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.Label LblDesconto;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblIdTarefa;
        private System.Windows.Forms.TextBox TxtIdTarefa;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.TextBox TxtProdutos;
        private System.Windows.Forms.Label LblProdutos;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.DateTimePicker DateNascimento;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblNomeOperador;
        private System.Windows.Forms.Label LblOperador;
    }
}