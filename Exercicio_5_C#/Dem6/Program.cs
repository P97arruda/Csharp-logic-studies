namespace Dem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limiteInferior, limiteSuperior, soma = 0;

            Console.Write("Insira o limite inferior: ");
            int.TryParse(Console.ReadLine(), out limiteInferior);

            Console.Write("Insira o limite superior: ");
            int.TryParse(Console.ReadLine(), out limiteSuperior);


            for(int i = limiteInferior; i < limiteSuperior; i++)
            {
                soma = soma + limiteInferior;
            }

            Console.WriteLine(soma);



        }
    }
}
