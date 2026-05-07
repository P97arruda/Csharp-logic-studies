namespace ExercicioFinanciamento
{
    internal class FinanciamentoDeCasa : Financiamento
    {
        public Fiador Fiador { get; set; }

        public double Spread { get; set; }

        public FinanciamentoDeCasa(double montanteFinanciado, int prazoDePagamento, double taxaDejurosAnual, Fiador fiador)
            : base(montanteFinanciado, prazoDePagamento, taxaDejurosAnual)
        {
            Spread = 1.015;
            Fiador = fiador;
        }

        public override double TotalDoFinanciamento()
        {
            double juros = MontanteAFinacia * ((TaxaDeJurosAnual / 100) + Spread) * (PrazoDePagamento / 12.0);
            return MontanteAFinacia + juros;
        }

        public override string ToString()
        {
            return $"Financiamento da Casa --> {base.ToString()} Total: {TotalDoFinanciamento():C0}  {Fiador.ToString()}";
        }
    }
}
