using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_project
{
    internal class TamagochiManager
    {
        private List<Tamagochi> tamagotchis = new List<Tamagochi>();

        public void AddTamagotchi(Tamagochi tamagotchi)
        {
            tamagotchis.Add(tamagotchi);
        }

        public void SimulateTime()
        {
            foreach (var tamagotchi in tamagotchis)
            {
                tamagotchi.UpdateNeeds();
            }
        }

        public void CheckTamagotchiNeeds()
        {
            foreach (var tamagotchi in tamagotchis)
            {
                if (!tamagotchi.IsDead())
                {
                    if (tamagotchi.Hunger >= 80)
                    {
                        Console.WriteLine($"{tamagotchi.Name} is hungry. Please feed them!");
                    }
                }
                else
                {
                    Console.WriteLine($"{tamagotchi.Name} has passed away.");
                    tamagotchis.Remove(tamagotchi);
                }
                // Check other needs and take actions as necessary
            }
        }

        public void DisplayTamagotchiStatus()
        {
            foreach (var tamagotchi in tamagotchis)
            {
                tamagotchi.DisplayStatus();
            }
        }
    }
}