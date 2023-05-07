using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class TestClassroom
    {
        static void Main()
        {
            Person tina = new Person("Tina", "De Vrieuw", new DateTime(1990, 06, 29));
            Person gilbert = new Person("Gilbert", "Vanghenechten", new DateTime(1959, 02, 28));
            Person vincent = new Person("Vincent", "Van De Walle", new DateTime(1970, 05, 06));

            Console.WriteLine(tina.AgeInDays); // test based on input constructor
            Console.WriteLine(tina.AgeInYears);
            Console.WriteLine(gilbert.AgeInDays);
            Console.WriteLine(gilbert.AgeInYears);
            Console.WriteLine(vincent.AgeInDays);
            Console.WriteLine(vincent.AgeInYears);

            tina.BirthDate = new DateTime(2023, 05, 07); // use currend day please to test
            gilbert.BirthDate = new DateTime(2024, 06, 28); // date in the future
            vincent.BirthDate = new DateTime(1970, 05, 20); // VVDW - added

            Console.WriteLine(gilbert.AgeInYears);
            Console.WriteLine(gilbert.AgeInDays);
            Console.WriteLine(tina.AgeInYears);
            Console.WriteLine(tina.AgeInDays);
            Console.WriteLine(vincent.AgeInYears);
            Console.WriteLine(vincent.AgeInDays);

            Console.ReadLine();
        }
    }
}
