using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Console UI (CUI)
            Console.Title = "SportsCars are Fun";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Do you name your SportsCar?");
            Console.BackgroundColor = ConsoleColor.Black;

            SportsCar myCar = new SportsCar();
            myCar.PetName = "Lucy";
            Console.WriteLine("My car's Petname is: {0}", myCar.GetPetName());

            // Wait for Enter key to be pressed.
            Console.ReadLine();
        }
    }
}
