using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class AreaCalculatorWithoutOCP
    {
        public double CalculateTotalArea(object[] shapes)
        {
            Rectangle objRectangle = null;
            Circle objCircle = null;
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    objRectangle = (Rectangle)shape;
                    area += objRectangle.Height * objRectangle.Width;
                }
                else
                {
                    objCircle = (Circle)shape;
                    area += objCircle.Radius * objCircle.Radius * Math.PI;
                }
            }

            return area;
        }
    }
}
