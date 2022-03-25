namespace ProjetoTecnico
{
    partial class frmPesquisarCadastroFisico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAlterarJuridico = new System.Windows.Forms.Button();
            this.BtnConsultarJuridico = new System.Windows.Forms.Button();
            this.BtnConsCliente = new System.Windows.Forms.Button();
            this.BtnAlterCliente = new System.Windows.Forms.Button();
            this.BtnAlterFuncio = new System.Windows.Forms.Button();
            this.BtnConsulFuncio = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnPesquisar);
            this.panel1.Controls.Add(this.TxtNome);
            this.panel1.Controls.Add(this.LblNome);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.dgwPrincipal);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 459);
            this.panel1.TabIndex = 0;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(438, 94);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(75, 29);
            this.BtnPesquisar.TabIndex = 11;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtNome.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.TxtNome.Location = new System.Drawing.Point(62, 94);
            this.TxtNome.MaxLength = 160;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(370, 29);
            this.TxtNome.TabIndex = 10;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.LblNome.Location = new System.Drawing.Point(7, 98);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 21);
            this.LblNome.TabIndex = 9;
            this.LblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(244, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 38);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Pesquisar Cadastro";
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Rua,
            this.Bairro,
            this.Celular,
            this.Situacao});
            this.dgwPrincipal.Location = new System.Drawing.Point(3, 141);
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(709, 313);
            this.dgwPrincipal.TabIndex = 0;
            this.dgwPrincipal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataPesquisar_CellFormatting);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Pessoa.Id";
            this.Id.HeaderText = "Codigo";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Pessoa.Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nome.Width = 200;
            // 
            // Rua
            // 
            this.Rua.DataPropertyName = "Endereco.Rua";
            this.Rua.HeaderText = "Rua";
            this.Rua.Name = "Rua";
            this.Rua.ReadOnly = true;
            this.Rua.Width = 200;
            // 
            // Bairro
            // 
            this.Bairro.DataPropertyName = "Endereco.Bairro";
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.ReadOnly = true;
            this.Bairro.Width = 200;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "Telefone.Celular1";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Pessoa.Situacao.Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnAlterarJuridico);
            this.panel2.Controls.Add(this.BtnConsultarJuridico);
            this.panel2.Controls.Add(this.BtnConsCliente);
            this.panel2.Controls.Add(this.BtnAlterCliente);
            this.panel2.Controls.Add(this.BtnAlterFuncio);
            this.panel2.Controls.Add(this.BtnConsulFuncio);
            this.panel2.Controls.Add(this.BtnSair);
            this.panel2.Location = new System.Drawing.Point(3, 469);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 57);
            this.panel2.TabIndex = 1;
            // 
            // BtnAlterarJuridico
            // 
            this.BtnAlterarJuridico.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.BtnAlterarJuridico.Location = new System.Drawing.Point(417, 3);
            this.BtnAlterarJuridico.Name = "BtnAlterarJuridico";
            this.BtnAlterarJuridico.Size = new System.Drawing.Size(78, 47);
            this.BtnAlterarJuridico.TabIndex = 10;
            this.BtnAlterarJuridico.Text = "Alterar Juridico";
            this.BtnAlterarJuridico.UseVisualStyleBackColor = true;
            this.BtnAlterarJuridico.Click += new System.EventHandler(this.BtnAlterarJuridico_Click);
            // 
            // BtnConsultarJuridico
            // 
            this.BtnConsultarJuridico.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.BtnConsultarJuridico.Location = new System.Drawing.Point(517, 3);
            this.BtnConsultarJuridico.Name = "BtnConsultarJuridico";
            this.BtnConsultarJuridico.Size = new System.Drawing.Size(82, 47);
            this.BtnConsultarJuridico.TabIndex = 11;
            this.BtnConsultarJuridico.Text = "Consultar Juridico";
            this.BtnConsultarJuridico.UseVisualStyleBackColor = true;
            this.BtnConsultarJuridico.Click += new System.EventHandler(this.BtnConsultarJuridico_Click);
            // 
            // BtnConsCliente
            // 
            this.BtnConsCliente.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.BtnConsCliente.Location = new System.Drawing.Point(116, 3);
            this.BtnConsCliente.Name = "BtnConsCliente";
            this.BtnConsCliente.Size = new System.Drawing.Size(75, 47);
            this.BtnConsCliente.TabIndex = 5;
            this.BtnConsCliente.Text = "Consultar Cliente";
            this.BtnConsCliente.UseVisualStyleBackColor = true;
            this.BtnConsCliente.Click += new System.EventHandler(this.BtnConsCliente_Click);
            // 
            // BtnAlterCliente
            // 
            this.BtnAlterCliente.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.BtnAlterCliente.Location = new System.Drawing.Point(19, 3);
            this.BtnAlterCliente.Name = "BtnAlterCliente";
            this.BtnAlterCliente.Size = new System.Drawing.Size(75, 47);
            this.BtnAlterCliente.TabIndex = 6;
            this.BtnAlterCliente.Text = "Alterar Cliente";
            this.BtnAlterCliente.UseVisualStyleBackColor = true;
            this.BtnAlterCliente.Click += new System.EventHandler(this.BtnAlterCliente_Click);
            // 
            // BtnAlterFuncio
            // 
            this.BtnAlterFuncio.Font = new System.Drawing.Font("Segoe Print", 7F);
            this.BtnAlterFuncio.Location = new System.Drawing.Point(213, 3);
            this.BtnAlterFuncio.Name = "BtnAlterFuncio";
            this.BtnAlterFuncio.Size = new System.Drawing.Size(78, 47);
            this.BtnAlterFuncio.TabIndex = 7;
            this.BtnAlterFuncio.Text = "Alterar Funcionario";
            this.BtnAlterFuncio.UseVisualStyleBackColor = true;
            this.BtnAlterFuncio.Click += new System.EventHandler(this.BtnAlterFuncio_Click);
            // 
            // BtnConsulFuncio
            // 
            this.BtnConsulFuncio.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.BtnConsulFuncio.Location = new System.Drawing.Point(313, 3);
            this.BtnConsulFuncio.Name = "BtnConsulFuncio";
            this.BtnConsulFuncio.Size = new System.Drawing.Size(82, 47);
            this.BtnConsulFuncio.TabIndex = 8;
            this.BtnConsulFuncio.Text = "Consultar Funcionario";
            this.BtnConsulFuncio.UseVisualStyleBackColor = true;
            this.BtnConsulFuncio.Click += new System.EventHandler(this.BtnConsulFuncio_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(621, 3);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 9;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // frmPesquisarCadastroFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe Print", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPesquisarCadastroFisico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cadastro Fisico";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnConsCliente;
        private System.Windows.Forms.Button BtnAlterCliente;
        private System.Windows.Forms.Button BtnAlterFuncio;
        private System.Windows.Forms.Button BtnConsulFuncio;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button BtnAlterarJuridico;
        private System.Windows.Forms.Button BtnConsultarJuridico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}