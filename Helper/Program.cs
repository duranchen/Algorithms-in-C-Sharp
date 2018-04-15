using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(args[0]);

            int[] a = new int[N];

            Random random = new Random();
            
            for(int i = 0; i <N;i++)
            {
                a[i] = random.Next(-1000000, 1000000);
            }
        }
    }
}
