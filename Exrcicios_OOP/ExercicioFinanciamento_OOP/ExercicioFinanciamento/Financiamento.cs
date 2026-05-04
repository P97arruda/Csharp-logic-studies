using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    internal class Financiamento
    {
        private int _prazoDePagamento;

        public double Montante {  get; set; }

        public double TaxaDeJuros { get; set; }

        public int PrazoDePagamento
        {
            get
            {
                return _prazoDePagamento;
            }
            set
            {
                if (value >= 1 && value <= 60)
                {
                    _prazoDePagamento = value;
                }
                else
                {
                    _prazoDePagamento = 1;
                }

            }
        }
    }
}
