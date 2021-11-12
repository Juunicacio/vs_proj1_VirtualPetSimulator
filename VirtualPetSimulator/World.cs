using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPetSimulator
{
    class World
    {
        public void Run()
        {
            Pet leo = new Pet("Leo", 2, "cat", true);
            /*
            leo.Name = "Leo";
            leo.Age = 2;
            leo.Specie = "cat";
            leo.IsAwake = true;*/

            Pet junior = new Pet("Junior", 13, "Parrot", true);

            /*
            Console.WriteLine("> Pet 1: ");
            Console.WriteLine($"My name is {leo.Name}.");
            Console.WriteLine($"I'm {leo.Age} years old.");
            Console.WriteLine($"And I'm a {leo.Specie}.");
            Console.WriteLine($"Is the pet awake? {leo.IsAwake}");
            */

            leo.Greet();
            junior.Greet();
            junior.Sleep();

            leo.Eat("cat food");
        }
    }
}
