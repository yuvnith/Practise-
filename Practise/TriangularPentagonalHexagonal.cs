using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Practise
{
    public class TriangularPentagonalHexagonal
    {
        public void demo()
        {
            var tri = new List<BigInteger>();
            var pen = new List<BigInteger>();
            var hex = new List<BigInteger>();

            for (BigInteger i = 2; i < 5000000; i++)
            {
                tri.Add((i * (i + 1)) / 2);
                pen.Add((i * ((3 * i) - 1)) / 2);
                hex.Add(i * ((2 * i) - 1));

                Console.WriteLine(i);
            }
            var common1 = tri.Intersect(pen);
            var common2 = common1.Intersect(hex);

            foreach (BigInteger l in common2)
            {
                Console.WriteLine("Common :", l);
            }

            //BigInteger i = 5000;
            //Console.WriteLine((i * (i + 1)) / 2);
            //Console.WriteLine((i * ((3 * i) - 1)) / 2);
            //Console.WriteLine(i * ((2 * i) - 1));


        }
    }
}