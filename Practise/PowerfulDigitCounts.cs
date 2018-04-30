using System;
using System.Collections.Generic;

namespace Practise
{
    public class PowerfulDigitCounts
    {
        public void demo()
        {
            int to = int.MaxValue,count = 0;

            var temp = new Dictionary<double,int>();


            for (int i = 1; i <= 10000; i++)
            {
               // Console.WriteLine(i);
                for (int j = 1; j <= 30; j++)
                {
                    
                    var temp2 = Math.Pow(i, j);

                    if (temp2 > to)
                        break;


                    if (temp2.ToString().Length == j && temp2 <= to)
                    {
                        Console.WriteLine(i+"pow"+j+"is"+temp2);
                        count++;
                    }
                        
                }
                    
            }

            Console.WriteLine(count);

        }
    }
}