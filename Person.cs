using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_quiz_1
{
    public class Person
    {
        private int age;
        public string name { get; set; }

        public Person(int Age, string Name)
        {
            age = Age;
            name = Name;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

    }
}
