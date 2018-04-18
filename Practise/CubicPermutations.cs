using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Practise
{
    public class CubicPermutations
    {
        public void demo()
        {
            Dictionary<BigInteger,BigInteger> Cubics = new Dictionary<BigInteger, BigInteger>();
            Dictionary<string, int> S = new Dictionary<string, int>();


            for (BigInteger i = 1; i < 100000; i++)
            {
                BigInteger te = i * i * i;
                Cubics.Add(i,te);
                string t = te+ "";
                string temp = Simplify(t);

                if (S.ContainsKey(temp))
                    S[temp] += 1;
                else
                {
                    S.Add(temp,1);
                }
            }


            foreach (var s in Cubics)
            {
                Console.WriteLine(s.Key);
                string temp = Simplify(s.Value.ToString());

                if (S.ContainsKey(temp))
                {

                    if (S[temp] == 5)
                    {
                        Console.WriteLine("Result:" + s.Key);
                        break;
                    }
                }
            }

            BigInteger tem2 =BigInteger.Multiply(5027,5027);
            BigInteger tem3 = BigInteger.Multiply(tem2,5027);
            Console.WriteLine(tem3);


        }

        public string Simplify(String val)
        {
            char[] temp = val.ToCharArray();
            Array.Sort(temp);
             string t = new string(temp);
            return t;


        }


        
    
    }
}