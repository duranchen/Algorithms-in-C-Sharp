using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Components
    {
        Graph G;
        private int ccount;
        private bool[] visited;
        private int[] id;

        private void dfs(int v)
        {
            visited[v] = true;
            id[v] = ccount;
            List<int> adjV = (List<int>)G.adj(v);
            foreach( int i in adjV)
            {
               
                if (visited[i] == false)
                { 
                    dfs(i);
                }
            }
        }

        public Components(Graph graph)
        {
            G = graph;
            ccount = 0;
            visited = new bool[G.V()];
            id = new int[G.V()];

            for (int i =0; i < G.V();i++)
            {
                visited[i] = false;
                id[i] = -1;
            }


            for(int i = 0; i<G.V();i++)
            {
                if(visited[i] == false)
                {
                    dfs(i);
                    ccount++;
                }
            }
        }

        public int count()
        {
            return ccount;
        }

        public bool isConnected(int v, int w)
        {
            return id[v] == id[w];
        }

    }
}
