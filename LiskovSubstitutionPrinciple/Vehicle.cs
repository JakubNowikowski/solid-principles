using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    abstract class Vehicle
    {
        public abstract void Drive();
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving");
        }
    }

    class Motorcycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Motorcycle is driving");
        }
    }

    class Plane : Vehicle
    {
        public override void Drive()
        {
            throw new NotImplementedException("Plane don't have wheels");
        }
    }
}
