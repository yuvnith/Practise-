using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    public class PentagonNumbers
    {
        public void demo()
        {
            BigInteger min = 4444444444444444444;
            List<BigInteger> numbers = new List<BigInteger>();

            for (int i = 1; i < 1000; i++)
            {
                BigInteger val = ((i) * ((3 * i) - 1)) / 2;

                if(!numbers.Contains(val))
                    numbers.Add(val);
            }

            Console.WriteLine("count: "+numbers.Count);

            for (int i = 0; i < numbers.Count; i++)
            {
               
                for (int j = 0; j < numbers.Count; j++)
                {
                    BigInteger a = numbers[i] + numbers[j];
                    BigInteger b = BigInteger.Abs(numbers[i] - numbers[j]);

                    if (numbers.Contains(a))
                    {
                        if (numbers.Contains(b))
                        {
                            BigInteger temp = BigInteger.Abs(a - b);
                            if (temp < min)
                                min = temp;
                        }
                    }
                }
            }



            Console.WriteLine("min is "+min );


        }
    }
}