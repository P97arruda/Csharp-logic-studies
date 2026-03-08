namespace Exemplo_1;




public class Program
{
    static void Main(string[] args)
    {
        int x = 20;

        
        //Instaciar o objecto
        Carro carrinho = new Carro();
        Console.WriteLine(carrinho.Estado);


        Carro popo = new Carro();

        //Ler o valor que está no atributo
        Console.WriteLine(popo.Estado);

        //Escrever o valor dentro do atributo
        //Neste caso vai da erro por que a propriedade é só de leitura 
       // popo.Estado = "Olá, consigue entrar no carro";

        Console.WriteLine(popo.Estado);

        Carro boguinhas = new Carro("Ferri", "California", "Amarelo");

        Console.WriteLine(boguinhas.Estado);

        string marca, modelo, cor;

        Console.Write("Escola a marca: ");
        marca = Console.ReadLine();

        Console.Write("Escola o modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Escola a cor: ");
        cor = Console.ReadLine();

        Carro MeuCarro = new Carro(marca, modelo, cor);
        Console.WriteLine(MeuCarro.Estado);

        //Estado linha vai dar erro por que o atributo _modelo é privado
        //MeuCarro._modelo = "Ferrari";
        

    }
}







