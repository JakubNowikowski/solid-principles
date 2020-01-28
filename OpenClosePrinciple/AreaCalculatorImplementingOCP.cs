using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class AreaCalculatorImplementingOCP
    {
        public double CalculateTotalArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.CalculateArea();
            }

            return area;
        }
    }
}
