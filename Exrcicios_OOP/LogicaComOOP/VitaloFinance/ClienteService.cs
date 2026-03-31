using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VitaloFinance
{
    internal class ClienteService
    {

        private List<Cliente> clientes = new List<Cliente>();

        private int proximoId = 1;

        public void CriarCliente()
        {
            Cliente cliente = new Cliente();

            cliente.Id = proximoId++;

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Sobrenome: ");
            cliente.SobreNome = Console.ReadLine();

            Console.Write("Salário: ");
            cliente.Salario = double.Parse(Console.ReadLine());

            clientes.Add(cliente);

            Console.WriteLine("Cliente criado com sucesso!");
        }

        public void ListarClientes()
        {
            foreach (var c in clientes)
            {
                Console.WriteLine($" Id: {c.Id} - Nome: {c.NomeCompleto} - Salario: {c.Salario}");
            }
        }

        public void AtualizarCliente()
        {
            Console.Write("Digite o Id: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                Console.Write("Novo Nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Novo Sobrenome: ");
                cliente.SobreNome = Console.ReadLine();

                Console.Write("Novo Salário: ");
                cliente.Salario = double.Parse(Console.ReadLine());
               

                Console.WriteLine("Atualizado!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }

        public void RemoverCliente()
        {
            Console.Write("Digite o Id: ");
            int id = int.Parse(Console.ReadLine());

            Cliente cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Removido!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");
            }
        }
    }
}

