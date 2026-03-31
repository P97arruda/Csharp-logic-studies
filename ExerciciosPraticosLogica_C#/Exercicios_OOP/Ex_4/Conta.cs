using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4
{
    public class Conta
    {
        public int _salario;
        public int _rendaCasa;
        public int _parcelaCarro;


        public int SomaGatos()
        {
            int total;

            total =  _salario - _rendaCasa - _parcelaCarro;
            
            return total;
       }

    }
}
