namespace Ex_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int codigo;

            Console.Write("Insira um codigo: ");
            int.TryParse(Console.ReadLine(), out codigo);

            switch (codigo) 
            {
                case 1:
                    Console.WriteLine("Alimento não-perecível");
                    break;

                case 2:
                    Console.WriteLine("Alimento perecível");
                    break;

                case 3:
                    Console.WriteLine("Vestuário");
                    break;

                case 4:
                    Console.WriteLine("Higiene pessoal");
                    break;

                    default:
                    Console.WriteLine("Código inválido");
                    break;



            }
    }
}
