using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Path
    {
        private Graph G;
        private int source;
        private bool[] visited;
        private int[] from;

        public Path(Graph graph,int s)
        {
            G = graph;
            visited = new bool[G.V()];
            from = new int[G.V()];
            for(int i = 0; i<G.V();i++)
            {
                visited[i] = false;
                from[i] = -1;
            }
            this.source = s;

            dfs(s);
        }

        private void dfs(int v)
        {
            visited[v] = true;
            List<int> adjV = (List<int>)G.adj(v);
            foreach (int i in adjV)
            {

                if (visited[i] == false)
                {
                    from[i] = v;
                    dfs(i);
                }
            }
        }

        public bool hasPath(int w)
        {
            return visited[w];
        }

        public List<int> path(int w)
        {
            int p = w;

            List<int> vec = new List<int>();
            Stack<int> stack = new Stack<int>();
            
            while(from[p] != -1)
            {
                stack.Push(p);
                p = from[p];
            }

            if(stack.Count != 0 )
            {
                stack.Push(p);
            }
            

            foreach(int v in stack)
            {
                vec.Add(v);
            }

            return vec;
        }

        public void printPath(int w)
        {
            List<int> path = new List<int>();

            path = this.path(w);


            Console.Write("{0:D} to {1:D} Path: ", source,w);
            foreach (int i in path)
            {
                Console.Write("{0:D} ", i);
            }
            Console.WriteLine();
        }

    }
}
