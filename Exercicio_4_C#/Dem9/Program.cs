

namespace Dem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigoAluno;
            double nota1, nota2, nota3, media;


            Console.Write("Insira seu codigo: ");
            int.TryParse(Console.ReadLine(), out codigoAluno);

            Console.Write("Insira a primeira nota: ");
            double.TryParse(Console.ReadLine(), out nota1);

            Console.Write("Insira a segunda nota: ");
            double.TryParse(Console.ReadLine(), out nota2);

            Console.Write("Insira a terceira nota: ");
            double.TryParse(Console.ReadLine(), out nota3);


            if(nota1 >= nota2)
            {
                if (nota1 >= nota3)
                {
                    media = (nota1 * 4 + nota2 * 3 + nota3) / 10;
                }
                else
                {
                    media = (nota1 * 3 + nota2 * 3 + nota3 * 4) / 10;
                } 
            }
            else
            {
                if (nota2 >= nota3)
                {
                    media = (nota1 * 3 + nota2 * 3 + nota3 * 4) / 10;
                }
                else
                {
                    media = (nota1 * 3 + nota2 * 3 + nota3 * 4) / 10;
                }
            }



            Console.WriteLine($"Código do aluno: {codigoAluno}");
            Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
            Console.WriteLine($"Média: {media}");


            if ( media >= 5)
            {
                Console.WriteLine("Aprovado!!");
            }
            else
            {
                Console.WriteLine("Reprovado!!");
            }


            /*
            Console.WriteLine($"Código do aluno: {codigoAluno}");
            Console.WriteLine($"Notas: {nota1}, {nota2}, {nota3}");
            Console.WriteLine($"Média: {media}");
            */








        }

        

    }
}
