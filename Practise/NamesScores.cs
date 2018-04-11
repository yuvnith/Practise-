using System;
using System.IO;

namespace Practise
{
    public class NamesScores
    {
        public void demo2()
        {
            string n = File.ReadAllText("C:/Users/vamshikrishna.pabba/Desktop/p022_names.txt");
            n = n.Trim();
            string[] names = n.Split(',');

            Array.Sort(names,StringComparer.InvariantCulture);

            string a = names[0];
            long val = 0;


            for(int i=0;i<names.Length;i++)
            {
                string name = names[i];
                int val2 = 0;
                foreach (var i2 in name)
                {
                    if(char.IsLetter(i2))
                    val2 += ((int)i2-64);
                }
                val2 = val2 * (i + 1);
                val += val2;
            }

            Console.WriteLine(val);
        }
    }
}