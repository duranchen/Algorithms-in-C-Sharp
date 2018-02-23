using System;

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

        public static void printArray(int[] arr)
        {

            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }

        public static void testSort<T>(string sortName,Action<T[]> sort,T[] arr)
        {
            DateTime start = DateTime.Now;
            sort(arr);
            DateTime end = DateTime.Now;

            TimeSpan elapsedtime =end - start;

            Console.WriteLine(sortName+" : " + elapsedtime.TotalSeconds+" s");

        }

        public static bool isSorted<T>(T[] arr) where T:IComparable
        {
            for(int i=0;i< arr.Length;i++)
            {
                if (arr[i].CompareTo(arr[i+1])>0)
                {
                    return false;
                }
  
            }
            return true;
        }
    }
}
