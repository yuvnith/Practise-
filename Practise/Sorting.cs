using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
     public class Sorting
    {
        public void BubbleSort(int[] a)
        {
            int temp;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    
                    if ( a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                        Console.WriteLine("Swapped " + a[i] + " and "+a[j]);
                        
                    }
                }
            }

            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            
        }

        public void A(int[] a)
        {
            int n = a.Length,temp;
            for (int k = 0; k < n - 1; k++)
            {
                // (n-k-1) is for ignoring comparisons of elements which have already been compared in earlier iterations

                for (int i = 0; i < n - k - 1; i++)
                {
                    Console.WriteLine(a[i] + " and " + a[i + 1]);
                    if (a[i] > a[i + 1])
                    {
                        // here swapping of positions is being done.
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;

                        Console.WriteLine("Swapped " + a[i] + " and " + a[i+1]);

                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
        }
        


    }
}
