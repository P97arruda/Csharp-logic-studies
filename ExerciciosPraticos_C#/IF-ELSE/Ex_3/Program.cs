namespace Ex_3
{
    internal class Program
    {
        //
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Insira sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);    

            if(idade >= 18)
            {
                Console.WriteLine("Voce e maior de idade.");
            }
            else
            {
                Console.WriteLine("Voce e menor de idade.");
            }
        }
    }
}
