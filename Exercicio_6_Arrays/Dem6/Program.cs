namespace Dem6
{
    internal class Program
    {
        //Elabore um programa que conte o número de vezes que cada elemento ocorre num vetor de N
        //inteiros.Por exemplo, no vetor A:
                                            //A = {4,2,5,4,3,5,2,2,4}
        //4 ocorre três vezes
        //2 ocorre três vezes
        //Etc....
        static void Main(string[] args)
        {
            int tamanho;
            Console.Write("Insira o tamanho do Array");
            int.TryParse(Console.ReadLine(), out tamanho);

            int[] numero = new int[tamanho];

            for (int i = 0; i <numero.Length; i++)
            {
                do
                {
                    Console.Write($"Insira um numero: {i + 1}: ");
                } while (!int.TryParse(Console.ReadLine(), out numero[i]));
            }

            int numeroRepetido;

            for (int i = 0; i < numero.Length; i++)
            {
                numeroRepetido = 0;

                for (int j = 0; j < numero.Length; j++)
                {
                    if (numero[i] == numero[j])
                    {
                        numeroRepetido++;
                    }
                }
                Console.WriteLine($"O numero {numero[i]} se repete {numeroRepetido} vezes");
            }

        }
    }
}
