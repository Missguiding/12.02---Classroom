using System;

namespace ArkOfNoah___14._03
{
    class TryoutPanda
    {
        static void Main()
        {
            AllThePandas allThePandasOfTheWorld = new AllThePandas();

            Panda aFirstPanda = new Panda("Pan Dah");
            Panda aSecondPanda = new Panda("Pan Deh");
            Panda aThirdPanda = new Panda("Pan Daa");

            allThePandasOfTheWorld.Add(aFirstPanda);
            allThePandasOfTheWorld.Add(aSecondPanda);
            allThePandasOfTheWorld.Add(aThirdPanda);

            Console.WriteLine("We created {0} pandas with the names:", allThePandasOfTheWorld.Count);

            for (int Counter = 0; Counter < allThePandasOfTheWorld.Count; Counter++)
            {
                Console.WriteLine("Is Panda {0} selected? {1}", allThePandasOfTheWorld[Counter].Name, allThePandasOfTheWorld[Counter].IsSelected);
            }
            Console.WriteLine();
            Console.WriteLine("Population of pandas at the moment: {0}", Panda.population);
            Console.WriteLine("Population of pandas at the moment: {0}", Panda.population);

            Console.ReadLine();
        }

    }

}

