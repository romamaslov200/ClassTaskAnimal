using ClassTaskAnimal.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskAnimal.Models
{
    public class Car : Vehicle
    {
        public int Forse;
        public Car(int forse, string Models, int Year) : base(Models, Year) 
        {
            Forse = forse;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Models - {Models}\nYear - {Year}\nЛощадиных сил - {Forse}");
        }
    }
}
