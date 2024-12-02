using ClassTaskAnimal.Core;
using ClassTaskAnimal.Models;
using RomanLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskAnimal
{
    internal class Program
    {
        static public Proverka proverka = new Proverka();
        static public Dog dog = new Dog("Долматинец", "Шарик", 5);
        static public Cat cat = new Cat("Хз", "Барси", 5);
        static public Car car = new Car(100, "Хз", 5);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Кошка\n2. Собака\n3. Машина\n");
                MySwich.Cenge(proverka.Type<int>("Выберете ==> "));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
