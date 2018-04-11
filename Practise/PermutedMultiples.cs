using System;
using System.Numerics;

namespace Practise
{
    public class PermutedMultiples
    {
        public void Demo()
        {
            for (int i = 100000; i < 1000000; i++)
            {
               
                BigInteger x2 = i * 2, x3 = i * 3, x4 = i * 4, x5 = i * 5, x6 = i * 6;

                char[] xx2 = x2.ToString().ToCharArray();
                Array.Sort(xx2);

                char[] xx3 = x3.ToString().ToCharArray();
                Array.Sort(xx3);

                char[] xx4 = x4.ToString().ToCharArray();
                Array.Sort(xx4);

                char[] xx5 = x5.ToString().ToCharArray();
                Array.Sort(xx5);
                char[] xx6 = x6.ToString().ToCharArray();
                Array.Sort(xx6);


                string xxx2 = new string(xx2);
                string xxx3 = new string(xx3);
                string xxx4 = new string(xx4);
                string xxx5 = new string(xx5);
                string xxx6 = new string(xx6);


                if(xxx2 == xxx3)
                    if (xxx2 == xxx4)
                        if (xxx2 == xxx5)
                            if (xxx2 == xxx6)
                            {
                                Console.WriteLine("final :"+i);
                                break;
                            }
            }
        }
    }
}