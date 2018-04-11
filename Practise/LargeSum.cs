using System;
using System.IO;
using System.Numerics;

namespace Practise
{
    public class LargeSum
    {
        private string[] ip = File.ReadAllLines("C:/Users/vamshikrishna.pabba/Desktop/demo.txt");
        private BigInteger sum = 0;

        public void calculate()
        {
            foreach (var s in  ip)
            {
                sum += BigInteger.Parse(s);
            }
            Console.WriteLine(sum);
        }

    }
}