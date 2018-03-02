using System;

namespace Algorithms.Sort
{
    class BubbleSort
    {
        public static void sort<T>(T[] arr) where T : IComparable
        {

            //循环n-1次，只需冒泡n-1个元素
            for (int i = 1; i <= arr.Length-1; i++)
            {
                //通过对arr[0..n-i]内的相邻元素依次进行比较并交换位置，使arr[0..n-i]中最大元素移动至arr[1,n-i]末端。
                for (int j = 0; j < arr.Length -i; j++)
                {
                    //比较相邻元素，如果arr[j-1]>arr[j]则交换位置
                    if (arr[j ].CompareTo(arr[j+1]) > 0)
                    {
                        SortTestHelper.swap(arr, j, j+1);
                    }
                }
            
            }
        }
    }
}

