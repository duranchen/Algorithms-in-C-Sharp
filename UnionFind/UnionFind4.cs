using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class UnionFind4
    {

        private int[] id;
        private int[] rank;
        private int count;


        public UnionFind4(int n)
        {
            count = n;
            id = new int[n];
            rank = new int[n];

            for(int i =0; i<n;i++)
            {
                id[i] = i;
            }

            for(int i =0;i<n;i++)
            {
                rank[i] = 1;
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
            if(rank[pID] > rank[qID])
            {
                id[qID] = pID;
                
            } else if(rank[pID] < rank[qID])
            {
                id[pID] = qID;
            } else
            {
                id[pID] = qID;
                rank[qID]++;
            }
        }
        
        public bool isConnected(int p, int q)
        {
            return find(p) == find(q);
        }
    }
}
