using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class ArrayConversion
    {
        public int arrayConversion(int[] inputArray)
        {
            var li = inputArray.ToList();
            int i = 1;
            while (li.Count != 1)
            {
                var temp = new List<int>();
                if (i % 2 != 0)
                {
                    for (int j = 0; j + 1 < li.Count; j++)
                    {
                        var a = li[j];
                        var b = li[j+1];
                        temp.Add(a + b);
                        j++;
                    }

                }
                else
                {
                    for (int j = 0; j + 1 < li.Count; j++)
                    {
                        var a = li[j];
                        var b = li[j + 1];
                        temp.Add(a * b);
                        j++;
                    }
                }
                li = new List<int>(temp);

                i++;
            }
            return li[0];
        }
    }
}