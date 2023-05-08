namespace _13._02___Mathematics
{
    class Rectangle : Polygon
    {
        public Rectangle(int _intWidth, int _intHeight, string _strColor) : base(_strColor) // constructor, inherints from polygon. 
        {
            Width = _intWidth;
            Height = _intHeight;
        }

        public int Width { get; set; } // automatic property

        public int Height { get;  set; } // automatic property

        public int AreaRectangle() // method to calculate area
        {
            int _intResultArea = Width * Height;        
            return _intResultArea;
            // VVDW - from now on you can and may shortcut :-) you understand it
            // VVDW - return Width * Height
        }

        public int CircumferenceRectangle() // method to calculate circumference
        {
            int _intResultCircumfence = 2 * Width + 2 * Height;
            return _intResultCircumfence;
        }
    }
}
