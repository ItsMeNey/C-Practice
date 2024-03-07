using System;

namespace LoginAuth
{
    class LoginAuth
    {
        static void Main(string[] args)
        {
            string[] username = { "jestoni", "matthew", "josh" };
            string[] password = { "jestoni123", "matthew123", "josh123" };

            Console.WriteLine("LOGIN");
            Console.WriteLine();

            Console.Write("Enter your username: ");
            string user = Console.ReadLine();

            Console.Write("Enter your password: ");
            string pass = Console.ReadLine();

            bool isFound = false;

            for (int i = 0; i < username.Length;  i++)
            {
                if (user.Equals(username[i]) && pass.Equals(password[i]))
                {
                    isFound = true;
                    Console.WriteLine("Welcome " + username[i]);
                    break;
                }
            }
            if (!isFound) Console.WriteLine("\nAccount not found! 404");
            

            Console.ReadKey();
        }
    }
}