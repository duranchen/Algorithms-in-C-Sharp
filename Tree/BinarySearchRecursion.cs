using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class BinarySearchRecursion
    {

        private BinarySearchRecursion() { }

        public static int find<T>(T[] arr, int l, int r, T target) where T : IComparable
        {
            int mid = (r + l) / 2;

            if (arr[mid].CompareTo(target) == 0)
            {
                return mid;
            }

            if (l <= r)
            {

                if (arr[mid].CompareTo(target) < 0)
                {
                    return find(arr, mid + 1, r, target);
                }
                else
                {
                    return find(arr, l, mid - 1, target);
                }

            }
            else
            {
                return -1;
            }  

        }
    }
}
