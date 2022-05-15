namespace ProjetoTecnico
{
    partial class FrmOrdemServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
<<<<<<< Updated upstream
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdemServico));
>>>>>>> Stashed changes
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.LblMarca = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.LblDefeito = new System.Windows.Forms.Label();
            this.TxtDefeito = new System.Windows.Forms.TextBox();
            this.TxtAparelho = new System.Windows.Forms.TextBox();
            this.LblAparelho = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPercentual = new System.Windows.Forms.TextBox();
            this.LblPercentual = new System.Windows.Forms.Label();
            this.TxtQuantidade = new System.Windows.Forms.TextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.LblDesconto = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblIdTarefa = new System.Windows.Forms.Label();
            this.TxtIdTarefa = new System.Windows.Forms.TextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.LblNomeOperado = new System.Windows.Forms.Label();
            this.LblOperador = new System.Windows.Forms.Label();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.DateNascimento = new System.Windows.Forms.DateTimePicker();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.BtnServico = new System.Windows.Forms.Button();
            this.BtnProdutos = new System.Windows.Forms.Button();
            this.TxtServico = new System.Windows.Forms.TextBox();
            this.TxtProdutos = new System.Windows.Forms.TextBox();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtPreco = new System.Windows.Forms.TextBox();
            this.LblPreco = new System.Windows.Forms.Label();
            this.LblServicos = new System.Windows.Forms.Label();
            this.LblProdutos = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PnBotoes = new System.Windows.Forms.Panel();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PdImprimirOrdem = new System.Drawing.Printing.PrintDocument();
            this.PDialImpressoras = new System.Windows.Forms.PrintDialog();
<<<<<<< Updated upstream
            this.txtIdPedido = new System.Windows.Forms.TextBox();
