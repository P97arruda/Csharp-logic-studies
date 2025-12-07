namespace Dem14
{
    class Program
    {
        static void Main()
        {
            double media, salario, soma = 0;
            int  maior = 0;
            int menor = 0;
            int mulheres = 0;
            int cont = 0;
            char sexo, resp = 's';
            int idade;

            while (resp == 's')
            {
                cont = cont + 1;

                Console.Write("Idade: ");
                int.TryParse(Console.ReadLine(), out idade);

                Console.Write("Sexo (M/F): ");
                char.TryParse(Console.ReadLine(), out sexo);

                Console.Write("Salario: ");
                double.TryParse(Console.ReadLine(), out salario);
                    

                soma = soma + salario;

                if (cont == 1)
                {
                    maior = idade;
                    menor = idade;
                }
                else
                {
                    if (idade > maior)
                    {
                        maior = idade;
                    }
                    else
                    {
                        if (idade < menor)
                        {
                            menor = idade;
                        }
                    }
                }

                if (sexo == 'F')
                {
                    if (salario <= 500)
                    {
                        mulheres ++;
                    }
                }

                Console.Write("Continuar (s/n)? ");
                Char.TryParse(Console.ReadLine(), out resp);
            }

            if (cont > 0)
            {
                 media = soma / cont;

                Console.WriteLine($"Media de salario do grupo: {media}");
                Console.WriteLine($"Maior idade do grupo: {maior}");
                Console.WriteLine($" Menor idade do grupo: {menor}");
                Console.WriteLine($"Quantidade de mulheres com salario ate 500 euros: {mulheres}"); ;
            }

        }

    }
}