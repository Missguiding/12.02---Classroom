using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraExerciseList
{

    public class Person
    {

        public string FirstName { get; set; } // propery
        public string LastName { get; set; } // propery

        public Person(string strFirstName, string strLastName) // constructor
        {
            FirstName = strFirstName;
            LastName = strLastName;
        }
    }
}

