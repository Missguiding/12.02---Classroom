using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._04___Animal
{
    public class Mammal : Animal // class mammal inhertis from animal
    {
        public Mammal()
        {
           
        }

        public override void Eat() // change method of base class (override)
        {
           
            Console.WriteLine("Mammal is eating");
        }
    }
}