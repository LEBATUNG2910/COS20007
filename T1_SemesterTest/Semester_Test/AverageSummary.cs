using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_Test
{
    public class AverageSummary : SummaryStrategy
    {
        private float Average(List<int> onumber)
        {
            int total = 0;
            foreach (int number in onumber)
            {
                total += number;
            }
            float result = total / onumber.Count;
            return result;
        }
        public override void PrintSummary(List<int> onumber)
        {
            Console.WriteLine("Average: " + Average(onumber));
        }
    }
}
