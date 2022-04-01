namespace ProjetoTecnico
{
    partial class frmCadastroProduto
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
            this.PnBotoes = new System.Windows.Forms.Panel();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboFabricante = new System.Windows.Forms.ComboBox();
            this.LblFabricante = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.DateNascimento = new System.Windows.Forms.DateTimePicker();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PnBotoes.SuspendLayout();
            this.PnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtnNovo);
            this.PnBotoes.Controls.Add(this.BtnSalvar);
            this.PnBotoes.Controls.Add(this.BtnCancelar);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.PnBotoes.Location = new System.Drawing.Point(4, 447);
            this.PnBotoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(493, 58);
            this.PnBotoes.TabIndex = 1;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnNovo.Location = new System.Drawing.Point(23, 4);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 47);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo\r\n";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSalvar.Location = new System.Drawing.Point(147, 4);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 47);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnCancelar.Location = new System.Drawing.Point(277, 4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 47);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSair.Location = new System.Drawing.Point(407, 4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.dgwPrincipal);
            this.PnPrincipal.Controls.Add(this.comboFabricante);
            this.PnPrincipal.Controls.Add(this.LblFabricante);
            this.PnPrincipal.Controls.Add(this.LblCadastro);
            this.PnPrincipal.Controls.Add(this.DateNascimento);
            this.PnPrincipal.Controls.Add(this.TxtId);
            this.PnPrincipal.Controls.Add(this.TxtNome);
            this.PnPrincipal.Controls.Add(this.LblId);
            this.PnPrincipal.Controls.Add(this.LblNome);
            this.PnPrincipal.Controls.Add(this.lblTitulo);
            this.PnPrincipal.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.PnPrincipal.Location = new System.Drawing.Point(4, 5);
            this.PnPrincipal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(493, 432);
            this.PnPrincipal.TabIndex = 0;
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Descricao,
            this.Fabricante});
            this.dgwPrincipal.Location = new System.Drawing.Point(5, 177);
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(482, 242);
            this.dgwPrincipal.TabIndex = 8;
            this.dgwPrincipal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgwPrincipal_CellFormatting);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdProdutos";
            this.IdProduto.HeaderText = "Id_Produto";
            this.IdProduto.Name = "IdProduto";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 250;
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "Fabricante.Descricao";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            this.Fabricante.Width = 300;
            // 
            // comboFabricante
            // 
            this.comboFabricante.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.comboFabricante.FormattingEnabled = true;
            this.comboFabricante.Location = new System.Drawing.Point(281, 111);
            this.comboFabricante.Name = "comboFabricante";
            this.comboFabricante.Size = new System.Drawing.Size(204, 25);
            this.comboFabricante.TabIndex = 7;
            // 
            // LblFabricante
            // 
            this.LblFabricante.AutoSize = true;
            this.LblFabricante.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblFabricante.Location = new System.Drawing.Point(209, 114);
            this.LblFabricante.Name = "LblFabricante";
            this.LblFabricante.Size = new System.Drawing.Size(57, 17);
            this.LblFabricante.TabIndex = 3;
            this.LblFabricante.Text = "Cadastro:";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCadastro.Location = new System.Drawing.Point(166, 86);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(57, 17);
            this.LblCadastro.TabIndex = 3;
            this.LblCadastro.Text = "Cadastro:";
            // 
            // DateNascimento
            // 
            this.DateNascimento.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.DateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNascimento.Location = new System.Drawing.Point(229, 80);
            this.DateNascimento.Name = "DateNascimento";
            this.DateNascimento.Size = new System.Drawing.Size(127, 25);
            this.DateNascimento.TabIndex = 4;
            // 
            // TxtId
            // 
            this.TxtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtId.Location = new System.Drawing.Point(41, 111);
            this.TxtId.MaxLength = 160;
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(69, 25);
            this.TxtId.TabIndex = 2;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNome
            // 
            this.TxtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtNome.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtNome.Location = new System.Drawing.Point(115, 142);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(338, 25);
            this.TxtNome.TabIndex = 6;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblId.Location = new System.Drawing.Point(9, 114);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 17);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblNome.Location = new System.Drawing.Point(69, 145);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 17);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 19F);
            this.lblTitulo.Location = new System.Drawing.Point(96, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro De Produtos";
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 508);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PnPrincipal);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadastroProduto";
            this.Load += new System.EventHandler(this.FrmCadastroProduto_Load);
            this.PnBotoes.ResumeLayout(false);
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.DateTimePicker DateNascimento;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.ComboBox comboFabricante;
        private System.Windows.Forms.Label LblFabricante;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
    }
}