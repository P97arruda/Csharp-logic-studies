namespace Dem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int limitadorSuperior, limitadorInferior, aux;

            Console.Write("ensira o LimitadorSuperior: ");
            int.TryParse(Console.ReadLine(), out limitadorInferior);

            Console.Write("ensira o LimitadorInferior: ");
            int.TryParse(Console.ReadLine(), out limitadorSuperior);

            if (limitadorInferior > limitadorSuperior)
            {
                Console.WriteLine("Os intervalos vinheiro trocados, vamos organizar :)");
                aux = limitadorInferior;
                limitadorInferior = limitadorSuperior;
                limitadorSuperior = aux;
            }

            while(limitadorInferior <= limitadorSuperior)
            {
                Console.WriteLine(limitadorInferior);
                limitadorInferior++;
            }
            





        }
    }
}
