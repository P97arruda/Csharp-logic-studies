namespace ExercicioFinanciamento
{
    public abstract class Financiamento
    {
        public double MontanteAFinacia { get; set; }
        public virtual int PrazoDePagamento { get; set; }
        public double TaxaDeJurosAnual { get; set; }

        public Financiamento(double montateFinanciado, int prazoDePagamento, double taxaDejurosAnual)
        {
            PrazoDePagamento = prazoDePagamento;
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
