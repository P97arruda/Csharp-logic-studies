namespace ExercicioFinanciamento
{
    public class FinanciamentoDeCarro : Financiamento
    {
        private int _prazoDePagamento;

        public double ComissaoDeAbertura { get; set; }

        public double ValorResidual { get; set; }


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

        public FinanciamentoDeCarro(double montanteFinanciado, int prazoDePagamento, double taxaDejurosAnual)
            : base(montanteFinanciado, prazoDePagamento, taxaDejurosAnual)
        {
            PrazoDePagamento = prazoDePagamento;
            ComissaoDeAbertura = 0.0001;
            ValorResidual = 0.01;
        }
        public override double TotalDoFinanciamento()
        {
            double juros = MontanteAFinacia * (TaxaDeJurosAnual / 100) * (PrazoDePagamento / 12);
            double comissao = MontanteAFinacia * (ComissaoDeAbertura / 100);
            double residual = MontanteAFinacia * (ValorResidual / 100);
            return MontanteAFinacia + juros + comissao + residual;
        }

        public override string ToString()
        {
            return $"Financiamento do Carro --> {base.ToString()} Montate: {TotalDoFinanciamento():C0}";
        }

    }
}
