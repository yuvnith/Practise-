using System;
using System.Linq;

namespace Practise
{
    public class RoadsBuilding
    {
        public int[][] roadsBuilding(int cities, int[][] roads)
        {
            if (cities == 1)
            {
                int[][] res2 = new int[1][];
                return res2;
            }

            int len1 = roads.Length;
            int len2 = roads[0].Length;
            int[][] res =new int[100][];
            int[,] count = new int[cities,cities];
            int k = 0;

            


            for (int i = 0; i < len1; i++)
            {
                int a = roads[i][0];
                int b = roads[i][1];
                count[a,b] = 1;
                count[b, a] = 1;
            }

            for (int i = 0; i < cities; i++)
            {
                for (int j = 0; j < cities; j++)
                {
                    if (i != j)
                    {
                        if (count[i, j] == 0)
                        {
                            if (i < j)
                            {
                                res[k] = new int[] {i,j };
                                k++;

                            }
                        }
                    }

                }
            }
            Array.Resize(ref res,k);


            




            return res;
        }


    }
}