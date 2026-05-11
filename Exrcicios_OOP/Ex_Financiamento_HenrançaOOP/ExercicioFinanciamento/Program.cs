namespace ExercicioFinanciamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            FinanciamentoDeCarro carro = new FinanciamentoDeCarro(10000, 24, 5);
            Console.WriteLine(carro.ToString());

            Console.WriteLine();
            Console.WriteLine();

            Fiador  fiador = new Fiador();
            fiador.Nome = "João Silva";
            fiador.Morada = "Rua das Flores 10";
            fiador.Telefone = "912345678";
            fiador.Nif = "123456789";
            fiador.RendimentoBrutoAnual = 25000;
            
            FinanciamentoDeCasa casa = new FinanciamentoDeCasa(150000, 360, 3.5, fiador);
            Console.WriteLine(casa.ToString());

            Console.WriteLine();

            OutrosFinanciamento outrosfinaciamento = new OutrosFinanciamento(101000, 32, 3);
            Console.WriteLine(outrosfinaciamento.ToString());

            
        }
    }
}
