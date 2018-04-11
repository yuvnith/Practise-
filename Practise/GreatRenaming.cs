using System.Collections.Generic;

namespace Practise
{
    public class GreatRenaming
    {
        public bool[][] greatRenaming(bool[][] roadRegister)
        {
            List<List<int>> temp = new List<List<int>>();

            List<int> temp3 = new List<int>();
            for (int j = 0; j < roadRegister.Length; j++)
            {
                if (roadRegister[roadRegister.Length-1][j] == true)
                {
                    if (j != roadRegister.Length - 1)
                    {
                        temp3.Add(j + 1);
                    }
                    else
                    {
                        temp3.Add(0);
                    }
                }
            }
            temp.Add(temp3);

            for (int i = 0; i < roadRegister.Length-1; i++)
            {
                List<int> temp2 = new List<int>();
                for (int j = 0; j < roadRegister.Length; j++)
                {
                    if (i != j)
                    {
                        if (roadRegister[i][j] == true)
                        {
                            if (j != roadRegister.Length - 1)
                            {
                                temp2.Add(j + 1);
                            }
                            else
                            {
                                temp2.Add(0);
                            }
                        }

                    }

                }
                temp.Add(temp2);
            }



            bool[][] res = new bool[roadRegister.Length][];

            for (int i = 0; i < temp.Count; i++)
            {
                res[i] = new bool[roadRegister.Length];
                for (int j = 0; j < roadRegister.Length; j++)
                {
                   
                        if (temp[i].Contains(j))
                            res[i][j] = true;
                        else
                            res[i][j] = false;
                   
                }
            }

            return res;

        }

    }
}