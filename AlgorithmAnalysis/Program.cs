using Algorithms.AlgorithmAnalysis;
using Alogrithms.Helper;
using System;

namespace Algorithms.AlgorithmAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {

            double prev = DoublingTest.timeTrial(125);
            for(int i = 250; true;i= i+i)
            {
                double time = DoublingTest.timeTrial(i);
                Console.WriteLine("{0}\t{1}", i, time/prev);

                prev = time;
            }
        }
    }
}
