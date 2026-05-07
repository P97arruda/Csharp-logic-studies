namespace ExercicioFinanciamento
{
    internal class Fiador
    {
        public string Nome { get; set; }
        public string Morada { get; set; }

        public string Telefone { get; set; }

        public string Nif { get; set; }

        public double RendimentoBrutoAnual { get; set; }
        
        public override string ToString()
        {
            return $"Fiador: {Nome} | Morada: {Morada} | Telefone: {Telefone} | NIF: {Nif} | Rendimento: {RendimentoBrutoAnual:C0}";
        }
    }
}
