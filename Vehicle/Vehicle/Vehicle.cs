using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Vehicle
    {
        public string name;
        public string model;
        public int year;

        public Vehicle(string name, string model, int year)
        {
            this.name = name;
            this.model = model;
            this.year = year;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Vehicle name is : " + this.name + ". Model is : " + this.model + ". Year is : " + this.year);
        }

    }
}
