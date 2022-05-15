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
            this.components = new System.ComponentModel.Container();
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
            this.TsServiços = new System.Windows.Forms.ToolStripMenuItem();
            this.TsFabricante = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPedido = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< Updated upstream
=======
            this.TsOrdemDeServicos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsVenda = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> Stashed changes
            this.TsMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador4 = new System.Windows.Forms.ToolStripSeparator();
            this.TsPesquisaServicos = new System.Windows.Forms.ToolStripDropDownButton();
            this.TsOS = new System.Windows.Forms.ToolStripMenuItem();
            this.TsConsultarOS = new System.Windows.Forms.ToolStripMenuItem();
            this.TsPesquisarNotasFechadas = new System.Windows.Forms.ToolStripMenuItem();
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
            this.TsVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador5 = new System.Windows.Forms.ToolStripSeparator();
            this.TsAjuda_Sobre = new System.Windows.Forms.ToolStripSplitButton();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsSeparador6 = new System.Windows.Forms.ToolStripSeparator();
            this.TsSair = new System.Windows.Forms.ToolStripButton();
<<<<<<< Updated upstream
            this.LblRelogio = new System.Windows.Forms.Label();
            this.StStatus = new System.Windows.Forms.StatusStrip();
            this.StVersao = new System.Windows.Forms.ToolStripStatusLabel();
=======
            this.LblRelogio = new System.Windows.Forms.ToolStripLabel();
            this.StStatus = new System.Windows.Forms.StatusStrip();
            this.StVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmData_Hora = new System.Windows.Forms.Timer(this.components);
