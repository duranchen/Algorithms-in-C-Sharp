using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName1 = "C:\\Users\\duran_k6g7e3i\\Documents\\Visual Studio 2017\\Projects\\Algorithms\\Graph\\testG1.txt";
            string fileName2 = "C:\\Users\\duran_k6g7e3i\\Documents\\Visual Studio 2017\\Projects\\Algorithms\\Graph\\testG2.txt";


            SparseGraph sparseGraph = new SparseGraph(13, false);
            ReadGraph rsg = new ReadGraph(sparseGraph, fileName1);

            Components sparseGraphCount = new Components(sparseGraph);

            Console.WriteLine("SparseGraph {0:D} components", sparseGraphCount.count());

            int v = 0, w = 4;
            Console.WriteLine("vertex {0:D} and vertex {1:D} connected: {2:D}",v,w,sparseGraphCount.isConnected(v, w));


            Path sgPath = new Path(sparseGraph, v);

            sgPath.printPath(w);

            sparseGraph.print();


            DenseGraph denseGraph = new DenseGraph(6, false);

            ReadGraph rdg = new ReadGraph(denseGraph, fileName2);

            Components denseGraphCount = new Components(denseGraph);

            Console.WriteLine("DenseGraph {0:D} components", denseGraphCount.count());

            Console.WriteLine("vertex {0:D} and vertex {1:D} connected: {2:D}", v, w, sparseGraphCount.isConnected(v, w));


            Path dgGath = new Path(denseGraph, v);
            dgGath.printPath(w);

            denseGraph.print();






        }
    }
}
