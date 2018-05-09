using System;
using System.Numerics;

namespace Practise
{
    public class CombinatoricSelections
    {
        public void demo()
        {
            int count = 0;


            for (int i = 5; i <= 100; i++)
            {
               
                for (int j = 3; j <= i; j++)
                {
                    BigInteger res = Combination(i, j);
                    Console.WriteLine(res);
                    if (res > 1000000)
                        count++;
                }
            }
            Console.WriteLine("result: "+count);

        }


        public BigInteger fact(int n)
        {
            BigInteger f = 1;
            for (int i = n; i > 1; i--)
                f = f * i;
            if (n == 0)
                return 1;

            return f;
        }

        public BigInteger Combination(int n, int r)
        {
            BigInteger numerator = fact(n);
            BigInteger denom = fact(r) * fact(n - r);

            return numerator / denom;
        }
    }
}