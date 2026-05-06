namespace ExercicioFinanciamento
{
    internal class OutrosFinanciamento : Financiamento
    {
        public double ComissaoDeAbertura { get; set; }

        public double TaxaAmortizacaoAntecipada { get; set; }


        public OutrosFinanciamento(double montanteFinanciado, int prazoDePagamento, double taxaDejurosAnual)
            : base(montanteFinanciado, prazoDePagamento, taxaDejurosAnual)
        {
            ComissaoDeAbertura = 0.01;
            TaxaAmortizacaoAntecipada = 0.0005;
        }


        public override double TotalDoFinanciamento()
        {
            double juros = MontanteAFinacia * (TaxaDeJurosAnual / 100) * (PrazoDePagamento / 12.0);
            double comissao = MontanteAFinacia * ComissaoDeAbertura;
            double amortizacao = MontanteAFinacia * TaxaAmortizacaoAntecipada;
            return MontanteAFinacia + juros + comissao + amortizacao;

        }

        public override string ToString()
        {
            return $"Outros financiamento --> {base.ToString()} Montate: {TotalDoFinanciamento():C0}";
        }
    }
}
