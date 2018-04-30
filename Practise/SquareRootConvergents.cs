using System;
using System.Numerics;

namespace Practise
{
    public class SquareRootConvergents
    {
        public void demo()
        {
            BigInteger a = 3, b = 2, count = 0;

            for (double i = 1; i < 1000; i++)
            {
                BigInteger a2 = a + (2 * b);
                BigInteger b2 = a + b;

                if (a2.ToString().Length > b2.ToString().Length)
                {
                    count++;
                    Console.WriteLine(a2+"/"+b2);
                }
                    

                a = a2;
                b = b2;

            }
            Console.WriteLine("res:"+count);
        }
    }
}