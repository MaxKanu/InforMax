using Objetos;
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
    public partial class FrmMenu : Form
    {
        public string Hora
        {
            //ToShortTimeString()
            get { return DateTime.Now.ToLongTimeString(); }
        }

        public string Segundos
        {
            get
            {
                return DateTime.Now.Second.ToString();
            }
        }
        public string Dia
        {
            get
            {
                return DateTime.Now.Day.ToString();
            }
        }
        public string Mes
        {
            get
            {
                return DateTime.Now.Month.ToString();
            }
        }
        public string Ano
        {
            get
            {
                return DateTime.Now.Year.ToString();
            }
        }
        ClienteFisico fisico = new ClienteFisico();
        ClienteFisicoColecao colecaoFisico = new ClienteFisicoColecao();
        Funcionarios funcionario = new Funcionarios();
        FuncionariosColecao colecaoFuncionario = new FuncionariosColecao();
        public FrmMenu()
        {
            InitializeComponent();
        }
        private void TmData_Hora_Tick(object sender, EventArgs e)
        {
            LblRelogio.Text = this.Dia + "/" + this.Mes + "/" + this.Ano + "   " + this.Hora;// + ":" + this.Segundos;
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            TmData_Hora.Start();
        }

        private void ClienteFisicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastros fisico = new FrmCadastros(Enumeradores.Fisico, null, null)
            {
                MdiParent = this
            };
            fisico.Show();
        }

        private void ClienteJuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroJuridico funcionario = new frmCadastroJuridico(Enumeradores.Juridico, null)
            {
                MdiParent = this
            };
            funcionario.Show();
        }

        private void FisicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarCadastroFisico pesq = new frmPesquisarCadastroFisico(Acao_Tela.ConsultarCliente)
            {
                MdiParent = this
            };
            pesq.Show();
        }

        private void FuncionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCadastros funcionarios = new FrmCadastros(Enumeradores.Funcionario, null, null)
            {
                MdiParent = this
            };
            funcionarios.Show();
        }

        private void FuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarCadastroFisico pesq = new frmPesquisarCadastroFisico(Acao_Tela.ConsultarFuncionario)
            {
                MdiParent = this
            };
            pesq.Show();
        }

        private void TsSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JuridicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisarCadastroFisico pesq = new frmPesquisarCadastroFisico(Acao_Tela.ConsultarJuridico)
            {
                MdiParent = this
            };
            pesq.Show();
        }

        private void TsProdutos_Click(object sender, EventArgs e)
        {
            frmCadastroProduto produtos = new frmCadastroProduto
            {
                MdiParent = this
            };
            produtos.Show();
        }

        private void TsServiços_Click(object sender, EventArgs e)
        {
            frmCadastroServico servicos = new frmCadastroServico
            {
                MdiParent = this
            };
            servicos.Show();
        }

        private void TsFabricante_Click(object sender, EventArgs e)
        {
            FrmFabricantes fabri = new FrmFabricantes(Acao_Tela.Inserir)
            {
                MdiParent = this
            };
            
            fabri.Show();
        }



        private void TsOS_Click(object sender, EventArgs e)
        {
            FrmOrdemServico OS = new FrmOrdemServico(Acao_Tela.InserirServico, null)
            {
                MdiParent = this
            };
            OS.Show();
        }

        private void TsPedido_Click(object sender, EventArgs e)
        {
            
        }

        private void TsPedidos_Click(object sender, EventArgs e)
        {
            FrmPesquisarPedidos pedidos = new FrmPesquisarPedidos(Acao_Tela.PesquisarPedidos)
            {
                 MdiParent = this
            };
            pedidos.Show();
        }

        private void TsPrecoProdutoInserir_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.InserirProduto)
            {
                MdiParent = this
            };
            preco.Show();
        }
        private void TsPrecoProdutoAlterar_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.AlterarProduto)
            {
                MdiParent = this
            };
            preco.Show();
        }
        private void TsPrecoProdutoConsultar_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.ConsultarProdutos)
            {
                MdiParent = this
            };
            preco.Show();
        }

        private void TsPrecoServicoInserir_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.InserirServico)
            {
                MdiParent = this
            };
            preco.Show();
        }

        private void TsPrecoServicoConsultar_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.ConsultarServicos)
            {
                MdiParent = this
            };
            preco.Show();
        }

        private void TsPrecoServicoAlterar_Click(object sender, EventArgs e)
        {
            FrmPreco preco = new FrmPreco(Acao_Tela.AlterarServico)
            {
                MdiParent = this
            };
            preco.Show();
        }

        private void TsConsultarOS_Click(object sender, EventArgs e)
        {
            FrmOrdemServico OS = new FrmOrdemServico(Acao_Tela.Consultar, null)
            {
                MdiParent = this
            };
            OS.Show();
        }

        private void TsPesquisarNotasFechadas_Click(object sender, EventArgs e)
        {
            FrmPesquisaItens pesquisa = new FrmPesquisaItens
            {
                MdiParent = this
            };
            pesquisa.Show();
        }

        private void TsMarca_Click(object sender, EventArgs e)
        {
            FrmFabricantes fabri = new FrmFabricantes(Acao_Tela.InserirProduto)
            {
                MdiParent = this
            };

            fabri.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaixaSobre sobre = new CaixaSobre();
            sobre.ShowDialog();
        }

        private void TsVendas_Click(object sender, EventArgs e)
        {
            
        }

        private void TsOrdemDeServicos_Click(object sender, EventArgs e)
        {
            FrmPedido pedido = new FrmPedido(Acao_Tela.Inserir, null)
            {
                MdiParent = this
            };
            pedido.Show();
        }

        private void TsVenda_Click(object sender, EventArgs e)
        {
            FrmPedido vendas = new FrmPedido(Acao_Tela.InserirProduto, null);
            vendas.MdiParent = this;
            vendas.Show();
        }

    }
}
