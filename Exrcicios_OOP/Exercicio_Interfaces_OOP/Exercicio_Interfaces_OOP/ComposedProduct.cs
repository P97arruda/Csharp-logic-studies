using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Interfaces_OOP
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        
        
        public  override double ValueToPay()
        {
            double total = 0;
            foreach (Product produt in Products)
            {
                total = total + produt.ValueToPay();
            }
            return total - (total * Discount);
        }

        public override string ToString() 
        {
            return $"Produto Composto: {base.ToString()}  Desconto: {Discount:P0}  Total: {ValueToPay():C2}";
        }
    }
}
