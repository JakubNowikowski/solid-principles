using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violating Liskov principle

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car());
            vehicles.Add(new Motorcycle());
            vehicles.Add(new Plane());

            foreach (var vehicle in vehicles)
                vehicle.Drive(); // trows error on Plane object


            // Implementig Liskov principle


            List<Beverage> beverages = new List<Beverage>();

            beverages.Add(new Coffee());
            beverages.Add(new Juice());
            beverages.Add(new Milk());

            foreach (var beverage in beverages)
                beverage.Pour();


            Console.ReadKey();
        }
    }
}
