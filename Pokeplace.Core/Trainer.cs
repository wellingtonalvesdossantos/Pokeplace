using System;
using System.Collections.Generic;
using System.Text;

namespace Pokeplace.Core
{
    public class Trainer : BaseDbEntity
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Codigo { get; set; }
        public short Nivel { get; set; }
        public int TeamId { get; set; }
        public bool Ativo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
