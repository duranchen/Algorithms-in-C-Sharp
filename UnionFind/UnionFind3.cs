using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class UnionFind3
    {

        private int[] id;
        private int[] size;
        private int count;


        public UnionFind3(int n)
        {
            count = n;
            id = new int[n];
            size = new int[n];

            for(int i =0; i<n;i++)
            {
                id[i] = i;
            }

            for(int i =0;i<n;i++)
            {
                size[i] = 1;
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
            if(size[pID] > size[qID])
            {
                id[qID] = pID;
                size[pID] = size[pID] + size[qID];
            } else
            {
                id[pID] = qID;
                size[qID] = size[pID] + size[qID];
            }
        }
        
        public bool isConnected(int p, int q)
        {
            return find(p) == find(q);
        }
    }
}
