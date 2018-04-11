using System;
using System.Collections.Generic;

namespace Practise
{
    public class LineEncoding
    {
        public string lineEncoding(string s)
        {
            //int[] dt = new int[1000];
            //string res = string.Empty;
            //string res2 = string.Empty;

            //char[] c = s.ToCharArray();

            //foreach (var cc in  c)
            //{   
            //    if (dt[(int) cc] != 0)
            //        dt[(int) cc] += 1;
            //    else
            //    {
            //        dt[(int) cc] = 1;
            //        res += cc.ToString();
            //    }
            //}

            //foreach (var c1 in res)
            //{
            //    if (dt[(int) c1] > 1)
            //    {
            //        res2 += dt[(int) c1];
            //        res2 += c1.ToString();
            //    }
            //    else
            //    {
            //        res2 += c1.ToString();
            //    }
            //}


            //abbcabb

            int count = 0;
            string res = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length-1)
                {
                    if (s[i] != s[i - 1])
                        res += s[i];
                    else
                        res += (count+1).ToString() + s[i];

                    return res;
                }


                else
                {
                    if (s[i] == s[i + 1])
                        count += 1;
                    else
                    {
                        if (count+1 == 1)
                            res += s[i];
                        else if (count+1 > 0)
                            res += (count+1).ToString() + s[i];
                        else
                            res += s[i];
                        count = 0;
                    }


                }

            }

            return res;


            //return res2;
        }

    }
}