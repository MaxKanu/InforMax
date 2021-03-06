namespace ProjetoTecnico
{
    partial class FrmPreco
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
            this.comboServicos = new System.Windows.Forms.ComboBox();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.TxtPreco2 = new System.Windows.Forms.TextBox();
            this.LblPreco2 = new System.Windows.Forms.Label();
            this.LblId = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtPreco1 = new System.Windows.Forms.TextBox();
            this.LblPreco1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblServicos = new System.Windows.Forms.Label();
            this.LblProdutos = new System.Windows.Forms.Label();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnBotoes = new System.Windows.Forms.Panel();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.PnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboServicos
            // 
            this.comboServicos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.comboServicos.FormattingEnabled = true;
            this.comboServicos.Location = new System.Drawing.Point(77, 148);
            this.comboServicos.Name = "comboServicos";
            this.comboServicos.Size = new System.Drawing.Size(262, 25);
            this.comboServicos.TabIndex = 10;
            // 
            // comboProdutos
            // 
            this.comboProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(77, 117);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(262, 25);
            this.comboProdutos.TabIndex = 6;
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.BtnSelecionar);
            this.PnPrincipal.Controls.Add(this.BtnPesquisar);
            this.PnPrincipal.Controls.Add(this.TxtPreco2);
            this.PnPrincipal.Controls.Add(this.LblPreco2);
            this.PnPrincipal.Controls.Add(this.LblId);
            this.PnPrincipal.Controls.Add(this.TxtId);
            this.PnPrincipal.Controls.Add(this.TxtPreco1);
            this.PnPrincipal.Controls.Add(this.LblPreco1);
            this.PnPrincipal.Controls.Add(this.lblTitulo);
            this.PnPrincipal.Controls.Add(this.LblServicos);
            this.PnPrincipal.Controls.Add(this.LblProdutos);
            this.PnPrincipal.Controls.Add(this.dgwPrincipal);
            this.PnPrincipal.Controls.Add(this.comboProdutos);
            this.PnPrincipal.Controls.Add(this.comboServicos);
            this.PnPrincipal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.PnPrincipal.Location = new System.Drawing.Point(5, 12);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(551, 399);
            this.PnPrincipal.TabIndex = 0;
            this.PnPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnPrincipal_Paint);
            // 
            // TxtPreco2
            // 
            this.TxtPreco2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPreco2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPreco2.Location = new System.Drawing.Point(417, 117);
            this.TxtPreco2.MaxLength = 50;
            this.TxtPreco2.Name = "TxtPreco2";
            this.TxtPreco2.Size = new System.Drawing.Size(127, 25);
            this.TxtPreco2.TabIndex = 8;
            this.TxtPreco2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPreco2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco2_KeyPress);
            // 
            // LblPreco2
            // 
            this.LblPreco2.AutoSize = true;
            this.LblPreco2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblPreco2.Location = new System.Drawing.Point(364, 120);
            this.LblPreco2.Name = "LblPreco2";
            this.LblPreco2.Size = new System.Drawing.Size(39, 17);
            this.LblPreco2.TabIndex = 7;
            this.LblPreco2.Text = "Preço:";
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblId.Location = new System.Drawing.Point(7, 87);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 17);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // TxtId
            // 
            this.TxtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtId.Location = new System.Drawing.Point(34, 86);
            this.TxtId.MaxLength = 50;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(127, 25);
            this.TxtId.TabIndex = 2;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPreco1
            // 
            this.TxtPreco1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPreco1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPreco1.Location = new System.Drawing.Point(417, 149);
            this.TxtPreco1.MaxLength = 50;
            this.TxtPreco1.Name = "TxtPreco1";
            this.TxtPreco1.Size = new System.Drawing.Size(127, 25);
            this.TxtPreco1.TabIndex = 12;
            this.TxtPreco1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPreco1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPreco1_KeyPress);
            // 
            // LblPreco1
            // 
            this.LblPreco1.AutoSize = true;
            this.LblPreco1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblPreco1.Location = new System.Drawing.Point(364, 152);
            this.LblPreco1.Name = "LblPreco1";
            this.LblPreco1.Size = new System.Drawing.Size(39, 17);
            this.LblPreco1.TabIndex = 11;
            this.LblPreco1.Text = "Preço:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(177, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(231, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro De Preços";
            // 
            // LblServicos
            // 
            this.LblServicos.AutoSize = true;
            this.LblServicos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblServicos.Location = new System.Drawing.Point(14, 152);
            this.LblServicos.Name = "LblServicos";
            this.LblServicos.Size = new System.Drawing.Size(50, 17);
            this.LblServicos.TabIndex = 9;
            this.LblServicos.Text = "Serviços:";
            // 
            // LblProdutos
            // 
            this.LblProdutos.AutoSize = true;
            this.LblProdutos.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblProdutos.Location = new System.Drawing.Point(14, 120);
            this.LblProdutos.Name = "LblProdutos";
            this.LblProdutos.Size = new System.Drawing.Size(57, 17);
            this.LblProdutos.TabIndex = 5;
            this.LblProdutos.Text = "Produtos:";
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Descricao,
            this.Preco});
            this.dgwPrincipal.Location = new System.Drawing.Point(5, 195);
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(546, 201);
            this.dgwPrincipal.TabIndex = 13;
            this.dgwPrincipal.TabStop = false;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descriçao";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 250;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 150;
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtnAlterar);
            this.PnBotoes.Controls.Add(this.BtnNovo);
            this.PnBotoes.Controls.Add(this.BtnSalvar);
            this.PnBotoes.Controls.Add(this.BtnCancelar);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Location = new System.Drawing.Point(50, 417);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(506, 62);
            this.PnBotoes.TabIndex = 1;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_selecionado_24;
            this.BtnSelecionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSelecionar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSelecionar.Location = new System.Drawing.Point(345, 81);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(75, 29);
            this.BtnSelecionar.TabIndex = 4;
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_pesquisar_16;
            this.BtnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnPesquisar.Location = new System.Drawing.Point(264, 81);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(39, 29);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.botao_atualizar;
            this.BtnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAlterar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnAlterar.Location = new System.Drawing.Point(227, 7);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 47);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackgroundImage = global::ProjetoTecnico.Properties.Resources.NovoCetro;
            this.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnNovo.Location = new System.Drawing.Point(29, 7);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 47);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_salvar_32;
            this.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSalvar.Location = new System.Drawing.Point(125, 7);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 47);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackgroundImage = global::ProjetoTecnico.Properties.Resources.kisspng_computer_icons_theme_clip_art_cancel_button_5abbe06e2cbec6_0343187815222621261833;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnCancelar.Location = new System.Drawing.Point(329, 7);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 47);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackgroundImage = global::ProjetoTecnico.Properties.Resources.icons8_sair_26__1_1;
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSair.Location = new System.Drawing.Point(431, 7);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // FrmPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 509);
            this.Controls.Add(this.PnPrincipal);
            this.Controls.Add(this.PnBotoes);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPreco";
            this.Load += new System.EventHandler(this.FrmPreco_Load);
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.PnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboServicos;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblServicos;
        private System.Windows.Forms.Label LblProdutos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblPreco1;
        private System.Windows.Forms.TextBox TxtPreco1;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.TextBox TxtPreco2;
        private System.Windows.Forms.Label LblPreco2;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnSelecionar;
    }
}