using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heap;

namespace Algorithms.Sort
{
    class HeapSort
    {

        public static void sort<Item>(Item[] arr) where Item:IComparable
        {
              MaxHeap<Item> maxHeap = new MaxHeap<Item>(arr);
            for(int i = arr.Length-1; i>=0;i--)
            {
                arr[i] = maxHeap.delMax();
            }
          
        }
    }
}
