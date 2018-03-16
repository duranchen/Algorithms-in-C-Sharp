using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heap
{
    class MaxHeap<Item> where Item : IComparable
    {
        public Item[] items;
        private int count;

        public MaxHeap(int capacity)
        {
            items = new Item[capacity + 1];
            count = 0;
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return count == 0 ? true : false;
        }

        public void insert(Item item)
        {

            items[++count] = item;
            if (count > 1)
            {

                int i = count;

                while (i > 1 && items[i / 2].CompareTo(items[i]) < 0)
                {
                    Item temp = items[i];
                    items[i] = items[i / 2];
                    items[i / 2] = temp;
                    i = i / 2;
                }
            }

        }

    }
}
