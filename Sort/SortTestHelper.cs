using System;
using Algorithms.Helper;


namespace Algorithms.Sort
{
    class SortTestHelper
    {

        public static int[] generateRandomArray(int n, int rangeL, int rangeR)
        {
            int[] arr = new int[n];
            Random r = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next() % (rangeR - rangeL + 1) + rangeL;
            }

            return arr;

        }

        public static int[] generateNearlyOrderedArray(int n, int swapTimes)
        {
            int[] arr = new int[n];

            for(int i =0;i<n;i++)
            {
                arr[i] = i;
            }

            Random r = new Random((int)DateTime.Now.Ticks);

            for(int j = 0; j < swapTimes; j++)
            {
                int x = r.Next() % n;
                int y = r.Next() % n;

                swap(arr,x,y);
            }

            return arr;
        }

        public static void printArray(int[] arr)
        {

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }

        public static void testSort<T>(string sortName, Action<T[]> sort, T[] arr) where T : IComparable
        {

            StopWatch stopWatch = new StopWatch(); 
            sort(arr);
            double elapsedTime = stopWatch.elapsedTime();

            if (isSorted(arr))
            {
                Console.WriteLine(sortName + " : " + elapsedTime + " s");
            }
            else
            {
                Console.WriteLine(sortName + " :  Sort failed");
            }

        }

        public static bool isSorted<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) > 0)
                {
                    return false;
                }

            }
            return true;
        }

        public static void swap<T>(T[] arr, int i, int j)
        {
            T temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }

    }
}
