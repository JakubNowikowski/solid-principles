namespace OpenClosePrinciple
{
    class RectangleOCP : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double CalculateArea()
        {
            return Height * Width;
        }
    }


}
