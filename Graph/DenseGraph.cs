using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class DenseGraph
    {
        private int n; //顶点数
        private int m; //边数
        private bool directed;
        private bool[,] g;

        public DenseGraph(int n, bool directed)
        {
            this.n = n;
            this.m = 0;
            this.directed = directed;
            for(int i=0;i<n;i++)
            {
                for(int j = 0; j<n;j++)
                {
                    g[i,j] = false;
                }
            }
        }

        public  int V()
        {
            return n;
        }

        public int E()
        {
            return m;
        }

        public bool hasEdge(int v,int w)
        {
            return g[v,w];
        }

        public void addEdge(int v, int w)
        {
            if(hasEdge(v,w))
            {
                return;
            }

            g[v, w] = true;

            if (directed == false)
            {
                g[w, v] = true;
            }

            m++;
        }

        public IEnumerable<int> adj(int v)
        {

            List<int> adjv = new List<int>();
            for(int i = 0; i<n;i++)
            {
                if (g[v,i] == true)
                {
                    adjv.Add(i);
                }
            }

            return adjv;
        }
    }
}
