using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    class ShellSort
    {
        public static void sort<T>(T[] arr) where T : IComparable
        {
            int n = arr.Length;

            n = n / 2;

            while (n > 0)
            {
                for (int i = n; i < arr.Length; i++)
                {

                    for (int j = i; j >= n; j = j - n)
                    {
                        if (arr[j - n].CompareTo(arr[j]) > 0)
                        {
                            SortTestHelper.swap(arr, j - n, j);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                n = n / 2;
            }



        }
    }
}
