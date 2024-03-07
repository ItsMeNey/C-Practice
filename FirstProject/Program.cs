using System;


namespace Tryyy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWelcome to my Calculator!");
            Console.WriteLine("Choose one: 1: Addition \t 2: Subtraction \t 3: Multiplication \t 4: Division");
            int chosen = Convert.ToInt32(Console.ReadLine());

            switch (chosen)
            {
                case 1:
                     {
                        Console.WriteLine("This is addition!");

                        Console.WriteLine("Enter the first number: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\b");
                        Console.WriteLine("The sum of the two is: "+ (a+b));
                    }
                    break;

                case 2:
                    Console.WriteLine("This is subtraction!");

                    Console.WriteLine("Enter the first number: ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double d = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\b");
                    Console.WriteLine("The diffrence of the two is: " + (c - d));
                    break;

                case 3:
                    Console.WriteLine("This is multiplication!");

                    Console.WriteLine("Enter the first number: ");
                    double e = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double f = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\b");
                    Console.WriteLine("The product of the two is: " + (e * f));
                    break;

                case 4:
                    Console.WriteLine("This is division!");

                    Console.WriteLine("Enter the first number: ");
                    double g = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    double h = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\b");
                    Console.WriteLine("The quotient of the two is: " + (g / h));
                    break;
                default:
                    {

                        Console.WriteLine("Error");
                    }
                    break;
            }

            Console.ReadKey();
            
        }
    }

}