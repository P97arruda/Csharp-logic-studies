namespace Dem5
{
    internal class Program
    {
        // 5. Elabore um programa que num vetor N determine o maior e menor elemento.

        static void Main(string[] args)
        {
            int tamanho1;
            
            Console.Write("Insira o um numero para indicar o tamanho  Array: ");
            int.TryParse(Console.ReadLine(), out tamanho1);

            int[] numero = new int[tamanho1];

            for (int i = 0; i <numero.Length; i++)
            {
                do
                {
                    Console.Write($"Insira um numero: {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out numero[i]));

            }
            int maior = numero[0];
            int menor = numero[0];

            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i] > maior)
                {
                    maior = numero[i];
                }
                if (numero[i] < menor)
                {
                    menor = numero[i];
                }
            }

            Console.WriteLine($"O maior numero do Array é: {maior}");
            Console.WriteLine($"O menor numero do Array é: {menor}");
        }
    }
}
