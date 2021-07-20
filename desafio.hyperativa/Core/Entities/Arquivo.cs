using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio.hyperativa.Domain.Entities
{
    public class Arquivo
    {
        public string Nome { get; set; }
        public string Lote { get; set; }
        public DateTime Data { get; set; }
        public int QtdRegistro { get; set; }
        public List<Cartao> Cartoes { get; set; }
    }
}
