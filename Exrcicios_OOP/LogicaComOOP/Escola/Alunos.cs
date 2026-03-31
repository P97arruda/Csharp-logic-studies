using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    internal class Alunos
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set; }

        public List<Disciplinas> Materias { get; set; } = new List<Disciplinas>();

        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Apelido}";
            }
        }



    }
}
