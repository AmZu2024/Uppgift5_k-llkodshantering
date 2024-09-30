// See https://aka.ms/new-console-template for more information
namespace Enkelkalkylator
{
    class Calc
    {
        //Metod för addition 
        public double Addition(double num1, double num2)
        {

            return num1 + num2;

        }

        //Metod för subtraction  
        public double Subtraction(double num1, double num2)
        {

            return num1 - num2;

        }

        //Metod för multiplication  
        public double Multiplication(double num1, double num2)
        {

            return num1* num2;

        }

        //Metod för Division  
        public double Division(double num1, double num2)
        {

            return num1/ num2;

        }


    }



    class Program
    {
       //Kollar så att det funkar
        static void Main(string[] args)
        {
            // Gör instans av min klass
            Calc calc = new Calc();
            Console.WriteLine("Enkel Kalkylator");
            Console.WriteLine("Ange aoperation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Ange det första talet: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange det andra talet: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result=0;

            switch (operation)
            {
                case '+':
                    //Kallar på min additions metod från min Calc class 
                  result = calc.Addition(num1, num2);

                    break;

                case '-':
                    //Kallar på min Subtraction metod från min Calc class 
                    result = calc.Subtraction(num1, num2);
                    break;

                case '*':
                    //Kallar på min multiplication metod från min Calc class 
                    result = calc.Multiplication(num1,num2);
                    break;

                case '/':
                    //Kallar på min division metod från min Calc class 
                    result = calc.Division(num1,num2);
                    break;

                default:
                    Console.WriteLine("Ogiltig operation.");
                    break;
            }
            Console.WriteLine($"Resultat:{result}");

          

        }
    }
}