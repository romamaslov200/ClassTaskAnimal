using ClassTaskAnimal.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaskAnimal.Models
{
    public class Cat : Animal
    {
        public string Breed;

        public Cat(string breed, string name, int age) : base(name, age)
        {
            Breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Кошка породы - {Breed}");
        }
    }
}
