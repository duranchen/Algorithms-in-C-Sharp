using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();

            int m = 10;
            MaxHeap<int> heap = new MaxHeap<int>(m);

            while (m > 0)
            {
                heap.insert(random.Next(1, 100));
                m--;
            }

            heap.printHeap();

            Console.WriteLine();
            int maxHeapItem = heap.delMax();

            Console.WriteLine("Max:" + maxHeapItem);

            heap.printHeap();

            // Console.WriteLine(heap.size());
            Console.WriteLine();
            Console.WriteLine("----Index Max Heap----");

            int n = 5;
            IndexMaxHeap<int> indexHeap = new IndexMaxHeap<int>(n);

            for (int k = 0; k < n; k++)
            {
                indexHeap.insert(k, random.Next(1, 10));
            }
            indexHeap.printIndexHeap();

            Console.WriteLine("---------------------");
            int max = indexHeap.delMax();
            Console.WriteLine("Delete Max Item:" + max);
            indexHeap.printIndexHeap();

            Console.WriteLine("---------------------");
            int maxIndex = indexHeap.delMaxIndex();
            Console.WriteLine("Delete Max Item Index:" + maxIndex);
            indexHeap.printIndexHeap();

            //Console.WriteLine("---------------------");
            //indexHeap.change(2, 8);
            //indexHeap.printIndexHeap();

        }
    }
}
