using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Practise
{
    public class EfficientRoadNetwork
    {
    
        public bool efficientRoadNetwork(int n, int[][] roads)
        {

            if (roads.Length == 0)
                return false;



            int len1 = roads.Length;
            int len2 = roads[0].Length;
            int[][] res = new int[100][];
            int[,] count = new int[n, n];
            int k = 0;

            
            for (int i = 0; i < len1; i++)
            {
                int a = roads[i][0];
                int b = roads[i][1];
                count[a, b] = 1;
                count[b, a] = 1;
            }

            for(int i=0;i<n;i++ )
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        if (count[i, j] == 0)
                        {
                           bool c = find(i, j , count,n);
                            if (c == false)
                                return false;
                        }
                    }
                }
            }
          

            return true;
        }

        public bool find(int start, int des,int[,] count,int n)
        {
            for (int i = 0; i < n; i++)
            {
                int m;
                if (count[start, i] == 1)
                {
                    
                        if (count[i, des] == 1)
                            return true;
                    
                }
            }
            return false;
        }

      

    }
}