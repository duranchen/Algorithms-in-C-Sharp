using System;

namespace Algorithms.Sort
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            int n = 100000;
            int[] a = SortTestHelper.generateRandomArray(n, 0, n);
     
    //        SelectionSort.sort(a);

    //        SortTestHelper.printArray(a);

            SortTestHelper.testSort("Selection Sort", SelectionSort.sort, a);
           

            float[] f = { 3.1F, 2.2F, 3.2F, 1.1F };
            SelectionSort.sort(f);

            foreach (float i in f)
            {
                Console.WriteLine(i);
            }

            Student[] stu = { new Student("A",10), new Student( "C", 30), new Student( "B", 20 ),new Student("D",20)};

            SelectionSort.sort<Student>(stu);
            foreach (Student i in stu)
            {
                Console.WriteLine(i);
            }

        }
    }


}
