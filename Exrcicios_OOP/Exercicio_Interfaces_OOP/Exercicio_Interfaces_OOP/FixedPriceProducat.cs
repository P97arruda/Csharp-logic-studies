namespace Exercicio_Interfaces_OOP
{
    internal class FixedPriceProducat : Product
    {


       
        public override string ToString()
        {
            return base.ToString();
        }

        public override double ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
