using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace Practise
{
    public class CitiesConquering
    {
        public int[] citiesConquering(int n, int[][] roads)
        {
            int flag = 0, count = 0, c = 0;
            var items = new Dictionary<int, List<int>>();
            var aaa = new int[n];
            int[] counts = new int[n];
            for (int i = 0; i < n; i++)
            {
                var t3 = new List<int>();
                items.Add(i, t3);
            }
            for (int i = 0; i < roads.Length; i++)
            {
                int[] temp = roads[i];
                int a = temp[0];
                int b = temp[1];

                var t1 = items[a];
                t1.Add(b);
                items[a] = t1;

                var t2 = items[b];
                t2.Add(a);
                items[b] = t2;

            }


            for (int i = 0; i < items.Count; i++)
            {
                var temp2 = items[i];

                counts[i] = temp2.Count;

                if (temp2.Count == 0)
                    aaa[i] = 1;
            }

            for (int i = 0; i < items.Count; i++)
            {
                var temp2 = items[i];

                if (temp2.Count == 1 || temp2.Count == 0)
                    c = Refresh2(items, aaa, count,counts);

                count = c;
            }

            for (int i = 0; i < items.Count; i++)
            {
                var temp2 = items[i];

                if (temp2.Count > 1)
                    aaa[i] = -1;
            }

            return aaa;

        }

        



        public int Refresh2(Dictionary<int, List<int>> items, int[] aaa, int count,int[] counts)
        {
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 1)
                {
                    var temp = items[i];

                    //if (temp.Count == 0)
                    //{
                    //    aaa[i] = aaa[i] +1;

                    //}
               
                    if (temp.Count == 1)
                    {
                        int road = temp[0];
                        temp.RemoveAt(0);
                        items[i] = temp;

                        var temp2 = items[road];
                        temp2.Remove(i);
                        items[road] = temp2;


                        if (temp.Count == 0)
                            aaa[i] = aaa[i] + 1;

                        if (temp2.Count == 0)
                            aaa[road] = aaa[road] + 1;

                        //var value = aaa[road];
                        //value = value + 1;
                        //aaa[road] = value;

                        //if (count == 0)
                        //    aaa[i] = aaa[i] + 1;
                        //else
                        //    aaa[i] = aaa[i] + count;


                    }

                    
                }

                var temp4 = items[i];
                if(counts[i] >0 && temp4.Count>0)
                aaa[i] = aaa[i] + 1;


            }

            RefreshCounts(items,counts);
            count++;
            return count;
        }

        public void RefreshCounts(Dictionary<int, List<int>> items, int[] counts)
        {
            for (int i = 0; i < items.Count; i++)
            {
                var temp2 = items[i];
                counts[i] = temp2.Count;
            }
        }
    }
}