=======
>>>>>>> Stashed changes
            this.PnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.PnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.LblMarca);
            this.PnPrincipal.Controls.Add(this.TxtMarca);
            this.PnPrincipal.Controls.Add(this.LblDefeito);
            this.PnPrincipal.Controls.Add(this.TxtDefeito);
            this.PnPrincipal.Controls.Add(this.TxtAparelho);
            this.PnPrincipal.Controls.Add(this.LblAparelho);
            this.PnPrincipal.Controls.Add(this.LblModelo);
            this.PnPrincipal.Controls.Add(this.TxtModelo);
            this.PnPrincipal.Controls.Add(this.BtnPesquisar);
            this.PnPrincipal.Controls.Add(this.TxtPercentual);
            this.PnPrincipal.Controls.Add(this.LblPercentual);
            this.PnPrincipal.Controls.Add(this.TxtQuantidade);
            this.PnPrincipal.Controls.Add(this.LblQuantidade);
            this.PnPrincipal.Controls.Add(this.TxtDesconto);
            this.PnPrincipal.Controls.Add(this.LblDesconto);
            this.PnPrincipal.Controls.Add(this.TxtTotal);
            this.PnPrincipal.Controls.Add(this.LblTotal);
            this.PnPrincipal.Controls.Add(this.LblIdTarefa);
            this.PnPrincipal.Controls.Add(this.TxtIdTarefa);
            this.PnPrincipal.Controls.Add(this.lblIdPedido);
            this.PnPrincipal.Controls.Add(this.LblNomeOperado);
            this.PnPrincipal.Controls.Add(this.LblOperador);
            this.PnPrincipal.Controls.Add(this.BtnInserir);
            this.PnPrincipal.Controls.Add(this.LblCadastro);
            this.PnPrincipal.Controls.Add(this.DateNascimento);
            this.PnPrincipal.Controls.Add(this.PicLogo);
            this.PnPrincipal.Controls.Add(this.BtnServico);
            this.PnPrincipal.Controls.Add(this.BtnProdutos);
            this.PnPrincipal.Controls.Add(this.TxtServico);
            this.PnPrincipal.Controls.Add(this.TxtProdutos);
            this.PnPrincipal.Controls.Add(this.dgwPrincipal);
            this.PnPrincipal.Controls.Add(this.TxtCliente);
            this.PnPrincipal.Controls.Add(this.LblCliente);
            this.PnPrincipal.Controls.Add(this.LblId);
            this.PnPrincipal.Controls.Add(this.txtIdPedido);
            this.PnPrincipal.Controls.Add(this.TxtId);
            this.PnPrincipal.Controls.Add(this.TxtPreco);
            this.PnPrincipal.Controls.Add(this.LblPreco);
            this.PnPrincipal.Controls.Add(this.LblServicos);
            this.PnPrincipal.Controls.Add(this.LblProdutos);
            this.PnPrincipal.Controls.Add(this.lblTitulo);
            this.PnPrincipal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.PnPrincipal.Location = new System.Drawing.Point(6, 13);
            this.PnPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(1032, 596);
            this.PnPrincipal.TabIndex = 0;
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblMarca.Location = new System.Drawing.Point(286, 183);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(42, 17);
            this.LblMarca.TabIndex = 61;
            this.LblMarca.Text = "Marca:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtMarca.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtMarca.Location = new System.Drawing.Point(335, 179);
            this.TxtMarca.MaxLength = 50;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(127, 25);
            this.TxtMarca.TabIndex = 62;
            this.TxtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDefeito
            // 
            this.LblDefeito.AutoSize = true;
            this.LblDefeito.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblDefeito.Location = new System.Drawing.Point(737, 184);
            this.LblDefeito.Name = "LblDefeito";
            this.LblDefeito.Size = new System.Drawing.Size(47, 17);
            this.LblDefeito.TabIndex = 60;
            this.LblDefeito.Text = "Defeito:";
            // 
            // TxtDefeito
            // 
            this.TxtDefeito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtDefeito.Font = new System.Drawing.Font("Segoe Print", 8.5F);
            this.TxtDefeito.Location = new System.Drawing.Point(790, 84);
            this.TxtDefeito.MaxLength = 200;
            this.TxtDefeito.Multiline = true;
            this.TxtDefeito.Name = "TxtDefeito";
            this.TxtDefeito.Size = new System.Drawing.Size(235, 163);
            this.TxtDefeito.TabIndex = 59;
            this.TxtDefeito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtAparelho
            // 
            this.TxtAparelho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtAparelho.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtAparelho.Location = new System.Drawing.Point(64, 180);
            this.TxtAparelho.MaxLength = 50;
            this.TxtAparelho.Name = "TxtAparelho";
            this.TxtAparelho.Size = new System.Drawing.Size(163, 25);
            this.TxtAparelho.TabIndex = 58;
            this.TxtAparelho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblAparelho
            // 
            this.LblAparelho.AutoSize = true;
            this.LblAparelho.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblAparelho.Location = new System.Drawing.Point(9, 184);
            this.LblAparelho.Name = "LblAparelho";
            this.LblAparelho.Size = new System.Drawing.Size(56, 17);
            this.LblAparelho.TabIndex = 57;
            this.LblAparelho.Text = "Aparelho:";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblModelo.Location = new System.Drawing.Point(500, 184);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(47, 17);
            this.LblModelo.TabIndex = 55;
            this.LblModelo.Text = "Modelo:";
            // 
            // TxtModelo
            // 
            this.TxtModelo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtModelo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtModelo.Location = new System.Drawing.Point(553, 180);
            this.TxtModelo.MaxLength = 50;
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(127, 25);
            this.TxtModelo.TabIndex = 56;
            this.TxtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnPesquisar.Location = new System.Drawing.Point(186, 35);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(36, 29);
            this.BtnPesquisar.TabIndex = 54;
            this.BtnPesquisar.Text = "...";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtPercentual
            // 
            this.TxtPercentual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPercentual.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPercentual.Location = new System.Drawing.Point(378, 262);
            this.TxtPercentual.MaxLength = 50;
            this.TxtPercentual.Name = "TxtPercentual";
            this.TxtPercentual.Size = new System.Drawing.Size(66, 25);
            this.TxtPercentual.TabIndex = 53;
            this.TxtPercentual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPercentual.TextChanged += new System.EventHandler(this.TxtPercentual_TextChanged);
            // 
            // LblPercentual
            // 
            this.LblPercentual.AutoSize = true;
            this.LblPercentual.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblPercentual.Location = new System.Drawing.Point(339, 266);
            this.LblPercentual.Name = "LblPercentual";
            this.LblPercentual.Size = new System.Drawing.Size(33, 17);
            this.LblPercentual.TabIndex = 52;
            this.LblPercentual.Text = "Perc:";
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtQuantidade.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtQuantidade.Location = new System.Drawing.Point(86, 262);
            this.TxtQuantidade.MaxLength = 50;
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.Size = new System.Drawing.Size(83, 25);
            this.TxtQuantidade.TabIndex = 51;
            this.TxtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblQuantidade.Location = new System.Drawing.Point(9, 266);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(71, 17);
            this.LblQuantidade.TabIndex = 50;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtDesconto.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtDesconto.Location = new System.Drawing.Point(520, 262);
            this.TxtDesconto.MaxLength = 50;
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(127, 25);
            this.TxtDesconto.TabIndex = 49;
            this.TxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblDesconto
            // 
            this.LblDesconto.AutoSize = true;
            this.LblDesconto.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblDesconto.Location = new System.Drawing.Point(457, 266);
            this.LblDesconto.Name = "LblDesconto";
            this.LblDesconto.Size = new System.Drawing.Size(57, 17);
            this.LblDesconto.TabIndex = 48;
            this.LblDesconto.Text = "Desconto:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtTotal.Location = new System.Drawing.Point(744, 262);
            this.TxtTotal.MaxLength = 50;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(127, 25);
            this.TxtTotal.TabIndex = 47;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblTotal.Location = new System.Drawing.Point(669, 266);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(69, 17);
            this.LblTotal.TabIndex = 46;
            this.LblTotal.Text = "Valor Total:";
            // 
            // LblIdTarefa
            // 
            this.LblIdTarefa.AutoSize = true;
            this.LblIdTarefa.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblIdTarefa.Location = new System.Drawing.Point(9, 224);
            this.LblIdTarefa.Name = "LblIdTarefa";
            this.LblIdTarefa.Size = new System.Drawing.Size(54, 17);
            this.LblIdTarefa.TabIndex = 44;
            this.LblIdTarefa.Text = "IdTarefa:";
            // 
            // TxtIdTarefa
            // 
            this.TxtIdTarefa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtIdTarefa.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtIdTarefa.Location = new System.Drawing.Point(69, 220);
            this.TxtIdTarefa.MaxLength = 50;
            this.TxtIdTarefa.Name = "TxtIdTarefa";
            this.TxtIdTarefa.Size = new System.Drawing.Size(78, 25);
            this.TxtIdTarefa.TabIndex = 45;
            this.TxtIdTarefa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.lblIdPedido.Location = new System.Drawing.Point(9, 41);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(62, 17);
            this.lblIdPedido.TabIndex = 42;
            this.lblIdPedido.Text = "Nº Pedido:";
            // 
            // LblNomeOperado
            // 
            this.LblNomeOperado.AutoSize = true;
            this.LblNomeOperado.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblNomeOperado.Location = new System.Drawing.Point(821, 50);
            this.LblNomeOperado.Name = "LblNomeOperado";
            this.LblNomeOperado.Size = new System.Drawing.Size(89, 17);
            this.LblNomeOperado.TabIndex = 41;
            this.LblNomeOperado.Text = "Nome Operador";
            // 
            // LblOperador
            // 
            this.LblOperador.AutoSize = true;
            this.LblOperador.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblOperador.Location = new System.Drawing.Point(834, 10);
            this.LblOperador.Name = "LblOperador";
            this.LblOperador.Size = new System.Drawing.Size(59, 17);
            this.LblOperador.TabIndex = 40;
            this.LblOperador.Text = "Operador:";
            // 
            // BtnInserir
            // 
            this.BtnInserir.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnInserir.Location = new System.Drawing.Point(877, 260);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(63, 29);
            this.BtnInserir.TabIndex = 15;
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCadastro.Location = new System.Drawing.Point(576, 143);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(57, 17);
            this.LblCadastro.TabIndex = 5;
            this.LblCadastro.Text = "Cadastro:";
            // 
            // DateNascimento
            // 
            this.DateNascimento.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.DateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNascimento.Location = new System.Drawing.Point(639, 139);
            this.DateNascimento.Name = "DateNascimento";
            this.DateNascimento.Size = new System.Drawing.Size(127, 25);
            this.DateNascimento.TabIndex = 6;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::ProjetoTecnico.Properties.Resources.SGN_10_05_2021_1633453034999_1_;
            this.PicLogo.Location = new System.Drawing.Point(6, 295);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(318, 292);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 39;
            this.PicLogo.TabStop = false;
            // 
            // BtnServico
            // 
            this.BtnServico.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnServico.Location = new System.Drawing.Point(757, 218);
            this.BtnServico.Name = "BtnServico";
            this.BtnServico.Size = new System.Drawing.Size(28, 29);
            this.BtnServico.TabIndex = 12;
            this.BtnServico.Text = "...";
            this.BtnServico.UseVisualStyleBackColor = true;
            this.BtnServico.Click += new System.EventHandler(this.BtnServico_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnProdutos.Location = new System.Drawing.Point(439, 218);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.Size = new System.Drawing.Size(28, 29);
            this.BtnProdutos.TabIndex = 9;
            this.BtnProdutos.Text = "...";
            this.BtnProdutos.UseVisualStyleBackColor = true;
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // TxtServico
            // 
            this.TxtServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtServico.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtServico.Location = new System.Drawing.Point(535, 220);
            this.TxtServico.MaxLength = 50;
            this.TxtServico.Name = "TxtServico";
            this.TxtServico.Size = new System.Drawing.Size(216, 25);
            this.TxtServico.TabIndex = 11;
            this.TxtServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtProdutos
            // 
            this.TxtProdutos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtProdutos.Location = new System.Drawing.Point(217, 220);
            this.TxtProdutos.MaxLength = 50;
            this.TxtProdutos.Name = "TxtProdutos";
            this.TxtProdutos.Size = new System.Drawing.Size(216, 25);
            this.TxtProdutos.TabIndex = 8;
            this.TxtProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.dgwPrincipal.Location = new System.Drawing.Point(330, 295);
            this.dgwPrincipal.MultiSelect = false;
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.ReadOnly = true;
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(702, 292);
            this.dgwPrincipal.TabIndex = 16;
            this.dgwPrincipal.TabStop = false;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quant.DefaultCellStyle = dataGridViewCellStyle1;
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
            // TxtCliente
            // 
            this.TxtCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtCliente.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtCliente.Location = new System.Drawing.Point(247, 139);
            this.TxtCliente.MaxLength = 50;
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(303, 25);
            this.TxtCliente.TabIndex = 4;
            this.TxtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCliente.Location = new System.Drawing.Point(195, 143);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(46, 17);
            this.LblCliente.TabIndex = 3;
            this.LblCliente.Text = "Cliente:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblId.Location = new System.Drawing.Point(9, 143);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 17);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtIdPedido.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.txtIdPedido.Location = new System.Drawing.Point(77, 38);
            this.txtIdPedido.MaxLength = 50;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(84, 25);
            this.txtIdPedido.TabIndex = 2;
            this.txtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtId
            // 
            this.TxtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtId.Location = new System.Drawing.Point(36, 140);
            this.TxtId.MaxLength = 50;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(127, 25);
            this.TxtId.TabIndex = 2;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPreco
            // 
            this.TxtPreco.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPreco.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPreco.Location = new System.Drawing.Point(233, 262);
            this.TxtPreco.MaxLength = 50;
            this.TxtPreco.Name = "TxtPreco";
            this.TxtPreco.Size = new System.Drawing.Size(100, 25);
            this.TxtPreco.TabIndex = 14;
            this.TxtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPreco.TextChanged += new System.EventHandler(this.TxtPreco_TextChanged);
            // 
            // LblPreco
            // 
            this.LblPreco.AutoSize = true;
            this.LblPreco.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblPreco.Location = new System.Drawing.Point(188, 266);
            this.LblPreco.Name = "LblPreco";
            this.LblPreco.Size = new System.Drawing.Size(39, 17);
            this.LblPreco.TabIndex = 13;
            this.LblPreco.Text = "Preço:";
            // 
            // LblServicos
            // 
            this.LblServicos.AutoSize = true;
            this.LblServicos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblServicos.Location = new System.Drawing.Point(479, 224);
            this.LblServicos.Name = "LblServicos";
            this.LblServicos.Size = new System.Drawing.Size(50, 17);
            this.LblServicos.TabIndex = 10;
            this.LblServicos.Text = "Serviços:";
            // 
            // LblProdutos
            // 
            this.LblProdutos.AutoSize = true;
            this.LblProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblProdutos.Location = new System.Drawing.Point(154, 224);
            this.LblProdutos.Name = "LblProdutos";
            this.LblProdutos.Size = new System.Drawing.Size(57, 17);
            this.LblProdutos.TabIndex = 7;
            this.LblProdutos.Text = "Produtos:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 19F);
            this.lblTitulo.Location = new System.Drawing.Point(383, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(272, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ordem De Serviços";
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtnImprimir);
            this.PnBotoes.Controls.Add(this.TxtValorTotal);
            this.PnBotoes.Controls.Add(this.LblValor);
            this.PnBotoes.Controls.Add(this.BtnNovo);
            this.PnBotoes.Controls.Add(this.BtnSalvar);
            this.PnBotoes.Controls.Add(this.BtnExcluir);
            this.PnBotoes.Controls.Add(this.BtnCancelar);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Location = new System.Drawing.Point(112, 617);
            this.PnBotoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(926, 60);
            this.PnBotoes.TabIndex = 1;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnImprimir.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.Image")));
            this.BtnImprimir.Location = new System.Drawing.Point(579, 6);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(40, 47);
            this.BtnImprimir.TabIndex = 50;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtValorTotal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtValorTotal.Location = new System.Drawing.Point(792, 17);
            this.TxtValorTotal.MaxLength = 50;
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(127, 25);
            this.TxtValorTotal.TabIndex = 49;
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtValorTotal.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblValor.Location = new System.Drawing.Point(696, 21);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(69, 17);
            this.LblValor.TabIndex = 48;
            this.LblValor.Text = "Valor Total:";
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.White;
            this.BtnNovo.BackgroundImage = global::ProjetoTecnico.Properties.Resources.NovoCetro;
            this.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnNovo.Location = new System.Drawing.Point(20, 6);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 47);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Lime;
            this.BtnSalvar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_salvar_32;
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSalvar.Location = new System.Drawing.Point(133, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 47);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnExcluir.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_remover_usuário_masculino_24;
            this.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnExcluir.Location = new System.Drawing.Point(252, 6);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 47);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.kisspng_computer_icons_theme_clip_art_cancel_button_5abbe06e2cbec6_0343187815222621261833;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnCancelar.Location = new System.Drawing.Point(371, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 47);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_sair_26__1_1;
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSair.Location = new System.Drawing.Point(490, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PdImprimirOrdem
            // 
            this.PdImprimirOrdem.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PdImprimirOrdem_PrintPage);
            // 
            // PDialImpressoras
            // 
            this.PDialImpressoras.UseEXDialog = true;
            // 
