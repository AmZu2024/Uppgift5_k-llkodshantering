// See https://aka.ms/new-console-template for more information
namespace Enkelkalkylator
{
    class Program
    {
       //Kollar så att det funkar
        static void Main(string[] args)
        {

            Console.WriteLine("Enkel Kalkylator");
            Console.WriteLine("Ange aoperation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine("Ange det första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange det andra talet: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result=0;
            switch (operation)
            {
                case '+':
                    result = num1 + num2;

                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2;
                    break;

                default:
                    Console.WriteLine("Ogiltig operation.");
                    break;
            }
            Console.WriteLine($"Resultat:{result}");

          

        }
    }
}