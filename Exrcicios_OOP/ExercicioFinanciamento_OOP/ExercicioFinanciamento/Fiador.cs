using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFinanciamento
{
    internal class Fiador
    {
        public string Nome {  get; set; }
        public string Morada { get; set; }

        public string Telefone { get; set; }

        public string Nif {  get; set; }

        public double RendimentoBrutoAnual { get; set; }


        public Fiador(string nome, string morada, string telefone, string nif, double rendimentosBrutoAnual)
        {
            Nome = nome;
            Morada = morada;
            Telefone = telefone;
            Nif = nif;
            RendimentoBrutoAnual = rendimentosBrutoAnual;
        }

        public override string ToString()
        {
            return $"Fiador: {Nome} | Morada: {Morada} | Telefone: {Telefone} | NIF: {Nif} | Rendimento: {RendimentoBrutoAnual:C0}";
        }
    }
}
