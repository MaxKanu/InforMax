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
    public partial class FrmFabricantes : Form
    {
        public FrmFabricantes()
        {
            InitializeComponent();
            TxtNome.Enabled = false;
            BtnSalvar.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            TxtNome.Enabled = true;
            BtnNovo.Enabled = false;
            BtnSalvar.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            NgFa fabricante = new NgFa();
            Fabricante fabri = new Fabricante();

            fabri.Descricao = TxtNome.Text;

            string retorno = fabricante.Inserir(fabri);
            try
            {
                int IdFabricante = Convert.ToInt32(retorno);
                MessageBox.Show("Produto inserido com sucesso! \n\n O codigo gerado foi : " + IdFabricante.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FrmFabricantes_Load(object sender, EventArgs e)
        {

        }
    }
}
