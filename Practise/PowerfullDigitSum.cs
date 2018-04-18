using System;
using System.Numerics;

namespace Practise
{
    public class PowerfullDigitSum
    {
        public void Demo()
        {
            int max = Int32.MinValue;
            for (int i = 1; i < 100; i++)
            {
                for (int j = 1; j < 100; j++)
                {
                    BigInteger res = 0;
                    res = BigInteger.Pow(i, j);
                    int val = digitalProduct(res);
                    if (max < val)
                        max = val;
                }
            }

            Console.WriteLine("max:"+max);
        }

        public int digitalProduct(BigInteger no)
        {
            char[] nu = no.ToString().ToCharArray();
            int sum=0;
            foreach (var n in nu)
            {
                sum += int.Parse(n.ToString());
            }

            return sum;
        }
    }
}