>>>>>>> Stashed changes
            this.TsTrip.SuspendLayout();
            this.StStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // TsTrip
            // 
            this.TsTrip.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.TsSeparador5,
            this.TsAjuda_Sobre,
            this.TsSeparador6,
            this.TsSair,
            this.LblRelogio});
            this.TsTrip.Location = new System.Drawing.Point(0, 0);
            this.TsTrip.Name = "TsTrip";
            this.TsTrip.Size = new System.Drawing.Size(800, 26);
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
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 23);
            this.toolStripDropDownButton1.Text = "Cadastros  & Pedidos";
            // 
            // clienteFisicoToolStripMenuItem
            // 
            this.clienteFisicoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clienteFisicoToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.business_color_business_contact_87_icon_icons_com_53468;
            this.clienteFisicoToolStripMenuItem.Name = "clienteFisicoToolStripMenuItem";
            this.clienteFisicoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clienteFisicoToolStripMenuItem.Text = "Cliente Fisico";
            this.clienteFisicoToolStripMenuItem.Click += new System.EventHandler(this.ClienteFisicoToolStripMenuItem_Click);
            // 
            // clienteJuridicoToolStripMenuItem
            // 
            this.clienteJuridicoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.clienteJuridicoToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.business_color_business_contact_86_icon_icons_com_53469;
            this.clienteJuridicoToolStripMenuItem.Name = "clienteJuridicoToolStripMenuItem";
            this.clienteJuridicoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.clienteJuridicoToolStripMenuItem.Text = "Cliente Juridico";
            this.clienteJuridicoToolStripMenuItem.Click += new System.EventHandler(this.ClienteJuridicoToolStripMenuItem_Click);
            // 
            // TsSeparador1
            // 
            this.TsSeparador1.Name = "TsSeparador1";
            this.TsSeparador1.Size = new System.Drawing.Size(6, 26);
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
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 23);
            this.toolStripDropDownButton2.Text = "Permissões";
            // 
            // funcionariosToolStripMenuItem1
            // 
            this.funcionariosToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.funcionariosToolStripMenuItem1.Image = global::ProjetoTecnico.Properties.Resources.icons8_adicionar_usuário_masculino_24;
            this.funcionariosToolStripMenuItem1.Name = "funcionariosToolStripMenuItem1";
            this.funcionariosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.funcionariosToolStripMenuItem1.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem1.Click += new System.EventHandler(this.FuncionariosToolStripMenuItem1_Click);
            // 
            // usuariosDoSistemaToolStripMenuItem
            // 
            this.usuariosDoSistemaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.usuariosDoSistemaToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.usuario;
            this.usuariosDoSistemaToolStripMenuItem.Name = "usuariosDoSistemaToolStripMenuItem";
            this.usuariosDoSistemaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosDoSistemaToolStripMenuItem.Text = "Usuarios do Sistema";
            // 
            // permissõesToolStripMenuItem
            // 
            this.permissõesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.permissõesToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.permissao;
            this.permissõesToolStripMenuItem.Name = "permissõesToolStripMenuItem";
            this.permissõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permissõesToolStripMenuItem.Text = "Permissões";
            // 
            // TsSeparador2
            // 
            this.TsSeparador2.Name = "TsSeparador2";
            this.TsSeparador2.Size = new System.Drawing.Size(6, 26);
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
            this.TSBPesquisaCadastro.Size = new System.Drawing.Size(29, 23);
            this.TSBPesquisaCadastro.Text = "Pesquisa Cadastro";
            // 
            // fisicoToolStripMenuItem
            // 
            this.fisicoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fisicoToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.clientefi;
            this.fisicoToolStripMenuItem.Name = "fisicoToolStripMenuItem";
            this.fisicoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fisicoToolStripMenuItem.Text = "Fisico";
            this.fisicoToolStripMenuItem.Click += new System.EventHandler(this.FisicoToolStripMenuItem_Click);
            // 
            // juridicoToolStripMenuItem
            // 
            this.juridicoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.juridicoToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.clientef;
            this.juridicoToolStripMenuItem.Name = "juridicoToolStripMenuItem";
            this.juridicoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.juridicoToolStripMenuItem.Text = "Juridico";
            this.juridicoToolStripMenuItem.Click += new System.EventHandler(this.JuridicoToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.funcionarioToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.funcionario;
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.FuncionarioToolStripMenuItem_Click);
            // 
            // TsSeparador3
            // 
            this.TsSeparador3.Name = "TsSeparador3";
            this.TsSeparador3.Size = new System.Drawing.Size(6, 26);
            // 
            // TsCadastroServicos
            // 
            this.TsCadastroServicos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TsCadastroServicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsCadastroServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsProdutos,
            this.TsServiços,
            this.TsFabricante,
            this.TsPedido,
            this.TsMarca});
            this.TsCadastroServicos.Image = ((System.Drawing.Image)(resources.GetObject("TsCadastroServicos.Image")));
            this.TsCadastroServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsCadastroServicos.Name = "TsCadastroServicos";
            this.TsCadastroServicos.Size = new System.Drawing.Size(29, 23);
            this.TsCadastroServicos.Text = "Cadastro Serviços";
            // 
            // TsProdutos
            // 
            this.TsProdutos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsProdutos.Image = global::ProjetoTecnico.Properties.Resources.produtos;
            this.TsProdutos.Name = "TsProdutos";
            this.TsProdutos.Size = new System.Drawing.Size(129, 22);
            this.TsProdutos.Text = "Produtos";
            this.TsProdutos.Click += new System.EventHandler(this.TsProdutos_Click);
            // 
            // TsServiços
            // 
            this.TsServiços.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsServiços.Image = global::ProjetoTecnico.Properties.Resources.servicos;
            this.TsServiços.Name = "TsServiços";
            this.TsServiços.Size = new System.Drawing.Size(129, 22);
            this.TsServiços.Text = "Serviços";
            this.TsServiços.Click += new System.EventHandler(this.TsServiços_Click);
            // 
            // TsFabricante
            // 
            this.TsFabricante.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsFabricante.Image = global::ProjetoTecnico.Properties.Resources.fabricantes;
            this.TsFabricante.Name = "TsFabricante";
            this.TsFabricante.Size = new System.Drawing.Size(129, 22);
            this.TsFabricante.Text = "Fabricante";
            this.TsFabricante.Click += new System.EventHandler(this.TsFabricante_Click);
            // 
            // TsPedido
            // 
            this.TsPedido.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPedido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsOrdemDeServicos,
            this.TsVenda});
            this.TsPedido.Image = global::ProjetoTecnico.Properties.Resources.pedido;
            this.TsPedido.Name = "TsPedido";
            this.TsPedido.Size = new System.Drawing.Size(129, 22);
            this.TsPedido.Text = "Pedido";
            this.TsPedido.Click += new System.EventHandler(this.TsPedido_Click);
            // 
