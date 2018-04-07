using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    interface Graph
    {
        int V();
        int E();
        void addEdge(int v, int w);
        bool hasEdge(int v, int w);
        IEnumerable<int> adj(int v);
        void print();
    }
}
