namespace RaioDeCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area, raio;

            Console.Write("Insira o Raio: ");
            double.TryParse(Console.ReadLine(), out raio);


            area = Math.PI * raio * raio;

            Console.WriteLine($" A = {Math.Round(area, 2)}");


        }
    }
}
