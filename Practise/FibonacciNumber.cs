using System;
using System.Numerics;

namespace Practise
{
    public class FibonacciNumber
    {
        public void generate()
        {
            int count = 3;
            BigInteger a = 1, b = 1;
            BigInteger c = a + b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            while (c.ToString().Length < 1000)
            {
                if (c.ToString().Length == 1000)
                    break;
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine(c);
                count++;
            }
            Console.WriteLine("final"+c);
            Console.WriteLine("count"+count);
        }
    }
}