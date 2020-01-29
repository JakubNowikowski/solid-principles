using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    abstract class Beverage
    {
        public abstract void Pour();
    }

    class Coffee : Beverage
    {
        public override void Pour()
        {
            Console.WriteLine("Pouring a cup of coffee");
        }
    }

    class Juice : Beverage
    {
        public override void Pour()
        {
            Console.WriteLine("Pouring one glass of juice");
        }
    }

    class Milk : Beverage
    {
        public override void Pour()
        {
            Console.WriteLine("Pouring one glass of milk");
        }
    }
}
