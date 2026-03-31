namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero;
            int numero, resultado; /*N = 1;*/

             Console.Write("Insira um numero:");
             int.TryParse(Console.ReadLine(), out numero);

              for (int i = 1; i <= 10; i++) 
              { 

                  resultado = numero * i;
                 Console.WriteLine($"{numero} x {i} = {resultado}");
                 

               }



            //int numero, resultado, N = 1;

            //Console.Write("Insira um numero entre 1 e 10: ");
            //int.TryParse(Console.ReadLine(), out numero);

            //while (N <= 10)
            //{
            //    resultado = numero * N;
            //    Console.WriteLine($"{numero} * {N} = {resultado}");
            //    N++;
            //}
        }
    }
}
