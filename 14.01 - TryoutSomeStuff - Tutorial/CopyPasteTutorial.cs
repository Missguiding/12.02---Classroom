using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._01___TryoutSomeStuff___Tutorial
{
    public class CopyPasteTutorial : Tutorial // CPT inherits from abstract class
    {

        public int KeyTutorial { get; set; } // property
        public string DescriptionTutorial { get; set; } // property

        public override void SetTutorial(int _intIDTutorial, string _strDescriptionTutorial) // method, 2 parameters with signature abstract class
        {
            // Do not use "_" for normal variables
            KeyTutorial = _intIDTutorial; 
            DescriptionTutorial = _strDescriptionTutorial;
        }

        public override string GetTutorial() // inherited method from parent abstract class, no parameters
        {
            return KeyTutorial + DescriptionTutorial; // return the info you recieved from SetTutorial
        }

    }
}
