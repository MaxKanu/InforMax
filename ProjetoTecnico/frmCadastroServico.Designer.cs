namespace ProjetoTecnico
{
    partial class frmCadastroServico
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
            this.PnBotoes.Location = new System.Drawing.Point(86, 557);
            this.PnBotoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(438, 58);
            this.PnBotoes.TabIndex = 3;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(115, 6);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 47);
            this.BtnNovo.TabIndex = 4;
            this.BtnNovo.Text = "Novo\r\n";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click_1);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(191, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 47);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(273, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 47);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(355, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 7;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.dgwPrincipal);
            this.PnPrincipal.Controls.Add(this.LblCadastro);
            this.PnPrincipal.Controls.Add(this.DateNascimento);
            this.PnPrincipal.Controls.Add(this.TxtId);
            this.PnPrincipal.Controls.Add(this.TxtNome);
            this.PnPrincipal.Controls.Add(this.LblId);
            this.PnPrincipal.Controls.Add(this.LblNome);
            this.PnPrincipal.Controls.Add(this.lblTitulo);
            this.PnPrincipal.Location = new System.Drawing.Point(3, 4);
            this.PnPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(521, 545);
            this.PnPrincipal.TabIndex = 2;
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.Descricao});
            this.dgwPrincipal.Location = new System.Drawing.Point(-1, 231);
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(519, 337);
            this.dgwPrincipal.TabIndex = 18;
            this.dgwPrincipal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgwPrincipal_CellFormatting);
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "IdServicos";
            this.IdProduto.HeaderText = "Id_Produto";
            this.IdProduto.Name = "IdProduto";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 370;
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.LblCadastro.Location = new System.Drawing.Point(139, 58);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(68, 21);
            this.LblCadastro.TabIndex = 13;
            this.LblCadastro.Text = "Cadastro:";
            // 
            // DateNascimento
            // 
            this.DateNascimento.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.DateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNascimento.Location = new System.Drawing.Point(237, 52);
            this.DateNascimento.Name = "DateNascimento";
            this.DateNascimento.Size = new System.Drawing.Size(127, 29);
            this.DateNascimento.TabIndex = 14;
            // 
            // TxtId
            // 
            this.TxtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtId.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.TxtId.Location = new System.Drawing.Point(42, 129);
            this.TxtId.MaxLength = 160;
            this.TxtId.Name = "TxtId";
            this.TxtId.ReadOnly = true;
            this.TxtId.Size = new System.Drawing.Size(69, 29);
            this.TxtId.TabIndex = 11;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNome
            // 
            this.TxtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtNome.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.TxtNome.Location = new System.Drawing.Point(65, 197);
            this.TxtNome.MaxLength = 50;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(428, 29);
            this.TxtNome.TabIndex = 16;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.LblId.Location = new System.Drawing.Point(10, 133);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(26, 21);
            this.LblId.TabIndex = 10;
            this.LblId.Text = "Id:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.LblNome.Location = new System.Drawing.Point(10, 201);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 21);
            this.LblNome.TabIndex = 15;
            this.LblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(121, 5);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 38);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Cadastro De Produtos";
            // 
            // frmCadastroServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 624);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PnPrincipal);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCadastroServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Servico";
            this.PnBotoes.ResumeLayout(false);
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.DateTimePicker DateNascimento;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}