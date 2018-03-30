using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class BinarySearchIteration
    {

        private BinarySearchIteration() { }

        public static int find<T>(T[] arr, T target) where T : IComparable
        {
            int l = 0, r = arr.Length - 1;

            while (l <= r)
            {
                int mid = (r + l) / 2;
                if (arr[mid].CompareTo(target) == 0)
                {
                    return mid;
                }

                if (arr[mid].CompareTo(target) < 0)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            return -1;
        }
    }
}
