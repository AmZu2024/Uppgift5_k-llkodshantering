// See https://aka.ms/new-console-template for more information


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
        return num1 * num2;
    }

    //Metod för Division  
    public double Division(double num1, double num2)
    {
        //Ifall nämnaren är 0 dvs division med 0 så kommer programmet be om en ny nämnare som inte är 0
        while (num2 == 0)
        {
            Console.WriteLine("Går ej att dividera med 0\nAnge en ny nämnare");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
        return num1 / num2;
    }

    //Metod för att läsa input
    public double input()
    {
        double result;
        string input;
        Console.WriteLine("Ange nummer");
        input = Console.ReadLine();

        //Gjort en tryparse som ser till att loopa så länge man inte matar in en double (siffra)
        while (!double.TryParse(input, out result))
        {
            Console.WriteLine("Ogiltligt inmatning försök igen");
            input = Console.ReadLine();
        }
        return result;
    }

    //Metod för att kunna köra kalkylatorn tills man själv väljer att stänga av den
    public bool Run(bool Runcalc)
    {
        Console.WriteLine("Vill du fortsätta räkna skriv ja/nej");
        string input = Console.ReadLine().ToLower();
        if (input == "nej")
        {
            Runcalc = false;
        }
        else if (input == "ja")
        {
            Runcalc = true;
        }
        return Runcalc;
    }

    //Metod Läsa operator
    public char read_op()
    {
        char operation;
        Console.WriteLine("Enkel Kalkylator");
        Console.WriteLine("Ange operator (+, -, *, /):");
        operation = Console.ReadKey().KeyChar;
        Console.WriteLine();
        while((operation !='+') && (operation != '-') && (operation != '*') && ( operation != '/'))
        {
            Console.WriteLine($"Fel inmatning! {operation} är ingen operator. Ange någon av dessa: (+, -, *, /):");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }
        return operation;
    }

}



class Program
{
    //Kollar så att det funkar
    static void Main(string[] args)
    {
        // Gör instans av min klass
        Calc calc = new Calc();
        char operation;
        double num1;
        double num2;
        double result = 0;
        bool Runcalc = true;
        //Kallar på metoden som läser operatorn 
        operation = calc.read_op();
        //Kallar på metoden som läser inputs och lagrar det på num1 och num2 
        num1 = calc.input();
        num2 = calc.input();


        while (Runcalc)
        {
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
                    result = calc.Multiplication(num1, num2);
                    break;

                case '/':
                    //Kallar på min division metod från min Calc class 
                    result = calc.Division(num1, num2);
                    break;

                default:
                    Console.WriteLine("Ogiltig operation.");
                    break;
            }
            Console.WriteLine($"Resultat: {result}\n");
            Runcalc = calc.Run(Runcalc);
        }



    }
}
