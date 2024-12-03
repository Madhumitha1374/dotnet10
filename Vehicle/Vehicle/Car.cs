using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : Vehicle
    {
        private int _trunkSize;

        public int TrunkSize
        {
            get
            {
                return _trunkSize;
            }
            set
            {
                if(value > 0)
                {
                    _trunkSize = value;
                }
                else
                {
                    Console.WriteLine("Trunk size must be positive");
                }
            }
        }


        public Car(string name, string model, int year):base(name, model, year)
        {
            
        }

        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("Trunk size is : " + _trunkSize);
        }
    }
}
