namespace ProjetoTecnico
{
    partial class FrmPesquisarPedidos
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
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.dgwPrincipal = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marcador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnBotoes = new System.Windows.Forms.Panel();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.TxtPesquisa = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).BeginInit();
            this.PnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::ProjetoTecnico.Properties.Resources.SGN_10_05_2021_1633453034999_1_;
            this.PicLogo.Location = new System.Drawing.Point(4, 172);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(268, 297);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 41;
            this.PicLogo.TabStop = false;
            // 
            // dgwPrincipal
            // 
            this.dgwPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.Cliente,
            this.Situacao,
            this.Cadastro,
            this.Marcador});
            this.dgwPrincipal.Location = new System.Drawing.Point(276, 172);
            this.dgwPrincipal.Name = "dgwPrincipal";
            this.dgwPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwPrincipal.Size = new System.Drawing.Size(519, 297);
            this.dgwPrincipal.TabIndex = 4;
            this.dgwPrincipal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgwPrincipal_CellFormatting);
            // 
            // IdPedido
            // 
            this.IdPedido.DataPropertyName = "IdPedidos";
            this.IdPedido.HeaderText = "Nº_Pedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.DataPropertyName = "Cliente.Pessoa.Nome";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 250;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao.Situacao";
            this.Situacao.HeaderText = "Situacao";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 170;
            // 
            // Cadastro
            // 
            this.Cadastro.DataPropertyName = "Cadastro";
            this.Cadastro.HeaderText = "Data_Pedido";
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.ReadOnly = true;
            this.Cadastro.Width = 150;
            // 
            // Marcador
            // 
            this.Marcador.DataPropertyName = "Marcador";
            this.Marcador.HeaderText = "Marcador";
            this.Marcador.Name = "Marcador";
            this.Marcador.ReadOnly = true;
            this.Marcador.Width = 200;
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtnNovo);
            this.PnBotoes.Controls.Add(this.BtnSelecionar);
            this.PnBotoes.Controls.Add(this.BtnExcluir);
            this.PnBotoes.Controls.Add(this.BtnCancelar);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Location = new System.Drawing.Point(223, 478);
            this.PnBotoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(573, 54);
            this.PnBotoes.TabIndex = 5;
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnNovo.Location = new System.Drawing.Point(17, 6);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(59, 42);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.Text = "Novo\r\n";
            this.BtnNovo.UseVisualStyleBackColor = true;
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSelecionar.Location = new System.Drawing.Point(133, 6);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(69, 42);
            this.BtnSelecionar.TabIndex = 1;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnExcluir.Location = new System.Drawing.Point(259, 6);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(64, 42);
            this.BtnExcluir.TabIndex = 2;
            this.BtnExcluir.Text = "Excluir Item";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnCancelar.Location = new System.Drawing.Point(380, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(64, 42);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnSair.Location = new System.Drawing.Point(501, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(64, 42);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.BtnPesquisar.Location = new System.Drawing.Point(587, 121);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(64, 26);
            this.BtnPesquisar.TabIndex = 3;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // TxtPesquisa
            // 
            this.TxtPesquisa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtPesquisa.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtPesquisa.Location = new System.Drawing.Point(264, 121);
            this.TxtPesquisa.MaxLength = 160;
            this.TxtPesquisa.Name = "TxtPesquisa";
            this.TxtPesquisa.Size = new System.Drawing.Size(318, 25);
            this.TxtPesquisa.TabIndex = 2;
            this.TxtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblNome.Location = new System.Drawing.Point(217, 125);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 17);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 19F);
            this.lblTitulo.Location = new System.Drawing.Point(307, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(251, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pesquisar Pedidos";
            // 
            // FrmPesquisarPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.TxtPesquisa);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.dgwPrincipal);
            this.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPesquisarPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPesquisarPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPrincipal)).EndInit();
            this.PnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.DataGridView dgwPrincipal;
        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSelecionar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.TextBox TxtPesquisa;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marcador;
    }
}