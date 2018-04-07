using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class SparseGraph:Graph
    {
        int n;
        int m;
        bool directed;
        List<int>[] g;

        public SparseGraph(int n, bool directed)
        {
            this.n = n;
            this.m = 0;
            this.directed = directed;

            g = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                g[i] = new List<int>();
            }
        }

        public int V()
        {
            return n;
        }

        public int E()
        {
            return m;
        }

        public bool hasEdge(int v, int w)
        {
            return g[v].Contains(w);
        }

        public void addEdge(int v, int w)
        {
            if(hasEdge(v,w) == true)
            {
                return;
            }

            g[v].Add(w);

            if(directed == false)
            {
                g[w].Add(v);
            }
            m++;
        }

        public IEnumerable<int> adj(int v)
        {
            return g[v];
        }

        public void print()
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vertex {0:D} : ", i);
                List<int> adjV = (List<int>)adj(i);
                foreach (int v in adjV)
                {
                    Console.Write("{0:D} ", v);
                }

                Console.WriteLine();
            }

        }
    }
}
