using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetSimulator
{
    class Pet
    {
        // Field
        // public = access modifier
        public string Name;
        public int Age;
        public string Specie;
        public bool IsAwake;

        private int ExperiencePoints;

        // to construct use the same name of your class, 
        // and the method do not use the word void
        public Pet(string petName, int petAge, string petSpecie, bool petIsAwake)
        {
            Console.WriteLine("Pet being constructed.");
            Name = petName;
            Age = petAge;
            Specie = petSpecie;
            IsAwake = petIsAwake;
        }

        public void Greet()
        {
            Console.WriteLine($"My name is {Name}.");
            Console.WriteLine($"I'm {Age} years old.");
            Console.WriteLine($"And I'm a {Specie}.");
            Console.WriteLine($"Is the pet awake? {IsAwake}");
            Console.WriteLine("");
        }

        public void Sleep()
        {
            IsAwake = false;
            Console.WriteLine($"{Name} is now happily snoring... Zzzz");
        }

        public void Eat(string foodName)
        {
            Console.WriteLine($"{Name} is eating {foodName}.");
        }
    }
}
