using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskAnimal.Core
{
    public static class MySwich
    {
        public static void Cenge(int i)
        {
            switch (i)
            {
                case 1:
                    Functions.Cat();
                    break;
                case 2:
                    Functions.Dog();
                    break;
                case 3:
                    Functions.Car();
                    break;
                default:
                    Console.WriteLine("Такова пункта нету");
                    break;
            }
        }
    }
}
