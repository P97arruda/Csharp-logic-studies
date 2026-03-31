using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Escola
{
    internal class AlunosService
    {
        private List<Alunos> alunos = new List<Alunos>();

        private int proximoId = 1;

        public void CriarAluno()
        {
            Alunos aluno = new Alunos();

            aluno.Id = proximoId++;

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Apelido: ");
            aluno.Apelido = Console.ReadLine();

            alunos.Add(aluno);

            Console.WriteLine("Aluno criado com sucesso!");
        }

        public void RemoverAluno()
        {
            Console.WriteLine("Digite o Id: ");
            int id = int.Parse(Console.ReadLine());

            Alunos aluno = alunos.Find(c => c.Id == id);

            if(aluno != null)
            {
                alunos.Remove(aluno);
                Console.WriteLine("Removido");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado!");

            }

        }


        public void ListarAlunos()
        {
            foreach (var c in alunos) 
            { 
                Console.WriteLine($"Id: {c.Id} - Nome: {c.NomeCompleto}");
            }
        }


        public void AtualizarAluno()
        {
            Console.WriteLine("insira o Id: ");
            int id = int.Parse(Console.ReadLine());

            Alunos aluno = alunos.Find(c => c.Id == id);    

            if(alunos != null)
            {
                Console.Write("Novo Nome: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Novo Sobre Nome");
                aluno.Apelido = Console.ReadLine();
            }
        }

    }
}
