using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class BinarySearch
    {
        public static int Search<T>(this T[] array, T searchedValue)
        {
            IComparer<T> comparer;
            if (array == null || searchedValue == null)
            {
                throw new ArgumentNullException();
            }

            if (searchedValue is IComparable)
            {
                comparer = Comparer<T>.Default;
            }
            else
            {
                throw new InvalidOperationException();
            }

            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                int compare = comparer.Compare(array[middle], searchedValue);

                if (compare == 0)
                {
                    return middle;
                }
                else if (compare < 0)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}
