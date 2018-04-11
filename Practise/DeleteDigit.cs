using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class DeleteDigit
    {
       public  int deleteDigit(int n)
        {
            char[] s = n.ToString().ToCharArray();
            int max = 0;
           

            for (int i = 0; i < s.Length; i++)
            {
                char[] t = n.ToString().ToCharArray();
                t[i] = ' ';
                string res = new string(t);
                res = res.Replace(" ", String.Empty);
                //res = res.Trim();

                if (max < int.Parse(res.ToString()))
                    max = int.Parse(res.ToString());

            }
            return max;

        }
        

    }
}
