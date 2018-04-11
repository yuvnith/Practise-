using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class IntegerRightTriangles
    {
        public void demo()
        {
            int[] max = new int[1001];

            
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine(i);
                for (int j = 0; j < i; j++)
                {
                    for (int k = 0; k < i; k++)
                    {
                        
                        for (int l = 0; l < i; l++)
                        {
                            if (i == j + k + l)
                                if((j*j)+(k*k)==(l*l))
                                max[i]++;
                        }
                    }
                }
            }

            int maxValue = max.Max();
            int maxIndex = max.ToList().IndexOf(maxValue);

            Console.WriteLine("max : "+maxValue);
            Console.WriteLine("index: " + maxIndex);

        }
    }
}
