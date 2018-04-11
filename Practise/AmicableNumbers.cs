using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    public class AmicableNumbers
    {
        public void demo()
        {
            int tot = 0;
            for (int i = 0; i < 10000; i++)
            {
                BigInteger temp = Factor(i);

                if (Factor(temp) == i)
                {
                    
                    if (temp != i)
                    {
                        Console.WriteLine(temp);
                        tot += i;
                    }
                    
                }
                    
            }
            Console.WriteLine(tot);
        }
        public BigInteger Factor(BigInteger number)
        {
            BigInteger sum = 0;
            for (int x = 1; x<number; x++)
            {
                if (number % x == 0)
                {
                    sum += x;
                }
            }
            return sum;
        }
    }
}