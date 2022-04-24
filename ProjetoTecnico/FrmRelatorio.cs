using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTecnico
{
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'InformaxDataSet.uspConsultarItensPedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.uspConsultarItensPedidosTableAdapter.Fill(InformaxDataSet.uspConsultarItensPedidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
