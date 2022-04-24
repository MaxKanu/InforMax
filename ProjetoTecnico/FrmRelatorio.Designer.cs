namespace ProjetoTecnico
{
    partial class FrmRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InformaxDataSet = new ProjetoTecnico.InformaxDataSet();
            this.uspConsultarItensPedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspConsultarItensPedidosTableAdapter = new ProjetoTecnico.InformaxDataSetTableAdapters.uspConsultarItensPedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InformaxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspConsultarItensPedidosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uspConsultarItensPedidosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjetoTecnico.Relatorio_O_S.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 658);
            this.reportViewer1.TabIndex = 0;
            // 
            // InformaxDataSet
            // 
            this.InformaxDataSet.DataSetName = "InformaxDataSet";
            this.InformaxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspConsultarItensPedidosBindingSource
            // 
            this.uspConsultarItensPedidosBindingSource.DataMember = "uspConsultarItensPedidos";
            this.uspConsultarItensPedidosBindingSource.DataSource = this.InformaxDataSet;
            // 
            // uspConsultarItensPedidosTableAdapter
            // 
            this.uspConsultarItensPedidosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 658);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorio";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InformaxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspConsultarItensPedidosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource uspConsultarItensPedidosBindingSource;
        private InformaxDataSet InformaxDataSet;
        private InformaxDataSetTableAdapters.uspConsultarItensPedidosTableAdapter uspConsultarItensPedidosTableAdapter;
    }
}