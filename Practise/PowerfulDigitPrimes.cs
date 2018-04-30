using System;
using System.Numerics;

namespace Practise
{
    public class PowerfulDigitPrimes
    {
        public void Demo()
        {
            int count = 0;
            for (BigInteger i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (BigInteger.Pow(i, j).ToString().Length == j)
                    {
                        Console.WriteLine(i+" "+j+" "+BigInteger.Pow(i, j));
                        count++;
                    }
                }
            }
        }
    }
}