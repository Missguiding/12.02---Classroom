using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._04___Animal
{
    public class Animal // parent class
    {
        public Animal() // constructor
        {
            
        }

        public virtual void Eat() // method
        {
            Console.WriteLine("Animal is eating");
        }
    }
}