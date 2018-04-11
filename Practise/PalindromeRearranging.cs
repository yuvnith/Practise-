namespace Practise
{
    public class PalindromeRearranging
    {
        public bool IsPalindromeRearrange(string value)
        {
            if (value.Length % 2 == 0)
            {
                foreach (var i in value)
                {
                    int count = 0;
                    foreach (var j in value)
                    {
                        if (i == j)
                        {
                            count++;
                        }
                    }
                    if (count % 2 != 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                int tmpcount = 0;
                char tmpstr = ' ';
                foreach (var i in value)
                {
                    if (tmpstr != i)
                    {
                        int count = 0;
                        foreach (var j in value)
                        {
                            if (i == j)
                            {
                                count++;
                            }
                        }
                        if (count % 2 != 0)
                        {
                            tmpcount++;
                        }
                        tmpstr = i;
                    }
                }
                if (tmpcount == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}