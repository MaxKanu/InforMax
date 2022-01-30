using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class PessoaJuridica
    {
        public Pessoa Pessoa { get; set; }
        public DateTime DataRegistro { get; set; }
        public string NomeFantasia { get; set; }
        public DocumentosJuridicos Documentos { get; set; }
        public Telefone Telefone { get; set; }
        public Email Email { get; set; }
        public Endereco Endereco { get; set; }
    }
}
