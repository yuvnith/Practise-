namespace Practise
{
    public class AreIsomorphic
    {
        public bool areIsomorphic(int[][] array1, int[][] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                int[] temp1 = array1[i];
                int[] temp2 = array2[i];

                if (temp1.Length != temp2.Length)
                    return false;
            }

            return true;
        }

    }
}