namespace Dem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoCusto = 0;
               
            int codigo;

            Console.Write("Preco de custo do produto: ");
            precoCusto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Codigo do produto 1 a 6: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            //switch (codigo)
            //{
            //    case 1:
            //    case 2:
            //        Console.WriteLine($"Para Lacticinios e carnes o valor e de {precoCusto + (precoCusto * 0.8)}");
            //        break;

            //    case 3:
            //    case 4:
            //        Console.WriteLine($"Para Peixes e Alves o valor e de {precoCusto * 2}");
            //        break;

            //    case 5:
            //    case 6:
            //        Console.WriteLine($"Para Ovos e Doces o valor e de  {precoCusto + (precoCusto * 0.9)}");
            //        break;
            //    default:
            //        Console.WriteLine("codigo invalido!");
            //        break;
            //}

            





        }
    }
}
