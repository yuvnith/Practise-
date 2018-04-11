namespace Practise
{
    public class DigitDegree
    {
        public int digitDegree(int n)
        {
            int count = 0;
            while (n.ToString().Length != 1)
            {
                int n1 = 0, n2 = n;
                int sum = 0;
                while (n2 > 0)
                {
                    n1 = n2 % 10;
                    sum += n1;
                    n2 = n2 / 10;
                }
                n = sum;
                count++;
            }
            return count;
        }
    }
}