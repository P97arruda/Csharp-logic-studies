namespace Dem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kgMorango, kgMaca;
            double precoMorango, precoMaca;
            double totalKg, total;

            Console.Write("Insira a quantidade de morangos (Kg): ");
            kgMorango = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a quantidade de maçãs (Kg): ");
            kgMaca = Convert.ToDouble(Console.ReadLine());

            // Preço morango
            if (kgMorango <= 5)
            {
                precoMorango = kgMorango * 2.50;
            }
            else
            {
                precoMorango = kgMorango * 2.20;
            }

            // Preço maçã
            if (kgMaca <= 5)
            {
                precoMaca = kgMaca * 1.80;
            }
            else
            {
                precoMaca = kgMaca * 1.50;
            }

            totalKg = kgMorango + kgMaca;
            total = precoMorango + precoMaca;

            // Verificar desconto
            if (totalKg > 8)
            {
                total = total - (total * 0.10);
            }
            else
            {
                if (total > 25)
                {
                    total = total - (total * 0.10);
                }
            }

            Console.WriteLine($"O valor total a pagar é: {total} euros");
        }
    }
}

