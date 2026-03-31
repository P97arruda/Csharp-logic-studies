using System.Collections.Generic;
using System;
namespace VitaloFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteService service = new ClienteService();

            while (true)
            {
                Console.WriteLine("1 - Criar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Remover");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        service.CriarCliente();
                        break;
                    case "2":
                        service.ListarClientes();
                        break;
                    case "3":
                        service.AtualizarCliente();
                        break;
                    case "4":
                        service.RemoverCliente();
                        break;
                    case "0":
                        return;
                }
            }
        }
    }

}
   
