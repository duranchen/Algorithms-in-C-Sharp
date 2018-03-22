using System;

namespace Heap
{
    public class MaxHeap<Item> where Item : IComparable
    {
        private Item[] data;
        private int count { get; set; }

        public MaxHeap(int capacity)
        {
            data = new Item[capacity + 1];
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

            this.data = data;
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

            data[++count] = item;
            if (count > 1)
            {
                int i = count;
                swim(i);

            }

        }

        public void swim(int i)
        {
            while (i > 1 && data[i / 2].CompareTo(data[i]) < 0)
            {
                Item temp = data[i];
                data[i] = data[i / 2];
                data[i / 2] = temp;
                i = i / 2;
            }

        }

        public Item delMax_M()
        {
            Item maxItem = data[1];
            data[1] = data[count];
            data[count] = default(Item);
            count--;
            int i = 1;
            while (i * 2 + 1 <= count)
            {

                if (i * 2 == count)
                {

                    swap(i * 2, i);
                    break;
                }

                if (data[i * 2].CompareTo(data[i * 2 + 1]) > 0)
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
            Item maxItem = data[1];
            data[1] = data[count];
            data[count--] = default(Item);
            int k = 1;

            sink(k);

            return maxItem;
        }

        public void sink(int k)
        {

            while (k * 2 <= count)
            {
                int j = k * 2;

                if (j + 1 <= count && data[j].CompareTo(data[j + 1]) < 0)
                {
                    j++;
                }

                if (data[j].CompareTo(data[k]) < 0)
                {
                    break;
                }

                swap(k, j);

                k = j;

            }

        }

        public void swap(int i, int j)
        {
            Item temp = data[i];
            data[i] = data[j];
            data[j] = temp;
        }

        public void printHeap()
        {

            for (int i = 1; i <= count; i++)
            {
                Console.Write(i.ToString().PadRight(3));

            }
            Console.WriteLine();
            for (int i = 1; i <= count; i++)
            {
                Console.Write(data[i].ToString().PadRight(3));

            }
        }

    }
}
