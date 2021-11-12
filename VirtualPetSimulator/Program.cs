using System;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Virtual Pet Simulator";
            Console.WriteLine("Welcome to the pet simulator!");
            // Empty line
            Console.WriteLine("");

            World myWorld = new World();
            myWorld.Run();


            // after that, the app will close. So, I'm gonna
            // use Console.ReadKey(); to keep that window open

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            // when I press a key, the window closes
        }
    }
}
