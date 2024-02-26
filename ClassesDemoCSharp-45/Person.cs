using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoCSharp_45
{
    public class Person
    {
        //Fields - a variable inside of a class
        public int money;
        public string clothes;

        //Properties - things that define the class
        public string Name { get; set; } = "Bob";
        public int Age { get; set; } = 23;
        public string HairColor { get; set; }

        //Methods in a class (non static)
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}.");
        }

        //Constructors
        //Default Constructor
        public Person()
        {

        }

        //Custom Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
