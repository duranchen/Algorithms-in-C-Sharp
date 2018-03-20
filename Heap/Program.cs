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

            foreach (int item in heap.items)
            {
                Console.WriteLine(item);

            }

            int i = heap.delMax();

            Console.WriteLine("Max:" +i);

            foreach (int item in heap.items)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine(heap.size());
        }
    }
}
