using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class BuildPalindrome
    {
        public string buildPalindrome(string st)
        {
            IEnumerable<char> rev = st.Reverse();

            string temp = st;

            foreach (var i in rev)
            {
                temp += i;
                IEnumerable<char> rev2 = temp;

                if (temp.Equals(rev2.ToString()))
                {
                    return temp;
                }
            }




            return temp;
        }
    }
}