using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class BeautifulText
    {
        public bool beautifulText(string inputString, int l, int r)
        {
           var ind = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i] ==' ')
                    ind.Add(i);
            }

            for (int i = 0; i < ind.Count; i++)
            {
                int a = ind[i];
                int flag = 0;
                if(a >= l && a <= r)
                while (a <= inputString.Length )
                {
                    if (a == inputString.Length)
                        flag++;
                    else if (inputString[a] != ' ')
                    {
                        flag = 1;
                        break;
                    }
                    else
                        flag++;

                    a += ind[i];
                    a++;
                }
                if ((flag*ind[i])+flag-1 == inputString.Length )
                    return true;
            }
            return false;

        }

        

    }
}