using System;
using System.Collections.Generic;

namespace Practise
{
    public class ChampernownesConstant
    {
        public void demo()
        {
             List<char> digits = new List<char>();
            int i = 1;
            while (digits.Count < 1000000)
            {
                char[] temp = i.ToString().ToCharArray();

                foreach (var c in temp)
                {
                    digits.Add(c);
                }
                i++;
            }

            Console.WriteLine("1:"+digits[0]);
            Console.WriteLine("10:" + digits[10-1]);
            Console.WriteLine("100:" + digits[100-1]);
            Console.WriteLine("1000:" + digits[1000-1]);
            Console.WriteLine("10000:" + digits[10000-1]);
            Console.WriteLine("100000:" + digits[100000-1]);
            Console.WriteLine("1000000:" + digits[1000000-1]);



        }
    }
}