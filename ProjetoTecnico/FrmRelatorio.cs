using Objetos;
using Negocios;
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
        ItensDePedidoColecao colecao = new ItensDePedidoColecao();
        //List<Recibos> _recibo;
        string  _Aparelho, _Modelo, _Cliente, _Data, _Defeito, _ValorTotal;


        private DataTable dt;

        //public FrmRelatorio(List<Recibos> dataSource, string Aparelho, string Modelo, string Data, string Cliente, string Defeito, string ValorTotal)
        //public FrmRelatorio(DataTable dt, string Aparelho, string Modelo, string Data, string Cliente, string Defeito, string ValorTotal)
        public FrmRelatorio(ItensDePedidoColecao dt, string Aparelho, string Modelo, string Data, string Cliente, string Defeito, string ValorTotal)
        {
            InitializeComponent();
            colecao = dt;
            _Aparelho = Aparelho;
            _Modelo = Modelo;
            _Cliente = Cliente;
            _Data = Data;
            _Defeito = Defeito;
            _ValorTotal = ValorTotal;
        }
        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            RecibosBindingSource.DataSource = colecao;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("rpAparelho",_Aparelho),
                new Microsoft.Reporting.WinForms.ReportParameter("rpModelo",_Modelo),
                new Microsoft.Reporting.WinForms.ReportParameter("rpCliente",_Cliente),
                new Microsoft.Reporting.WinForms.ReportParameter("rpData",_Data),
                new Microsoft.Reporting.WinForms.ReportParameter("rpDefeito",_Defeito),
                new Microsoft.Reporting.WinForms.ReportParameter("rpValorTotal",_ValorTotal)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

    }
}
