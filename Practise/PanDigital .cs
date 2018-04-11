using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    public class PanDigital 
    {
        public void demo()
        {
            BigInteger tot = 0;
            var final = new List<double>();

            for (int i = 0; i < 9999; i++)
            {
                for (int j = 1; j < 9999; j++)
                {
                    int flag = 0;
                    var prod = i * j;
                    char[] temp = (prod+i.ToString()+j.ToString()).ToString().ToCharArray();

                    var temp2 = new List<char>();
                    foreach (var a in  temp)
                    {
                        if (a == '0')
                        {
                            flag = 1;
                        }
                            
                        else
                        {
                            if (temp2.Contains(a))
                            {
                               // break;
                                flag = 1;
                            }
                                
                            else
                                temp2.Add(a);
                        }
                    }
                    if (temp2.Count == 9 && flag==0)
                    {
                        tot += prod;
                        Console.WriteLine(i+" "+j+" "+prod+" "+tot);
                    }
                        

                }
            }
            Console.WriteLine(tot);
        }
    }
}