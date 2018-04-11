using System.Collections.Generic;

namespace Practise
{
    public class ArrayPreviousLess
    {
        public int[] arrayPreviousLess(int[] items)
        {
            var temp = new List<int>(items);
            for (int i = 0; i < items.Length; i++)
            {
                int flag = 0;
                var temp2 = 0;
                for (int j = 0; j < i; j++)
                {
                    if (items[j] < items[i])
                    {
                        temp2 = items[j];
                        flag = 1;
                    }
                }

                if (flag == 0)
                    temp[i] = -1;
                else
                    temp[i] = temp2;

            }

            return temp.ToArray();
        }

    }
}