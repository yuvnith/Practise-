using System;
using System.Linq;

namespace Practise
{
    public class VolleyballPositions
    {
        public string[][] volleyballPositions(string[][] formation, int k)
        {
            string[][] res = CopyArrayLinq(formation);
            for (int j = 0; j < k; j++)
            {
                 if (k > 5)
                    k = k % 6;
                res[1][0] = formation[0][1];
                res[3][0] = formation[1][0];
                res[2][1] = formation[3][0];
                res[3][2] = formation[2][1];
                res[1][2] = formation[3][2];
                res[0][1] = formation[1][2];
                formation = CopyArrayLinq(res);
            }

            Console.WriteLine(res[0][1]);
            return res;
        }

        static string[][] CopyArrayLinq(string[][] source)
        {
            return source.Select(s => s.ToArray()).ToArray();
        }

    }
}