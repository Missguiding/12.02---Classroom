using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkOfNoah___14._03
{
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
}

