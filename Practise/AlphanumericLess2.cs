using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Practise
{
    public class AlphanumericLess2
    {
        public bool alphanumericLess(string s1, string s2)
        {
            int len1 = s1.Length;
            int len2 = s2.Length;
            int max, v1=0, v2 = 0;
            if (len1 > len2)
                max = len1;
           else if (len2 < len1)
                max = len2;
            else
                max = len1;

            for (int i = 0; i < max; i++)
            {
                if (i < len1 )
                {
                    if (i < len2)
                    {
                        if (s1[i] != '0' && s2[i] != '0')
                        {
                            if ((int)s1[i] < (int)s2[i])
                                return true;
                            else if ((int)s1[i] > (int)s2[i])
                                return false;
                        }
                    }
                    else
                        return false;

                }
                else
                    return true;


            }




            return true;
        }
    }
}