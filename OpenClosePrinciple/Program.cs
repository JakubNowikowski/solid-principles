using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {

            // Calculate area without OCP
            AreaCalculatorWithoutOCP areaCalculator = new AreaCalculatorWithoutOCP();

            double result = areaCalculator.CalculateTotalArea(new object[]
            {
                new Rectangle { Height = 2, Width = 2 },
                new Rectangle { Height = 2, Width = 2 },
                new Circle{ Radius = 2 }
            });
            Console.WriteLine("Calculate without OCP " + result);

            //Calculate with OCP approach

            AreaCalculatorImplementingOCP areaCalculatorOCP = new AreaCalculatorImplementingOCP();

            double resultOCP = areaCalculatorOCP.CalculateTotalArea(new Shape[]
                {
                    new RectangleOCP {Height=2, Width=2 },
                    new RectangleOCP {Height=2, Width=2 },
                    new CircleOCP {Radius=2}
                });

            Console.WriteLine("Calculate with OCP approach " + resultOCP);

            Console.ReadKey();
        }
    }
}
