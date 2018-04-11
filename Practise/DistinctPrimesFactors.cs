using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class DistinctPrimesFactors
    {
        public void demo()
        {
            for (BigInteger i = 100000; i + 4 < 1000000; i++)
            {
                Console.WriteLine(i);
                var l1 = Generate(i);
                if (l1.Count >= 4)
                {
                    var l2 = Generate(i + 1);
                    if (l2.Count >= 4)
                    {
                        var l3 = Generate(i + 2);
                        if (l3.Count >= 4)
                        {
                            var l4 = Generate(i + 3);
                            if (l4.Count >= 4)
                            {
                                Console.WriteLine("Res:" + i);
                                break;

                            }



                        }
                    }
                }
            }

            //var l1 = Generate(3624);
            //foreach (var b in l1)
            //{
            //    Console.WriteLine(b);
            //}
        }


        public static List<BigInteger> Generate(BigInteger number)
        {
            var primes = new List<BigInteger>();

            for (BigInteger div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    if(!primes.Contains(div))
                    primes.Add(div);
                    number = number / div;
                }
            }
            return primes;
        }
    }
}
