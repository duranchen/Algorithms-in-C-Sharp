using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = {1, 2, 4, 6, 7, 9 };

            int target = 7;
            int position1,position2;

            position1 = BinarySearchIteration.find(arr, target);

            Console.WriteLine(position1);


            position2 = BinarySearchRecursion.find(arr, 0, arr.Length - 1, target);

            Console.WriteLine(position2);

        }
    }
}
