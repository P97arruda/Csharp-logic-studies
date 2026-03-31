namespace Escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlunosService aluno = new AlunosService();

            while (true)
            {
                Console.WriteLine("1 - Criar Aluno");
                Console.WriteLine("2 - Listar ALuno");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Remover");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        aluno.CriarAluno();
                        break;
                    case "2":
                        aluno.CriarAluno();
                        break;
                    case "3":
                        aluno.CriarAluno();
                        break;
                    case "4":
                        aluno.RemoverAluno();
                        break;
                    case "0":
                        return;
                }
            }
        }
    }
}
