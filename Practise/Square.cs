namespace Practise
{
    public class Square : IDemo
    {
        public int Length { get ; set ; }
        public int NumberOfSides { get ; set; }

        public Square(int len)
        {
            Length = len;
            NumberOfSides = 4;
        }

        public int CalculateArea()
        {
            return Length * Length;
        }

        public int CalculatePerimeter()
        {
            return Length * NumberOfSides;
        }

        
    }
}