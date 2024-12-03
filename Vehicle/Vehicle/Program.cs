using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle("Suzuki", "Swift", 1998);
            v.PrintDetails();

            Car c = new Car("Honda", "Hondai", 2000);
            c.TrunkSize = 200;
            c.PrintDetails();

            Truck t = new Truck("ecart", "Express", 2014);
            t.PayloadCapacity = 300;
            t.PrintDetails();
        }
    }
}
