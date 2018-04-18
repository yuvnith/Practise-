using System;
using System.IO;
using System.Numerics;

namespace Practise
{
    public class LargestExponential
    {
        public void demo()
        {
            BigInteger max = 0;
            int i = 0 , line = 1 ;
            string[] values = File.ReadAllLines("D:/p099_base_exp.txt");

            foreach (var value in values)
            {
                Console.WriteLine(i);
                string[] temp = value.Split(',');

               

                
                    

                i++;
            }
            Console.WriteLine(BigInteger.Multiply(999665,500894));



            Console.WriteLine(BigInteger.Multiply(44840,646067));
        }
    }
}