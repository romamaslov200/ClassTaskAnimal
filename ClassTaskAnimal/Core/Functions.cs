using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskAnimal.Core
{
    public static class Functions
    {
        public static void Cat()
        {
            Program.cat.MakeSound();
        }
        public static void Dog() 
        {
            Program.dog.MakeSound();
        }
        public static void Car() 
        {
            Program.car.GetInfo();
        }
    }
}
