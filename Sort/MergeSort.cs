using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort
{
    class MergeSort<T> where T : IComparable
    {

        private static T[] aux;

        public static void sort(T[] arr)
        {
            aux = new T[arr.Length];
            sort(arr, 0, arr.Length - 1);
        }

        public static void sort(T[] arr, int l, int r)
        {
            if (r <= l)
            {
                return;
            }
            int mid = (l + r) / 2;
          
            sort(arr, l, mid);
            sort(arr, mid + 1, r);
            merge(arr, l, mid, r);

        }

        public static void merge(T[] arr, int l, int mid, int r)
        {

            for (int k = l; k <= r; k++)
            {
                aux[k] = arr[k];
            }


            int i = l, j = mid + 1;

            for (int k = l; k <= r; k++)
            {

                if (i > mid)
                {
                    arr[k] = aux[j];
                    j++;
                }
                else if (j > r)
                {
                    arr[k] = aux[i];
                    i++;
                }
                else if (aux[i].CompareTo(aux[j]) < 0)
                {
                    arr[k] = aux[i];
                    i++;
                }
                else
                {
                    arr[k] = aux[j];
                    j++;
                }


            }


        }
    }
}
