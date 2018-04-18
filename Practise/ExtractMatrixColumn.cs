namespace Practise
{
    public class ExtractMatrixColumn
    {
        public int[] extractMatrixColumn(int[][] matrix, int column)
        {
            int[] res = new int[matrix.Length];
            int k = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                int[] temp = matrix[i];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (j == column)
                    {
                        res[k] = temp[j];
                        k++;
                    }
                }
            }
            return res;
        }

    }
}