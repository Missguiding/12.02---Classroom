using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._04___Animal
{
    public class Cat : Mammal // inherets from mammal
    {
        public Cat()
        {
            
        }

        public override void Eat() // change parent method
        { 
            
            Console.WriteLine("Cat is eating");
        }
    }
}