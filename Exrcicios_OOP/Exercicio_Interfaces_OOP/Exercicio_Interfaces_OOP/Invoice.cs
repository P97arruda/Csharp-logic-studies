namespace Exercicio_Interfaces_OOP
{
    public class Invoice : IPay
    {
        private readonly string _products;


        public Invoice()
        {

        }



        public double ValueToPay()
        {
            throw new NotImplementedException();
        }
    }
}
