using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiTask
{
    public class Fibonachi
    {
        static IEnumerable<long> FindFibonachi(int countOfNumbers)
        {
            long prev = -1;
            long next = 1;
            for (int i = 0; i< countOfNumbers; i++)
            {
                long sum = prev + next;
                prev = next;
                next = sum;
                yield return sum;
            }
        }
    }
}
