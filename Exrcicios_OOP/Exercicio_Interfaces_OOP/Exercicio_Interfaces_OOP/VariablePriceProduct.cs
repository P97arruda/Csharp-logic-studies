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
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override string ToString()
        {
            return $"Produto Variável -> {base.ToString()} | {Measurement}: {Quantity} | Total: {ValueToPay():F2}";
        }
        
        public override double ValueToPay()
        {
            return (double)(Price * (decimal)Quantity + Price * (decimal)Quantity * (decimal)Tax);
        }
       
    }
}
