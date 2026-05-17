using Microsoft.VisualBasic;
using System.Reflection.Emit;

namespace Exercicio_Interfaces_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRODUTOS");
            Console.WriteLine("-------------------------------------------------");

            Product product1 = new FixedPriceProduct()
            {
                Description = "Vinho Gatão",
                Id = 1010,
                Price = 2000M,
                Tax = 0.19F
            };

            Product product2 = new FixedPriceProduct()
            {
                Description = "Pão Bimbo Artesanal",
                Id = 2020,
                Price = 1560M,
                Tax = 0.19F
            };

            Product product3 = new VariablePriceProduct()
            {
                Description = "Queijo Holandês",
                Id = 3030,
                Measurement = "Kilo",
                Price = 32000M,
                Quantity = 0.536F,
                Tax = 0.19F
            };

            Product product4 = new VariablePriceProduct()
            {
                Description = "Cebolas",
                Id = 4040,
                Measurement = "Kilo",
                Price = 18000M,
                Quantity = 0.389F,
                Tax = 0.19F
            };

            Product product5 = new ComposedProduct()
            {
                Description = "Cabaz #1",
                Discount = 0.12F,
                Id = 5050,
                Products = new List<Product>() { product1, product2, product3, product4 }
            };

            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product3);
            Console.WriteLine(product4);
            Console.WriteLine(product5);
            Invoice invoice = new Invoice();
            invoice.AddProduct(product1);
            invoice.AddProduct(product3);
            invoice.AddProduct(product5);
            Console.WriteLine(invoice);
        }
    }
}
