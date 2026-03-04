using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal partial class MinMax
    {
        internal static int MaxValueInArrayIterative()
        {
            int max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                    max = number;
            }

            return max;
        }

    }
}
