using System;

namespace Algorithms.AlgorithmAnalysis
{
    class DoublingTest
    {

        public static double timeTrial(int n)
        {
            int MAX = 1000000;
            int[] a = new int[n];

            Random random = new Random();

            for(int i = 0; i< n; i++)
            {
                a[i] = random.Next(-MAX, MAX);
            }

            StopWatch stopWatch = new StopWatch();
            int count = ThreeSum.count(a);

            return stopWatch.elapsedTime();
        }
        
    }
}
