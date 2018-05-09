using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class CurrentBuffer
    {

        public static int twoStacks(int x, int[] a, int[] b)
        {
            int count = 0, aa = 0, bb = 0, sum = 0;

            Stack<int> astack = new Stack<int>(a.Reverse());
            Stack<int> bstack = new Stack<int>(b.Reverse());
            while (sum <= x)
            {
                int temp1 = int.MaxValue,temp2 = int.MaxValue;
                if (astack.Count != 0)
                     temp1 = astack.Peek();
       

                if (bstack.Count != 0)
                     temp2 = bstack.Peek();


                if (temp1 < temp2)
                {
                    if (sum + temp1 <= x)
                    {
                        sum += temp1;
                        count++;
                        astack.Pop();
                    }
                    else
                    {
                        return count;
                    }
                }
                else
                {
                    if (sum + temp2 <= x)
                    {
                        sum += temp2;
                        count++;
                        bstack.Pop();
                    }
                    else
                        return count++;
                }
            }
            return count;
        }
    }
}
