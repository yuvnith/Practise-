using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace Practise
{
    public class DigitFactorial 
    {
        public void Demo()
        {
            double val = 0;
            for (int i = 3; i < 100000; i++)
            {
                if (i == Fact(i))
                {
                    val += i;
                    Console.WriteLine(i);
                }
                    
            }
            Console.WriteLine("sum "+val);
            Console.WriteLine("completed");
        }

        public double Fact(int no)
        {
            string temp = no.ToString();
            double res = 0;

            foreach (var i in temp)
            {
                res += Fact2(float.Parse(i.ToString()));
            }
            return res;

        }

        public double Fact2(double value)
        {
            int res2 = 1;
            for (int i = 1; i <= value; i++)
                res2 = res2 * i;
            return res2;
        }
    }
}