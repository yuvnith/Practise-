using System;

namespace Practise
{
    public class NumberSpiralDiagonals
    {
        public void demo()
        {
            long res = 1, flag = 0, prev = 1, b = 2 ;


            for (int i = 1; i < 1001; i++)
            {
                long curr;
               
                if (flag < 4)
                {
                    curr = prev + b;
                    Console.WriteLine(curr);
                    res += curr;
                    prev = curr;
                   // Console.WriteLine(curr);
                    flag++;
                }
                else
                {
                    flag = 0;
                    b += 2;
                }
               

            }


            Console.WriteLine(res);


        }
    }
    //669 171 001
}