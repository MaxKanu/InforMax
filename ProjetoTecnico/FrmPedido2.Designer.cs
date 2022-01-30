﻿namespace ProjetoTecnico
{
    partial class FrmPedido
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
            this.btnConsultarPedidos = new System.Windows.Forms.Button();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnPrincipal = new System.Windows.Forms.Panel();
            this.txtMarcador = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.ComboOperacao = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMarcador = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.ComboSituacao = new System.Windows.Forms.ComboBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.dateCadastro = new System.Windows.Forms.DateTimePicker();
            this.PnBotoes.SuspendLayout();
            this.PnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.btnConsultarPedidos);
            this.PnBotoes.Controls.Add(this.btnNovoCadastro);
            this.PnBotoes.Controls.Add(this.btnSalvar);
            this.PnBotoes.Controls.Add(this.btnAtualizar);
            this.PnBotoes.Controls.Add(this.btnPesquisa);
            this.PnBotoes.Controls.Add(this.btnVendas);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Location = new System.Drawing.Point(3, 357);
            this.PnBotoes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(926, 63);
            this.PnBotoes.TabIndex = 5;
            // 
            // btnConsultarPedidos
            // 
            this.btnConsultarPedidos.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnConsultarPedidos.Location = new System.Drawing.Point(420, 4);
            this.btnConsultarPedidos.Name = "btnConsultarPedidos";
            this.btnConsultarPedidos.Size = new System.Drawing.Size(92, 50);
            this.btnConsultarPedidos.TabIndex = 15;
            this.btnConsultarPedidos.Text = "Pesquisar Pedidos";
            this.btnConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnNovoCadastro.Location = new System.Drawing.Point(9, 4);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(92, 50);
            this.btnNovoCadastro.TabIndex = 9;
            this.btnNovoCadastro.Text = "Novo";
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnSalvar.Location = new System.Drawing.Point(146, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 50);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnAtualizar.Location = new System.Drawing.Point(283, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(92, 50);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnPesquisa.Location = new System.Drawing.Point(557, 4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(92, 50);
            this.btnPesquisa.TabIndex = 12;
            this.btnPesquisa.Text = "Pesquisar Clientes";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.btnVendas.Location = new System.Drawing.Point(694, 4);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(92, 50);
            this.btnVendas.TabIndex = 13;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.BtnVendas_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic);
            this.BtnSair.Location = new System.Drawing.Point(831, 4);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(92, 50);
            this.BtnSair.TabIndex = 14;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PnPrincipal
            // 
            this.PnPrincipal.Controls.Add(this.txtMarcador);
            this.PnPrincipal.Controls.Add(this.LblNome);
            this.PnPrincipal.Controls.Add(this.ComboOperacao);
            this.PnPrincipal.Controls.Add(this.lblTitulo);
            this.PnPrincipal.Controls.Add(this.lblMarcador);
            this.PnPrincipal.Controls.Add(this.lblIdPedido);
            this.PnPrincipal.Controls.Add(this.txtIdPedido);
            this.PnPrincipal.Controls.Add(this.lblIDCliente);
            this.PnPrincipal.Controls.Add(this.txtID);
            this.PnPrincipal.Controls.Add(this.lblOperacao);
            this.PnPrincipal.Controls.Add(this.ComboSituacao);
            this.PnPrincipal.Controls.Add(this.lblSituacao);
            this.PnPrincipal.Controls.Add(this.lblCadastro);
            this.PnPrincipal.Controls.Add(this.dateCadastro);
            this.PnPrincipal.Location = new System.Drawing.Point(3, 4);
            this.PnPrincipal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnPrincipal.Name = "PnPrincipal";
            this.PnPrincipal.Size = new System.Drawing.Size(926, 345);
            this.PnPrincipal.TabIndex = 4;
            // 
            // txtMarcador
            // 
            this.txtMarcador.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.txtMarcador.Location = new System.Drawing.Point(255, 172);
            this.txtMarcador.MaxLength = 50;
            this.txtMarcador.Name = "txtMarcador";
            this.txtMarcador.Size = new System.Drawing.Size(157, 29);
            this.txtMarcador.TabIndex = 58;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 10.25F);
            this.LblNome.Location = new System.Drawing.Point(313, 246);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(62, 24);
            this.LblNome.TabIndex = 57;
            this.LblNome.Text = "Cliente:";
            // 
            // ComboOperacao
            // 
            this.ComboOperacao.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.ComboOperacao.FormattingEnabled = true;
            this.ComboOperacao.Location = new System.Drawing.Point(508, 172);
            this.ComboOperacao.Name = "ComboOperacao";
            this.ComboOperacao.Size = new System.Drawing.Size(141, 29);
            this.ComboOperacao.TabIndex = 56;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Italic);
            this.lblTitulo.Location = new System.Drawing.Point(285, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(304, 56);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "Cadastro Pedidos";
            // 
            // lblMarcador
            // 
            this.lblMarcador.AutoSize = true;
            this.lblMarcador.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.lblMarcador.Location = new System.Drawing.Point(170, 175);
            this.lblMarcador.Name = "lblMarcador";
            this.lblMarcador.Size = new System.Drawing.Size(79, 23);
            this.lblMarcador.TabIndex = 53;
            this.lblMarcador.Text = "Marcador:";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.lblIdPedido.Location = new System.Drawing.Point(9, 175);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(28, 23);
            this.lblIdPedido.TabIndex = 51;
            this.lblIdPedido.Text = "ID:";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtIdPedido.Enabled = false;
            this.txtIdPedido.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.txtIdPedido.Location = new System.Drawing.Point(40, 172);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(100, 29);
            this.txtIdPedido.TabIndex = 52;
            this.txtIdPedido.UseWaitCursor = true;
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.lblIDCliente.Location = new System.Drawing.Point(53, 247);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(79, 23);
            this.lblIDCliente.TabIndex = 49;
            this.lblIDCliente.Text = "ID Cliente:";
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.txtID.Location = new System.Drawing.Point(138, 244);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 29);
            this.txtID.TabIndex = 50;
            this.txtID.UseWaitCursor = true;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.lblOperacao.Location = new System.Drawing.Point(426, 175);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(76, 23);
            this.lblOperacao.TabIndex = 48;
            this.lblOperacao.Text = "Operação:";
            // 
            // ComboSituacao
            // 
            this.ComboSituacao.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.ComboSituacao.FormattingEnabled = true;
            this.ComboSituacao.Location = new System.Drawing.Point(775, 172);
            this.ComboSituacao.Name = "ComboSituacao";
            this.ComboSituacao.Size = new System.Drawing.Size(141, 29);
            this.ComboSituacao.TabIndex = 47;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.lblSituacao.Location = new System.Drawing.Point(699, 175);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(70, 23);
            this.lblSituacao.TabIndex = 46;
            this.lblSituacao.Text = "Situação:";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.lblCadastro.Location = new System.Drawing.Point(730, 11);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(74, 23);
            this.lblCadastro.TabIndex = 44;
            this.lblCadastro.Text = "Cadastro:";
            // 
            // dateCadastro
            // 
            this.dateCadastro.Enabled = false;
            this.dateCadastro.Font = new System.Drawing.Font("Segoe Print", 9.25F);
            this.dateCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCadastro.Location = new System.Drawing.Point(810, 8);
            this.dateCadastro.Name = "dateCadastro";
            this.dateCadastro.Size = new System.Drawing.Size(112, 29);
            this.dateCadastro.TabIndex = 45;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 427);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PnPrincipal);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.PnBotoes.ResumeLayout(false);
            this.PnPrincipal.ResumeLayout(false);
            this.PnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Button btnConsultarPedidos;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Panel PnPrincipal;
        private System.Windows.Forms.ComboBox ComboOperacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMarcador;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.ComboBox ComboSituacao;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.DateTimePicker dateCadastro;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.TextBox txtMarcador;
    }
}