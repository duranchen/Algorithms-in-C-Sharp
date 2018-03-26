using System;

namespace Heap
{
    public class IndexMaxHeapAdvance<Item> where Item : IComparable
    {
        private Item[] data; //数据
        private int[] indexes; //索引
        private int[] reverse;  //反向索引， reverse[i] =x 表示索引i在x的位置
        protected int count;
        protected int capacity;

        public IndexMaxHeapAdvance(int capacity)
        {
            data = new Item[capacity + 1];
            indexes = new int[capacity + 1];
            reverse = new int[capacity + 1];

            for (int i = 0; i <= capacity; i++)
            {
                reverse[i] = 0;
            }
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

        //参数i，对于用户是从0开始
        public void insert(int i, Item item)
        {

            data[++i] = item;
            indexes[++count] = i;
            reverse[i] = count;

            swim(count);
        }

        public void swim(int i)
        {
            while (i > 1 && data[indexes[i / 2]].CompareTo(data[indexes[i]]) < 0)
            {
                swap(i, i / 2);
                i = i / 2;
            }

        }

        public void sink(int k)
        {

            while (k * 2 <= count)
            {
                int j = k * 2;

                if (j + 1 <= count && data[indexes[j]].CompareTo(data[indexes[j + 1]]) < 0)
                {
                    j++;
                }

                if (data[indexes[j]].CompareTo(data[indexes[k]]) < 0)
                {
                    break;
                }

                swap(k, j);
                k = j;
            }
        }

        public Item delMax()
        {
            Item maxItem = data[indexes[1]];
            indexes[1] = indexes[count];

            indexes[count] = default(int);
            count--;
            sink(1);

            return maxItem;
        }

        public int delMaxIndex()
        {
            int maxIndex = indexes[1];

            maxIndex = maxIndex - 1;
            indexes[1] = indexes[count];

            indexes[count] = default(int);
            count--;
            sink(1);

            return maxIndex;
        }

        //获取索引为i的元素
        public Item getItem(int i)
        {
            return data[i + 1];
        }

        //将索引为i的元素修改newItem
        public void change(int i, Item newItem)
        {
            data[++i] = newItem;
            for (int j = 1; j <= count; j++)
            {
                if (indexes[j] == i)
                {
                    swim(j);
                    sink(j);
                    return;
                }
            }
        }

        public void swap(int i, int j)
        {
            int temp = indexes[i];
            indexes[i] = indexes[j];
            indexes[j] = temp;
        }

        public void printIndexHeap()
        {

            for (int h = 1; h <= count; h++)
            {
                Console.Write(h.ToString().PadRight(3));
            }
            Console.WriteLine();
            for (int h = 1; h <= count; h++)
            {
                Console.Write(indexes[h].ToString().PadRight(3));
            }
            Console.WriteLine();
            for (int h = 1; h <= count; h++)
            {
                Console.Write(data[h].ToString().PadRight(3));
            }
            Console.WriteLine();
        }
    }
}