<<<<<<< Updated upstream
            // TsMarca
            // 
=======
            // TsOrdemDeServicos
            // 
            this.TsOrdemDeServicos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsOrdemDeServicos.Image = global::ProjetoTecnico.Properties.Resources.Pesquisar_OS;
            this.TsOrdemDeServicos.Name = "TsOrdemDeServicos";
            this.TsOrdemDeServicos.Size = new System.Drawing.Size(173, 22);
            this.TsOrdemDeServicos.Text = "Ordem de Serviços";
            this.TsOrdemDeServicos.Click += new System.EventHandler(this.TsOrdemDeServicos_Click);
            // 
            // TsVenda
            // 
            this.TsVenda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsVenda.Image = global::ProjetoTecnico.Properties.Resources.icons8_moedas_241;
            this.TsVenda.Name = "TsVenda";
            this.TsVenda.Size = new System.Drawing.Size(173, 22);
            this.TsVenda.Text = "Vendas";
            this.TsVenda.Click += new System.EventHandler(this.TsVenda_Click);
            // 
            // TsMarca
            // 
            this.TsMarca.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsMarca.Image = global::ProjetoTecnico.Properties.Resources.marca;
>>>>>>> Stashed changes
            this.TsMarca.Name = "TsMarca";
            this.TsMarca.Size = new System.Drawing.Size(129, 22);
            this.TsMarca.Text = "Marca";
            this.TsMarca.Click += new System.EventHandler(this.TsMarca_Click);
            // 
            // TsSeparador4
            // 
            this.TsSeparador4.Name = "TsSeparador4";
            this.TsSeparador4.Size = new System.Drawing.Size(6, 26);
            // 
            // TsPesquisaServicos
            // 
            this.TsPesquisaServicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsPesquisaServicos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsOS,
            this.TsPedidos,
            this.TsPrecos,
            this.TsVendas});
            this.TsPesquisaServicos.Image = ((System.Drawing.Image)(resources.GetObject("TsPesquisaServicos.Image")));
            this.TsPesquisaServicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsPesquisaServicos.Name = "TsPesquisaServicos";
            this.TsPesquisaServicos.Size = new System.Drawing.Size(29, 23);
            this.TsPesquisaServicos.Text = "Pesquisar Serviços";
            // 
            // TsOS
            // 
            this.TsOS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsOS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsConsultarOS,
            this.TsPesquisarNotasFechadas});
            this.TsOS.Image = global::ProjetoTecnico.Properties.Resources.Pesquisar_OS;
            this.TsOS.Name = "TsOS";
            this.TsOS.Size = new System.Drawing.Size(173, 22);
            this.TsOS.Text = "Ordem de Serviços";
            this.TsOS.Click += new System.EventHandler(this.TsOS_Click);
            // 
            // TsConsultarOS
            // 
            this.TsConsultarOS.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsConsultarOS.Image = global::ProjetoTecnico.Properties.Resources.Imagem3;
            this.TsConsultarOS.Name = "TsConsultarOS";
            this.TsConsultarOS.Size = new System.Drawing.Size(211, 22);
            this.TsConsultarOS.Text = "Consultar";
            this.TsConsultarOS.Click += new System.EventHandler(this.TsConsultarOS_Click);
            // 
            // TsPesquisarNotasFechadas
            // 
            this.TsPesquisarNotasFechadas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPesquisarNotasFechadas.Image = global::ProjetoTecnico.Properties.Resources.Imagem3;
            this.TsPesquisarNotasFechadas.Name = "TsPesquisarNotasFechadas";
            this.TsPesquisarNotasFechadas.Size = new System.Drawing.Size(211, 22);
            this.TsPesquisarNotasFechadas.Text = "Consultar Notas Fechadas";
            this.TsPesquisarNotasFechadas.Click += new System.EventHandler(this.TsPesquisarNotasFechadas_Click);
            // 
            // TsPedidos
            // 
            this.TsPedidos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPedidos.Image = global::ProjetoTecnico.Properties.Resources.pedido1;
            this.TsPedidos.Name = "TsPedidos";
            this.TsPedidos.Size = new System.Drawing.Size(173, 22);
            this.TsPedidos.Text = "Pedidos";
            this.TsPedidos.Click += new System.EventHandler(this.TsPedidos_Click);
            // 
            // TsPrecos
            // 
            this.TsPrecos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsPrecoProdutos,
            this.TsPrecoServicos});
            this.TsPrecos.Image = global::ProjetoTecnico.Properties.Resources.preco;
            this.TsPrecos.Name = "TsPrecos";
            this.TsPrecos.Size = new System.Drawing.Size(173, 22);
            this.TsPrecos.Text = "Preços";
            // 
            // TsPrecoProdutos
            // 
            this.TsPrecoProdutos.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.TsPrecoProdutoInserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecoProdutoInserir.Name = "TsPrecoProdutoInserir";
            this.TsPrecoProdutoInserir.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoProdutoInserir.Text = "Inserir";
            this.TsPrecoProdutoInserir.Click += new System.EventHandler(this.TsPrecoProdutoInserir_Click);
            // 
            // TsPrecoProdutoConsultar
            // 
            this.TsPrecoProdutoConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecoProdutoConsultar.Name = "TsPrecoProdutoConsultar";
            this.TsPrecoProdutoConsultar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoProdutoConsultar.Text = "Consultar";
            this.TsPrecoProdutoConsultar.Click += new System.EventHandler(this.TsPrecoProdutoConsultar_Click);
            // 
            // TsPrecoProdutoAlterar
            // 
            this.TsPrecoProdutoAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecoProdutoAlterar.Name = "TsPrecoProdutoAlterar";
            this.TsPrecoProdutoAlterar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoProdutoAlterar.Text = "Alterar";
            this.TsPrecoProdutoAlterar.Click += new System.EventHandler(this.TsPrecoProdutoAlterar_Click);
            // 
            // TsPrecoServicos
            // 
            this.TsPrecoServicos.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.TsPrecoServicoInserir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecoServicoInserir.Name = "TsPrecoServicoInserir";
            this.TsPrecoServicoInserir.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoServicoInserir.Text = "Inserir";
            this.TsPrecoServicoInserir.Click += new System.EventHandler(this.TsPrecoServicoInserir_Click);
            // 
            // TsPrecoServicoConsultar
            // 
            this.TsPrecoServicoConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecoServicoConsultar.Name = "TsPrecoServicoConsultar";
            this.TsPrecoServicoConsultar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoServicoConsultar.Text = "Consultar";
            this.TsPrecoServicoConsultar.Click += new System.EventHandler(this.TsPrecoServicoConsultar_Click);
            // 
            // TsPrecoServicoAlterar
            // 
            this.TsPrecoServicoAlterar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsPrecoServicoAlterar.Name = "TsPrecoServicoAlterar";
            this.TsPrecoServicoAlterar.Size = new System.Drawing.Size(125, 22);
            this.TsPrecoServicoAlterar.Text = "Alterar";
            this.TsPrecoServicoAlterar.Click += new System.EventHandler(this.TsPrecoServicoAlterar_Click);
            // 
            // TsVendas
            // 
            this.TsVendas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TsVendas.Image = global::ProjetoTecnico.Properties.Resources.icons8_moedas_241;
            this.TsVendas.Name = "TsVendas";
            this.TsVendas.Size = new System.Drawing.Size(173, 22);
            this.TsVendas.Text = "Vendas";
            this.TsVendas.Click += new System.EventHandler(this.TsVendas_Click);
            // 
            // TsSeparador5
            // 
            this.TsSeparador5.Name = "TsSeparador5";
            this.TsSeparador5.Size = new System.Drawing.Size(6, 26);
            // 
            // TsAjuda_Sobre
            // 
            this.TsAjuda_Sobre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TsAjuda_Sobre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsAjuda_Sobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajudaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.TsAjuda_Sobre.Image = global::ProjetoTecnico.Properties.Resources.questao1;
            this.TsAjuda_Sobre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsAjuda_Sobre.Name = "TsAjuda_Sobre";
            this.TsAjuda_Sobre.Size = new System.Drawing.Size(32, 23);
            this.TsAjuda_Sobre.Text = "Ajuda / Sobre";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ajudaToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.questao;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sobreToolStripMenuItem.Image = global::ProjetoTecnico.Properties.Resources.questao__1_;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // TsSeparador6
            // 
            this.TsSeparador6.Name = "TsSeparador6";
            this.TsSeparador6.Size = new System.Drawing.Size(6, 26);
            // 
            // TsSair
            // 
            this.TsSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsSair.Image = ((System.Drawing.Image)(resources.GetObject("TsSair.Image")));
            this.TsSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsSair.Name = "TsSair";
            this.TsSair.Size = new System.Drawing.Size(23, 23);
            this.TsSair.Text = "Sair";
            this.TsSair.Click += new System.EventHandler(this.TsSair_Click);
            // 
            // LblRelogio
            // 
            this.LblRelogio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.LblRelogio.Font = new System.Drawing.Font("Segoe Print", 9.5F);
            this.LblRelogio.ForeColor = System.Drawing.Color.DarkGreen;
            this.LblRelogio.Name = "LblRelogio";
            this.LblRelogio.Size = new System.Drawing.Size(55, 23);
            this.LblRelogio.Text = "Relógio";
            // 
            // StStatus
            // 
            this.StStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StVersao});
            this.StStatus.Location = new System.Drawing.Point(0, 566);
            this.StStatus.Name = "StStatus";
            this.StStatus.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StStatus.Size = new System.Drawing.Size(800, 22);
            this.StStatus.TabIndex = 4;
            this.StStatus.Text = "statusStrip1";
            // 
            // StVersao
            // 
            this.StVersao.ForeColor = System.Drawing.Color.Sienna;
            this.StVersao.Name = "StVersao";
            this.StVersao.Size = new System.Drawing.Size(59, 17);
            this.StVersao.Text = "Versão 1.0";
            this.StVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TmData_Hora
            // 
            this.TmData_Hora.Interval = 10;
            this.TmData_Hora.Tick += new System.EventHandler(this.TmData_Hora_Tick);
            // 
            // StStatus
            // 
            this.StStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StVersao});
            this.StStatus.Location = new System.Drawing.Point(0, 566);
            this.StStatus.Name = "StStatus";
            this.StStatus.Size = new System.Drawing.Size(800, 22);
            this.StStatus.TabIndex = 4;
            this.StStatus.Text = "statusStrip1";
            // 
            // StVersao
            // 
            this.StVersao.Name = "StVersao";
            this.StVersao.Size = new System.Drawing.Size(59, 17);
            this.StVersao.Text = "Versão 1.0";
            this.StVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProjetoTecnico.Properties.Resources.SGN_10_05_2021_1633453034999_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.StStatus);
