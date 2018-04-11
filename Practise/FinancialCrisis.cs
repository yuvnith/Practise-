using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class FinancialCrisis
    {
        public bool[][][] financialCrisis(bool[][] roadRegister)
        {
            int len1 = roadRegister.Length;
            List<List<List<bool>>> res = new List<List<List<bool>>>();
       
           
            bool[][][] r =new bool[len1][][];
         


            int ii = 0;

            while (ii < len1)
            {
                List<List<bool>> res2 = new List<List<bool>>();
                for (int i = 0; i < len1; i++)
                {
                    if (i != ii)
                    {
                        List<bool> res3 = new List<bool>();
                        bool[] temp = roadRegister[i];
                        for (int j = 0; j < len1; j++)
                        {
                            if (j != ii)
                            {
                                
                                res3.Add(temp[j]);
                            }
                        }
                        
                        res2.Add(res3);
                    }
                   
                    
                }
                res.Add(res2);
                ii++;
            }






            for (int i = 0; i < res.Count; i++)
            {
                r[i] = new bool[res[i].Count][];
                for (int j = 0; j < res[i].Count; j++)
                {
                    r[i][j] = res[i][j].ToArray();
                }
                
            }





            return r;
        }

    }
}