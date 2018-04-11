using System.Linq;

namespace Practise
{
    public class ElectionsWinners
    {
        public int electionsWinners(int[] votes, int k)
        {

            int count = 0;
            int max = votes.Max();


            int count2 = 0;
            if (k == 0)
            {
                foreach (var bc in votes)
                    if (max == bc)
                    {
                        count2++;
                    }
                if (count2 > 1)
                    return 0;
                else
                    return count2;
            }
            foreach (var a in votes)
                if (a + k > max)
                    count++;

            return count;
        }
    }
}