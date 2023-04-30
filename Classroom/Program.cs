using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Test based on input constructor:");
            Person tina = new Person("Tina", "De Vrieuw", new DateTime(1990, 06, 29));
            Person gilbert = new Person("Gilbert", "Vanghenechten", new DateTime(1959, 02, 28));

            Console.WriteLine(tina.FullName + " " + tina.BirthDate);
            Console.WriteLine(gilbert.FullName + " " + gilbert.BirthDate + "\n");

            Console.WriteLine("Test Age in years:");
            Console.WriteLine(gilbert.AgeInYears);
            Console.WriteLine(tina.AgeInYears + "\n");

            Console.WriteLine("Test Age in days:");
            Console.WriteLine(Convert.ToInt32(tina.AgeInDays));
            Console.WriteLine(Convert.ToInt32(gilbert.AgeInDays));

            tina.BirthDate = new DateTime(2023, 04, 12);
            gilbert.BirthDate = new DateTime(1939, 06, 28);

            Console.WriteLine("\n" + "Test age in years, new input day, month, year:");
            Console.WriteLine(gilbert.AgeInYears);
            Console.WriteLine(tina.AgeInYears + "\n");

            Console.WriteLine("Test Age in days:");
            Console.WriteLine(Convert.ToInt32(tina.AgeInDays));
            Console.WriteLine(Convert.ToInt32(gilbert.AgeInDays));
                        
            Console.ReadLine();
        }
    }
}
