using System;

namespace ExtraExerciseList
{
  public class TestProgram
  {
    static void Main()
    {

      Person lindsay = new Person("Lindsay", "Legrande");
      Person gilles = new Person("Gilles", "Bonte");
      Person mieke = new Person("Mieke", "Vandewalle");
      Person lemmy = new Person("Lemmy", "de Terminator");

      Cursus csharp = new Cursus("C#");

      csharp.Add(mieke);
      csharp.Add(lindsay);
      csharp.Add(gilles);
      csharp.Add(lemmy);

      Console.WriteLine("Person {0} {1}", csharp[2].FirstName, csharp[2].LastName);
      Console.WriteLine("Person {0} {1}", csharp[3].FirstName, csharp[0].LastName);
      Console.WriteLine("Person {0}", csharp["Lindsay"].FirstName);
      Console.WriteLine("Person {0}", csharp["Lemmy"].LastName);
      Console.WriteLine("Person {0}", csharp["Prosper"].LastName); // VVDW Extra test
      Console.ReadLine();
    }
  }
}

