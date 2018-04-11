using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class PandigitalPrime
    {
        public void demo()
        {
            long prime = 0;
            for (long i = 1; i < 999999999; i++)
            {
                if (isPanDigital(i))
                {
                    if (isPrime(i))
                    {
                        Console.WriteLine(i);
                        prime = i;
                    }
                }
            }

            Console.WriteLine("largest prime is :"+prime);

        }


        bool isPrime(long number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (long i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        bool isPanDigital(long val)
        {
            char[] value = val.ToString().ToCharArray();
            int len = val.ToString().Length;
            List<string> temp = new List<string>();

            foreach (var c in value)
            {
                if (c == '0')
                    return false;

                if (temp.Contains(c.ToString()))
                    return false;
                else
                    temp.Add(c.ToString());
            }
            for (int i = 1; i <= len; i++)
            {
                string c = i.ToString();
                if (!temp.Contains(c))
                    return false;
            }

            return true;
        }
    }
}