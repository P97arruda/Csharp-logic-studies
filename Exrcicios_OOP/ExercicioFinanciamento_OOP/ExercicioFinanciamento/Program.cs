namespace ExercicioFinanciamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Financiamento fin = new Financiamento(10.000, 30, 6.7);

            // montate, prazo em meses, taxa anual 
            FinanciamentoDeCarro carro = new FinanciamentoDeCarro(10000, 24, 5);

            Console.WriteLine(carro.ToString());
            Console.WriteLine("Total: " + carro.TotalDoFinanciamento());




            
        }
    }
}
