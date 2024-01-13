using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockclass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            for (int i = 0; i < 24 * 60 * 60; i++)
            {
                clock.Time();
                Console.WriteLine(clock.displayTime());
            }
        }
    }
}