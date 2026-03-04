using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    internal partial class MinMax
    {
        internal static int MaxValueInArrayRecursive()
        {
            if (numbers.Count == 0)
                return int.MinValue;

            return MaxValueInArrayRecursiveHelper(0, int.MinValue);
            
        }

        private static int MaxValueInArrayRecursiveHelper(int i, int minValue)
        {
            if (i==numbers.Count)
                return minValue;

            if (numbers[i] > minValue)
                minValue = numbers[i];

            return MaxValueInArrayRecursiveHelper(i + 1, minValue);


        }
    }
}
