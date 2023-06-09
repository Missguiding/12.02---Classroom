using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._01___LoopingNumbers
{
    public class PositiveEvenNumber
    {
        private ushort _ushtPosEvenNumber = 4;
        private readonly List<ushort> lstPositiveEvenNumbers;

        public PositiveEvenNumber(ushort ushtNumber)
        {
            lstPositiveEvenNumbers = new List<ushort>();

            for (int counter = 0; counter < ushtNumber; counter++)
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
            foreach (ushort number in lstPositiveEvenNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            return lstPositiveEvenNumbers.ToString();
        }
    }
}
