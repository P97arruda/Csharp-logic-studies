using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VitaloFinance
{
    public  class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public double Salario { get; set; }

        public string NomeCompleto => Nome + " " + SobreNome;
    }


}

