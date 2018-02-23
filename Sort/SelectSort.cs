using System;

namespace Algorithms.Sort
{
    class SelectionSort
    {

        public static void sort<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j].CompareTo(arr[minIndex]) <= 0)
                    {
                        minIndex = j;
                    }
                }

                T temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

    }
}
