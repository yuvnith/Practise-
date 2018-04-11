using System.Collections.Generic;

namespace Practise
{
    public class AlphanumericLess
    {
        public bool alphanumericLess(string s1, string s2)
        {
            var l1 = new List<string>();
            var l2 = new List<string>();
            int z1 = 0, z2 = 0;

            ulong b1, b2;


            //if (s1.Length < s2.Length)
            //    return true;
            /*else*/
            if (s1 == s2)
                return false;
            //else if (s1.Length > s2.Length)
            //    return false;
            else
            {
                string temp = string.Empty;
                foreach (var i in s1)
                {
                    int a;

                    if (int.TryParse(i.ToString(), out a))
                    {
                        temp += i.ToString();
                        if (i == '0')
                            z1++;
                    }
                    else
                    {
                        if (temp != string.Empty)
                        {
                            l1.Add(temp);
                            temp = string.Empty;
                        }

                        l1.Add(i.ToString());
                    }
                }
                if (temp != string.Empty)
                    l1.Add(temp);


                string temp2 = string.Empty;
                foreach (var i in s2)
                {
                    int a;

                    if (int.TryParse(i.ToString(), out a))
                    {
                        temp2 += i.ToString();
                        if (i == '0')
                            z2++;
                    }
                    else
                    {
                        if (temp2 != string.Empty)
                        {
                            l2.Add(temp2);
                            temp2 = string.Empty;
                        }

                        l2.Add(i.ToString());
                    }
                }
                if (temp2 != string.Empty)
                    l2.Add(temp2);

                ulong val1 = 0;
                for (int i = 0; i < l1.Count; i++)
                {
                    ulong a;
                    string vall1 = l1[i];
                    if (!ulong.TryParse(vall1, out a))
                        val1 += ulong.Parse(((int)vall1[0]).ToString());
                    else
                        val1 += a;
                }

                ulong val2 = 0;
                for (int i = 0; i < l2.Count; i++)
                {
                    ulong a;
                    string vall2 = l2[i];
                    if (!ulong.TryParse(vall2, out a))
                        val2 += ulong.Parse(((int)vall2[0]).ToString());
                    else
                        val2 += a;


                }

                //if (ulong.TryParse(s1, out b1))
                //{
                //    if (ulong.TryParse(s2, out b2))
                //    {
                //        if (ulong.Parse(s1) < double.Parse(s2))
                //            return true;
                //        else if (ulong.Parse(s1) == ulong.Parse(s2))
                //        {
                //            if (z1 < z2)
                //                return false;
                //            else if (z1 == z2 && z1 > 0)
                //                return true;
                //            else if (z1 == 0 && z2 == 0)
                //                return false;

                //            else
                //                return true;
                //        }
                //        //else
                //        //    return true;
                        
                //    }
                //}

                if (val1 < val2)
                    return true;
                else if (val1 == val2)
                {

                    if (z1 < z2)
                        return false;
                    else if (z1 == z2 && z1 > 0)
                        return true;
                    else if (z1 == 0 && z2 == 0)
                        return false;

                    else
                        return true;

                }
                else 
                return false;
            }

            return false;


        }

    }
}