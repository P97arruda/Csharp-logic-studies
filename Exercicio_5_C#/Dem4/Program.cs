namespace Dem4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int limiteInferior, limiteSuperior, aux;

            Console.Write("Insira o limite inferior: ");
            int.TryParse(Console.ReadLine(), out limiteInferior);

            Console.Write("Insira o limite superior: ");
            int.TryParse(Console.ReadLine(), out limiteSuperior);

            if(limiteInferior > limiteSuperior)
            {
                Console.WriteLine("Os intervalos vinhero trocados, vamos organizar :) ");

                aux = limiteInferior;
                limiteInferior = limiteSuperior;
                limiteSuperior = aux;
            }

            for (int i = limiteInferior; i < limiteSuperior; i++) {

                if (i % 5 != 0)
                {
                    Console.WriteLine(i);
                }


            }

        }
    }
}