<<<<<<< Updated upstream
            this.Controls.Add(this.LblRelogio);
=======
>>>>>>> Stashed changes
            this.Controls.Add(this.TsTrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.TsTrip.ResumeLayout(false);
            this.TsTrip.PerformLayout();
            this.StStatus.ResumeLayout(false);
            this.StStatus.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem TsOS;
        private System.Windows.Forms.ToolStripMenuItem TsPedido;
        private System.Windows.Forms.ToolStripMenuItem TsPedidos;
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
        private System.Windows.Forms.ToolStripMenuItem TsMarca;
        private System.Windows.Forms.StatusStrip StStatus;
        private System.Windows.Forms.ToolStripStatusLabel StVersao;
<<<<<<< Updated upstream
=======
        private System.Windows.Forms.ToolStripSeparator TsSeparador5;
        private System.Windows.Forms.ToolStripSeparator TsSeparador6;
        private System.Windows.Forms.ToolStripSplitButton TsAjuda_Sobre;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TsVendas;
        private System.Windows.Forms.ToolStripMenuItem TsOrdemDeServicos;
        private System.Windows.Forms.ToolStripMenuItem TsVenda;
        private System.Windows.Forms.Timer TmData_Hora;
        private System.Windows.Forms.ToolStripLabel LblRelogio;
>>>>>>> Stashed changes
    }
}