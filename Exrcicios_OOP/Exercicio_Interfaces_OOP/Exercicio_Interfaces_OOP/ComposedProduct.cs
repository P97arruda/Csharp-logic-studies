using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces_OOP
{
    public class ComposedProduct : Product
    {
        private readonly float _discount;
        private readonly List<Product> _products;

        public List<Product> Products { get; set; }



        public ComposedProduct(string description, string id, double price, double tax) 
            : base(description, id, price, tax)
        {
            _discount = _discount;
            _products = _products;
        }
        
        public  override double ValueToPay()
        {
            double total = 0;
            foreach (Product p in _products)
            {
                total += p.ValueToPay();
            }
            return total - (total * _discount);
        }

        public override string ToString() 
        {
            return $"Produto Composto -> {base.ToString()} | Desconto: {_discount:P0} | Total: {ValueToPay():C2}";
        }
    }
}
