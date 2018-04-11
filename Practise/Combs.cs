using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Combs
    {
        public int combs(string comb1, string comb2)
        {
            int flag = 0, a = 0;
            while (flag == 0)
            {
                for (int i = 0; i < comb2.Length; i++)
                {
                    if (comb1[i] == comb2[i+a])
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 0)
                    a++;
                else
                    break;
            }

        }

    }
}
