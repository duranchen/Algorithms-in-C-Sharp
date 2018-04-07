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
            string fileName = "C:\\Users\\duran_k6g7e3i\\Documents\\Visual Studio 2017\\Projects\\Algorithms\\Graph\\testG1.txt";

            SparseGraph sg = new SparseGraph(13, false);
            ReadGraph rsg = new ReadGraph(sg, fileName);

            sg.print();
            DenseGraph dg = new DenseGraph(13, false);

            ReadGraph rdg = new ReadGraph(dg,fileName);

            dg.print();



        }
    }
}
