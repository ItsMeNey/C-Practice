using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Person
    {
        public string firstName;
        public string lastName;
        public int age;
        public char sex;

        public Person(string firstName, string lastName,  int age, char sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.sex = sex;

            Console.WriteLine("The person is " + firstName + " " + lastName);
            Console.WriteLine("His age is " + age + " and his sex is " + sex);
            
        }
    }
}
