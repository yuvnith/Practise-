using System.Linq;

namespace Practise
{
    public class LongestWord
    {
        public string longestWord(string text)
        {
            string s = string.Empty;

            foreach (var i in text)
            {
                int ascii = (int) i;
                if ((ascii >= 65 && ascii <= 90) || (ascii >= 97 && ascii <= 122) || ascii==32)
                    s += i.ToString();
                else
                    s += ' ';
            }

            string[] res = s.Split(' ');

            string longest = res.OrderByDescending(s2 => s2.Length).First();

            return longest;
        }



        public bool validTime(string time)
        {
            string[] temp = time.Split(':');

            if (int.Parse(temp[0]) < 24 && int.Parse(temp[1]) < 60)
                return true;


            return false;
        }

    }
}