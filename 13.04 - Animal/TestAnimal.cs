using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._04___Animal
{
    class TestAnimal
    {
        static void Main()
        {
            Animal aBeast = new Animal();
            aBeast.Eat();

            Mammal mammalOne = new Mammal();
            mammalOne.Eat();

            Cat catOne = new Cat();
            catOne.Eat();

            Mouse piepOne = new Mouse();
            piepOne.Eat();

            Console.ReadLine();
        }
    }
}
