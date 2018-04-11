using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class NamingRoads
    {
        public bool namingRoads(int[][] roads)
        {
            int len1 = roads.Length;
            int len2 = roads[0].Length;
            Dictionary<int,int[]>  temp = new Dictionary<int, int[]>();

            for (int i = 0; i < len1; i++)
            {
                temp.Add(roads[i][2], new int[] { roads[i][0], roads[i][1] });

            }



            for (int i = 0; i < temp.Count-1; i++)
            {
                var val1 = temp[i];
                var val2 = temp[i+1];

                IEnumerable<int> both = val1.Intersect(val2);

                if (both.Count() > 0)
                {
                    return false;
                }
            }


            

            return true;

        }

    }
}