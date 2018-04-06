using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class UnionFind2
    {

        private int[] id;
        private int count;

        public UnionFind2(int n)
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
            while(id[p] != p)
            {
                p = id[p];

            }

            return id[p];
        }

        public void  union(int p, int q)
        {

            int pID = find(p);
            int qID = find(q);

            if(pID == qID)
            {
                return;
            }
            id[pID] = qID;
        }
        
        public bool isConnected(int p, int q)
        {
            return find(p) == find(q);
        }
    }
}
