using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class UnionFind5
    {

        private int[] parent;
        private int[] rank;
        private int count;


        public UnionFind5(int n)
        {
            count = n;
            parent = new int[n];
            rank = new int[n];

            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
            }

            for (int i = 0; i < n; i++)
            {
                rank[i] = 1;
            }

        }

        public int find(int p)
        {
            //while (parent[p] != p)
            //{
            //    parent[p] = parent[parent[p]];
            //    p = parent[p];

            //}
            //return p;

            if(parent[p]!=p)
            {
                parent[p] = find(parent[p]);
            }
            return parent[p];
        }

        public void union(int p, int q)
        {

            int pRoot = find(p);
            int qRoot = find(q);

            if (pRoot == qRoot)
            {
                return;
            }
            if (rank[pRoot] > rank[qRoot])
            {
                parent[qRoot] = pRoot;

            }
            else if (rank[pRoot] < rank[qRoot])
            {
                parent[pRoot] = qRoot;
            }
            else
            {
                parent[pRoot] = qRoot;
                rank[qRoot]++;
            }
        }

        public bool isConnected(int p, int q)
        {
            return find(p) == find(q);
        }
    }
}
