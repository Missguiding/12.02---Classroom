using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Persons
{

    namespace Persons
    {
        class TestPerson
        {
            static void Main(string[] args)
            {
                Person mark = new Person("Mark Desodt", new DateTime(1993, 03, 25), "Dorpsstraat", "20", "8630", "Veurne");
                Console.WriteLine(mark.ShowInformation());

                mark.Name = "Marc Alleman";
                mark.Street = "Stadenstraat";
                mark.HouseNumber = "33";
                mark.BirthDate = new DateTime(1953, 01, 02);
                mark.City = "Staden";
                mark.ZipCode = "8840";

                Console.WriteLine(mark.ShowInformation());

                Employee fien = new Employee("Fien Dequidt", new DateTime(1986, 05, 2), "Stationsweg", "205B", "8647", "Lo", "ACV", 3269.20D);
                Console.WriteLine(fien.Address);
                Console.WriteLine(fien.ShowInformation());

                fien.Company = "CM";
                fien.Wage = 3693.50D;
                Console.WriteLine(fien.ShowInformation());

                Student peter = new Student("Peter Devos", new DateTime(1970, 02, 21), "Speltstraat", "13", "8600", "Diksmuide", "KU Leuven");
                Console.WriteLine(peter.ShowInformation());

                peter.School = "U Gent";
                peter.ZipCode = "BE 8650";
                peter.Street = "Melkweg";
                peter.City = "Houthulst";
                Console.WriteLine(peter.ShowInformation());

                Console.ReadLine();
            }
        }
    }
}





