using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class SquareDigitChains
    {
        public void demo()
        {
            long count = 0;

            for (BigInteger i = 9999991; i <= 10000000; i++)
            {
                Console.WriteLine(i);
                List<BigInteger> temp = new List<BigInteger>();
                temp.Add(i);
                BigInteger t = Sum(i);
                while(t!=89)
                {
                  
                    temp.Add(t);
                    t = Sum(t);

                    if (t == 1)
                        break;

                }

                if (t == 89)
                    count++;
               
            }


            Console.WriteLine("count:"+count);
        }


        public BigInteger Sum(BigInteger value)
        {
            char[] temp = value.ToString().ToCharArray();
            BigInteger sum = 0;
            foreach (var t in temp)
            {
                sum += (BigInteger.Parse(t.ToString())) * (BigInteger.Parse(t.ToString()));
            }
            return sum;
        }
    }
}
