using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class DigitsProduct
    {
        public int digitsProduct(int product)
        {

            for (int i = 0; i < 10000; i++)
            {
                string temp = i.ToString();
                int val = 1; 
                foreach (var var in temp)
                {
                    val  = val * int.Parse(var.ToString());
                }

                if (val == product)
                    return i;


            }
            
            return -1;
        }



    }
}
