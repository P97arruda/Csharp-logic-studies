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

        public string Id { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }


        protected Product(string description, string id, double price, double tax)
        {
            Description = description;
            Id = id;
            Price = price;
            Tax = tax;
        }

        public override string ToString()
        {
            return $"Descrição: {Description} Id: {Id} Preço: {Price} Taxa: {Tax}";
        }

        public abstract double ValueToPay();
        
    }
}
