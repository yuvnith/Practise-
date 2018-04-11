using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    public class SubStringDivisibility
    {
        public void demo()
        {
            BigInteger sum = 0;
            for (BigInteger i = 1000000000; i < 10000000000; i++)
            {
               Console.WriteLine(i);
                if (isPanDigital(i.ToString().ToCharArray()))
                {
                    char[] temp = i.ToString().ToCharArray();
                    string d2 = temp[1] + temp[2] + temp[3] + "";
                    string d3 = temp[2] + temp[3] + temp[4] + "";
                    string d5 = temp[3] + temp[4] + temp[5] + "";
                    string d7 = temp[4] + temp[5] + temp[6] + "";
                    string d11 = temp[5] + temp[6] + temp[7] + "";
                    string d13 = temp[6] + temp[7] + temp[8] + "";
                    string d17 = temp[7] + temp[8] + temp[9] + "";

                    if (int.Parse(d2) % 2 == 0)
                    {
                        if (int.Parse(d3) % 3 == 0)
                        {
                            if (int.Parse(d5) % 5 == 0)
                            {
                                if (int.Parse(d7) % 7 == 0)
                                {
                                    if (int.Parse(d11) % 11 == 0)
                                    {
                                        if (int.Parse(d13) % 13 == 0)
                                        {
                                            if (int.Parse(d17) % 17 == 0)
                                            {
                                                sum += i;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }


                }
            }

            Console.WriteLine("sum : "+sum);
        }



        bool isPanDigital(char[] value)
        {
            int len = value.Length;
            List<string> temp = new List<string>();

            foreach (var c in value)
            {
               if (temp.Contains(c.ToString()))
                    return false;
                else
                    temp.Add(c.ToString());
            }
            
                if (temp.Count!=10)
                    return false;
            

            return true;
        }
    }
}