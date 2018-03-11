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

            int j = partition1(arr, l, r);
            sort(arr, l, j - 1);
            sort(arr, j + 1, r);
        }

        public static int partition<T>(T[] arr, int l, int r) where T : IComparable
        {
            int i = l, j = r + 1;

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

        public static int partition1<T>(T[] arr, int l, int r) where T : IComparable
        {
            int i = l + 1, j = l;

            while (i <= r)
            {
                if (arr[i].CompareTo(arr[l]) <= 0)
                {
                    j++;
                    SortTestHelper.swap(arr, j, i);

                }
                i++;

            }

            SortTestHelper.swap(arr, l, j);
            return j;


        }


        public static int partition2<T>(T[] arr, int l, int r) where T : IComparable
        {
            int i = l, j = r;

            while (i != j)
            {
                // 必须j先出动，因为j是寻找小于基准数的值，最后与基准数交换位置的值必须小于基准数的数。
                while (i < j && arr[j].CompareTo(arr[l]) >= 0)
                {
                    j--;

                }

                while (i < j && arr[i].CompareTo(arr[l]) <= 0)
                {
                    i++;
                }

                if (i < j)
                {
                    SortTestHelper.swap(arr, i, j);
                }
            }

            SortTestHelper.swap(arr, j, l);

            return i;

        }


    }
}

