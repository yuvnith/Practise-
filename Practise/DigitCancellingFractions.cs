using System;
using System.Linq;

namespace Practise
{
    public class DigitCancellingFractions
    {
        public void Demo()
        {
            for (float i =10; i <= 99; i++)
            {
                for (float j = 10; j <= 99; j++)
                {
                    if (i != j)
                    {
                        var ii = i.ToString().ToCharArray();
                        var jj = j.ToString().ToCharArray();

                        if (ii[0] != '0' && jj[0] != '0' && ii[1] != '0' && jj[1] != '0')
                        {
                            if (ii[0] == jj[0])
                            {
                                ii[0] = ' ';
                                jj[0] = ' ';
                            }
                            if (ii[0] == jj[1])
                            {
                                ii[0] = ' ';
                                jj[1] = ' ';

                            }
                            if (ii[1] == jj[1])
                            {
                                ii[1] = ' ';
                                jj[1] = ' ';

                            }
                            if (ii[1] == jj[0])
                            {
                                ii[1] = ' ';
                                jj[0] = ' ';

                            }
                            string temp = new string(ii).Trim();
                            string temp2 = new string(jj).Trim();
                            float iii;
                            float.TryParse(temp, out iii);
                            float jjj;
                            float.TryParse(temp2, out jjj);

                            if (iii != i && jjj != j)
                                if (jjj != 0 && j != 0)
                                {
                                    float a = iii / jjj, b = i / j;
                                    if (a.Equals(b))
                                        if(a<1 && b<1)
                                        Console.WriteLine(i + " " + j + " ");
                                }

                        }
                    }
                }
            }
        }
    }
}