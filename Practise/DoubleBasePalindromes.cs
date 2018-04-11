using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class DoubleBasePalindromes
    {
        public void demo()
        {
            double sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                var result = Convert.ToString(i, 2);
                if (Palindrome(result))
                {
                    if (Palindrome(i.ToString()))
                    {
                        sum += i;
                        Console.WriteLine(i+" "+result);
                    }
                        

                }
            }

            Console.WriteLine(sum);
        }

        public static bool Palindrome(string no)
        {
            var rev = no.Reverse();

            string temp = string.Empty;
            foreach (var r in rev)
            {
                temp += r.ToString();
            }
            if (temp == no)
                return true;
            else
                return false;

        }
    }
}