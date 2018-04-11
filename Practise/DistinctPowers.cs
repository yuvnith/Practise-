using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Practise
{
    public class DistinctPowers
    {
        public void demo()
        {
            var res = new List<BigInteger>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    var temp = BigInteger.Pow(i,j);
                    res.Add(temp);
                }
            }

            var res2 = res.Distinct().ToArray();
            Array.Sort(res2);

            Console.WriteLine("count" + res2.Length);

        }
    }
}