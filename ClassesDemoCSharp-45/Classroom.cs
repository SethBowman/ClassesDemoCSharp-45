using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemoCSharp_45
{
    public class Classroom
    {
        //Properties can be of type List or Array
        public List<Person> OurClass { get; set; } = new List<Person>();

        //Method in a class (non static)
        public void GreetEveryone()
        {
            foreach(var person in OurClass)
            {
                //Calling a method from the Person class using each person
                person.Greet();
            }
        }

    }
}
