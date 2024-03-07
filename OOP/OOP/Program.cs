using OOP;
using System;

    namespace LearningC
{
    class OOP
    {
        static void Main(string[] args)
        {
            
            //Person
            Console.Write("");
            Person p1 = new Person("Jestoni", "Estardo", 22, 'M');
            Console.WriteLine();

            

            //Favorites
            Console.Write("Favorite anime: ");
            string anime = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Favorite hobby: ");
            string hobby = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Number of anime watched: ");
            int watched = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Number of anime watched: ");
            int read = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Favorites fave = new Favorites(anime, hobby, watched, read);


            //Products
            Products pr1 = new Products("Nike Shoes", "Running Shoes", 123, 99.99f, 100);

            

            //Student
            Student a = new Student("Jestoni", "Estardo", "BSIT", 4, 'A', 89.99f, 95.05f);
            
            
            Console.Write("What is your first name? ");
            string fname = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lname = Console.ReadLine();

            Console.Write("What is your course? ");
            string course = Console.ReadLine();

            Console.Write("What is your year? ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your section? ");
            char section =Convert.ToChar(Console.ReadLine());

            Console.Write("What is your midterm grade? ");
            float midterm = Convert.ToSingle(Console.ReadLine());

            Console.Write("What is your final grade? ");
            float final = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine();

            Student student = new Student(fname, lname, course,year, section, midterm, final);
            student.introduction();
            student.grades();

            Console.ReadKey();

        }
    }
}