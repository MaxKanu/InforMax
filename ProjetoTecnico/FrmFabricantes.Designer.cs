namespace ProjetoTecnico
{
    partial class FrmFabricantes
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
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(92, 98);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(308, 27);
            this.TxtNome.TabIndex = 2;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Segoe Print", 9F);
            this.LblNome.Location = new System.Drawing.Point(37, 98);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(49, 21);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome:";
            // 
            // BtnNovo
            // 
            this.BtnNovo.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.Location = new System.Drawing.Point(56, 172);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(69, 47);
            this.BtnNovo.TabIndex = 3;
            this.BtnNovo.Text = "Novo\r\n";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(148, 172);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 47);
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(246, 172);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 47);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(344, 172);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 47);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Print", 16F);
            this.lblTitulo.Location = new System.Drawing.Point(109, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(286, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro De Fabricantes";
            // 
            // FrmFabricantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 241);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.TxtNome);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmFabricantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFabricantes";
            this.Load += new System.EventHandler(this.FrmFabricantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label lblTitulo;
    }
}