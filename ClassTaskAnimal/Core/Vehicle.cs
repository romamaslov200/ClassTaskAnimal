using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskAnimal.Core
{
    public class Vehicle
    {
        public string Models { get; set; }
        public int Year {  get; set; }

        public Vehicle(string model, int year)
        {
            Models = model;
            Year = year;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Models - {Models}\nYear - {Year}");
        }
    }
}
