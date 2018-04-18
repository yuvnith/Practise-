using System;
using System.Numerics;

namespace Practise
{
    public class LychrelNumbers
    {
        public void demo()
        {
            int count = 0;
            for (int i = 196; i < 10000; i++)
            {
                Console.WriteLine(i);
                BigInteger t = i;
                int flag = 0;
                for (int j = 0; j < 50; j++)
                {
                    char[] t2 = t.ToString().ToCharArray();
                    Array.Reverse(t2);
                    BigInteger t3 = BigInteger.Parse(new string(t2));

                    t += t3;

                    string a = t.ToString();
                    char[] b = t.ToString().ToCharArray();
                    Array.Reverse(b);
                    string c = new string(b);

                    if (a == c)
                    {
                        flag = 1;
                        break;
                    }
                        

                }
                if (flag == 0)
                    count++;
            }

            Console.WriteLine(count);
        }

    }
}