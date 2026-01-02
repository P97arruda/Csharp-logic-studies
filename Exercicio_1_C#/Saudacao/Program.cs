namespace Saudacao
{
    internal class Program
    {
        /* 1. Create an application that asks for the user's first and last name and responds with "Hello, what's your first and last name end 
         * How are you?" */

        static void Main(string[] args)
        {
            string name, lastName;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your Last Name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"Hello, {name} {lastName} How are you?");


        }
    }
}
