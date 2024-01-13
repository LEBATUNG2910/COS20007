using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_project
{
    public class Tamagochi : INeeds
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Hunger { get; private set; }
        public int Happiness { get; private set; }
        public int Rest { get; private set; }

        public Tamagochi(string name, string color)
        {
            Name = name;
            Color = color;
            Hunger = 70;
            Happiness = 100;
            Rest = 100;
        }

        public void Feed()
        {
            Hunger += 10;
            Happiness += 5;
        }

        public void Play()
        {
            Hunger -= 5;
            Happiness += 10;
        }

        public void Sleep()
        {
            Rest += 15;
        }

        internal void UpdateNeeds()
        {
            throw new NotImplementedException();
        }

        internal void DisplayStatus()
        {
            throw new NotImplementedException();
        }

        internal bool IsDead()
        {
            throw new NotImplementedException();
        }
    }
}
