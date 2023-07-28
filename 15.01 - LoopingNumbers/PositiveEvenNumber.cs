using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._01___LoopingNumbers
{
    public class PositiveEvenNumber
    {
        private ushort _ushtPosEvenNumber = 4; // field 
        private readonly List<ushort> lstPositiveEvenNumbers; // field

        public PositiveEvenNumber(ushort ushtNumber) // constructor with parameter
        {
            lstPositiveEvenNumbers = new List<ushort>(); // create a 
            
            for (int counter = 0; counter < ushtNumber/2; counter++)
            {
                AddPositiveNumber();
            }
        }

        private void AddPositiveNumber()
        {
            lstPositiveEvenNumbers.Add(_ushtPosEvenNumber);
            _ushtPosEvenNumber += 2;
        }

        public override string ToString()
        {
            Console.WriteLine("List with positive even numbers:");
            foreach (ushort number in lstPositiveEvenNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            return lstPositiveEvenNumbers.ToString();
        }
    }
}
