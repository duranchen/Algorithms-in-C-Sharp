using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class UnionFind1
    {
        private int[] id;
        int count;

        public UnionFind1(int n)
        {
            count = n;

            id = new int[n];
            for(int i =0; i<n;i++)
            {
                id[i] = i;
            }
        }

        public int find(int p)
        {
            return id[p];
        }

        public void union(int p, int q)
        {
            int pID = id[p];
            int qID = id[q];

            if(pID == qID)
            {
                return;
            }
            
            for(int i = 0; i<count;i++)
            {
                if(id[i] == qID)
                {
                    id[i] = pID;
                }
            }
             
        }

        public bool isConnected(int p, int q)
        {
            return id[p] == id[q];
        }

    }
}
