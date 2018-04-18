namespace Practise
{
    public class CrossingSum
    {
        public int crossingSum(int[][] matrix, int a, int b)
        {
            int sum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == a)
                        sum += matrix[i][j];
                    if (j == b & i != a)
                        sum += matrix[i][j];

                }
            }
            return sum;
        }

    }
}