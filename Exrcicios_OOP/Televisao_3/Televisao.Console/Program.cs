namespace Televisao.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // instanciar o objecto meo do tipo Box(Classe)
                Box meo = new Box();

                if (meo == null)
                {
                    System.Console.WriteLine("A box ainda não foi criada!!");
                }
                else
                {
                    System.Console.WriteLine("A box já foi criada!!");
                    int op;
                    do
                    {
                        do
                        {
                            //System.Console.Clear();
                            System.Console.WriteLine("********** COMANDO DA BOX *********");
                            System.Console.WriteLine("1-Ligar a Box");
                            System.Console.WriteLine("2-Desligar a Box");
                            System.Console.WriteLine("0-Sair");
                            System.Console.WriteLine("Escola op:");

                        } while (!int.TryParse(System.Console.ReadLine(), out op));

                    } while (op < 0 || op > 2);


                    switch (op)
                    {
                        case 1:
                            if (meo.Estado == false)
                            {
                                meo.Ligar();
                                //ir buscar a mensagem da box 
                                System.Console.WriteLine(meo.Mensagem);
                            }
                            else
                            {
                                System.Console.WriteLine("box ja esta ligada");
                            }

                            //Como a Mensagem é so de leitura só de leitura bão posso fazer o código embaixo.
                            //meo.Mensagem = "Olá";

                            break;

                        case 2:
                            meo.Desligar();
                            System.Console.WriteLine(meo.Mensagem);
                            break;
                    }

                }
            }
        }
}   }