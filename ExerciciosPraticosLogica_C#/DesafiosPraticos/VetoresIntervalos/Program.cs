namespace VetoresIntervalos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Passo 1: Ler os valores
            Console.Write("Digite a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Digite c: ");
            double c = double.Parse(Console.ReadLine());

            // Passo 2: Verificar 'a'
            if (a == 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }

            // Passo 3: Calcular delta
            double delta = b * b - 4 * a * c;

            // Passo 4: Verificar delta
            if (delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
                return;
            }

            // Passo 5: Calcular raízes
            double raizDelta = Math.Sqrt(delta);
            double x1 = (-b + raizDelta) / (2 * a);
            double x2 = (-b - raizDelta) / (2 * a);

            // Passo 6: Mostrar resultados
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");

        }
    }
 }
    

