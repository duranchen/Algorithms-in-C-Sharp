using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heap;

namespace Algorithms.Sort
{

    //原地堆排序
    class HeapSort2
    {

        private HeapSort2() { }

        public static void sort<Item>(Item[] arr) where Item : IComparable
        {
            int n = arr.Length;

            for (int i = (n - 1 - 1) / 2; i >= 0; i--)
            {
                sink(arr, n, i);
            }

            for (int j = n - 1; j > 0; j--)
            {
                SortTestHelper.swap(arr, 0, j);
                sink(arr, j, 0);
            }

        }

        public static void sink<Item>(Item[] arr, int n, int k) where Item : IComparable
        {
            while (k * 2 + 1 < n)
            {
                int j = k * 2 + 1;
                if (k * 2 + 2 < n && arr[j + 1].CompareTo(arr[j]) > 0)
                {
                    j++;
                }
                if (arr[j].CompareTo(arr[k]) > 0)
                {
                    SortTestHelper.swap(arr, j, k);

                    k = j;
                }
                else
                {
                    break;
                }

            }

        }
    }
}
