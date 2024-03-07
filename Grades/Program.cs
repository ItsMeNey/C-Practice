using System;

namespace GradeCompute
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will get your average grade!");
            Console.WriteLine("\t");

            Console.WriteLine("Enter your grade in English: ");
            double eng = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Math: ");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Filipino: ");
            double fil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Physical Education: ");
            double pe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Science: ");
            double sci = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Araling Panlipunan: ");
            double ap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Edukasyon sa Pagpapakatao: ");
            double esp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your grade in Music: ");
            double mus = Convert.ToDouble(Console.ReadLine());

            double sum = eng + math + fil + pe + sci + ap + esp + mus;
            double ave = sum / 8;

            Console.WriteLine("Your general average is: " + ave);

            if ( ave >=75)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You failed!"); 
            }
            Console.ReadKey();
        }
    }
}