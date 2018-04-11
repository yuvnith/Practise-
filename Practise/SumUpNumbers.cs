using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practise
{
    public class SumUpNumbers
    {
        public int sumUpNumbers(string inputString)
        {



            string temp = inputString.Replace("," , string.Empty);
            //List<int> rates = new List<int>();
            int tot = 0;

            string[] digits = Regex.Split(temp, @"\D+");

            //string[] temp2 = temp.Split(' ');

            foreach (var s in digits)
            {
                int a;
                if (int.TryParse(s, out a))
                {
                    tot += a;
                }
            }




            //for (int i = 0; i < inputString.Length-1; i++)
            //{
            //    int a;
            //    if (int.TryParse(inputString[i].ToString(), out a))
            //    {
            //        int a1;
            //        if (int.TryParse(inputString[i+1].ToString(), out a1))
            //        {
            //            tot += a;
            //        }
            //    }
            //}



            return tot;
        }
    }
}