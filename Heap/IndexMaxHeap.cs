using System;

namespace Heap
{
    public class IndexMaxHeap<Item> where Item : IComparable
    {
        public Item[] data;
        public int[] indexes;
        protected int count;
        protected int capacity;

        public IndexMaxHeap(int capacity)
        {
            data = new Item[capacity + 1];
            indexes = new int[capacity + 1];
            count = 0;
            this.capacity = capacity;
        }

        public int size()
        {
            return count;
        }

        public Boolean isEmpty()
        {
            return count == 0 ? true : false;
        }

        public void insert(int i,Item item)
        {
            i = i + 1;
            data[i] = item;        
          
            indexes[count+1] = i;
            count++;
        
            swim(count);

        }

        public void swim(int i)
        {
            while (i > 1 && data[indexes[i / 2]].CompareTo(data[indexes[i]]) < 0)
            {
                int temp = indexes[i];
                indexes[i] = indexes[i / 2];
                indexes[i / 2] = temp;
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



    }
}
