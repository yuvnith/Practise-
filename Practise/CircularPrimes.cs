using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class CircularPrimes
    {
        public void demo()
        {
            int count = 0;
        
            for (double i = 999978;i < 1000000; i++)
            {
                int flag = 0;

                
               var temp= rotate(i);

                foreach (var val in temp)
                {
                    if (!IsPrime(double.Parse(val)))
                        flag = 1;
                }
                if (flag == 0)
                {
                    count++; 
                    Console.WriteLine(i);
                }
                    
            }
            Console.WriteLine("count: "+count);
        }

        public static bool IsPrime(double number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (double)Math.Floor(Math.Sqrt(number));

            for (double i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static List<string> rotate(double no)
        {
            var res  =new List<string>();
            int len = no.ToString().Length;
            char[] temp = no.ToString().ToCharArray();
            string prev = new string(temp);
            string curr = new string(temp);
            
            for (int i = 0; i < temp.Length; i++)
            {
                char[] temp2 = curr.ToCharArray();
                temp2[len - 1] = prev[0];
                res.Add(new string(temp2).Trim());
                prev = curr;
            }
            return res;
        }



    }
}
