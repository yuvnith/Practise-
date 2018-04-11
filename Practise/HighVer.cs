using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Practise
{
    public class HighVer
    {
        public bool main(string ver1, string ver2)
        {
            string[] ls1 = ver1.Split('.');
            //string tmpls1 = string.Empty;
            int[] tmpls1 = new int[ls1.Length];
            for (int i = 0; i < tmpls1.Length; i++)
            {
                tmpls1[i] = int.Parse(ls1[i]);
            }
            string[] ls2 = ver2.Split('.');
            //string tmpls2 = string.Empty;
            int[] tmpls2 = new int[ls2.Length];
            for (int i = 0; i < tmpls2.Length; i++)
            {
                tmpls2[i] = int.Parse(ls2[i]);
            }

            for (int i = 0; i < tmpls1.Length; i++)
            {
                if (tmpls1[i] > tmpls2[i])
                {
                    return true;
                }
                else if (tmpls1[i] < tmpls2[i])
                {
                    return false;
                }
            }

            /*foreach (var s in ls2)
            {
                int count = 0;
                foreach (var s2 in s)
                {
                    if (count == 0)
                    {
                        if (s2 != '0')
                        {
                            tmpls2 += s2.ToString();
                        }
                        else
                        {
                            count = -1;
                        }
                    }
                    else
                    {
                        tmpls2 += s2.ToString();
                    }
                    count++;
                }
            }*/
            return false;
        }
    }
}