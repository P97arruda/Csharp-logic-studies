namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular compra de frutas - VERSÃO INICIANTE

            //Variáveis para as quantidades
            double kgMorangos;
            double kgMacas;

            //Variáveis para os preços
            double precoMorangos;
            double precoMacas;

            //Variáveis para os totais
            double totalKg;
            double valorBruto;
            double valorFinal;

            //Variável para saber se tem desconto
            bool temDesconto;

            //Pedir quantidade de morangos
            Console.Write("Quantos quilos de morango? ");
            kgMorangos = Convert.ToDouble(Console.ReadLine());

            //Pedir quantidade de maçãs
            Console.Write("Quantos quilos de maçã? ");
            kgMacas = Convert.ToDouble(Console.ReadLine());

            //CALCULAR PREÇO DOS MORANGOS
            //Se comprar até 5 kg
            if (kgMorangos <= 5)
            {
                precoMorangos = kgMorangos * 2.50;
            }
            //Se comprar mais de 5 kg
            else
            {
                precoMorangos = kgMorangos * 2.20;
            }

            //CALCULAR PREÇO DAS MAÇÃS
            //Se comprar até 5 kg
            if (kgMacas <= 5)
            {
                precoMacas = kgMacas * 1.80;
            }
            //Se comprar mais de 5 kg
            else
            {
                precoMacas = kgMacas * 1.50;
            }

            //SOMAR TUDO
            totalKg = kgMorangos + kgMacas;
            valorBruto = precoMorangos + precoMacas;

            //VERIFICAR SE TEM DESCONTO
            //Começar assumindo que NÃO tem desconto
            temDesconto = false;

            //Verificar se tem mais de 8 kg no total
            if (totalKg > 8)
            {
                temDesconto = true;
            }

            //Verificar se o valor passa de 25 euros
            if (valorBruto > 25)
            {
                temDesconto = true;
            }

            //CALCULAR VALOR FINAL
            //Se tem desconto
            if (temDesconto == true)
            {
                valorFinal = valorBruto * 0.90;
            }
            //Se não tem desconto
            else
            {
                valorFinal = valorBruto;
            }

            //MOSTRAR RESULTADO
            Console.WriteLine("Valor a pagar: " + Math.Round(valorFinal, 2) + " euros");
        }
    }
}