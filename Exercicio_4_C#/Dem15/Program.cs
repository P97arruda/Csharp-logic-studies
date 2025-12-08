namespace Dem15
{
    class Program
    {
        static void Main()
        {
            int numero, digito, soma, resultado, copia, mult = 0;
            int controle;



            Console.Write("Insira o codigo: ");
            int.TryParse(Console.ReadLine(), out numero);

            copia = numero;
            soma = 0;
            mult = 1;


            Console.WriteLine("\nCalculando");

            while (numero > 0)
            {
                 digito = numero % 10;
                 resultado = digito * mult;

                Console.WriteLine($"{digito} x {mult} = {resultado}");

                soma = soma + resultado;
                mult++;
                numero = numero / 10;
            }

             controle = soma % 7;


            Console.WriteLine($"\nCodigo final: {copia} {controle}");
        }
    }
}
