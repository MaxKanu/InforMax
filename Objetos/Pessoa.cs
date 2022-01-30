using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Cadastro { get; set; }
        public DateTime Alteracao { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
        public Situacoes Situacao { get; set; }
    }
}
