using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13._04___Animal
{
    public class Mouse : Mammal // class mouse inherits from mammal
    {
        public Mouse()
        {

        }

        public override void Eat() // change method of parent class
        {
           
            Console.WriteLine("Mouse is eating cheese");
        }
    }
}