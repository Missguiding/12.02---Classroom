using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02___Mathematics
{
    class TestMathematics
    {
        static void Main()
        {
            Polygon poly1 = new Polygon("red");
            Rectangle rect1 = new Rectangle(20, 40, "black");
            Square square1 = new Square(40, "green");
            RightTriangle rt1 = new RightTriangle(20, 30, "blue");
            Console.WriteLine("Polygon: " + poly1.Color + "\n");
            Console.WriteLine("Rectangle: " + rect1.Color + "\n" + rect1.Height + "\n" + rect1.Width + "\n" + rect1.AreaRectangle() + "\n" + rect1.CircumferenceRectangle() + "\n");
            Console.WriteLine("Square: " + square1.Color + "\n" + square1.Height + "\n" + square1.Width + "\n" + square1.AreaRectangle() +"\n" + square1.CircumferenceRectangle() + "\n");
            Console.WriteLine("RightTriangle: " + rt1.Color + "\n" + rt1.Base + "\n" + rt1.Height + "\n" + rt1.AreaRightTriangle() + "\n" + rt1.CircumfenceRightTriangle() + "\n");           

            poly1.Color = "yellow";                        
            Console.WriteLine("Polygon: " + poly1.Color);

            rect1.Height = 100;
            rect1.Width = 5;
            Console.WriteLine("Rectangle: " + rect1.Color + "\n" + rect1.Height + "\n" + rect1.Width + "\n" + rect1.AreaRectangle() + "\n" + rect1.CircumferenceRectangle() + "\n");

            square1.Height = 40;
            square1.Width = 80;
            Console.WriteLine("\n" + square1.Color);
            Console.WriteLine("Square: " + square1.Color + "\n" + square1.Height + "\n" + square1.Width + "\n" + square1.AreaRectangle() + "\n" + square1.CircumferenceRectangle() + "\n");

            rt1.Height = 4;
            rt1.Base = 3;
            Console.WriteLine("\n" + rt1.Color);
            Console.WriteLine("RightTriangle: " + rt1.Color + "\n" + rt1.Base + "\n" + rt1.Height + "\n" + rt1.AreaRightTriangle() + "\n" + rt1.CircumfenceRightTriangle() + "\n");
           
            Console.ReadLine();
      
      // VVDW - very good
      // VVDW - I've changed the values of your RightTriangle to check the correctness.

        }
    }
}
