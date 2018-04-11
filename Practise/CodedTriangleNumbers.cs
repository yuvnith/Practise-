using System;
using System.Collections.Generic;
using System.IO;

namespace Practise
{
    public class CodedTriangleNumbers
    {
        public void demo()
        {
            int count = 0;
            var triangles = new List<double>();
            for (int i = 1; i < 100; i++)
            {
                double val = (0.5) * (i) * (i + 1);
                triangles.Add(val);
            }
            string file = File.ReadAllText("D:/words.txt");
            string[] words = file.Split(',');

            foreach (var word in words)
            {
                if (triangles.Contains(alpha(word)))
                    count++;
            }

            Console.WriteLine(count);
        }

        public long alpha(string  a )
        {
            a=a.Trim('"');
            a=a.Trim('\\');
            long val = 0;

            foreach (var c in a)
            {
                val += ((int) c)-64;
            }
            return val;
        }
    }
}