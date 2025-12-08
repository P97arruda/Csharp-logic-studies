namespace Dem15
{
    class Program
    {
        static void Main()
        {
            int d1, d2, d3, d4;
            int soma = 0, mult = 1;
            int resultado = 0, contador = 0;

            Console.WriteLine("Digite 4 digitos:");

            Console.Write("Digito 1: ");
            int.TryParse(Console.ReadLine(), out d1);

            Console.Write("Digito 2: ");
            int.TryParse(Console.ReadLine(), out d2);

            Console.Write("Digito 3: ");
            int.TryParse(Console.ReadLine(), out d3);

            Console.Write("Digito 4: ");
            int.TryParse(Console.ReadLine(), out d4);

            Console.WriteLine("\nCalculando:");

           
            while (contador < 4)
            {
               

                if (contador == 0)
                {
                    resultado = d4 * mult;
                    Console.WriteLine($"{d4} × {mult} = {resultado}");
                }

                if (contador == 1)
                {
                    resultado = d3 * mult;
                    Console.WriteLine($"{d3} × {mult} = {resultado}");
                }

                if (contador == 2)
                {
                    resultado = d2 * mult;
                    Console.WriteLine($"{d2} × {mult} = {resultado}");
                }

                if (contador == 3)
                {
                    resultado = d1 * mult;
                    Console.WriteLine($"{d1} × {mult} = {resultado}");
                }

                soma = soma + resultado;
                mult = mult + 1;
                contador = contador + 1;
            }

            int controle = soma % 7;
            Console.WriteLine($"\nCodigo final: {d1}{d2}{d3}{d4}{controle}");
        }
    }
}
