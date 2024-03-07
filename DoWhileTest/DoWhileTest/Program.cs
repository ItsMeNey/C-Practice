using System;
using System.Runtime.InteropServices.Marshalling;

namespace DoWhile
{
    class DoWhileTest
    {
        static void Main(string[] args)
        {
            int age = 22, life = 5;
            


            while (life>0)
            {
                Console.WriteLine("What is my age?");
                Console.WriteLine();
                Console.WriteLine("Answer: ");
                int ans = Convert.ToInt32(Console.ReadLine());

                if (ans == 22)
                {
                    Console.WriteLine("You are correct!");
                    break;
                }
                else if (ans !=22);
                {
                    life--;
                    Console.WriteLine("Your current life is: " + life);
                }

                if (life==0) Console.WriteLine("You lose!");
                    
                   
                
            }

      


        }
    }
}