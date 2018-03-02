using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    class MergeSortBU<T> where T:IComparable
    {
        private static T[] aux;

        //O(nlogn)时间复杂度
        public static void sort(T[] arr)
        {
           
            int n = arr.Length;
            aux = new T[n];
            for (int size = 1; size <n; size =size*2 )
            {
                for(int lo =0;lo<n-size;lo = lo +size*2)
                {
                    merge(arr, lo, lo + size - 1, Math.Min(lo + size * 2 - 1,n-1));
                }
            }
           
        }
        //将arr[l...mid]和arr[mid+1,r]进行归并
        public static void merge(T[] arr, int l, int mid, int r)
        {
            // 将数组arr[l...r]复制辅助数组aux。
            for (int k = l; k <= r; k++)
            {
                aux[k] = arr[k];
            }


            //初始化，i指向左半部分起始位置l，j指向右半部分起始位置mid+1
            int i = l, j = mid + 1;

            for (int k = l; k <= r; k++)
            {
                // 如左半部分元素已经处理完
                if (i > mid)
                {
                    arr[k] = aux[j];
                    j++;
                }
                // 如果右半部分元素已经处理完
                else if (j > r)
                {
                    arr[k] = aux[i];
                    i++;
                }
                // 如果左半部分i所指元素 < 右半部分j所指元素
                else if (aux[i].CompareTo(aux[j]) < 0)
                {
                    arr[k] = aux[i];
                    i++;
                }
                // 如果左半部分i所指元素 >= 右半部分j所指元素
                else
                {
                    arr[k] = aux[j];
                    j++;
                }


            }


        }

    }
}
