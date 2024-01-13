using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockclass
{
    public class Counterclass
    {
        private int counts;
        private string names;
        public Counterclass(string name)
        {
            names = name;
            counts = 0;
        }
        public int Ticks
        {
            get
            {
                return counts;
            }
        }
        public string Name
        {
            get
            {
                return names;
            }
            set
            {
                names = value;
            }
        }
        public void Increment()
        {
            counts++;
        }
        public void Reset()
        {
            counts = 0;
        }
    }
}