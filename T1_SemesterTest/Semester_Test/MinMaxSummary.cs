using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Test
{
    public class MinMaxSummary : SummaryStrategy
    {
        private int Minimum(List<int> onumber)
        {
            int small = onumber[0];
            foreach (int i in onumber)
            {
                if (small > i)
                {
                    small = i;
                }
            }
            return small;
        }
        private int Maximum(List<int> onumber)
        {
            int large = onumber[0];
            foreach (int i in onumber)
            {
                if (large < i)
                {
                    large = i;
                }
            }
            return large;
        }
        public override void PrintSummary(List<int> onumber)
        {
            Console.WriteLine("Min Value: " + Minimum(onumber));
            Console.WriteLine("Max Value: " + Maximum(onumber));
        }
    }
}