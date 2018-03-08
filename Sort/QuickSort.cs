using System;

namespace Algorithms.Sort
{
    class QuickSort
    {
        public static void sort<T>(T[] arr) where T : IComparable
        {

            sort(arr, 0, arr.Length - 1);

        }

        public static void sort<T>(T[] arr, int l, int r) where T : IComparable
        {
            if (r <= l)
            {
                return;
            }

            int j = partition(arr, l, r);
            sort(arr, l, j - 1);
            sort(arr, j + 1, r);
        }

        public static int partition<T>(T[] arr, int l, int r) where T : IComparable
        {
            int i = l , j = r+1;

            while (true)
            {

                while (arr[++i].CompareTo(arr[l]) < 0)
                {
                    if (i == r)
                    {
                        break;
                    }
                   
                }
                while (arr[--j].CompareTo(arr[l]) > 0)
                {
                    if (j == l)
                    {
                        break;
                    }
                    
                }

                if (i >= j)
                {
                    break;
                }

                SortTestHelper.swap(arr, i, j);
            }
            SortTestHelper.swap(arr, l, j);
            return j;


        }
       

    }
}

