using System;

namespace Practise
{
    public class SpiralPrimes
    {
        public void demo()
        {
            double percentage=double.MaxValue;
            double a = 2,
                i = 1;
            int length = 3;


            double primecount = 0, totalcount = 0;

            while (percentage > 10)
            {
                i += a;

                totalcount++;
                if (IsPrime(i))
                    primecount++;

                double temp = Math.Sqrt(i);
                double t = temp % 1;

                if (temp % 1 == 0)
                {
                    i += 2;

                    percentage = (primecount / totalcount) * 100;
                    length += 2;

                    Console.WriteLine(percentage);
                }

            }

            Console.WriteLine(length);



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