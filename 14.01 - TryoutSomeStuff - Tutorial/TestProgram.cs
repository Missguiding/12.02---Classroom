using System;

namespace _14._01___TryoutSomeStuff___Tutorial
{
    public class TestProgram
    {
        static void Main()
        {
            CopyPasteTutorial cpTutorialCsharp = new CopyPasteTutorial();
            CopyPasteTutorial cpTutorialDatabase = new CopyPasteTutorial();

            cpTutorialCsharp.SetTutorial(1, "C# .Net");
            cpTutorialDatabase.SetTutorial(2, "SQL Server");

            Console.WriteLine(cpTutorialCsharp.GetTutorial());
            Console.WriteLine(cpTutorialDatabase.GetTutorial());

            Console.ReadLine();
        }
    }
}
