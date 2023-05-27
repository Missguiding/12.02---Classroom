using System.Collections.Generic;

namespace ArkOfNoah___14._03
{
    public class AllThePandas 
    {
        public List<Panda> pandas; // list pandas
        public AllThePandas()  // constructor 
        {
            pandas = new List<Panda>();
        }

        public Panda this[int index] // indexer list pandas
        {
            get
            {
                return pandas[index];
            }
            set
            {
                pandas[index] = value;
            }
        }

        public int Count // propery
        {
            get
            {
                return pandas.Count;
            }
        }

        public void Add(Panda strPandaName) // method to add name panda
        {
            pandas.Add(strPandaName);
        }
    }
}

