using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class ClienteFisico
    {
        public DateTime DataNascimento { get; set; }
        public Pessoa Pessoa { get; set; }
        public Documentos Documentos { get; set; }
        public Telefone Telefone { get; set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
