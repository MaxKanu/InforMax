using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Pedidos
    {
        public int IdPedidos { get; set; }
        public int Id { get; set; }
        public string Marcador { get; set; }
        public int IdTipoAparelho { get; set; }
        public int IdMarca { get; set; }
        public string TipoAparelho { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Observacoes { get; set; }
        public Tarefas Tarefas { get; set; }
        public DateTime Cadastro { get; set; }
        public Operacao Operacao { get; set; }
        public PedidoSituacao Situacao { get; set; }
        public ClienteFisico Cliente { get; set; }
        public PessoaJuridica Juridico { get; set; }
    }
}
