namespace Exercicio_Interfaces_OOP
{
    public class FixedPriceProduct : Product
    {


        public FixedPriceProduct(string description, string id, double price, double tax) 
          : base(description, id, price, tax)
        {

        }

        public override string ToString()
        {
            return $"Produto Fixo -> {base.ToString()} | Total: {ValueToPay():C2}";
        }

        public override double ValueToPay()
        {
            return Price + (Price * Tax);
        }
    }
}
