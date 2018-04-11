using System;
using System.Numerics;

namespace Practise
{
    public class FifthPowers 
    {
        public void Cal()
        {
            BigInteger sum = 0;
            int count = 0;
            for (int i = 2; i < 1000000; i++)
            {
                if (i == indiv(i))
                {
                    sum += i;
                    count++;
                    Console.WriteLine(i);
                }
                    
            }
            Console.WriteLine("sum:"+sum);
        }

        public BigInteger indiv(int i)
        {
            char[] temp = i.ToString().ToCharArray();
            BigInteger sum = 0;

            foreach (var c in temp)
            {
                sum += BigInteger.Pow(BigInteger.Parse(c.ToString()),5);
            }
           
            return sum;
        }
    }
}