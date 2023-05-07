using System;

namespace _13._02___Mathematics
{
    class RightTriangle : Polygon
    {
        public RightTriangle(int _intBase, int _intHeight, string _strColor) : base(_strColor) // constructor, inherints from polygon
        {
            Base = _intBase;
            Height = _intHeight;
        }

        public int Base { get; set; } // automatic property

        public int Height { get; set; } // automatic property

        public int AreaRightTriangle() // method to calculate area
        {
            int _intResultAreaRT = Base * Height / 2;
            return _intResultAreaRT;
        }

        public double CircumfenceRightTriangle() // method to calculate circumfence
        {
            double _dblResultCircumferceRT = Base + Height + Math.Sqrt (Base * Base + Height * Height);
            
            return _dblResultCircumferceRT;
        }

    }
}
