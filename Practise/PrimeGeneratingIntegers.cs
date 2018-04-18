using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    public class PrimeGeneratingIntegers
    {
        public void demo()
        {
            BigInteger sum = 0;
            for (double i = 1; i < 100000000; i++)
            {
                

                List<double> temp = Factors(i);

                int flag = 0;
                foreach (var hh in temp )
                {
                    double te = hh + (i / hh);

                    if (!IsPrime(te))
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine(i);
                    sum += BigInteger.Parse(i.ToString());
                }
                    


            }



            Console.WriteLine(sum);
        }



        public List<double> Factors(double val)
        {
            var temp = new List<double>();
            for (double i = 1; i <= val; i++)
            {
                if(val%i == 0 )
                    temp.Add(i);
            }

            return temp;
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