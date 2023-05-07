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
      Person vincent = new Person("Vincent", "Van De Walle", new DateTime(1970, 05, 06));

      Console.WriteLine(tina.FullName + " " + tina.BirthDate);
      Console.WriteLine(gilbert.FullName + " " + gilbert.BirthDate + "\n");

      Console.WriteLine("Test Age in years:");
      Console.WriteLine(gilbert.AgeInYears);
      Console.WriteLine(tina.AgeInYears); // VVDW - changed
      Console.WriteLine(vincent.FullName + " (years): " + vincent.AgeInYears + "\n"); // VVDW - added

      Console.WriteLine("Test Age in days:");
      Console.WriteLine(Convert.ToInt32(tina.AgeInDays));
      Console.WriteLine(Convert.ToInt32(gilbert.AgeInDays));
      Console.WriteLine(vincent.FullName + " (days): " +  Convert.ToInt32(vincent.AgeInDays)); // VVDW - added

      tina.BirthDate = new DateTime(2023, 04, 12);
      gilbert.BirthDate = new DateTime(1939, 06, 28);
      vincent.BirthDate = new DateTime(1970, 05, 20); // VVDW - added

      Console.WriteLine("\n" + "Test age in years, new input day, month, year:");
      Console.WriteLine(gilbert.AgeInYears);
      Console.WriteLine(tina.AgeInYears); // VVDW - changed
      Console.WriteLine(vincent.FullName + " (years): " + vincent.AgeInYears + "\n"); // VVDW - added

      Console.WriteLine("Test Age in days:");
      Console.WriteLine(Convert.ToInt32(tina.AgeInDays));
      Console.WriteLine(Convert.ToInt32(gilbert.AgeInDays));
      Console.WriteLine(vincent.FullName + " (days): " + Convert.ToInt32(vincent.AgeInDays)); // VVDW - added

      Console.ReadLine();
    }
  }
}
