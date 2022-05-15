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
        NgFa fabricante = new NgFa();
        Fabricante fabri = new Fabricante();

        Acao_Tela telaSelecionada;
        public FrmFabricantes(Acao_Tela acao)
        {
            InitializeComponent();
            telaSelecionada = acao;
            Cancelar();
            if (acao.Equals(Acao_Tela.Inserir))
            {
                lblTitulo.Text = "Cadastrar Fabricante";
            }
            if (acao.Equals(Acao_Tela.InserirProduto))
            {
                lblTitulo.Text = "Cadastrar Marca";
            }
        }
        void Cancelar()
        {
            TxtNome.Enabled = false;
            TxtNome.Clear();
            BtnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;
        }
        void Ativar()
        {
            TxtNome.Enabled = true;
            BtnNovo.Enabled = false; ;
            BtnSalvar.Enabled = true;
            BtnCancelar.Enabled = true;
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Ativar();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (telaSelecionada.Equals(Acao_Tela.Inserir))
            {
                fabri.Descricao = TxtNome.Text;

                string retorno = fabricante.Inserir(fabri);
                try
                {
                    int IdFabricante = Convert.ToInt32(retorno);
                    MessageBox.Show("Fabricante inserido com sucesso! \n\n O codigo gerado foi : " + IdFabricante.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cancelar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            if (telaSelecionada.Equals(Acao_Tela.InserirProduto))
            {
                fabri.Descricao = TxtNome.Text;

                string retorno = fabricante.InserirMarca(fabri);
                try
                {
                    int IdFabricante = Convert.ToInt32(retorno);
                    MessageBox.Show("Marca inserida com sucesso! \n\n O codigo gerado foi : " + IdFabricante.ToString(), "SUCESSO!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cancelar();
                }
                catch (Exception)
                {
                    throw;
                }
            }
           
           
        }

        private void FrmFabricantes_Load(object sender, EventArgs e)
        {

            ToolTip nomeObjeto = new ToolTip();

            nomeObjeto.AutoPopDelay = 5000;
            nomeObjeto.InitialDelay = 100;
            nomeObjeto.ReshowDelay = 100;
            nomeObjeto.ShowAlways = true;

            nomeObjeto.SetToolTip(this.BtnSalvar, "Salvar Cadastro");
            nomeObjeto.SetToolTip(this.BtnCancelar, "Cancelar");
            nomeObjeto.SetToolTip(this.BtnSair, "Fechar");
            nomeObjeto.SetToolTip(this.BtnNovo, "Novo Cadastro");
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
    }
}
