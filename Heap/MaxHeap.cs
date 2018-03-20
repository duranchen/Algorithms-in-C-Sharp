using System;

namespace Heap
{
    public class MaxHeap<Item> where Item : IComparable
    {
        public Item[] items;
        private int count;

        public MaxHeap(int capacity)
        {
            items = new Item[capacity + 1];
            count = 0;
        }

        public MaxHeap(Item[] arr)
        {

            count = arr.Length;
            Item[] data = new Item[arr.Length + 1];
            for(int i =0; i<arr.Length;i++)
            {
                data[i + 1] = arr[i];

            }

            items = data;
            int k = count/2;
            while(k >=1)
            {
                sink(k);
                k--;
            }

           
          
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
                swim(i);

            }

        }

        public void swim(int i)
        {
            while (i > 1 && items[i / 2].CompareTo(items[i]) < 0)
            {
                Item temp = items[i];
                items[i] = items[i / 2];
                items[i / 2] = temp;
                i = i / 2;
            }

        }

        public Item delMax_M()
        {
            Item maxItem = items[1];
            items[1] = items[count];
            items[count] = default(Item);
            count--;
            int i = 1;
            while (i * 2 + 1 <= count)
            {

                if (i * 2 == count)
                {

                    swap(i * 2, i);
                    break;
                }

                if (items[i * 2].CompareTo(items[i * 2 + 1]) > 0)
                {

                    swap(i * 2, i);
                    i = i * 2;

                }
                else
                {
                    swap(i * 2 + 1, i);
                    i = i * 2 + 1;
                }
            }

            return maxItem;

        }

        public Item delMax()
        {
            Item maxItem = items[1];
            items[1] = items[count];
            items[count--] = default(Item);
            int k = 1;

            sink(k);

            return maxItem;
        }

        public void sink(int k)
        {

            while (k * 2 <= count)
            {
                int j = k * 2;

                if (j + 1 <= count && items[j].CompareTo(items[j + 1]) < 0)
                {
                    j++;
                }

                if (items[j].CompareTo(items[k]) < 0)
                {
                    break;
                }

                swap(k, j);

                k = j;

            }

        }

        public void swap(int i, int j)
        {
            Item temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }



    }
}
