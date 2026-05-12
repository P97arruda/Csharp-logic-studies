using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces_OOP
{
    public class VariablePriceProduct : Product
    {


        private readonly string _measurement;

        private readonly float _quantity;

        public VariablePriceProduct(string description, string id, double price, double tax, string measurement, int quantity) 
            : base(description, id,  price, tax)
        {
            _measurement = measurement;
            _quantity = quantity;
        }


        public override string ToString()
        {
            return $"Produto Variável -> {base.ToString()} | Medida: {_measurement} Qtd: {_quantity} | Total: {ValueToPay():C2}";
        }

        public override double ValueToPay()
        {
            return (Price * _quantity) + (Price * _quantity * Tax);
        }
       
    }
}
