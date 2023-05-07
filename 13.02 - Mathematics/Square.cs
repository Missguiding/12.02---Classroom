namespace _13._02___Mathematics
{
    class Square : Rectangle 
    {
        public Square(int _intWidth, string _strColor) : base(_intWidth, _intWidth, _strColor) // constructor , inherints from rectangle
        {
            Height = Width;            
        }

        
    }
}
