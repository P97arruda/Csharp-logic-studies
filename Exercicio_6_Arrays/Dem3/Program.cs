namespace Dem3
{
    internal class Program
    {
        //3. Elabore um programa que forme um array com as 16 primeiras letras do alfabeto. (A, B, C, D,..., P)
        static void Main(string[] args)
        {
            char [] alfabeto = new char[16];
            char letra = 'A';

            for (int i = 0; i < alfabeto.Length; i++)
            {
                alfabeto[i] = letra;
                letra++;
            }

            for (int i = 0; i < alfabeto.Length; i++)
            {
                Console.WriteLine(alfabeto[i]);
            }





        }
    }
}
