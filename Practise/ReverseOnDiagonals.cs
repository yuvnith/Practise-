using System;

namespace Practise
{
    public class ReverseOnDiagonals
    {
        public int[][] reverseOnDiagonals(int[][] matrix)
        {
            int[] temp = new int[matrix.Length];
            int[] temp2 = new int[matrix.Length];
            int k = 0, l = 0, m = matrix.Length-1, n = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (i == j)
                    {
                        temp[j] = matrix[i][j];
                        k++;
                    }

                    if (i == l && j == m)
                    {
                        temp2[n] = matrix[i][j];
                        n++;
                        l++;
                        m--;

                    }

                }
            }

            l = 0; m = matrix.Length-1;
            k = temp.Length - 1;
            int k2 = temp.Length - 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (i == j)
                    {
                        matrix[i][j] = temp[k];
                        k--;
                    }
                    if (i == l && j == m)
                    {
                        matrix[i][j] = temp2[k2];
                        k2--;
                        n++;
                        l++;
                        m--;
                    }


                }
            }



            return matrix;
        }

    }
}