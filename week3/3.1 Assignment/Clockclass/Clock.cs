using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clockclass
{
    public class Clock
    {
        private Counterclass hours, minutes, seconds;
        public Clock()
        {
            hours = new Counterclass("Hours");
            minutes = new Counterclass("Minutes");
            seconds = new Counterclass("Seconds");
        }
        public void Time()
        {
            seconds.Increment();
            if (seconds.Ticks == 60)
            {
                seconds.Reset();
                minutes.Increment();
                if (minutes.Ticks == 60)
                {
                    minutes.Reset();
                    hours.Increment();
                    if (hours.Ticks == 24)
                    {
                        Reset();
                    }
                }

            }
        }
        public void Reset()
        {
            seconds.Reset();
            hours.Reset();
            minutes.Reset();

        }
        public string displayTime()
        {
            return $"{hours.Ticks:D2}:{minutes.Ticks:D2}:{seconds.Ticks:D2}";
        }

    }
}