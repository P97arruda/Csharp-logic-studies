using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces_OOP
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }

        public int Id { get; set; }

        public decimal Price { get; set; }

        public float Tax { get; set; }
        public override string ToString()
        {
            return $"Descrição: {Description} Id: {Id} Preço: {Price} Taxa: {Tax}";
        }

        public abstract double ValueToPay();
        
    }
}
