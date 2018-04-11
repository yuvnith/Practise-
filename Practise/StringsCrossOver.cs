using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class StringsCrossOver
    {
        public int stringsCrossover(String[] inputArray, String result)
        {
            int count = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    int flag = 0;
                    string a = inputArray[i];
                    string b = inputArray[j];


                    for (int k = 0; k < a.Length; k++)
                    {
                        if (a[k] == result[k] || b[k] == result[k])
                            flag++;
                        else
                        {
                            break;
                        }
                    }

                    if (flag == a.Length)
                        count++;


                }
            }
            return count;
        }

    }
}
