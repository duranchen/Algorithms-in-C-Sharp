using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class UnionFindTestHelper
    {

        public static void testUF1(int n)
        {
            Random r = new Random();

            UnionFind1 uf = new UnionFind1(n);

            DateTime start = DateTime.Now;
         
            
            for (int i =0; i<n;i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.union(a, b);
            }

            for(int i=0;i<n;i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.isConnected(a, b);
            }

            DateTime end = DateTime.Now;

            TimeSpan elapsedtime = end - start;

            Console.WriteLine("UnionFind1, " +2*n+ " ops, " + elapsedtime.TotalSeconds + " s");
        }


        public static void testUF2(int n)
        {
            Random r = new Random();

            UnionFind2 uf = new UnionFind2(n);

            DateTime start = DateTime.Now;


            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.union(a, b);
            }

            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.isConnected(a, b);
            }

            DateTime end = DateTime.Now;

            TimeSpan elapsedtime = end - start;

            Console.WriteLine("UnionFind2, " + 2 * n + " ops, " + elapsedtime.TotalSeconds + " s");
        }

        public static void testUF3(int n)
        {
            Random r = new Random();

            UnionFind3 uf = new UnionFind3(n);

            DateTime start = DateTime.Now;


            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.union(a, b);
            }

            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.isConnected(a, b);
            }

            DateTime end = DateTime.Now;

            TimeSpan elapsedtime = end - start;

            Console.WriteLine("UnionFind3, " + 2 * n + " ops, " + elapsedtime.TotalSeconds + " s");
        }

        public static void testUF4(int n)
        {
            Random r = new Random();

            UnionFind4 uf = new UnionFind4(n);

            DateTime start = DateTime.Now;


            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.union(a, b);
            }

            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.isConnected(a, b);
            }

            DateTime end = DateTime.Now;

            TimeSpan elapsedtime = end - start;

            Console.WriteLine("UnionFind4, " + 2 * n + " ops, " + elapsedtime.TotalSeconds + " s");
        }

        public static void testUF5(int n)
        {
            Random r = new Random();

            UnionFind5 uf = new UnionFind5(n);

            DateTime start = DateTime.Now;


            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.union(a, b);
            }

            for (int i = 0; i < n; i++)
            {
                int a = r.Next(n);
                int b = r.Next(n);
                uf.isConnected(a, b);
            }

            DateTime end = DateTime.Now;

            TimeSpan elapsedtime = end - start;

            Console.WriteLine("UnionFind5, " + 2 * n + " ops, " + elapsedtime.TotalSeconds + " s");
        }

    }
}
