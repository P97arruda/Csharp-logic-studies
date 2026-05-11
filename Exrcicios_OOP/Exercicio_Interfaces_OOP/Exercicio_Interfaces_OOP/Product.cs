using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces_OOP
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }

        public string Id { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }

        public override string ToString()
        {
            return $"Descrição: {Description} Id: {Id} Preço: {Price} Taxa: {Tax}";
        }

        public abstract double ValueToPay();
        
    }
}
