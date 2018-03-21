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
            MaxHeap<int> heap = new MaxHeap<int>(10);

            heap.insert(30);
            heap.insert(20);
            heap.insert(10);
            heap.insert(25);
            heap.insert(100);
            heap.insert(90);

            foreach (int item in heap.data)
            {
                Console.WriteLine(item);

            }

            int i = heap.delMax();

            Console.WriteLine("Max:" +i);

            foreach (int item in heap.data)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(heap.size());

            Console.WriteLine("---------------------");

            int n = 5;
            IndexMaxHeap<int> indexHeap = new IndexMaxHeap<int>(n);
            Random random = new Random();
            for(int k =0;k< n; k++)
            {
                indexHeap.insert(k, random.Next(1, 100));
            }

            for(int h = 1;h<= n; h++)
            {
                Console.Write(h.ToString().PadRight(3));
            }
            Console.WriteLine();
            for (int h = 1; h <= n; h++)
            {
                Console.Write(indexHeap.indexes[h].ToString().PadRight(3));
            }
            Console.WriteLine();
            for (int h = 1; h <= n; h++)
            {
                Console.Write(indexHeap.data[h].ToString().PadRight(3));
            }
            Console.WriteLine();



        }
    }
}
