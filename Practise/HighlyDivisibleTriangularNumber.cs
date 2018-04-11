using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    public class HighlyDivisibleTriangularNumber
    {
        public void demo()
        {


            for (int i = 1; i < 100000; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i; j++)
                {
                    sum += j;
                }
              //  Console.WriteLine(sum);
                var temp = Factor(sum);
                Console.WriteLine(i + "  " + temp.Count + " ");
                if (temp.Count > 500)
                {
                   Console.WriteLine(sum);
                    break;
                }




            }
        }
        public List<int> Factor(int number)
        {
            List<int> factors = new List<int>();
            int max = (int)Math.Sqrt(number);  
            for (int factor = 1; factor <= max; ++factor)
            {
                if (number % factor == 0)
                {
                    factors.Add(factor);
                    if (factor != number / factor)
                    { 
                        factors.Add(number / factor);
                    }
                }
            }
            //Console.WriteLine(factors.Count);
            return factors;
        }
    }
}