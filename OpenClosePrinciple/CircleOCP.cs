using System;

namespace OpenClosePrinciple
{
    class CircleOCP : Shape
    {
        public int Radius { get; set; }

        public double CalculateArea()
        {
            return Radius * Radius * Math.PI;
        }
    }


}
