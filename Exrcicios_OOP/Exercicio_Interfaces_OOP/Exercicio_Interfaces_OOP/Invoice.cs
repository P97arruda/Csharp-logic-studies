namespace Exercicio_Interfaces_OOP
{
    public class Invoice : IPay
    {
         private List<IPay> _products;
            

        public Invoice()
        {
            _products = new List<IPay>();
        }

        public void AddProduct(IPay product)
        {
            _products.Add(product);
        }


        public double ValueToPay()
        {
            double total = 0;
            foreach (IPay produt in _products)
            {
                total = total + produt.ValueToPay();
            }
            return total;
        }

        public override string ToString()
        {
            return $"Fatura Total: {ValueToPay()}";
        }
    }
}
