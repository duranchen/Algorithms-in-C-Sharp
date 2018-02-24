using System;

namespace Algorithms.Sort
{

    class Program
    {

        static void Main(string[] args)
        {
            int n = 10;
            int[] a = SortTestHelper.generateRandomArray(n, 0, n);
            int[] d = SortTestHelper.generateNearlyOrderedArray(n, 3);
 
            //SelectionSort.sort(a);
            //SortTestHelper.printArray(a);
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];
            Array.Copy(a, b, a.Length);
            Array.Copy(a, c, a.Length);

            SortTestHelper.testSort("Selection Sort", SelectionSort.sort, a);
            SortTestHelper.testSort("Insertion Sort Basic", InsertionSort.sortBasic, b);
            SortTestHelper.testSort("Insertion Sort Advanced", InsertionSort.sortAdvanced, c);
            SortTestHelper.testSort("Insertion Sort Advanced Nearly Ordered", InsertionSort.sortAdvanced, d);

   
            float[] f = { 3.1F, 2.2F, 3.2F, 1.1F };
            InsertionSort.sortBasic(f);

            foreach (float i in f)
            {
                Console.WriteLine(i);
            }

            Student[] stu = { new Student("A", 10), new Student("C", 30), new Student("B", 20), new Student("D", 20) };

            SelectionSort.sort<Student>(stu);
            foreach (Student i in stu)
            {
                Console.WriteLine(i);
            }

        }
    }


}
