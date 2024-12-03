using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Truck: Vehicle
    {
        private int _payloadCapacity;

        public int PayloadCapacity
        {
            get
            {
                return _payloadCapacity;
            }
            set
            {
                if(value > 0)
                {
                    _payloadCapacity = value;
                }
                else
                {
                    Console.WriteLine("Payload capaacity must be a positive number");
                }
            }
        }

        public Truck(string name, string model, int year):base(name, model, year)
        {
            
        }

        public void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("payloadCapacity is : " + _payloadCapacity);
        }



    }
}
