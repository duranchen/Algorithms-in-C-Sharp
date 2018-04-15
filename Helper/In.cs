using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alogrithms.Helper
{
    public class In
    {

        public static int[] readInts(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);

            String fileContent = sr.ReadToEnd();

            string[] IntStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int[] a = new int[IntStrings.Length];

            for (int i = 0; i < IntStrings.Length; i++)
            {
                a[i] = int.Parse(IntStrings[i]);

            }

            return a;
        }
      
    }
}
