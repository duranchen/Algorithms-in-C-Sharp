using System;

namespace Heap
{
    public class IndexMaxHeap<Item> where Item : IComparable
    {
        public Item[] data;
        public int[] indexes;
        protected int count;
        protected int capacity;

        //构造一个空堆，有capacity个元素
        public IndexMaxHeap(int capacity)
        {
            data = new Item[capacity + 1];
            indexes = new int[capacity + 1];
            count = 0;
            this.capacity = capacity;
        }

        //返回索引堆中的元素个数
        public int size()
        {
            return count;
        }

        //判断索引堆是否为空
        public Boolean isEmpty()
        {
            return count == 0 ? true : false;
        }

        //向索引堆中插入一个新元素，新元素索引为i，元素为item
        //对于用户，索引从0开始
        public void insert(int i, Item item)
        {
            i = i + 1; //索引从0开始，所以加1
            data[i] = item;

            indexes[++count] = i;

            swim(count);

        }

        //从索引堆中取出最大元素，并在堆中删除该元素
        public Item delMax()
        {
            Item maxItem = data[indexes[1]];
            swapIndexes(1, count);

            data[indexes[count]] = default(Item);
            indexes[count] = -1;

            count--;
            sink(1);

            return maxItem;
        }

        //从索引堆中取出最大元素的索引，并在堆中删除该索引
        public int delMaxIndex()
        {
            int maxIndex = indexes[1]-1;


            swapIndexes(1, count);
            data[indexes[count]] = default(Item);

            indexes[count] = -1;
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
        public void swim(int i)
        {
            while (i > 1 && data[indexes[i / 2]].CompareTo(data[indexes[i]]) < 0)
            {
                swapIndexes(i, i / 2);
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

                swapIndexes(k, j);
                k = j;

            }

        }

        public void swapIndexes(int i, int j)
        {
            int temp = indexes[i];
            indexes[i] = indexes[j];
            indexes[j] = temp;

        }

        public void printIndexHeap()
        {

            for (int h = 0; h <= capacity; h++)
            {
                Console.Write(h.ToString().PadRight(3));
            }
            Console.WriteLine();
            Console.Write("i  ");
            for (int h = 1; h <= capacity; h++)
            {
                Console.Write(indexes[h].ToString().PadRight(3));
            }
            Console.WriteLine();

            Console.Write("d  ");
            for (int h = 1; h <= capacity; h++)
            {
                Console.Write(data[h].ToString().PadRight(3));
            }
            Console.WriteLine();
        }



    }
}
