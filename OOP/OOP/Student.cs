using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student
    {
        string firstName, lastName, course;
        int year;
        char section;
        float midtermGrade, finalGrade;

        public Student(string firstName, string lastName, string course, int year, char section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.course = course;
            this.year = year;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;

            
        }
        public void introduction()
        {
            Console.WriteLine("Hi, my full name is: " + firstName + " " + lastName);
            Console.WriteLine("I am from class "+year+"-"+section);
            Console.WriteLine();
        }

        public void grades()
        {
            Console.WriteLine("My midterm grade is: " + midtermGrade);
            Console.WriteLine("My final grade is: "+finalGrade);
            Console.WriteLine();

            float ave = (midtermGrade+finalGrade)/2;
            Console.WriteLine("My average grade is?: "+ave);

            if(ave > 100)
            {
                Console.WriteLine("Invalid Grade!");
            }
            else if(ave >=98)
            {
                Console.WriteLine("With Highest Honors!");
            }
            else if (ave >= 95)
            {
                Console.WriteLine("With High Honors!");
            }
            else if (ave >= 90)
            {
                Console.WriteLine("With Honors!");
            }
            else if (ave >= 75)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("You Failed!");
            }
        }

      
    }
}
