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

      for (int counter = 0; counter < ushtNumber / 2; counter++)
      {
        AddPositiveNumber();
      }
    }

    private void AddPositiveNumber()
    {
      lstPositiveEvenNumbers.Add(_ushtPosEvenNumber);
      _ushtPosEvenNumber += 2;
    }

    //public override string ToString()
    //{
    //  Console.WriteLine("List with positive even numbers:");
    //  foreach (ushort number in lstPositiveEvenNumbers)
    //  {
    //    Console.WriteLine(number.ToString());
    //  }
    //  return lstPositiveEvenNumbers.ToString();
    //}

    // VVDW - Alternative
    public override string ToString()
    {
      string strResult;
      
      // Set title and a new line
      strResult = "List with positive even numbers:\n";

      // Loop thru numbers, add the number to the result with a new line
      foreach (ushort number in lstPositiveEvenNumbers)
      {
        strResult += number.ToString();
        strResult += "\n";
      }

      // Return the stuff
      return strResult;
    }

  }
}
