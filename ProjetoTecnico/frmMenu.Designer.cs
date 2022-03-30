namespace ProjetoTecnico
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.TsTrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.clienteFisicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteJuridicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.funcionariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosDoSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permissõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBPesquisaCadastro = new System.Windows.Forms.ToolStripDropDownButton();
            this.fisicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juridicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsCadastroServicos = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPreço = new System.Windows.Forms.ToolStripMenuItem();
            this.TsServiços = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPreçoServico = new System.Windows.Forms.ToolStripMenuItem();
            this.TsFabricante = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsPesquisaServicos = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsOS = new System.Windows.Forms.ToolStripMenuItem();
            this.TsConsultarOS = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoProdutoInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoProdutoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoProdutoAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoServicoInserir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoServicoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPrecoServicoAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSair = new System.Windows.Forms.ToolStripButton();
            this.LblRelogio = new System.Windows.Forms.Label();
            this.TsPesquisarNotasFechadas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsTrip
            // 
            this.TsTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.TsSeparador1,
            this.toolStripDropDownButton2,
            this.TsSeparador2,
            this.TSBPesquisaCadastro,
            this.TsSeparador3,
            this.TsCadastroServicos,
            this.TsSeparador4,
            this.TsPesquisaServicos,
            this.TsSair});
            this.TsTrip.Location = new System.Drawing.Point(0, 0);
            this.TsTrip.Name = "TsTrip";
            this.TsTrip.Size = new System.Drawing.Size(800, 25);
            this.TsTrip.TabIndex = 0;
            this.TsTrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteFisicoToolStripMenuItem,
            this.clienteJuridicoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "Cadastros  & Pedidos";
            // 
            // clienteFisicoToolStripMenuItem
            // 
            this.clienteFisicoToolStripMenuItem.Name = "clienteFisicoToolStripMenuItem";
            this.clienteFisicoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clienteFisicoToolStripMenuItem.Text = "Cliente Fisico";
            this.clienteFisicoToolStripMenuItem.Click += new System.EventHandler(this.ClienteFisicoToolStripMenuItem_Click);
            // 
            // clienteJuridicoToolStripMenuItem
            // 
            this.clienteJuridicoToolStripMenuItem.Name = "clienteJuridicoToolStripMenuItem";
            this.clienteJuridicoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clienteJuridicoToolStripMenuItem.Text = "Cliente Juridico";
            this.clienteJuridicoToolStripMenuItem.Click += new System.EventHandler(this.ClienteJuridicoToolStripMenuItem_Click);
            // 
            // TsSeparador1
            // 
            this.TsSeparador1.Name = "TsSeparador1";
            this.TsSeparador1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem1,
            this.usuariosDoSistemaToolStripMenuItem,
            this.permissõesToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton2.Text = "Permissões";
            // 
            // funcionariosToolStripMenuItem1
            // 
            this.funcionariosToolStripMenuItem1.Name = "funcionariosToolStripMenuItem1";
            this.funcionariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.funcionariosToolStripMenuItem1.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem1.Click += new System.EventHandler(this.FuncionariosToolStripMenuItem1_Click);
            // 
            // usuariosDoSistemaToolStripMenuItem
            // 
            this.usuariosDoSistemaToolStripMenuItem.Name = "usuariosDoSistemaToolStripMenuItem";
            this.usuariosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosDoSistemaToolStripMenuItem.Text = "Usuarios do Sistema";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // TsSeparador2
            // 
            this.TsSeparador2.Name = "TsSeparador2";
            this.TsSeparador2.Size = new System.Drawing.Size(6, 25);
            // 
            // TSBPesquisaCadastro
            // 
            this.TSBPesquisaCadastro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSBPesquisaCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisicoToolStripMenuItem,
            this.juridicoToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.TSBPesquisaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("TSBPesquisaCadastro.Image")));
            this.TSBPesquisaCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBPesquisaCadastro.Name = "TSBPesquisaCadastro";
            this.TSBPesquisaCadastro.Size = new System.Drawing.Size(29, 22);
            this.TSBPesquisaCadastro.Text = "Pesquisa Cadastro";
            // 
            // fisicoToolStripMenuItem
            // 
            this.fisicoToolStripMenuItem.Name = "fisicoToolStripMenuItem";
            this.fisicoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fisicoToolStripMenuItem.Text = "Fisico";
            this.fisicoToolStripMenuItem.Click += new System.EventHandler(this.FisicoToolStripMenuItem_Click);
            // 
            // juridicoToolStripMenuItem
            // 
            this.juridicoToolStripMenuItem.Name = "juridicoToolStripMenuItem";
            this.juridicoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.juridicoToolStripMenuItem.Text = "Juridico";
            this.juridicoToolStripMenuItem.Click += new System.EventHandler(this.JuridicoToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.FuncionarioToolStripMenuItem_Click);
            // 
            // TsSeparador3
            // 
            this.TsSeparador3.Name = "TsSeparador3";
            this.TsSeparador3.Size = new System.Drawing.Size(6, 25);
            // 
            // TsCadastroServicos
            // 
            this.TsCadastroServicos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TsCadastroServicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsCadastroServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsProdutos,
            this.TsServiços,
            this.TsFabricante,
            this.TsPedido});
            this.TsCadastroServicos.Image = ((System.Drawing.Image)(resources.GetObject("TsCadastroServicos.Image")));
            this.TsCadastroServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsCadastroServicos.Name = "TsCadastroServicos";
            this.TsCadastroServicos.Size = new System.Drawing.Size(29, 22);
            this.TsCadastroServicos.Text = "Cadastro Serviços";
            // 
            // TsProdutos
            // 
            this.TsProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsPreço});
            this.TsProdutos.Name = "TsProdutos";
            this.TsProdutos.Size = new System.Drawing.Size(129, 22);
            this.TsProdutos.Text = "Produtos";
            this.TsProdutos.Click += new System.EventHandler(this.TsProdutos_Click);
            // 
            // TsPreço
            // 
            this.TsPreço.Name = "TsPreço";
            this.TsPreço.Size = new System.Drawing.Size(104, 22);
            this.TsPreço.Text = "Preço";
            this.TsPreço.Click += new System.EventHandler(this.TsPreço_Click);
            // 
            // TsServiços
            // 
            this.TsServiços.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsPreçoServico});
            this.TsServiços.Name = "TsServiços";
            this.TsServiços.Size = new System.Drawing.Size(129, 22);
            this.TsServiços.Text = "Serviços";
            this.TsServiços.Click += new System.EventHandler(this.TsServiços_Click);
            // 
            // TsPreçoServico
            // 
            this.TsPreçoServico.Name = "TsPreçoServico";
            this.TsPreçoServico.Size = new System.Drawing.Size(104, 22);
            this.TsPreçoServico.Text = "Preço";
            this.TsPreçoServico.Click += new System.EventHandler(this.TsPreçoServico_Click);
            // 
            // TsFabricante
            // 
            this.TsFabricante.Name = "TsFabricante";
            this.TsFabricante.Size = new System.Drawing.Size(129, 22);
            this.TsFabricante.Text = "Fabricante";
            this.TsFabricante.Click += new System.EventHandler(this.TsFabricante_Click);
            // 
            // TsPedido
            // 
            this.TsPedido.Name = "TsPedido";
            this.TsPedido.Size = new System.Drawing.Size(129, 22);
            this.TsPedido.Text = "Pedido";
            this.TsPedido.Click += new System.EventHandler(this.TsPedido_Click);
            // 
            // TsSeparador4
            // 
            this.TsSeparador4.Name = "TsSeparador4";
            this.TsSeparador4.Size = new System.Drawing.Size(6, 25);
            // 
            // TsPesquisaServicos
            // 
            this.TsPesquisaServicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsPesquisaServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsOS,
            this.TsPedidos,
            this.TsPrecos});
            this.TsPesquisaServicos.Image = ((System.Drawing.Image)(resources.GetObject("TsPesquisaServicos.Image")));
            this.TsPesquisaServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsPesquisaServicos.Name = "TsPesquisaServicos";
            this.TsPesquisaServicos.Size = new System.Drawing.Size(29, 22);
            this.TsPesquisaServicos.Text = "Pesquisar Serviços";
            // 
            // TsOS
            // 
            this.TsOS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsConsultarOS,
            this.TsPesquisarNotasFechadas});
            this.TsOS.Name = "TsOS";
            this.TsOS.Size = new System.Drawing.Size(180, 22);
            this.TsOS.Text = "O.S";
            this.TsOS.Click += new System.EventHandler(this.TsOS_Click);
            // 
            // TsConsultarOS
            // 
            this.TsConsultarOS.Name = "TsConsultarOS";
            this.TsConsultarOS.Size = new System.Drawing.Size(210, 22);
            this.TsConsultarOS.Text = "Consultar";
            this.TsConsultarOS.Click += new System.EventHandler(this.TsConsultarOS_Click);
            // 
            // TsPedidos
            // 
            this.TsPedidos.Name = "TsPedidos";
            this.TsPedidos.Size = new System.Drawing.Size(180, 22);
            this.TsPedidos.Text = "Pedidos";
            this.TsPedidos.Click += new System.EventHandler(this.TsPedidos_Click);
            // 
            // TsPrecos
            // 
            this.TsPrecos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsPrecoProdutos,
            this.TsPrecoServicos});
            this.TsPrecos.Name = "TsPrecos";
            this.TsPrecos.Size = new System.Drawing.Size(180, 22);
            this.TsPrecos.Text = "Preços";
            // 
            // TsPrecoProdutos
            // 
            this.TsPrecoProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsPrecoProdutoInserir,
            this.TsPrecoProdutoConsultar,
            this.TsPrecoProdutoAlterar});
            this.TsPrecoProdutos.Name = "TsPrecoProdutos";
            this.TsPrecoProdutos.Size = new System.Drawing.Size(122, 22);
            this.TsPrecoProdutos.Text = "Produtos";
            // 
            // TsPrecoProdutoInserir
            // 
            this.TsPrecoProdutoInserir.Name = "TsPrecoProdutoInserir";
            this.TsPrecoProdutoInserir.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoProdutoInserir.Text = "Inserir";
            this.TsPrecoProdutoInserir.Click += new System.EventHandler(this.TsPrecoProdutoInserir_Click);
            // 
            // TsPrecoProdutoConsultar
            // 
            this.TsPrecoProdutoConsultar.Name = "TsPrecoProdutoConsultar";
            this.TsPrecoProdutoConsultar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoProdutoConsultar.Text = "Consultar";
            this.TsPrecoProdutoConsultar.Click += new System.EventHandler(this.TsPrecoProdutoConsultar_Click);
            // 
            // TsPrecoProdutoAlterar
            // 
            this.TsPrecoProdutoAlterar.Name = "TsPrecoProdutoAlterar";
            this.TsPrecoProdutoAlterar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoProdutoAlterar.Text = "Alterar";
            this.TsPrecoProdutoAlterar.Click += new System.EventHandler(this.TsPrecoProdutoAlterar_Click);
            // 
            // TsPrecoServicos
            // 
            this.TsPrecoServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsPrecoServicoInserir,
            this.TsPrecoServicoConsultar,
            this.TsPrecoServicoAlterar});
            this.TsPrecoServicos.Name = "TsPrecoServicos";
            this.TsPrecoServicos.Size = new System.Drawing.Size(122, 22);
            this.TsPrecoServicos.Text = "Serviços";
            // 
            // TsPrecoServicoInserir
            // 
            this.TsPrecoServicoInserir.Name = "TsPrecoServicoInserir";
            this.TsPrecoServicoInserir.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoServicoInserir.Text = "Inserir";
            this.TsPrecoServicoInserir.Click += new System.EventHandler(this.TsPrecoServicoInserir_Click);
            // 
            // TsPrecoServicoConsultar
            // 
            this.TsPrecoServicoConsultar.Name = "TsPrecoServicoConsultar";
            this.TsPrecoServicoConsultar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoServicoConsultar.Text = "Consultar";
            this.TsPrecoServicoConsultar.Click += new System.EventHandler(this.TsPrecoServicoConsultar_Click);
            // 
            // TsPrecoServicoAlterar
            // 
            this.TsPrecoServicoAlterar.Name = "TsPrecoServicoAlterar";
            this.TsPrecoServicoAlterar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoServicoAlterar.Text = "Alterar";
            this.TsPrecoServicoAlterar.Click += new System.EventHandler(this.TsPrecoServicoAlterar_Click);
            // 
            // TsSair
            // 
            this.TsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsSair.Image = ((System.Drawing.Image)(resources.GetObject("TsSair.Image")));
            this.TsSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsSair.Name = "TsSair";
            this.TsSair.Size = new System.Drawing.Size(23, 22);
            this.TsSair.Text = "Sair";
            this.TsSair.Click += new System.EventHandler(this.TsSair_Click);
            // 
            // LblRelogio
            // 
            this.LblRelogio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRelogio.AutoSize = true;
            this.LblRelogio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRelogio.Location = new System.Drawing.Point(693, 9);
            this.LblRelogio.Name = "LblRelogio";
            this.LblRelogio.Size = new System.Drawing.Size(95, 13);
            this.LblRelogio.TabIndex = 2;
            this.LblRelogio.Text = "18/03/2022 12:00";
            // 
            // TsPesquisarNotasFechadas
            // 
            this.TsPesquisarNotasFechadas.Name = "TsPesquisarNotasFechadas";
            this.TsPesquisarNotasFechadas.Size = new System.Drawing.Size(210, 22);
            this.TsPesquisarNotasFechadas.Text = "Pesquisar Notas Fechadas";
            this.TsPesquisarNotasFechadas.Click += new System.EventHandler(this.TsPesquisarNotasFechadas_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTecnico.Properties.Resources.SGN_10_05_2021_1633453034999_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblRelogio);
            this.Controls.Add(this.TsTrip);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.TsTrip.ResumeLayout(false);
            this.TsTrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TsTrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosDoSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permissõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteFisicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteJuridicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TsSeparador1;
        private System.Windows.Forms.ToolStripSeparator TsSeparador2;
        private System.Windows.Forms.ToolStripDropDownButton TSBPesquisaCadastro;
        private System.Windows.Forms.ToolStripMenuItem fisicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juridicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TsSeparador3;
        private System.Windows.Forms.ToolStripDropDownButton TsCadastroServicos;
        private System.Windows.Forms.ToolStripSeparator TsSeparador4;
        private System.Windows.Forms.ToolStripDropDownButton TsPesquisaServicos;
        private System.Windows.Forms.ToolStripButton TsSair;
        private System.Windows.Forms.ToolStripMenuItem TsProdutos;
        private System.Windows.Forms.ToolStripMenuItem TsServiços;
        private System.Windows.Forms.ToolStripMenuItem TsFabricante;
        private System.Windows.Forms.ToolStripMenuItem TsPreço;
        private System.Windows.Forms.ToolStripMenuItem TsPreçoServico;
        private System.Windows.Forms.ToolStripMenuItem TsOS;
        private System.Windows.Forms.ToolStripMenuItem TsPedido;
        private System.Windows.Forms.ToolStripMenuItem TsPedidos;
        private System.Windows.Forms.Label LblRelogio;
        private System.Windows.Forms.ToolStripMenuItem TsPrecos;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoProdutos;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoServicos;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoProdutoInserir;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoProdutoConsultar;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoProdutoAlterar;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoServicoInserir;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoServicoConsultar;
        private System.Windows.Forms.ToolStripMenuItem TsPrecoServicoAlterar;
        private System.Windows.Forms.ToolStripMenuItem TsConsultarOS;
        private System.Windows.Forms.ToolStripMenuItem TsPesquisarNotasFechadas;
    }
}