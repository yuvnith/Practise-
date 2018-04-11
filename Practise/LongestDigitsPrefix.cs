using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class LongestDigitsPrefix
    {
        public string longestDigitsPrefix(string inputString)
        {
            string res = string.Empty;
            foreach (var i in inputString)
            {
                int a;
                if (int.TryParse(i.ToString(), out a))
                {
                    res += a.ToString();
                }
                else
                    return res;
            }
            return res;
        }

    }
}
