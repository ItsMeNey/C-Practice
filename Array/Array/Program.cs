using System;

namespace ArrayLesson
{
    class Array
    {
        static void Main(string[] args)
        {
            String[] email = { "john@gmail.com", "jay@gmail.com", "roy@gmail.com" };
            String[] username = { "John", "Jay", "Roy" };
            String[] password = { "john123", "jay123", "roy123" };

            Console.Write("index    : ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("email    : " + email[index]);
            Console.WriteLine("username : " + username[index]);
            Console.WriteLine("password : " + password[index]);

        }
    }
   
}