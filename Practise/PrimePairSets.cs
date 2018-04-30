using System;
using System.Collections.Generic;

namespace Practise
{
    public class PrimePairSets
    {
        public void demo()
        {
             List<double> primes = new List<double>();
            double min = double.MaxValue;

            for (int i = 0; i < 1000; i++)
            {
                 if(IsPrime(i))
                    primes.Add(i);
            }

            for (int i = 0; i < primes.Count; i++)
            {
                for (int j = i + 1; j < primes.Count; j++)
                {
                    string a = i.ToString() + j.ToString();
                    string b = j.ToString() + i.ToString();

                    if (IsPrime(double.Parse(a)))
                    {
                        if (IsPrime(double.Parse(b)))
                        {
                            double temp = i + j + double.Parse(a) + double.Parse(b);
                            if (min > temp)
                                min = temp;
                        }
                    }
                }
            }

            Console.WriteLine("res:"+min);
        }
        public static bool IsPrime(double number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var boundary = (double)Math.Floor(Math.Sqrt(number));
            for (double i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}