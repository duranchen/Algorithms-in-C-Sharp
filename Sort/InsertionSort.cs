using System;
using Algorithms.Sort;
namespace Algorithms.Sort
{
    class InsertionSort
    {

        public static void sortBasic<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {

                for (int j = i; j > 0; j--)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        SortTestHelper.swap(arr, j - 1, j);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void sortAdvanced<T>(T[] arr) where T : IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {


                for (int j = i; j > 0; j--)
                {
                    T e = arr[i];

                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        arr[j] = arr[j - 1];
                    }
                    else
                    {
                        arr[j] = e;
                        break;
                    }
                }

            }
        }
    }
}