<<<<<<< Updated upstream
            // txtIdPedido
            // 
            this.txtIdPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtIdPedido.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.txtIdPedido.Location = new System.Drawing.Point(77, 38);
            this.txtIdPedido.MaxLength = 50;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(84, 25);
            this.txtIdPedido.TabIndex = 2;
            this.txtIdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
=======
>>>>>>> Stashed changes
            // FrmOrdemServico
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(1043, 722);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PnPrincipal);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordem de Servico";
            this.Load += new System.EventHandler(this.FrmOrdemServico_Load);
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.PnBotoes.ResumeLayout(false);
            this.PnBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox TxtServico;
        private System.Windows.Forms.TextBox TxtProdutos;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtPreco;
        private System.Windows.Forms.Label LblPreco;
        private System.Windows.Forms.Label LblServicos;
        private System.Windows.Forms.Label LblProdutos;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Button BtnServico;
        private System.Windows.Forms.Button BtnProdutos;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.DateTimePicker DateNascimento;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label LblNomeOperado;
        private System.Windows.Forms.Label LblOperador;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Label LblIdTarefa;
        private System.Windows.Forms.TextBox TxtIdTarefa;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.Label LblDesconto;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtQuantidade;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.TextBox TxtPercentual;
        private System.Windows.Forms.Label LblPercentual;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Drawing.Printing.PrintDocument PdImprimirOrdem;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.TextBox TxtAparelho;
        private System.Windows.Forms.Label LblAparelho;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtDefeito;
        private System.Windows.Forms.Label LblDefeito;
        private System.Windows.Forms.PrintDialog PDialImpressoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Total;
        private System.Windows.Forms.TextBox txtIdPedido;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.TextBox TxtMarca;
>>>>>>> Stashed changes
    }
}