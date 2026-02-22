namespace ValoresduplaPrecisão
{
    internal class Program
    {
        // Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C.Em seguida, calcule e
        // mostre: 
        // a) a área do triângulo retângulo que tem A por base e C por altura.
        // b) a área do círculo de raio C. (pi = 3.14159)
        // c) a área do trapézio que tem A e B por bases e C por altura.
        // d) a área do quadrado que tem lado B.
        // e) a área do retângulo que tem lados A e B.


        static void Main(string[] args)
        {
           double A, B, C;
           double PI = 3.14159;

            Console.WriteLine();

            double.TryParse(Console.ReadLine(), out A);

            double.TryParse(Console.ReadLine(), out B);

            double.TryParse(Console.ReadLine(), out C);


            double triangulo = (A * C) / 2;
            double circulo = PI * C * C;
            double trapezio = ((A + B) * C) / 2;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine($"TRIANGULO = {triangulo:F3}");
            Console.WriteLine($"CIRCULO = {circulo:F3}");
            Console.WriteLine($"TRAPEZIO = {trapezio:F3}");
            Console.WriteLine($"QUADRADO = {quadrado:F3}");
            Console.WriteLine($"RETANGULO = {retangulo:F3}");



        }
    }      
}
