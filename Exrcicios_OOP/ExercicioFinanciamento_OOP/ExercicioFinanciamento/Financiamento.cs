using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    public abstract class Financiamento
    {
        public double MontanteAFinacia {  get; set; }
        public virtual int PrazoDePagamento { get; set; }
        public double TaxaDeJurosAnual { get; set; }

        public Financiamento(double montateFinanciado, int prazoPagamento, double taxaDejurosAnual)
        {
            PrazoDePagamento = prazoPagamento;
            MontanteAFinacia = montateFinanciado;
            TaxaDeJurosAnual = taxaDejurosAnual;
        }

        public override string ToString()
        {
            return $"Montante financiado: {MontanteAFinacia} ,Prazo de pagamento: {PrazoDePagamento} ,Taxa de juros anual: {TaxaDeJurosAnual}%";
        }

        public abstract double TotalDoFinanciamento();
    }
}
