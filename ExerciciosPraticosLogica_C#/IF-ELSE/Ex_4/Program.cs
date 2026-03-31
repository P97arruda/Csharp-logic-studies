using System.ComponentModel.Design;

namespace Ex_4
{
    internal class Program
    {
        // Leia a idade de uma pessoa e informe se pode votar.
        // Ex.: Entrada 15 → Saída Não pode votar
        //
        static void Main(string[] args)
        {
            int idade;
            string pais;

            Console.Write("Insira seu Pais: ");
            pais = Console.ReadLine();


            Console.Write("Insira sua idade: ");
            int.TryParse(Console.ReadLine(), out idade);


            // Para comprar toda String(string.Equals(pais.Trim(), "Portugal", StringComparison.OrdinalIgnoreCase))

            if (pais.ToLower() == "portugal")
            {
                if (idade >= 18)
                {
                    Console.WriteLine("Voce pode votar.");
                }
                else 
                {
                    Console.WriteLine("menor de idade nao pode voltar.");
                }
            }
            else
            {
               Console.WriteLine("Voce nao vive em Portugal nao pode votar");
            }

        }
    }
}
