using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practise
{
    public class MessageFromBinaryCode
    {
        public string messageFromBinaryCode(string code)
        {

           // string[] digits = Regex.Split(code, @"\d+8");
            string res = string.Empty;
            MatchCollection mc = Regex.Matches(code, @"\w{8}");

            foreach (var i in mc)
            {
                int temp = Convert.ToInt32(i.ToString(),2);
                char ch = (char) temp;
                res+= ch.ToString();
            }


            return res;
        }

    }
}