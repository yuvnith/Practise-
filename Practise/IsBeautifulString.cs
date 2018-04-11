using System.Collections.Generic;

namespace Practise
{
    public class IsBeautifulString
    {
        public bool isBeautifulString(string inputString)
        {
            char[] ip = inputString.ToCharArray();
            Dictionary<int,int> count = new Dictionary<int,int>();
           
            for (int i = 97; i <= 122; i++)
            {
                count[i] = 0;
            }
            foreach (var i in inputString)
            {
                count[(int) i] += 1;
            }
            int max = count[97];
            for (int k=0; k<inputString.Length;k++)
            {
                if (max < count[inputString[k]])
                    return false;
            }
            return true;
        }
    }
}