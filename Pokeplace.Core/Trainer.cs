using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokeplace.Core
{
    public class Trainer : BaseDbEntity<Trainer>
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Codigo { get; set; }
        public int Nivel { get; set; }
        public int TeamId { get; set; }
        public bool Ativo { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }

        public static Trainer FetchByApelido(string apelido, params string[] dependencies)
        {
            return ListAll(dependencies).FirstOrDefault(x => x.Apelido == apelido);
        }

        public static Trainer FetchByCodigo(string codigo, params string[] dependencies)
        {
            return ListAll(dependencies).FirstOrDefault(x => x.Codigo == codigo);
        }

    }
}
