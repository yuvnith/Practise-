using System;
using System.Collections;
using System.Linq;
using System.Numerics;

namespace Practise
{
    public class SelfPowers
    {
        public void demo()
        {
            BigInteger res = 0;
            for (int i = 1; i <= 1000; i++)
            {
                BigInteger temp = BigInteger.Pow(i,i);
                res += temp;
            }

            IEnumerable rev = res.ToString().Reverse();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}


            Console.WriteLine(res);
        }
    }
}