using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class ReadGraph
    {

        public ReadGraph(Graph g,String fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            string firstLine = sr.ReadLine();

            string[] VE = firstLine.Split(' ');

            int V = int.Parse(VE[0]);
            int E = int.Parse(VE[1]);

            string line;
            while((line = sr.ReadLine()) != null)
            {
                string[] vw = line.Split(' ');
                int v = int.Parse(vw[0]);
                int w = int.Parse(vw[1]);
                g.addEdge(v, w);
            }

        }
    }
}
