using System;
using System.Collections.Generic;
using System.Numerics;

namespace Practise
{
    class Program2
    {
         List<string> temp = new List<string>();
        public  void Swap(ref char a, ref char b)
        {
            if (a == b) return;

            a ^= b;
            b ^= a;
            a ^= b;
        }

        public  void GetPer(char[] list)
        {
            int x = list.Length - 1;
            GetPer(list, 0, x);
        }

        public void GetPer(char[] list, int k, int m)
        {
            if (k == m)
            {
                string temp2 = new string(list);
                temp.Add(temp2);
              //  Console.WriteLine(list);
            }
            else
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    GetPer(list, k + 1, m);
                    Swap(ref list[k], ref list[i]);
                }
        }

        public  void print()
        {
            temp.Sort();


            Console.WriteLine(temp[1000000-1]);
        }

        public  List<string> perm()
        {
            return temp;
        }
        
    }
}