using System.Collections.Generic;

namespace Practise
{
    public class PairOfShoes
    {
        public bool pairOfShoes(int[][] shoes)
        {
            var dict = new Dictionary<int,int>();
            var dict2 = new Dictionary<int, int>();
            int len = shoes.Length;
            for (int i = 0; i < len; i++)
            {
                if (shoes[i][0] == 0)
                {
                    if (dict.ContainsKey(shoes[i][1]))
                        dict[shoes[i][1]] += 1;
                    else
                        dict[shoes[i][1]] = 1;

                }

                else if (shoes[i][0] == 1)
                {
                    if (dict2.ContainsKey(shoes[i][1]))
                        dict2[shoes[i][1]] += 1;
                    else
                        dict2[shoes[i][1]] = 1;

                }
            }

            int flag = 0;

            for (int i = 0; i < len; i++)
            {
                if (dict.ContainsKey(shoes[i][1]) && dict2.ContainsKey(shoes[i][1]))
                {
                    if (dict[shoes[i][1]] == dict2[shoes[i][1]] )
                        flag++;

                }
            }

            if (flag == len)
                return true;
            else
                return false;
        }

    }
}