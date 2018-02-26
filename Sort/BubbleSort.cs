using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    class BubbleSort
    {
        public static void sort<T>(T[] arr) where T : IComparable
        {
            //for(int i = 0; i<arr.Length;i++)
            //{
            //    for(int j = i+1; j<arr.Length;j++ )
            //    {
            //        if(arr[j].CompareTo(arr[i])<0)
            //        {
            //            SortTestHelper.swap(arr, j, i);
            //        }
            //    }

            
            for (int i = 0; i < arr.Length-1; i++)
            {
               
                for (int j = 1; j < arr.Length -i; j++)
                {
                    if (arr[j - 1].CompareTo(arr[j]) > 0)
                    {
                        SortTestHelper.swap(arr, j - 1, j);
                    }
                }
            
            }
        }
    }
}

