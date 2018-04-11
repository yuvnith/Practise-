using System;
using System.Numerics;


namespace Practise
{
    public class Demo2
    {
        public long demo()
        {
            for (long i = 0; i < 50000; i++)
            {
                long val = 0;

                for (long j = 0; j <= i; j++)
                    val += j;

                int count = 0;
                for (long k = 1; k <= val; k++)
                {
                    if (val % k == 0)
                        count++;
                }

                if (count >= 500)
                    return val;
            }


            return 0;

        }


        public void demo2()
        {
            BigInteger fact =1;
            BigInteger i;
            fact = 1;
            for (i = 1; i <= 100; i++)
            {
                fact = BigInteger.Multiply(fact, i);
            }

            BigInteger sum = 0;
            string res = fact.ToString();
            for (int j = 0; j < res.Length; j++)
            {
                int no = int.Parse(res[j].ToString());
                sum += no;

            }



            Console.WriteLine(fact);
            Console.WriteLine(sum);
        }


      








    }
}