namespace ProjetoTecnico
{
    partial class FrmCadastros
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
            this.BtnAtualizar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PnCadastro = new System.Windows.Forms.Panel();
            this.DateNascimento = new System.Windows.Forms.DateTimePicker();
            this.LblNascimento = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.ComboSituacao = new System.Windows.Forms.ComboBox();
            this.TxtEmail2 = new System.Windows.Forms.TextBox();
            this.LblEmail2 = new System.Windows.Forms.Label();
            this.TxtEmail1 = new System.Windows.Forms.TextBox();
            this.LblEmail1 = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.MaskCel2 = new System.Windows.Forms.MaskedTextBox();
            this.LblCelular2 = new System.Windows.Forms.Label();
            this.MaskFixo2 = new System.Windows.Forms.MaskedTextBox();
            this.LblFixo2 = new System.Windows.Forms.Label();
            this.MaskRG = new System.Windows.Forms.MaskedTextBox();
            this.LblRG = new System.Windows.Forms.Label();
            this.MaskCPF = new System.Windows.Forms.MaskedTextBox();
            this.LblCPF = new System.Windows.Forms.Label();
            this.MaskMatricula = new System.Windows.Forms.MaskedTextBox();
            this.LblMatricula = new System.Windows.Forms.Label();
            this.MaskCel1 = new System.Windows.Forms.MaskedTextBox();
            this.LblCelular1 = new System.Windows.Forms.Label();
            this.MaskFixo1 = new System.Windows.Forms.MaskedTextBox();
            this.LblFixo1 = new System.Windows.Forms.Label();
            this.DateCadastro = new System.Windows.Forms.DateTimePicker();
            this.MaskUF = new System.Windows.Forms.MaskedTextBox();
            this.LblUF = new System.Windows.Forms.Label();
            this.MaskCEP = new System.Windows.Forms.MaskedTextBox();
            this.LblCEP = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.TxtComplemento2 = new System.Windows.Forms.TextBox();
            this.LblComplemento2 = new System.Windows.Forms.Label();
            this.TxtComplemento1 = new System.Windows.Forms.TextBox();
            this.LblComplemento = new System.Windows.Forms.Label();
            this.TxtCidade = new System.Windows.Forms.TextBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtBairro = new System.Windows.Forms.TextBox();
            this.LblBairro = new System.Windows.Forms.Label();
            this.TxtRua = new System.Windows.Forms.TextBox();
            this.LblRua = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblCadastro = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.PnBotoes.SuspendLayout();
            this.PnCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnBotoes
            // 
            this.PnBotoes.Controls.Add(this.BtnNovo);
            this.PnBotoes.Controls.Add(this.BtnSalvar);
            this.PnBotoes.Controls.Add(this.BtnAtualizar);
            this.PnBotoes.Controls.Add(this.BtnCancelar);
            this.PnBotoes.Controls.Add(this.BtnSair);
            this.PnBotoes.Location = new System.Drawing.Point(291, 454);
            this.PnBotoes.Name = "PnBotoes";
            this.PnBotoes.Size = new System.Drawing.Size(703, 48);
            this.PnBotoes.TabIndex = 1;
            this.PnBotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.PnBotoes_Paint);
            // 
            // BtnNovo
            // 
            this.BtnNovo.BackColor = System.Drawing.Color.White;
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 6.5F);
            this.BtnNovo.Image = global::ProjetoTecnico.Properties.Resources.NovoCetro;
            this.BtnNovo.Location = new System.Drawing.Point(32, 6);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 39);
            this.BtnNovo.TabIndex = 0;
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.BackColor = System.Drawing.Color.Lime;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe Print", 6.5F);
            this.BtnSalvar.Image = global::ProjetoTecnico.Properties.Resources.icons8_salvar_32;
            this.BtnSalvar.Location = new System.Drawing.Point(175, 6);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 39);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Font = new System.Drawing.Font("Segoe Print", 6.5F);
            this.BtnAtualizar.Image = global::ProjetoTecnico.Properties.Resources.botao_atualizar;
            this.BtnAtualizar.Location = new System.Drawing.Point(324, 6);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 39);
            this.BtnAtualizar.TabIndex = 2;
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 6.5F);
            this.BtnCancelar.Image = global::ProjetoTecnico.Properties.Resources.icons8_excluir_filled_50;
            this.BtnCancelar.Location = new System.Drawing.Point(473, 6);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 39);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 6.5F);
            this.BtnSair.Image = global::ProjetoTecnico.Properties.Resources.icons8_sair_26__1_1;
            this.BtnSair.Location = new System.Drawing.Point(622, 6);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 39);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // PnCadastro
            // 
            this.PnCadastro.Controls.Add(this.DateNascimento);
            this.PnCadastro.Controls.Add(this.LblNascimento);
            this.PnCadastro.Controls.Add(this.lblSituacao);
            this.PnCadastro.Controls.Add(this.ComboSituacao);
            this.PnCadastro.Controls.Add(this.TxtEmail2);
            this.PnCadastro.Controls.Add(this.LblEmail2);
            this.PnCadastro.Controls.Add(this.TxtEmail1);
            this.PnCadastro.Controls.Add(this.LblEmail1);
            this.PnCadastro.Controls.Add(this.LblTipo);
            this.PnCadastro.Controls.Add(this.ComboTipo);
            this.PnCadastro.Controls.Add(this.MaskCel2);
            this.PnCadastro.Controls.Add(this.LblCelular2);
            this.PnCadastro.Controls.Add(this.MaskFixo2);
            this.PnCadastro.Controls.Add(this.LblFixo2);
            this.PnCadastro.Controls.Add(this.MaskRG);
            this.PnCadastro.Controls.Add(this.LblRG);
            this.PnCadastro.Controls.Add(this.MaskCPF);
            this.PnCadastro.Controls.Add(this.LblCPF);
            this.PnCadastro.Controls.Add(this.MaskMatricula);
            this.PnCadastro.Controls.Add(this.LblMatricula);
            this.PnCadastro.Controls.Add(this.MaskCel1);
            this.PnCadastro.Controls.Add(this.LblCelular1);
            this.PnCadastro.Controls.Add(this.MaskFixo1);
            this.PnCadastro.Controls.Add(this.LblFixo1);
            this.PnCadastro.Controls.Add(this.DateCadastro);
            this.PnCadastro.Controls.Add(this.MaskUF);
            this.PnCadastro.Controls.Add(this.LblUF);
            this.PnCadastro.Controls.Add(this.MaskCEP);
            this.PnCadastro.Controls.Add(this.LblCEP);
            this.PnCadastro.Controls.Add(this.TxtNumero);
            this.PnCadastro.Controls.Add(this.LblNumero);
            this.PnCadastro.Controls.Add(this.TxtComplemento2);
            this.PnCadastro.Controls.Add(this.LblComplemento2);
            this.PnCadastro.Controls.Add(this.TxtComplemento1);
            this.PnCadastro.Controls.Add(this.LblComplemento);
            this.PnCadastro.Controls.Add(this.TxtCidade);
            this.PnCadastro.Controls.Add(this.LblCidade);
            this.PnCadastro.Controls.Add(this.TxtBairro);
            this.PnCadastro.Controls.Add(this.LblBairro);
            this.PnCadastro.Controls.Add(this.TxtRua);
            this.PnCadastro.Controls.Add(this.LblRua);
            this.PnCadastro.Controls.Add(this.TxtId);
            this.PnCadastro.Controls.Add(this.TxtNome);
            this.PnCadastro.Controls.Add(this.LblId);
            this.PnCadastro.Controls.Add(this.LblCadastro);
            this.PnCadastro.Controls.Add(this.LblNome);
            this.PnCadastro.Controls.Add(this.lblTitulo);
            this.PnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.PnCadastro.Location = new System.Drawing.Point(3, 3);
            this.PnCadastro.Name = "PnCadastro";
            this.PnCadastro.Size = new System.Drawing.Size(991, 450);
            this.PnCadastro.TabIndex = 0;
            this.PnCadastro.Paint += new System.Windows.Forms.PaintEventHandler(this.PnCadastro_Paint);
            // 
            // DateNascimento
            // 
            this.DateNascimento.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.DateNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateNascimento.Location = new System.Drawing.Point(497, 67);
            this.DateNascimento.Name = "DateNascimento";
            this.DateNascimento.Size = new System.Drawing.Size(127, 25);
            this.DateNascimento.TabIndex = 4;
            // 
            // LblNascimento
            // 
            this.LblNascimento.AutoSize = true;
            this.LblNascimento.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblNascimento.Location = new System.Drawing.Point(402, 71);
            this.LblNascimento.Name = "LblNascimento";
            this.LblNascimento.Size = new System.Drawing.Size(74, 17);
            this.LblNascimento.TabIndex = 3;
            this.LblNascimento.Text = "Nascimento :";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.lblSituacao.Location = new System.Drawing.Point(713, 140);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(54, 17);
            this.lblSituacao.TabIndex = 11;
            this.lblSituacao.Text = "Situacao:";
            // 
            // ComboSituacao
            // 
            this.ComboSituacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboSituacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.ComboSituacao.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.ComboSituacao.FormattingEnabled = true;
            this.ComboSituacao.Location = new System.Drawing.Point(773, 136);
            this.ComboSituacao.Name = "ComboSituacao";
            this.ComboSituacao.Size = new System.Drawing.Size(141, 25);
            this.ComboSituacao.TabIndex = 12;
            // 
            // TxtEmail2
            // 
            this.TxtEmail2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtEmail2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtEmail2.Location = new System.Drawing.Point(556, 232);
            this.TxtEmail2.MaxLength = 160;
            this.TxtEmail2.Name = "TxtEmail2";
            this.TxtEmail2.Size = new System.Drawing.Size(370, 25);
            this.TxtEmail2.TabIndex = 24;
            this.TxtEmail2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEmail2
            // 
            this.LblEmail2.AutoSize = true;
            this.LblEmail2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblEmail2.Location = new System.Drawing.Point(489, 236);
            this.LblEmail2.Name = "LblEmail2";
            this.LblEmail2.Size = new System.Drawing.Size(51, 17);
            this.LblEmail2.TabIndex = 23;
            this.LblEmail2.Text = "Email 2:";
            // 
            // TxtEmail1
            // 
            this.TxtEmail1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtEmail1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtEmail1.Location = new System.Drawing.Point(76, 231);
            this.TxtEmail1.MaxLength = 160;
            this.TxtEmail1.Name = "TxtEmail1";
            this.TxtEmail1.Size = new System.Drawing.Size(370, 25);
            this.TxtEmail1.TabIndex = 22;
            this.TxtEmail1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblEmail1
            // 
            this.LblEmail1.AutoSize = true;
            this.LblEmail1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblEmail1.Location = new System.Drawing.Point(9, 235);
            this.LblEmail1.Name = "LblEmail1";
            this.LblEmail1.Size = new System.Drawing.Size(51, 17);
            this.LblEmail1.TabIndex = 21;
            this.LblEmail1.Text = "Email 1:";
            // 
            // LblTipo
            // 
            this.LblTipo.AutoSize = true;
            this.LblTipo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblTipo.Location = new System.Drawing.Point(453, 140);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(87, 17);
            this.LblTipo.TabIndex = 9;
            this.LblTipo.Text = "Tipo Cadastro :";
            // 
            // ComboTipo
            // 
            this.ComboTipo.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Location = new System.Drawing.Point(546, 135);
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(141, 25);
            this.ComboTipo.TabIndex = 10;
            // 
            // MaskCel2
            // 
            this.MaskCel2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskCel2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskCel2.Location = new System.Drawing.Point(516, 181);
            this.MaskCel2.Mask = "(00)0-0000-0000";
            this.MaskCel2.Name = "MaskCel2";
            this.MaskCel2.Size = new System.Drawing.Size(131, 25);
            this.MaskCel2.TabIndex = 18;
            this.MaskCel2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCelular2
            // 
            this.LblCelular2.AutoSize = true;
            this.LblCelular2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCelular2.Location = new System.Drawing.Point(453, 185);
            this.LblCelular2.Name = "LblCelular2";
            this.LblCelular2.Size = new System.Drawing.Size(57, 17);
            this.LblCelular2.TabIndex = 17;
            this.LblCelular2.Text = "Celular 2:";
            // 
            // MaskFixo2
            // 
            this.MaskFixo2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskFixo2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskFixo2.Location = new System.Drawing.Point(716, 181);
            this.MaskFixo2.Mask = "(00)0000-0000";
            this.MaskFixo2.Name = "MaskFixo2";
            this.MaskFixo2.Size = new System.Drawing.Size(131, 25);
            this.MaskFixo2.TabIndex = 20;
            this.MaskFixo2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblFixo2
            // 
            this.LblFixo2.AutoSize = true;
            this.LblFixo2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblFixo2.Location = new System.Drawing.Point(668, 185);
            this.LblFixo2.Name = "LblFixo2";
            this.LblFixo2.Size = new System.Drawing.Size(42, 17);
            this.LblFixo2.TabIndex = 19;
            this.LblFixo2.Text = "Fixo 2:";
            // 
            // MaskRG
            // 
            this.MaskRG.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskRG.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskRG.Location = new System.Drawing.Point(58, 278);
            this.MaskRG.Mask = "00,000,000-A";
            this.MaskRG.Name = "MaskRG";
            this.MaskRG.Size = new System.Drawing.Size(131, 25);
            this.MaskRG.TabIndex = 26;
            this.MaskRG.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblRG
            // 
            this.LblRG.AutoSize = true;
            this.LblRG.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblRG.Location = new System.Drawing.Point(9, 282);
            this.LblRG.Name = "LblRG";
            this.LblRG.Size = new System.Drawing.Size(36, 17);
            this.LblRG.TabIndex = 25;
            this.LblRG.Text = "R.G. :";
            // 
            // MaskCPF
            // 
            this.MaskCPF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskCPF.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskCPF.Location = new System.Drawing.Point(305, 278);
            this.MaskCPF.Mask = "000,000,000-00";
            this.MaskCPF.Name = "MaskCPF";
            this.MaskCPF.Size = new System.Drawing.Size(131, 25);
            this.MaskCPF.TabIndex = 28;
            this.MaskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCPF.Location = new System.Drawing.Point(248, 282);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(44, 17);
            this.LblCPF.TabIndex = 27;
            this.LblCPF.Text = "C.P.F. :";
            // 
            // MaskMatricula
            // 
            this.MaskMatricula.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskMatricula.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskMatricula.Location = new System.Drawing.Point(614, 276);
            this.MaskMatricula.Mask = "AA-0000/0";
            this.MaskMatricula.Name = "MaskMatricula";
            this.MaskMatricula.Size = new System.Drawing.Size(131, 25);
            this.MaskMatricula.TabIndex = 30;
            this.MaskMatricula.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblMatricula
            // 
            this.LblMatricula.AutoSize = true;
            this.LblMatricula.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblMatricula.Location = new System.Drawing.Point(533, 280);
            this.LblMatricula.Name = "LblMatricula";
            this.LblMatricula.Size = new System.Drawing.Size(63, 17);
            this.LblMatricula.TabIndex = 29;
            this.LblMatricula.Text = "Matrícula :";
            // 
            // MaskCel1
            // 
            this.MaskCel1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskCel1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskCel1.Location = new System.Drawing.Point(83, 184);
            this.MaskCel1.Mask = "(00)0-0000-0000";
            this.MaskCel1.Name = "MaskCel1";
            this.MaskCel1.Size = new System.Drawing.Size(131, 25);
            this.MaskCel1.TabIndex = 14;
            this.MaskCel1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCelular1
            // 
            this.LblCelular1.AutoSize = true;
            this.LblCelular1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCelular1.Location = new System.Drawing.Point(9, 188);
            this.LblCelular1.Name = "LblCelular1";
            this.LblCelular1.Size = new System.Drawing.Size(57, 17);
            this.LblCelular1.TabIndex = 13;
            this.LblCelular1.Text = "Celular 1:";
            // 
            // MaskFixo1
            // 
            this.MaskFixo1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskFixo1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskFixo1.Location = new System.Drawing.Point(307, 184);
            this.MaskFixo1.Mask = "(00)0000-0000";
            this.MaskFixo1.Name = "MaskFixo1";
            this.MaskFixo1.Size = new System.Drawing.Size(131, 25);
            this.MaskFixo1.TabIndex = 16;
            this.MaskFixo1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblFixo1
            // 
            this.LblFixo1.AutoSize = true;
            this.LblFixo1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblFixo1.Location = new System.Drawing.Point(249, 186);
            this.LblFixo1.Name = "LblFixo1";
            this.LblFixo1.Size = new System.Drawing.Size(42, 17);
            this.LblFixo1.TabIndex = 15;
            this.LblFixo1.Text = "Fixo 1:";
            // 
            // DateCadastro
            // 
            this.DateCadastro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.DateCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateCadastro.Location = new System.Drawing.Point(830, 66);
            this.DateCadastro.Name = "DateCadastro";
            this.DateCadastro.Size = new System.Drawing.Size(127, 25);
            this.DateCadastro.TabIndex = 6;
            // 
            // MaskUF
            // 
            this.MaskUF.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskUF.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskUF.Location = new System.Drawing.Point(511, 420);
            this.MaskUF.Mask = "A,A";
            this.MaskUF.Name = "MaskUF";
            this.MaskUF.Size = new System.Drawing.Size(42, 25);
            this.MaskUF.TabIndex = 46;
            this.MaskUF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblUF
            // 
            this.LblUF.AutoSize = true;
            this.LblUF.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblUF.Location = new System.Drawing.Point(464, 423);
            this.LblUF.Name = "LblUF";
            this.LblUF.Size = new System.Drawing.Size(35, 17);
            this.LblUF.TabIndex = 45;
            this.LblUF.Text = "U.F. :";
            // 
            // MaskCEP
            // 
            this.MaskCEP.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.MaskCEP.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.MaskCEP.Location = new System.Drawing.Point(790, 325);
            this.MaskCEP.Mask = "00000-000";
            this.MaskCEP.Name = "MaskCEP";
            this.MaskCEP.Size = new System.Drawing.Size(131, 25);
            this.MaskCEP.TabIndex = 36;
            this.MaskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // LblCEP
            // 
            this.LblCEP.AutoSize = true;
            this.LblCEP.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCEP.Location = new System.Drawing.Point(732, 329);
            this.LblCEP.Name = "LblCEP";
            this.LblCEP.Size = new System.Drawing.Size(45, 17);
            this.LblCEP.TabIndex = 35;
            this.LblCEP.Text = "C.E.P. :";
            // 
            // TxtNumero
            // 
            this.TxtNumero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtNumero.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtNumero.Location = new System.Drawing.Point(544, 328);
            this.TxtNumero.MaxLength = 160;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(156, 25);
            this.TxtNumero.TabIndex = 34;
            this.TxtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblNumero.Location = new System.Drawing.Point(476, 332);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(51, 17);
            this.LblNumero.TabIndex = 33;
            this.LblNumero.Text = "Numero:";
            // 
            // TxtComplemento2
            // 
            this.TxtComplemento2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtComplemento2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtComplemento2.Location = new System.Drawing.Point(830, 373);
            this.TxtComplemento2.MaxLength = 160;
            this.TxtComplemento2.Name = "TxtComplemento2";
            this.TxtComplemento2.Size = new System.Drawing.Size(156, 25);
            this.TxtComplemento2.TabIndex = 42;
            this.TxtComplemento2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblComplemento2
            // 
            this.LblComplemento2.AutoSize = true;
            this.LblComplemento2.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblComplemento2.Location = new System.Drawing.Point(732, 376);
            this.LblComplemento2.Name = "LblComplemento2";
            this.LblComplemento2.Size = new System.Drawing.Size(92, 17);
            this.LblComplemento2.TabIndex = 41;
            this.LblComplemento2.Text = "Complemento 2:";
            // 
            // TxtComplemento1
            // 
            this.TxtComplemento1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtComplemento1.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtComplemento1.Location = new System.Drawing.Point(546, 372);
            this.TxtComplemento1.MaxLength = 160;
            this.TxtComplemento1.Name = "TxtComplemento1";
            this.TxtComplemento1.Size = new System.Drawing.Size(156, 25);
            this.TxtComplemento1.TabIndex = 40;
            this.TxtComplemento1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblComplemento
            // 
            this.LblComplemento.AutoSize = true;
            this.LblComplemento.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblComplemento.Location = new System.Drawing.Point(448, 376);
            this.LblComplemento.Name = "LblComplemento";
            this.LblComplemento.Size = new System.Drawing.Size(92, 17);
            this.LblComplemento.TabIndex = 39;
            this.LblComplemento.Text = "Complemento 1:";
            // 
            // TxtCidade
            // 
            this.TxtCidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtCidade.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtCidade.Location = new System.Drawing.Point(64, 419);
            this.TxtCidade.MaxLength = 160;
            this.TxtCidade.Name = "TxtCidade";
            this.TxtCidade.Size = new System.Drawing.Size(370, 25);
            this.TxtCidade.TabIndex = 44;
            this.TxtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCidade.Location = new System.Drawing.Point(4, 423);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(46, 17);
            this.LblCidade.TabIndex = 43;
            this.LblCidade.Text = "Cidade:";
            // 
            // TxtBairro
            // 
            this.TxtBairro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtBairro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtBairro.Location = new System.Drawing.Point(64, 372);
            this.TxtBairro.MaxLength = 160;
            this.TxtBairro.Name = "TxtBairro";
            this.TxtBairro.Size = new System.Drawing.Size(370, 25);
            this.TxtBairro.TabIndex = 38;
            this.TxtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblBairro
            // 
            this.LblBairro.AutoSize = true;
            this.LblBairro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblBairro.Location = new System.Drawing.Point(6, 376);
            this.LblBairro.Name = "LblBairro";
            this.LblBairro.Size = new System.Drawing.Size(43, 17);
            this.LblBairro.TabIndex = 37;
            this.LblBairro.Text = "Bairro:";
            // 
            // TxtRua
            // 
            this.TxtRua.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtRua.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtRua.Location = new System.Drawing.Point(49, 325);
            this.TxtRua.MaxLength = 160;
            this.TxtRua.Name = "TxtRua";
            this.TxtRua.Size = new System.Drawing.Size(370, 25);
            this.TxtRua.TabIndex = 32;
            this.TxtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblRua
            // 
            this.LblRua.AutoSize = true;
            this.LblRua.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblRua.Location = new System.Drawing.Point(6, 329);
            this.LblRua.Name = "LblRua";
            this.LblRua.Size = new System.Drawing.Size(30, 17);
            this.LblRua.TabIndex = 31;
            this.LblRua.Text = "Rua:";
            // 
            // TxtId
            // 
            this.TxtId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtId.Location = new System.Drawing.Point(41, 66);
            this.TxtId.MaxLength = 160;
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(69, 25);
            this.TxtId.TabIndex = 2;
            this.TxtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtNome
            // 
            this.TxtNome.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.TxtNome.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.TxtNome.Location = new System.Drawing.Point(64, 137);
            this.TxtNome.MaxLength = 160;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(370, 25);
            this.TxtNome.TabIndex = 8;
            this.TxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblId.Location = new System.Drawing.Point(9, 70);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(21, 17);
            this.LblId.TabIndex = 1;
            this.LblId.Text = "Id:";
            // 
            // LblCadastro
            // 
            this.LblCadastro.AutoSize = true;
            this.LblCadastro.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblCadastro.Location = new System.Drawing.Point(747, 70);
            this.LblCadastro.Name = "LblCadastro";
            this.LblCadastro.Size = new System.Drawing.Size(57, 17);
            this.LblCadastro.TabIndex = 5;
            this.LblCadastro.Text = "Cadastro:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 7.5F);
            this.LblNome.Location = new System.Drawing.Point(9, 141);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(40, 17);
            this.LblNome.TabIndex = 7;
            this.LblNome.Text = "Nome:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 19F);
            this.lblTitulo.Location = new System.Drawing.Point(312, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(136, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro";
            // 
            // FrmCadastros
            // 
            this.AcceptButton = this.BtnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(996, 504);
            this.Controls.Add(this.PnBotoes);
            this.Controls.Add(this.PnCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.FrmCadastros_Load);
            this.PnBotoes.ResumeLayout(false);
            this.PnCadastro.ResumeLayout(false);
            this.PnCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnBotoes;
        private System.Windows.Forms.Panel PnCadastro;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.MaskedTextBox MaskCel2;
        private System.Windows.Forms.Label LblCelular2;
        private System.Windows.Forms.MaskedTextBox MaskFixo2;
        private System.Windows.Forms.Label LblFixo2;
        private System.Windows.Forms.MaskedTextBox MaskRG;
        private System.Windows.Forms.Label LblRG;
        private System.Windows.Forms.MaskedTextBox MaskCPF;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.MaskedTextBox MaskMatricula;
        private System.Windows.Forms.Label LblMatricula;
        private System.Windows.Forms.MaskedTextBox MaskCel1;
        private System.Windows.Forms.Label LblCelular1;
        private System.Windows.Forms.MaskedTextBox MaskFixo1;
        private System.Windows.Forms.Label LblFixo1;
        private System.Windows.Forms.DateTimePicker DateCadastro;
        private System.Windows.Forms.MaskedTextBox MaskUF;
        private System.Windows.Forms.Label LblUF;
        private System.Windows.Forms.MaskedTextBox MaskCEP;
        private System.Windows.Forms.Label LblCEP;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.TextBox TxtComplemento2;
        private System.Windows.Forms.Label LblComplemento2;
        private System.Windows.Forms.TextBox TxtComplemento1;
        private System.Windows.Forms.Label LblComplemento;
        private System.Windows.Forms.TextBox TxtCidade;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxtBairro;
        private System.Windows.Forms.Label LblBairro;
        private System.Windows.Forms.TextBox TxtRua;
        private System.Windows.Forms.Label LblRua;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblCadastro;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox TxtEmail2;
        private System.Windows.Forms.Label LblEmail2;
        private System.Windows.Forms.TextBox TxtEmail1;
        private System.Windows.Forms.Label LblEmail1;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnAtualizar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.ComboBox ComboSituacao;
        private System.Windows.Forms.DateTimePicker DateNascimento;
        private System.Windows.Forms.Label LblNascimento;
    }
}