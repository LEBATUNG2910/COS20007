using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tamagotchi Simulator!");

            // You can create and interact with Tamagotchis here.
            Tamagochi tamagotchi = new Tamagochi("Tama", "Pink");

            // For testing purposes, let's feed and play with the Tamagotchi.
            tamagotchi.Feed();
            tamagotchi.Play();

            Console.WriteLine($"{tamagotchi.Name} is now feeling:");
            Console.WriteLine($"Hunger: {tamagotchi.Hunger}");
            Console.WriteLine($"Happiness: {tamagotchi.Happiness}");
            Console.WriteLine($"Rest: {tamagotchi.Rest}");
        }
    }
}