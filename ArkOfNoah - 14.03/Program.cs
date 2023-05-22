using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkOfNoah___14._03
{
    public class AllThePandas : Panda

    {
        public AllThePandas(string _strPandaName) : base(_strPandaName) // constructor inherits from parent
        {
            _Pandas = new List<string>();
        }
        public List<string> _Pandas = new List<string>(); // lijst pandas
       

        public Panda this[int index]
        {
            get
            {
                return _;
            }
        }

        public void Add(string _strPandaName)
        {

            _Pandas.Add(_strPandaName);
        }



    }

    public class Panda
    {
        public string Name; // Field of the instance of a Panda: the name of the panda
        public bool IsSelected = false; // Field of the instance of a Panda: has the panda access to the ark?
        public static int population; // field of the type Panda

        public Panda(string strPandaName) // Constructor
        {
            Name = strPandaName;
            population += 1;

            if (population < 3)
            {
                IsSelected = true;
            }
        }
    }

    class TryoutPanda
    {

        static void Main()
        {
            AllThePandas allThePandasOfTheWorld = new AllThePandas();

            Panda aFirstPanda = new Panda("Pan Dah");
            Panda aSecondPanda = new Panda("Pan Deh");
            Panda aThirdPanda = new Panda("Pan Daa");

            //allThePandasOfTheWorld.Add(aFirstPanda);
            //allThePandasOfTheWorld.Add(aSecondPanda);
            //allThePandasOfTheWorld.Add(aThirdPanda);

            //Console.WriteLine("We created {0} pandas with te names:", allThePandasOfTheWorld.Count);

            //for (int Counter = 0; Counter < allThePandasOfTheWorld.Count; Counter++)
            //{
            //    Console.WriteLine("Is Panda {0} selected? {}", allThePandasOfTheWorld[Counter].Name, allThePandasOfTheWorld[Counter].IsSelected);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Population of pandas at the moment: {0}", Panda.population);

            //Console.WriteLine("Population of pandas at the moment: {0}", Panda.population);


            Console.ReadLine();
        }

    }

}

